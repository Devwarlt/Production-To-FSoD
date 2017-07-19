//Packets have been imported to list!
namespace wServer
{
    public enum PacketID : byte
    {
        /// <summary>Failure.as</summary>
        FAILURE = 0,
        /// <summary>CreateSuccess.as</summary>
        CREATE_SUCCESS = 84,
        /// <summary>Create.as</summary>
        CREATE = 66,
        /// <summary>PlayerShoot.as</summary>
        PLAYERSHOOT = 63,
        /// <summary>Move.as</summary>
        MOVE = 35,
        /// <summary>PlayerText.as</summary>
        PLAYERTEXT = 17,
        /// <summary>Text.as</summary>
        TEXT = 18,
        /// <summary>ServerPlayerShoot.as</summary>
        SERVERPLAYERSHOOT = 104,
        /// <summary>Damage.as</summary>
        DAMAGE = 96,
        /// <summary>Update.as</summary>
        UPDATE = 52,
        /// <summary>Message.as</summary>
        UPDATEACK = 102,
        /// <summary>Notification.as</summary>
        NOTIFICATION = 51,
        /// <summary>NewTick.as</summary>
        NEWTICK = 69,
        /// <summary>InvSwap.as</summary>
        INVSWAP = 56,
        /// <summary>UseItem.as</summary>
        USEITEM = 30,
        /// <summary>ShowEffect.as</summary>
        SHOWEFFECT = 74,
        /// <summary>Hello.as</summary>
        HELLO = 46,
        /// <summary>Goto.as</summary>
        GOTO = 36,
        /// <summary>InvDrop.as</summary>
        INVDROP = 67,
        /// <summary>InvResult.as</summary>
        INVRESULT = 44,
        /// <summary>Reconnect.as</summary>
        RECONNECT = 85,
        /// <summary>Ping.as</summary>
        PING = 1,
        /// <summary>Pong.as</summary>
        PONG = 101,
        /// <summary>MapInfo.as</summary>
        MAPINFO = 103,
        /// <summary>Load.as</summary>
        LOAD = 64,
        /// <summary>Pic.as</summary>
        PIC = 89,
        /// <summary>SetCondition.as</summary>
        SETCONDITION = 15,
        /// <summary>Teleport.as</summary>
        TELEPORT = 26,
        /// <summary>UsePortal.as</summary>
        USEPORTAL = 14,
        /// <summary>Death.as</summary>
        DEATH = 91,
        /// <summary>Buy.as</summary>
        BUY = 22,
        /// <summary>BuyResult.as</summary>
        BUYRESULT = 7,
        /// <summary>Aoe.as</summary>
        AOE = 65,
        /// <summary>GroundDamage.as</summary>
        GROUNDDAMAGE = 9,
        /// <summary>PlayerHit.as</summary>
        PLAYERHIT = 80,
        /// <summary>EnemyHit.as</summary>
        ENEMYHIT = 93,
        /// <summary>AoeAck.as</summary>
        AOEACK = 97,
        /// <summary>ShootAck.as</summary>
        SHOOTACK = 78,
        /// <summary>OtherHit.as</summary>
        OTHERHIT = 3,
        /// <summary>SquareHit.as</summary>
        SQUAREHIT = 60,
        /// <summary>GotoAck.as</summary>
        GOTOACK = 68,
        /// <summary>EditAccountList.as</summary>
        EDITACCOUNTLIST = 55,
        /// <summary>AccountList.as</summary>
        ACCOUNTLIST = 8,
        /// <summary>QuestObjId.as</summary>
        QUESTOBJID = 81,
        /// <summary>ChooseName.as</summary>
        CHOOSENAME = 21,
        /// <summary>NameResult.as</summary>
        NAMERESULT = 39,
        /// <summary>CreateGuild.as</summary>
        CREATEGUILD = 58,
        /// <summary>GuildResult.as</summary>
        GUILDRESULT = 61,
        /// <summary>GuildRemove.as</summary>
        GUILDREMOVE = 41,
        /// <summary>GuildInvite.as</summary>
        GUILDINVITE = 31,
        /// <summary>AllyShoot.as</summary>
        ALLYSHOOT = 33,
        /// <summary>EnemyShoot.as</summary>
        ENEMYSHOOT = 34,
        /// <summary>RequestTrade.as</summary>
        REQUESTTRADE = 12,
        /// <summary>TradeRequested.as</summary>
        TRADEREQUESTED = 19,
        /// <summary>TradeStart.as</summary>
        TRADESTART = 40,
        /// <summary>ChangeTrade.as</summary>
        CHANGETRADE = 88,
        /// <summary>TradeChanged.as</summary>
        TRADECHANGED = 25,
        /// <summary>AcceptTrade.as</summary>
        ACCEPTTRADE = 24,
        /// <summary>CancelTrade.as</summary>
        CANCELTRADE = 13,
        /// <summary>TradeDone.as</summary>
        TRADEDONE = 76,
        /// <summary>TradeAccepted.as</summary>
        TRADEACCEPTED = 59,
        /// <summary>ClientStat.as</summary>
        CLIENTSTAT = 11,
        /// <summary>CheckCredits.as</summary>
        CHECKCREDITS = 23,
        /// <summary>Escape.as</summary>
        ESCAPE = 10,
        /// <summary>File.as</summary>
        FILE = 5,
        /// <summary>InvitedToGuild.as</summary>
        INVITEDTOGUILD = 75,
        /// <summary>JoinGuild.as</summary>
        JOINGUILD = 83,
        /// <summary>ChangeGuildRank.as</summary>
        CHANGEGUILDRANK = 16,
        /// <summary>PlaySound.as</summary>
        PLAYSOUND = 87,
        /// <summary>GlobalNotification.as</summary>
        GLOBAL_NOTIFICATION = 90,
        /// <summary>Reskin.as</summary>
        RESKIN = 4,
        /// <summary>PetUpgradeRequest.as</summary>
        PETUPGRADEREQUEST = 45,
        /// <summary>ActivePetUpdateRequest.as</summary>
        ACTIVE_PET_UPDATE_REQUEST = 38,
        /// <summary>ActivePet.as</summary>
        ACTIVEPETUPDATE = 79,
        /// <summary>NewAbilityMessage.as</summary>
        NEW_ABILITY = 62,
        /// <summary>PetYard.as</summary>
        PETYARDUPDATE = 37,
        /// <summary>EvolvedPetMessage.as</summary>
        EVOLVE_PET = 94,
        /// <summary>DeletePetMessage.as</summary>
        DELETE_PET = 57,
        /// <summary>HatchPetMessage.as</summary>
        HATCH_PET = 92,
        /// <summary>EnterArena.as</summary>
        ENTER_ARENA = 6,
        /// <summary>ImminentArenaWave.as</summary>
        IMMINENT_ARENA_WAVE = 99,
        /// <summary>ArenaDeath.as</summary>
        ARENA_DEATH = 47,
        /// <summary>OutgoingMessage.as</summary>
        ACCEPT_ARENA_DEATH = 48,
        /// <summary>VerifyEmail.as</summary>
        VERIFY_EMAIL = 77,
        /// <summary>ReskinUnlock.as</summary>
        RESKIN_UNLOCK = 95,
        /// <summary>PasswordPrompt.as</summary>
        PASSWORD_PROMPT = 86,
        /// <summary>OutgoingMessage.as</summary>
        QUEST_FETCH_ASK = 27,
        /// <summary>QuestRedeem.as</summary>
        QUEST_REDEEM = 28,
        /// <summary>QuestFetchResponse.as</summary>
        QUEST_FETCH_RESPONSE = 53,
        /// <summary>QuestRedeemResponse.as</summary>
        QUEST_REDEEM_RESPONSE = 42,
        /// <summary>ReskinPet.as</summary>
        PET_CHANGE_FORM_MSG = 100,
        /// <summary>KeyInfoRequest.as</summary>
        KEY_INFO_REQUEST = 98,
        /// <summary>KeyInfoResponse.as</summary>
        KEY_INFO_RESPONSE = 20,
        /// <summary>ClaimDailyRewardMessage.as</summary>
        CLAIM_LOGIN_REWARD_MSG = 50,
        /// <summary>ClaimDailyRewardResponse.as</summary>
        LOGIN_REWARD_MSG = 82,
        /// <summary>GoToQuestRoom.as</summary>
        QUEST_ROOM_MSG = 49
    }
}