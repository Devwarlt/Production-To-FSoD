#region

using System;
using System.Linq;

#endregion

namespace wServer.realm.entities.player
{
    partial class Player
    {
        private int CanTPCooldownTime;
        private float bleeding;
        private int healCount;
        private float healing;
        private int newbieTime;

        public bool IsVisibleToEnemy()
        {
            if (HasConditionEffect(ConditionEffectIndex.Paused))
                return false;
            if (HasConditionEffect(ConditionEffectIndex.Invisible))
                return false;
            if (newbieTime > 0)
                return false;
            return true;
        }

        private bool HasRequiredEquipment(string objectId)
            => inventory.Take(4).FirstOrDefault(item => item.ObjectId.ToLower() == objectId.ToLower()) != null;

        private void HandleEffects(RealmTime time)
        {
            if (HasConditionEffect(ConditionEffectIndex.Healing))
            {
                if (healing > 1)
                {
                    HP = Math.Min(Stats[0] + Boost[0], HP + (int)healing);
                    healing -= (int)healing;
                    UpdateCount++;
                    healCount++;
                }
                healing += 28 * (time.thisTickTimes / 1000f);
            }
            if (HasConditionEffect(ConditionEffectIndex.Quiet) &&
                Mp > 0)
            {
                Mp = 0;
                UpdateCount++;
            }
            if (HasConditionEffect(ConditionEffectIndex.Bleeding) &&
                HP > 1)
            {
                if (bleeding > 1)
                {
                    HP -= (int)bleeding;
                    bleeding -= (int)bleeding;
                    UpdateCount++;
                }
                bleeding += 28 * (time.thisTickTimes / 1000f);
            }

            if (newbieTime > 0)
            {
                newbieTime -= time.thisTickTimes;
                if (newbieTime < 0)
                    newbieTime = 0;
            }
            if (CanTPCooldownTime > 0)
            {
                CanTPCooldownTime -= time.thisTickTimes;
                if (CanTPCooldownTime < 0)
                    CanTPCooldownTime = 0;
            }

            if (HasRequiredEquipment("sword of acclaim"))
            {
                if (mp >= 0.9f)
                {
                    Stats[2] = (int)attBase + 10 + Boost[2]; // increase att in +10
                    Stats[7] = (int)dexBase + 20 + Boost[7]; // increase dex in +20
                }
                else
                {
                    Stats[2] = (int)attBase - 15 + Boost[2]; // decrease att in -15
                    Stats[7] = (int)dexBase - 25 + Boost[7]; // decrease dex in -25
                }
            }
        }

        // stats base
        private float hpBase => Stats[0];

        private float maxHpBase => (float)ObjectDesc.MaxHP;
        private float mpBase => Stats[1];
        private float maxMpBase => (float)ObjectDesc.MaxMP;
        private float attBase => Stats[2];
        private float defBase => Stats[3];
        private float spdBase => Stats[4];
        private float dexBase => Stats[7];
        private float vitBase => Stats[5];
        private float wisBase => Stats[6];

        // stats base + boosts
        private float hp => hpBase + Boost[0];

        private float maxHp => maxHpBase + Boost[0];
        private float mp => mpBase + Boost[1];
        private float maxMp => maxMpBase + Boost[1];
        private float att => attBase + Boost[2];
        private float def => defBase + Boost[3];
        private float spd => spdBase + Boost[4];
        private float dex => dexBase + Boost[7];
        private float vit => vitBase + Boost[5];
        private float wis => wisBase + Boost[6];

        private float hpPercent => hp / maxHp;
        private float mpPercent => mp / maxMp;

        private bool CanHpRegen()
        {
            if (HasConditionEffect(ConditionEffectIndex.Sick) || HasConditionEffect(ConditionEffectIndex.Bleeding) || OxygenBar == 0)
                return false;
            return true;
        }

        private bool CanMpRegen()
        {
            if (HasConditionEffect(ConditionEffectIndex.Quiet) || ninjaShoot)
                return false;
            return true;
        }

        internal void SetNewbiePeriod()
        {
            newbieTime = 3000;
        }

        internal void SetTPDisabledPeriod()
        {
            CanTPCooldownTime = 10 * 1000; // 10 seconds
        }

        public bool TPCooledDown()
        {
            if (CanTPCooldownTime > 0)
                return false;
            return true;
        }
    }
}