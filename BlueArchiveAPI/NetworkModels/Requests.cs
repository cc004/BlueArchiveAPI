namespace BlueArchiveAPI.NetworkModels;
using System.Collections.ObjectModel;

public class SystemVersionRequest : Request<SystemVersionResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.System_Version;
}

public class SessionInfoRequest : Request<SessionInfoResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Session_Info;
}

public class AuditGachaStatisticsRequest : Request<AuditGachaStatisticsResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Audit_GachaStatistics;
    public long MerchandiseUniqueId;
    public long ShopUniqueId;
    public long Count;
}

public class AccountCreateRequest : Request<AccountCreateResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_Create;
    public string DevId;
    public long Version;
    public long IMEI;
    public string AccessIP;
    public string MarketId;
    public string UserType;
    public string AdvertisementId;
    public string OSType;
    public string OSVersion;
    public string CountryCode;
}

public class AccountNicknameRequest : Request<AccountNicknameResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_Nickname;
    public string Nickname;
}

public class AccountAuthRequest : Request<AccountAuthResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_Auth;
    public long Version;
    public string DevId;
    public long IMEI;
    public string AccessIP;
    public string MarketId;
    public string UserType;
    public string AdvertisementId;
    public string OSType;
    public string OSVersion;
    public string DeviceUniqueId;
    public string DeviceModel;
    public int DeviceSystemMemorySize;
    public string CountryCode;
    public string Idfv;
    public bool IsTeenVersion;
}

public class AccountCurrencySyncRequest : Request<AccountCurrencySyncResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_CurrencySync;
}

public class AccountSetRepresentCharacterAndCommentRequest : Request<AccountSetRepresentCharacterAndCommentResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_SetRepresentCharacterAndComment;
    public int RepresentCharacterServerId;
    public string Comment;
}

public class AccountGetTutorialRequest : Request<AccountGetTutorialResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_GetTutorial;
}

public class AccountSetTutorialRequest : Request<AccountSetTutorialResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_SetTutorial;
    public List<long> TutorialIds;
}

public class AccountPassCheckRequest : Request<AccountPassCheckResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_PassCheck;
    public string DevId;
}

public class AccountCheckYostarRequest : Request<AccountCheckYostarResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_CheckYostar;
    public long UID;
    public string YostarToken;
    public string EnterTicket;
    public bool PassCookieResult;
    public string Cookie;
}

public class AccountCallNameRequest : Request<AccountCallNameResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_CallName;
    public string CallName;
    public string CallNameKatakana;
}

public class AccountBirthDayRequest : Request<AccountBirthDayResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_BirthDay;
    public DateTime BirthDay;
}

public class AccountAuth2Request : Request<AccountAuth2Response>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_Auth2;
}

public class AccountLinkRewardRequest : Request<AccountLinkRewardResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_LinkReward;
}

public class AccountCheckNexonRequest : Request<AccountCheckNexonResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_CheckNexon;
    public long NpSN;
    public string NpToken;
    public bool PassCheckNexonServer;
    public string EnterTicket;
}

public class AccountDetachNexonRequest : Request<AccountDetachNexonResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_DetachNexon;
}

public class AccountReportXignCodeCheaterRequest : Request<AccountReportXignCodeCheaterResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_ReportXignCodeCheater;
    public string ErrorCode;
}

public class AccountDismissRepurchasablePopupRequest : Request<AccountDismissRepurchasablePopupResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_DismissRepurchasablePopup;
    public List<long> ProductIds;
}

public class AccountInvalidateTokenRequest : Request<AccountInvalidateTokenResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_InvalidateToken;
}

public class AccountLoginSyncRequest : Request<AccountLoginSyncResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_LoginSync;
    public List<Protocol> SyncProtocols;
}

public class AccountVerifyAdultCheckRequest : Request<AccountVerifyAdultCheckResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_VerifyCheckAdultAgree;
}

public class CharacterListRequest : Request<CharacterListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Character_List;
}

public class CharacterTranscendenceRequest : Request<CharacterTranscendenceResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Character_Transcendence;
    public long TargetCharacterServerId;
}

public class CharacterExpGrowthRequest : Request<CharacterExpGrowthResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Character_ExpGrowth;
    public long TargetCharacterServerId;
    public ConsumeRequestDB ConsumeRequestDB;
}

public class CharacterFavorGrowthRequest : Request<CharacterFavorGrowthResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Character_FavorGrowth;
    public long TargetCharacterDBId;
    public Dictionary<long, int> ConsumeItemDBIdsAndCounts;
}

public class CharacterUnlockWeaponRequest : Request<CharacterUnlockWeaponResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Character_UnlockWeapon;
    public long TargetCharacterServerId;
}

public class CharacterWeaponExpGrowthRequest : Request<CharacterWeaponExpGrowthResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Character_WeaponExpGrowth;
    public long TargetCharacterServerId;
    public Dictionary<long, long> ConsumeUniqueIdAndCounts;
}

public class CharacterWeaponTranscendenceRequest : Request<CharacterWeaponTranscendenceResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Character_WeaponTranscendence;
    public long TargetCharacterServerId;
}

public class CharacterSetFavoritesRequest : Request<CharacterSetFavoritesResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Character_SetFavorites;
    public Dictionary<long, bool> ActivateByServerIds;
}

public class EquipmentBatchGrowthRequest : Request<EquipmentBatchGrowthResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Equipment_BatchGrowth;
    public List<EquipmentBatchGrowthRequestDB> EquipmentBatchGrowthRequestDBs;
}

public class ItemListRequest : Request<ItemListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Item_List;
}

public class ItemSellRequest : Request<ItemSellResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Item_Sell;
    public List<long> TargetServerIds;
}

public class ItemConsumeRequest : Request<ItemConsumeResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Item_Consume;
    public long TargetItemServerId;
    public int ConsumeCount;
}

public class ItemLockRequest : Request<ItemLockResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Item_Lock;
    public long TargetServerId;
    public bool IsLocked;
}

public class ItemBulkConsumeRequest : Request<ItemBulkConsumeResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Item_BulkConsume;
    public long TargetItemServerId;
    public int ConsumeCount;
}

public class ItemSelectTicketRequest : Request<ItemSelectTicketResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Item_SelectTicket;
    public long TicketItemServerId;
    public long SelectItemUniqueId;
    public int ConsumeCount;
}

public class EchelonListRequest : Request<EchelonListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Echelon_List;
}

public class EchelonSaveRequest : Request<EchelonSaveResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Echelon_Save;
    public EchelonDB EchelonDB;
    public List<ClanAssistUseInfo> AssistUseInfos;
}

public class EchelonPresetListRequest : Request<EchelonPresetListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Echelon_PresetList;
}

public class EchelonPresetSaveRequest : Request<EchelonPresetSaveResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Echelon_PresetSave;
    public EchelonPresetDB PresetDB;
}

public class EchelonPresetGroupRenameRequest : Request<EchelonPresetGroupRenameResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Echelon_PresetGroupRename;
    public int PresetGroupIndex;
    public string PresetGroupLabel;
}

public class CampaignListRequest : Request<CampaignListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_List;
}

public class CampaignEnterMainStageRequest : Request<CampaignEnterMainStageResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_EnterMainStage;
    public long StageUniqueId;
}

public class CampaignConfirmMainStageRequest : Request<CampaignConfirmMainStageResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_ConfirmMainStage;
    public long StageUniqueId;
}

public class CampaignDeployEchelonRequest : Request<CampaignDeployEchelonResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_DeployEchelon;
    public long StageUniqueId;
    public List<HexaUnit> DeployedEchelons;
}

public class CampaignWithdrawEchelonRequest : Request<CampaignWithdrawEchelonResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_WithdrawEchelon;
    public long StageUniqueId;
    public List<long> WithdrawEchelonEntityId;
}

public class CampaignMapMoveRequest : Request<CampaignMapMoveResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_MapMove;
    public long StageUniqueId;
    public long EchelonEntityId;
    public HexLocation DestPosition;
}

public class CampaignEndTurnRequest : Request<CampaignEndTurnResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_EndTurn;
    public long StageUniqueId;
}

public class CampaignEnterTacticRequest : Request<CampaignEnterTacticResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_EnterTactic;
    public long StageUniqueId;
    public long EchelonIndex;
    public long EnemyIndex;
}

public class CampaignTacticResultRequest : Request<CampaignTacticResultResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_TacticResult;
    public bool PassCheckCharacter;
    public BattleSummary Summary;
    public SkillCardHand Hand;
    public TacticSkipSummary SkipSummary;
}

public class CampaignRetreatRequest : Request<CampaignRetreatResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_Retreat;
    public long StageUniqueId;
}

public class CampaignChapterClearRewardRequest : Request<CampaignChapterClearRewardResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_ChapterClearReward;
    public long CampaignChapterUniqueId;
    public StageDifficulty StageDifficulty;
}

public class CampaignHealRequest : Request<CampaignHealResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_Heal;
    public long CampaignStageUniqueId;
    public long EchelonIndex;
    public long CharacterServerId;
}

public class CampaignEnterSubStageRequest : Request<CampaignEnterSubStageResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_EnterSubStage;
    public long StageUniqueId;
    public long LastEnterStageEchelonNumber;
}

public class CampaignSubStageResultRequest : Request<CampaignSubStageResultResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_SubStageResult;
    public bool PassCheckCharacter;
    public BattleSummary Summary;
}

public class CampaignPortalRequest : Request<CampaignPortalResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_Portal;
    public long StageUniqueId;
    public long EchelonEntityId;
}

public class CampaignConfirmTutorialStageRequest : Request<CampaignConfirmTutorialStageResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_ConfirmTutorialStage;
    public long StageUniqueId;
}

public class CampaignPurchasePlayCountHardStageRequest : Request<CampaignPurchasePlayCountHardStageResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_PurchasePlayCountHardStage;
    public long StageUniqueId;
}

public class CampaignEnterTutorialStageRequest : Request<CampaignEnterTutorialStageResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_EnterTutorialStage;
    public long StageUniqueId;
}

public class CampaignTutorialStageResultRequest : Request<CampaignTutorialStageResultResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_TutorialStageResult;
    public BattleSummary Summary;
}

public class CampaignRestartMainStageRequest : Request<CampaignRestartMainStageResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_RestartMainStage;
    public long StageUniqueId;
}

public class MailListRequest : Request<MailListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Mail_List;
    public bool IsReadMail;
    public DateTime PivotTime;
    public long PivotIndex;
    public bool IsDescending;
}

public class MailCheckRequest : Request<MailCheckResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Mail_Check;
}

public class MailReceiveRequest : Request<MailReceiveResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Mail_Receive;
    public List<long> MailServerIds;
}

public class MissionListRequest : Request<MissionListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Mission_List;
    public Int64? EventContentId;
}

public class MissionRewardRequest : Request<MissionRewardResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Mission_Reward;
    public long MissionUniqueId;
    public long ProgressServerId;
    public Int64? EventContentId;
}

public class MissionMultipleRewardRequest : Request<MissionMultipleRewardResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Mission_MultipleReward;
    public MissionCategory MissionCategory;
    public Int64? GuideMissionSeasonId;
    public Int64? EventContentId;
}

public class MissionSyncRequest : Request<MissionSyncResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Mission_Sync;
}

public class AttendanceRewardRequest : Request<AttendanceRewardResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Attendance_Reward;
    public Dictionary<long, long> DayByBookUniqueId;
    public long AttendanceBookUniqueId;
    public long Day;
}

public class ShopBuyMerchandiseRequest : Request<ShopBuyMerchandiseResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Shop_BuyMerchandise;
    public bool IsRefreshGoods;
    public long ShopUniqueId;
    public long GoodsId;
    public long PurchaseCount;
}

public class ShopBuyGachaRequest : Request<ShopBuyGachaResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Shop_BuyGacha;
    public long GoodsId;
    public long ShopUniqueId;
}

public class ShopListRequest : Request<ShopListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Shop_List;
    public List<ShopCategoryType> CategoryList;
}

public class ShopRefreshRequest : Request<ShopRefreshResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Shop_Refresh;
    public ShopCategoryType ShopCategoryType;
}

public class ShopBuyEligmaRequest : Request<ShopBuyEligmaResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Shop_BuyEligma;
    public long GoodsUniqueId;
    public long ShopUniqueId;
    public long CharacterUniqueId;
    public long PurchaseCount;
}

public class ShopBuyGacha2Request : Request<ShopBuyGacha2Response>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Shop_BuyGacha2;
}

public class ShopGachaRecruitListRequest : Request<ShopGachaRecruitListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Shop_GachaRecruitList;
}

public class ShopBuyRefreshMerchandiseRequest : Request<ShopBuyRefreshMerchandiseResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Shop_BuyRefreshMerchandise;
    public List<long> ShopUniqueIds;
}

public class ShopBuyGacha3Request : Request<ShopBuyGacha3Response>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Shop_BuyGacha3;
    public long FreeRecruitId;
    public ParcelCost Cost;
}

public class ShopBuyAPRequest : Request<ShopBuyAPResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Shop_BuyAP;
    public long ShopUniqueId;
    public long PurchaseCount;
}

public class RecipeCraftRequest : Request<RecipeCraftResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Recipe_Craft;
    public long RecipeCraftUniqueId;
    public long RecipeIngredientUniqueId;
}

public class MemoryLobbyListRequest : Request<MemoryLobbyListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.MemoryLobby_List;
}

public class MemoryLobbySetMainRequest : Request<MemoryLobbySetMainResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.MemoryLobby_SetMain;
    public long MemoryLobbyId;
}

public class MemoryLobbyUpdateLobbyModeRequest : Request<MemoryLobbyUpdateLobbyModeResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.MemoryLobby_UpdateLobbyMode;
    public bool IsMemoryLobbyMode;
}

public class MemoryLobbyInteractRequest : Request<MemoryLobbyInteractResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.MemoryLobby_Interact;
}

public class CumulativeTimeRewardListRequest : Request<CumulativeTimeRewardListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.CumulativeTimeReward_List;
}

public class OpenConditionListRequest : Request<OpenConditionListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.OpenCondition_List;
}

public class OpenConditionSetRequest : Request<OpenConditionSetResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.OpenCondition_Set;
    public OpenConditionDB ConditionDB;
}

public class OpenConditionEventListRequest : Request<OpenConditionEventListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.OpenCondition_EventList;
    public List<long> ConquestEventIds;
    public Dictionary<long, long> WorldRaidSeasonAndGroupIds;
}

public class ToastListRequest : Request<ToastListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Toast_List;
}

public class RaidListRequest : Request<RaidListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_List;
    public string RaidBossGroup;
    public Difficulty RaidDifficulty;
    public RaidRoomSortOption RaidRoomSortOption;
}

public class RaidCompleteListRequest : Request<RaidCompleteListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_CompleteList;
}

public class RaidDetailRequest : Request<RaidDetailResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_Detail;
    public long RaidServerId;
    public long RaidUniqueId;
}

public class RaidSearchRequest : Request<RaidSearchResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_Search;
    public string SecretCode;
    public List<string> Tags;
}

public class RaidCreateBattleRequest : Request<RaidCreateBattleResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_CreateBattle;
    public long RaidUniqueId;
    public bool IsPractice;
    public List<int> Tags;
    public bool IsPublic;
    public Difficulty Difficulty;
    public ClanAssistUseInfo AssistUseInfo;
}

public class RaidEnterBattleRequest : Request<RaidEnterBattleResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_EnterBattle;
    public long RaidServerId;
    public long RaidUniqueId;
    public bool IsPractice;
    public ClanAssistUseInfo AssistUseInfo;
}

public class RaidBattleUpdateRequest : Request<RaidBattleUpdateResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_BattleUpdate;
    public long RaidServerId;
    public int RaidBossIndex;
    public long CumulativeDamage;
    public long CumulativeGroggyPoint;
    public List<DebuffDescription> playerDebuffs;
}

public class RaidEndBattleRequest : Request<RaidEndBattleResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_EndBattle;
    public int EchelonId;
    public long RaidServerId;
    public bool IsPractice;
    public List<DebuffDescription> playerDebuffs;
    public BattleSummary Summary;
    public ClanAssistUseInfo AssistUseInfo;
}

public class RaidRewardRequest : Request<RaidRewardResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_Reward;
    public long RaidServerId;
    public bool IsPractice;
}

public class RaidRewardAllRequest : Request<RaidRewardAllResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_RewardAll;
}

public class RaidShareRequest : Request<RaidShareResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_Share;
    public long RaidServerId;
}

public class RaidSeasonRewardRequest : Request<RaidSeasonRewardResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_SeasonReward;
}

public class RaidLobbyRequest : Request<RaidLobbyResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_Lobby;
}

public class RaidGiveUpRequest : Request<RaidGiveUpResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_GiveUp;
    public long RaidServerId;
    public bool IsPractice;
}

public class RaidOpponentListRequest : Request<RaidOpponentListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_OpponentList;
    public Int64? Rank;
    public Int64? Score;
    public bool IsUpper;
    public RankingSearchType SearchType;
}

public class RaidRankingRewardRequest : Request<RaidRankingRewardResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_RankingReward;
}

public class RaidLoginRequest : Request<RaidLoginResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_Login;
}

public class RaidSweepRequest : Request<RaidSweepResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_Sweep;
    public long UniqueId;
    public long SweepCount;
}

public class RaidGetBestTeamRequest : Request<RaidGetBestTeamResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_GetBestTeam;
    public long SearchAccountId;
}

public class SkipHistoryListRequest : Request<SkipHistoryListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.SkipHistory_List;
}

public class SkipHistorySaveRequest : Request<SkipHistorySaveResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.SkipHistory_Save;
    public SkipHistoryDB SkipHistoryDB;
}

public class ScenarioListRequest : Request<ScenarioListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_List;
}

public class ScenarioClearRequest : Request<ScenarioClearResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_Clear;
    public long ScenarioId;
    public BattleSummary BattleSummary;
}

public class ScenarioGroupHistoryUpdateRequest : Request<ScenarioGroupHistoryUpdateResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_GroupHistoryUpdate;
    public long ScenarioGroupUniqueId;
    public long ScenarioType;
}

public class ScenarioSkipRequest : Request<ScenarioSkipResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_Skip;
    public long ScriptGroupId;
    public int SkipPointScriptCount;
}

public class ScenarioSelectRequest : Request<ScenarioSelectResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_Select;
    public long ScriptGroupId;
    public long ScriptSelectGroup;
}

public class ScenarioAccountStudentChangeRequest : Request<ScenarioAccountStudentChangeResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_AccountStudentChange;
    public long AccountStudent;
    public long AccountStudentBefore;
}

public class ScenarioLobbyStudentChangeRequest : Request<ScenarioLobbyStudentChangeResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_LobbyStudentChange;
    public List<long> LobbyStudents;
    public List<long> LobbyStudentsBefore;
}

public class ScenarioSpecialLobbyChangeRequest : Request<ScenarioSpecialLobbyChangeResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_SpecialLobbyChange;
    public long MemoryLobbyId;
    public long MemoryLobbyIdBefore;
}

public class ScenarioEnterRequest : Request<ScenarioEnterResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_Enter;
    public long ScenarioId;
}

public class ScenarioEnterMainStageRequest : Request<ScenarioEnterMainStageResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_EnterMainStage;
    public long StageUniqueId;
}

public class ScenarioConfirmMainStageRequest : Request<ScenarioConfirmMainStageResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_ConfirmMainStage;
    public long StageUniqueId;
}

public class ScenarioDeployEchelonRequest : Request<ScenarioDeployEchelonResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_DeployEchelon;
    public long StageUniqueId;
    public List<HexaUnit> DeployedEchelons;
}

public class ScenarioWithdrawEchelonRequest : Request<ScenarioWithdrawEchelonResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_WithdrawEchelon;
    public long StageUniqueId;
    public List<long> WithdrawEchelonEntityId;
}

public class ScenarioMapMoveRequest : Request<ScenarioMapMoveResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_MapMove;
    public long StageUniqueId;
    public long EchelonEntityId;
    public HexLocation DestPosition;
}

public class ScenarioEndTurnRequest : Request<ScenarioEndTurnResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_EndTurn;
    public long StageUniqueId;
}

public class ScenarioEnterTacticRequest : Request<ScenarioEnterTacticResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_EnterTactic;
    public long StageUniqueId;
    public long EchelonIndex;
    public long EnemyIndex;
}

public class ScenarioTacticResultRequest : Request<ScenarioTacticResultResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_TacticResult;
    public bool PassCheckCharacter;
    public BattleSummary Summary;
    public SkillCardHand Hand;
    public TacticSkipSummary SkipSummary;
}

public class ScenarioRetreatRequest : Request<ScenarioRetreatResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_Retreat;
    public long StageUniqueId;
}

public class ScenarioPortalRequest : Request<ScenarioPortalResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_Portal;
    public long StageUniqueId;
    public long EchelonEntityId;
}

public class ScenarioRestartMainStageRequest : Request<ScenarioRestartMainStageResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_RestartMainStage;
    public long StageUniqueId;
}

public class ScenarioSkipMainStageRequest : Request<ScenarioSkipMainStageResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_SkipMainStage;
    public long StageUniqueId;
}

public class CafeGetInfoRequest : Request<CafeGetInfoResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Cafe_Get;
    public long AccountServerId;
}

public class CafeAckRequest : Request<CafeAckResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Cafe_Ack;
}

public class CafeListPresetRequest : Request<CafeListPresetResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Cafe_ListPreset;
}

public class CafeRenamePresetRequest : Request<CafeRenamePresetResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Cafe_RenamePreset;
    public int SlotId;
    public string PresetName;
}

public class CafeClearPresetRequest : Request<CafeClearPresetResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Cafe_ClearPreset;
    public int SlotId;
}

public class CafeUpdatePresetFurnitureRequest : Request<CafeUpdatePresetFurnitureResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Cafe_UpdatePresetFurniture;
    public int SlotId;
}

public class CafeApplyPresetRequest : Request<CafeApplyPresetResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Cafe_ApplyPreset;
    public int SlotId;
}

public class CafeRankUpRequest : Request<CafeRankUpResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Cafe_RankUp;
    public long AccountServerId;
    public ConsumeRequestDB ConsumeRequestDB;
}

public class CafeReceiveCurrencyRequest : Request<CafeReceiveCurrencyResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Cafe_ReceiveCurrency;
    public long AccountServerId;
}

public class CafeGiveGiftRequest : Request<CafeGiveGiftResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Cafe_GiveGift;
    public long CharacterUniqueId;
    public ConsumeRequestDB ConsumeRequestDB;
}

public class CafeSummonCharacterRequest : Request<CafeSummonCharacterResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Cafe_SummonCharacter;
    public long CharacterServerId;
}

public class CafeTrophyHistoryRequest : Request<CafeTrophyHistoryResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Cafe_TrophyHistory;
}

public class CraftSelectNodeRequest : Request<CraftSelectNodeResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Craft_SelectNode;
    public long SlotId;
    public long LeafNodeIndex;
}

public class CraftUpdateNodeLevelRequest : Request<CraftUpdateNodeLevelResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Craft_UpdateNodeLevel;
    public ConsumeRequestDB ConsumeRequestDB;
    public long ConsumeGoldAmount;
    public long SlotId;
    public CraftNodeTier CraftNodeType;
}

public class CraftBeginProcessRequest : Request<CraftBeginProcessResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Craft_BeginProcess;
    public long SlotId;
}

public class CraftCompleteProcessRequest : Request<CraftCompleteProcessResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Craft_CompleteProcess;
    public long SlotId;
}

public class CraftRewardRequest : Request<CraftRewardResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Craft_Reward;
    public long SlotId;
}

public class CraftShiftingBeginProcessRequest : Request<CraftShiftingBeginProcessResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Craft_ShiftingBeginProcess;
    public long SlotId;
    public long RecipeId;
    public ConsumeRequestDB ConsumeRequestDB;
}

public class CraftShiftingCompleteProcessRequest : Request<CraftShiftingCompleteProcessResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Craft_ShiftingCompleteProcess;
    public long SlotId;
}

public class CraftShiftingRewardRequest : Request<CraftShiftingRewardResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Craft_ShiftingReward;
    public long SlotId;
}

public class ArenaEnterLobbyRequest : Request<ArenaEnterLobbyResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Arena_EnterLobby;
}

public class ArenaLoginRequest : Request<ArenaLoginResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Arena_Login;
}

public class ArenaSettingChangeRequest : Request<ArenaSettingChangeResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Arena_SettingChange;
    public long MapId;
}

public class ArenaOpponentListRequest : Request<ArenaOpponentListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Arena_OpponentList;
}

public class ArenaEnterBattleRequest : Request<ArenaEnterBattleResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Arena_EnterBattle;
    public long OpponentAccountServerId;
    public long OpponentIndex;
}

public class ArenaEnterBattlePart1Request : Request<ArenaEnterBattlePart1Response>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Arena_EnterBattlePart1;
    public long OpponentAccountServerId;
    public long OpponentRank;
    public int OpponentIndex;
}

public class ArenaEnterBattlePart2Request : Request<ArenaEnterBattlePart2Response>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Arena_EnterBattlePart2;
    public ArenaBattleDB ArenaBattleDB;
}

public class ArenaBattleResultRequest : Request<ArenaBattleResultResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Arena_BattleResult;
    public ArenaBattleDB ArenaBattleDB;
}

public class ArenaCumulativeTimeRewardRequest : Request<ArenaCumulativeTimeRewardResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Arena_CumulativeTimeReward;
}

public class ArenaDailyRewardRequest : Request<ArenaDailyRewardResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Arena_DailyReward;
}

public class ArenaRankListRequest : Request<ArenaRankListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Arena_RankList;
    public int StartIndex;
    public int Count;
}

public class ArenaHistoryRequest : Request<ArenaHistoryResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Arena_History;
    public DateTime SearchStartDate;
    public int Count;
}

public class ArenaCheckSeasonCloseRewardRequest : Request<ArenaCheckSeasonCloseRewardResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Arena_CheckSeasonCloseReward;
}

public class ArenaSyncEchelonSettingTimeRequest : Request<ArenaSyncEchelonSettingTimeResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Arena_SyncEchelonSettingTime;
}

public class WeekDungeonListRequest : Request<WeekDungeonListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.WeekDungeon_List;
}

public class WeekDungeonEnterBattleRequest : Request<WeekDungeonEnterBattleResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.WeekDungeon_EnterBattle;
    public long StageUniqueId;
    public long EchelonIndex;
}

public class WeekDungeonBattleResultRequest : Request<WeekDungeonBattleResultResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.WeekDungeon_BattleResult;
    public long StageUniqueId;
    public bool PassCheckCharacter;
    public BattleSummary Summary;
}

public class WeekDungeonRetreatRequest : Request<WeekDungeonRetreatResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.WeekDungeon_Retreat;
    public long StageUniqueId;
}

public class AcademyGetInfoRequest : Request<AcademyGetInfoResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Academy_GetInfo;
}

public class AcademyAttendScheduleRequest : Request<AcademyAttendScheduleResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Academy_AttendSchedule;
    public long ZoneId;
}

public class EventRewardIncreaseRequest : Request<EventRewardIncreaseResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Event_RewardIncrease;
}

public class ContentSaveGetRequest : Request<ContentSaveGetResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.ContentSave_Get;
}

public class ContentSaveDiscardRequest : Request<ContentSaveDiscardResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.ContentSave_Discard;
    public ContentType ContentType;
    public long StageUniqueId;
}

public class ClanLobbyRequest : Request<ClanLobbyResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_Lobby;
}

public class ClanLoginRequest : Request<ClanLoginResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_Login;
}

public class ClanSearchRequest : Request<ClanSearchResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_Search;
    public string SearchString;
    public ClanJoinOption ClanJoinOption;
    public string ClanUniqueCode;
}

public class ClanCreateRequest : Request<ClanCreateResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_Create;
    public string ClanNickName;
    public ClanJoinOption ClanJoinOption;
}

public class ClanMemberRequest : Request<ClanMemberResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_Member;
    public long ClanDBId;
    public long MemberAccountId;
}

public class ClanApplicantRequest : Request<ClanApplicantResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_Applicant;
    public long OffSet;
}

public class ClanJoinRequest : Request<ClanJoinResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_Join;
    public long ClanDBId;
}

public class ClanQuitRequest : Request<ClanQuitResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_Quit;
}

public class ClanPermitRequest : Request<ClanPermitResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_Permit;
    public long ApplicantAccountId;
    public bool IsPerMit;
}

public class ClanKickRequest : Request<ClanKickResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_Kick;
    public long MemberAccountId;
}

public class ClanSettingRequest : Request<ClanSettingResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_Setting;
    public string ChangedClanName;
    public string ChangedNotice;
    public ClanJoinOption ClanJoinOption;
}

public class ClanConferRequest : Request<ClanConferResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_Confer;
    public long MemberAccountId;
    public ClanSocialGrade ConferingGrade;
}

public class ClanDismissRequest : Request<ClanDismissResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_Dismiss;
}

public class ClanAutoJoinRequest : Request<ClanAutoJoinResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_AutoJoin;
}

public class ClanMemberListRequest : Request<ClanMemberListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_MemberList;
    public long ClanDBId;
}

public class ClanCancelApplyRequest : Request<ClanCancelApplyResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_CancelApply;
}

public class ClanMyAssistListRequest : Request<ClanMyAssistListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_MyAssistList;
}

public class ClanSetAssistRequest : Request<ClanSetAssistResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_SetAssist;
    public EchelonType EchelonType;
    public int SlotNumber;
    public long CharacterDBId;
}

public class ClanChatLogRequest : Request<ClanChatLogResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_ChatLog;
    public string Channel;
    public DateTime FromDate;
}

public class ClanCheckRequest : Request<ClanCheckResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_Check;
}

public class ClanAllAssistListRequest : Request<ClanAllAssistListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_AllAssistList;
    public EchelonType EchelonType;
}

public class BillingTransactionStartByYostarRequest : Request<BillingTransactionStartByYostarResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Billing_TransactionStartByYostar;
    public long ShopCashId;
    public bool VirtualPayment;
}

public class BillingTransactionEndByYostarRequest : Request<BillingTransactionEndByYostarResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Billing_TransactionEndByYostar;
    public long PurchaseOrderId;
    public BillingTransactionEndType EndType;
}

public class BillingPurchaseListByYostarRequest : Request<BillingPurchaseListByYostarResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Billing_PurchaseListByYostar;
}

public class BillingPurchaseCashShopVerifyByNexonRequest : Request<BillingPurchaseCashShopVerifyByNexonResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Billing_PurchaseCashShopVerifyByNexon;
    public long NpSN;
    public string StampToken;
    public long ShopCashId;
    public bool VirtualPayment;
    public string CurrencyCode;
    public long CurrencyValue;
}

public class BillingPurchaseListByNexonRequest : Request<BillingPurchaseListByNexonResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Billing_PurchaseListByNexon;
}

public class EventContentAdventureListRequest : Request<EventContentAdventureListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_AdventureList;
    public long EventContentId;
}

public class EventContentEnterMainStageRequest : Request<EventContentEnterMainStageResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_EnterMainStage;
    public long EventContentId;
    public long StageUniqueId;
}

public class EventContentConfirmMainStageRequest : Request<EventContentConfirmMainStageResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_ConfirmMainStage;
    public long EventContentId;
    public long StageUniqueId;
}

public class EventContentEnterTacticRequest : Request<EventContentEnterTacticResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_EnterTactic;
    public long EventContentId;
    public long StageUniqueId;
    public long EchelonIndex;
    public long EnemyIndex;
}

public class EventContentTacticResultRequest : Request<EventContentTacticResultResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_TacticResult;
    public long EventContentId;
    public bool PassCheckCharacter;
    public BattleSummary Summary;
    public SkillCardHand Hand;
    public TacticSkipSummary SkipSummary;
}

public class EventContentEnterSubStageRequest : Request<EventContentEnterSubStageResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_EnterSubStage;
    public long EventContentId;
    public long StageUniqueId;
    public long LastEnterStageEchelonNumber;
}

public class EventContentSubStageResultRequest : Request<EventContentSubStageResultResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_SubStageResult;
    public long EventContentId;
    public bool PassCheckCharacter;
    public BattleSummary Summary;
}

public class EventContentDeployEchelonRequest : Request<EventContentDeployEchelonResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_DeployEchelon;
    public long EventContentId;
    public long StageUniqueId;
    public List<HexaUnit> DeployedEchelons;
}

public class EventContentWithdrawEchelonRequest : Request<EventContentWithdrawEchelonResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_WithdrawEchelon;
    public long EventContentId;
    public long StageUniqueId;
    public List<long> WithdrawEchelonEntityId;
}

public class EventContentMapMoveRequest : Request<EventContentMapMoveResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_MapMove;
    public long EventContentId;
    public long StageUniqueId;
    public long EchelonEntityId;
    public HexLocation DestPosition;
}

public class EventContentEndTurnRequest : Request<EventContentEndTurnResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_EndTurn;
    public long EventContentId;
    public long StageUniqueId;
}

public class EventContentRetreatRequest : Request<EventContentRetreatResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_Retreat;
    public long EventContentId;
    public long StageUniqueId;
}

public class EventContentPortalRequest : Request<EventContentPortalResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_Portal;
    public long EventContentId;
    public long StageUniqueId;
    public long EchelonEntityId;
}

public class EventContentPurchasePlayCountHardStageRequest : Request<EventContentPurchasePlayCountHardStageResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_PurchasePlayCountHardStage;
    public long EventContentId;
    public long StageUniqueId;
}

public class EventContentShopListRequest : Request<EventContentShopListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_ShopList;
    public long EventContentId;
    public List<ShopCategoryType> CategoryList;
}

public class EventContentShopRefreshRequest : Request<EventContentShopRefreshResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_ShopRefresh;
    public long EventContentId;
    public ShopCategoryType ShopCategoryType;
}

public class EventContentReceiveStageTotalRewardRequest : Request<EventContentReceiveStageTotalRewardResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_ReceiveStageTotalReward;
    public long EventContentId;
}

public class EventContentEnterMainGroundStageRequest : Request<EventContentEnterMainGroundStageResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_EnterMainGroundStage;
    public long EventContentId;
    public long StageUniqueId;
    public long LastEnterStageEchelonNumber;
}

public class EventContentMainGroundStageResultRequest : Request<EventContentMainGroundStageResultResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_MainGroundStageResult;
    public long EventContentId;
    public bool PassCheckCharacter;
    public BattleSummary Summary;
}

public class EventContentShopBuyMerchandiseRequest : Request<EventContentShopBuyMerchandiseResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_ShopBuyMerchandise;
    public long EventContentId;
    public bool IsRefreshMerchandise;
    public long ShopUniqueId;
    public long GoodsUniqueId;
    public long PurchaseCount;
}

public class EventContentShopBuyRefreshMerchandiseRequest : Request<EventContentShopBuyRefreshMerchandiseResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_ShopBuyRefreshMerchandise;
    public long EventContentId;
    public List<long> ShopUniqueIds;
}

public class EventContentSelectBuffRequest : Request<EventContentSelectBuffResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_SelectBuff;
    public long SelectedBuffId;
}

public class EventContentBoxGachaShopListRequest : Request<EventContentBoxGachaShopListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_BoxGachaShopList;
    public long EventContentId;
}

public class EventContentBoxGachaShopPurchaseRequest : Request<EventContentBoxGachaShopPurchaseResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_BoxGachaShopPurchase;
    public long EventContentId;
    public long PurchaseCount;
    public bool PurchaseAll;
}

public class EventContentBoxGachaShopRefreshRequest : Request<EventContentBoxGachaShopRefreshResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_BoxGachaShopRefresh;
    public long EventContentId;
}

public class EventContentCollectionListRequest : Request<EventContentCollectionListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_CollectionList;
    public long EventContentId;
}

public class EventContentCollectionForMissionRequest : Request<EventContentCollectionForMissionResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_CollectionForMission;
    public long EventContentId;
}

public class EventContentScenarioGroupHistoryUpdateRequest : Request<EventContentScenarioGroupHistoryUpdateResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_ScenarioGroupHistoryUpdate;
    public long ScenarioGroupUniqueId;
    public long ScenarioType;
    public long EventContentId;
}

public class EventContentCardShopListRequest : Request<EventContentCardShopListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_CardShopList;
    public long EventContentId;
}

public class EventContentCardShopShuffleRequest : Request<EventContentCardShopShuffleResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_CardShopShuffle;
    public long EventContentId;
}

public class EventContentCardShopPurchaseRequest : Request<EventContentCardShopPurchaseResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_CardShopPurchase;
    public long EventContentId;
    public int SlotNumber;
}

public class EventContentRestartMainStageRequest : Request<EventContentRestartMainStageResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_RestartMainStage;
    public long EventContentId;
    public long StageUniqueId;
}

public class EventContentLocationGetInfoRequest : Request<EventContentLocationGetInfoResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_LocationGetInfo;
    public long EventContentId;
}

public class EventContentLocationAttendScheduleRequest : Request<EventContentLocationAttendScheduleResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_LocationAttendSchedule;
    public long EventContentId;
    public long ZoneId;
    public long Count;
}

public class EventContentFortuneGachaPurchaseRequest : Request<EventContentFortuneGachaPurchaseResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_FortuneGachaPurchase;
    public long EventContentId;
}

public class EventContentSubEventLobbyRequest : Request<EventContentSubEventLobbyResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_SubEventLobby;
    public long EventContentId;
}

public class EventContentEnterStoryStageRequest : Request<EventContentEnterStoryStageResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_EnterStoryStage;
    public long StageUniqueId;
    public long EventContentId;
}

public class EventContentStoryStageResultRequest : Request<EventContentStoryStageResultResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_StoryStageResult;
    public long EventContentId;
    public long StageUniqueId;
}

public class EventContentDiceRaceLobbyRequest : Request<EventContentDiceRaceLobbyResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_DiceRaceLobby;
    public long EventContentId;
}

public class EventContentDiceRaceRollRequest : Request<EventContentDiceRaceRollResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_DiceRaceRoll;
    public long EventContentId;
}

public class EventContentDiceRaceLapRewardRequest : Request<EventContentDiceRaceLapRewardResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_DiceRaceLapReward;
    public long EventContentId;
}

public class EventContentPermanentListRequest : Request<EventContentPermanentListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_PermanentList;
}

public class TTSGetFileRequest : Request<TTSGetFileResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.TTS_GetFile;
}

public class TTSGetKanaRequest : Request<TTSGetKanaResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.TTS_GetKana;
    public string CallName;
}

public class ContentLogUIOpenStatisticsRequest : Request<ContentLogUIOpenStatisticsResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.ContentLog_UIOpenStatistics;
    public Dictionary<string, int> OpenCountPerPrefab;
}

public class MomoTalkOutLineRequest : Request<MomoTalkOutLineResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.MomoTalk_OutLine;
}

public class MomoTalkMessageListRequest : Request<MomoTalkMessageListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.MomoTalk_MessageList;
    public long CharacterDBId;
}

public class MomoTalkReadRequest : Request<MomoTalkReadResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.MomoTalk_Read;
    public long CharacterDBId;
    public long LastReadMessageGroupId;
    public Int64? ChosenMessageId;
}

public class MomoTalkFavorScheduleRequest : Request<MomoTalkFavorScheduleResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.MomoTalk_FavorSchedule;
    public long ScheduleId;
}

public class ClearDeckListRequest : Request<ClearDeckListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.ClearDeck_List;
    public long StageId;
}

public class MiniGameStageListRequest : Request<MiniGameStageListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.MiniGame_StageList;
    public long EventContentId;
}

public class MiniGameEnterStageRequest : Request<MiniGameEnterStageResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.MiniGame_EnterStage;
    public long EventContentId;
    public long UniqueId;
}

public class MiniGameResultRequest : Request<MiniGameResultResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.MiniGame_Result;
    public long EventContentId;
    public long UniqueId;
    public MinigameRhythmSummary Summary;
}

public class MiniGameMissionListRequest : Request<MiniGameMissionListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.MiniGame_MissionList;
    public long EventContentId;
}

public class MiniGameMissionRewardRequest : Request<MiniGameMissionRewardResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.MiniGame_MissionReward;
    public long MissionUniqueId;
    public long ProgressServerId;
    public long EventContentId;
}

public class MiniGameMissionMultipleRewardRequest : Request<MiniGameMissionMultipleRewardResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.MiniGame_MissionMultipleReward;
    public MissionCategory MissionCategory;
    public long EventContentId;
}

public class NotificationLobbyCheckRequest : Request<NotificationLobbyCheckResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Notification_LobbyCheck;
}

public class ProofTokenRequestQuestionRequest : Request<ProofTokenRequestQuestionResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.ProofToken_RequestQuestion;
}

public class ProofTokenSubmitRequest : Request<ProofTokenSubmitResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.ProofToken_Submit;
    public long Answer;
}

public class SchoolDungeonListRequest : Request<SchoolDungeonListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.SchoolDungeon_List;
}

public class SchoolDungeonEnterBattleRequest : Request<SchoolDungeonEnterBattleResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.SchoolDungeon_EnterBattle;
    public long StageUniqueId;
}

public class SchoolDungeonBattleResultRequest : Request<SchoolDungeonBattleResultResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.SchoolDungeon_BattleResult;
    public long StageUniqueId;
    public bool PassCheckCharacter;
    public BattleSummary Summary;
}

public class SchoolDungeonRetreatRequest : Request<SchoolDungeonRetreatResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.SchoolDungeon_Retreat;
    public long StageUniqueId;
}

public class TimeAttackDungeonLobbyRequest : Request<TimeAttackDungeonLobbyResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.TimeAttackDungeon_Lobby;
}

public class TimeAttackDungeonCreateBattleRequest : Request<TimeAttackDungeonCreateBattleResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.TimeAttackDungeon_CreateBattle;
    public bool IsPractice;
}

public class TimeAttackDungeonEnterBattleRequest : Request<TimeAttackDungeonEnterBattleResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.TimeAttackDungeon_EnterBattle;
    public long RoomId;
    public ClanAssistUseInfo AssistUseInfo;
}

public class TimeAttackDungeonEndBattleRequest : Request<TimeAttackDungeonEndBattleResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.TimeAttackDungeon_EndBattle;
    public int EchelonId;
    public long RoomId;
    public BattleSummary Summary;
    public ClanAssistUseInfo AssistUseInfo;
}

public class TimeAttackDungeonSweepRequest : Request<TimeAttackDungeonSweepResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.TimeAttackDungeon_Sweep;
    public long SweepCount;
}

public class TimeAttackDungeonGiveUpRequest : Request<TimeAttackDungeonGiveUpResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.TimeAttackDungeon_GiveUp;
    public long RoomId;
}

public class TimeAttackDungeonLoginRequest : Request<TimeAttackDungeonLoginResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.TimeAttackDungeon_Login;
}

public class WorldRaidLobbyRequest : Request<WorldRaidLobbyResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.WorldRaid_Lobby;
    public long SeasonId;
}

public class WorldRaidBossListRequest : Request<WorldRaidBossListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.WorldRaid_BossList;
    public long SeasonId;
    public bool RequestOnlyWorldBossData;
}

public class WorldRaidEnterBattleRequest : Request<WorldRaidEnterBattleResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.WorldRaid_EnterBattle;
    public long SeasonId;
    public long GroupId;
    public long UniqueId;
    public long EchelonId;
    public bool IsPractice;
    public bool IsTicket;
    public List<ClanAssistUseInfo> AssistUseInfos;
}

public class WorldRaidBattleResultRequest : Request<WorldRaidBattleResultResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.WorldRaid_BattleResult;
    public long SeasonId;
    public long GroupId;
    public long UniqueId;
    public long EchelonId;
    public bool IsPractice;
    public bool IsTicket;
    public BattleSummary Summary;
    public List<ClanAssistUseInfo> AssistUseInfos;
}

public class WorldRaidReceiveRewardRequest : Request<WorldRaidReceiveRewardResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.WorldRaid_ReceiveReward;
    public long SeasonId;
}

public class ResetableContentGetRequest : Request<ResetableContentGetResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.ResetableContent_Get;
}

public class ConquestGetInfoRequest : Request<ConquestGetInfoResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Conquest_GetInfo;
    public long EventContentId;
}

public class ConquestConquerRequest : Request<ConquestConquerResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Conquest_Conquer;
    public long EventContentId;
    public StageDifficulty Difficulty;
    public long TileUniqueId;
}

public class ConquestConquerWithBattleStartRequest : Request<ConquestConquerWithBattleStartResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Conquest_ConquerWithBattleStart;
    public long EventContentId;
    public StageDifficulty Difficulty;
    public long TileUniqueId;
    public Int64? EchelonNumber;
    public ClanAssistUseInfo ClanAssistUseInfo;
}

public class ConquestConquerWithBattleResultRequest : Request<ConquestConquerWithBattleResultResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Conquest_ConquerWithBattleResult;
    public long EventContentId;
    public StageDifficulty Difficulty;
    public long TileUniqueId;
    public BattleSummary BattleSummary;
}

public class ConquestManageBaseRequest : Request<ConquestManageBaseResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Conquest_ManageBase;
    public long EventContentId;
    public StageDifficulty Difficulty;
    public long TileUniqueId;
    public int ManageCount;
}

public class ConquestUpgradeBaseRequest : Request<ConquestUpgradeBaseResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Conquest_UpgradeBase;
    public long EventContentId;
    public StageDifficulty Difficulty;
    public long TileUniqueId;
}

public class ConquestTakeEventObjectRequest : Request<ConquestTakeEventObjectResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Conquest_TakeEventObject;
    public long EventContentId;
    public long ConquestObjectDBId;
}

public class ConquestEventObjectBattleStartRequest : Request<ConquestEventObjectBattleStartResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Conquest_EventObjectBattleStart;
    public long EventContentId;
    public long ConquestObjectDBId;
    public long EchelonNumber;
    public ClanAssistUseInfo ClanAssistUseInfo;
}

public class ConquestEventObjectBattleResultRequest : Request<ConquestEventObjectBattleResultResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Conquest_EventObjectBattleResult;
    public long EventContentId;
    public long ConquestObjectDBId;
    public BattleSummary BattleSummary;
}

public class ConquestNormalizeEchelonRequest : Request<ConquestNormalizeEchelonResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Conquest_NormalizeEchelon;
    public long EventContentId;
    public StageDifficulty Difficulty;
    public long TileUniqueId;
}

public class ConquestCheckRequest : Request<ConquestCheckResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Conquest_Check;
    public long EventContentId;
}

public class FriendListRequest : Request<FriendListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Friend_List;
}

public class FriendRemoveRequest : Request<FriendRemoveResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Friend_Remove;
    public long TargetAccountId;
}

public class FriendGetFriendDetailedInfoRequest : Request<FriendGetFriendDetailedInfoResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Friend_GetFriendDetailedInfo;
    public long FriendAccountId;
}

public class FriendGetIdCardRequest : Request<FriendGetIdCardResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Friend_GetIdCard;
}

public class FriendSetIdCardRequest : Request<FriendSetIdCardResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Friend_SetIdCard;
    public string Comment;
    public long RepresentCharacterUniqueId;
    public bool SearchPermission;
    public bool AutoAcceptFriendRequest;
    public bool ShowAccountLevel;
    public bool ShowFriendCode;
    public bool ShowRaidRanking;
    public bool ShowArenaRanking;
    public long BackgroundId;
}

public class FriendSearchRequest : Request<FriendSearchResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Friend_Search;
    public string FriendCode;
    public FriendSearchLevelOption LevelOption;
}

public class FriendSendFriendRequestRequest : Request<FriendSendFriendRequestResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Friend_SendFriendRequest;
    public long TargetAccountId;
}

public class FriendAcceptFriendRequestRequest : Request<FriendAcceptFriendRequestResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Friend_AcceptFriendRequest;
    public long TargetAccountId;
}

public class FriendDeclineFriendRequestRequest : Request<FriendDeclineFriendRequestResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Friend_DeclineFriendRequest;
    public long TargetAccountId;
}

public class FriendCancelFriendRequestRequest : Request<FriendCancelFriendRequestResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Friend_CancelFriendRequest;
    public long TargetAccountId;
}

public class FriendCheckRequest : Request<FriendCheckResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Friend_Check;
}

public class CharacterGearListRequest : Request<CharacterGearListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.CharacterGear_List;
}

public class CharacterGearUnlockRequest : Request<CharacterGearUnlockResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.CharacterGear_Unlock;
    public long CharacterServerId;
    public int SlotIndex;
}

public class CharacterGearTierUpRequest : Request<CharacterGearTierUpResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.CharacterGear_TierUp;
    public long GearServerId;
}

public class QueuingGetTicketRequest : Request<QueuingGetTicketResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Queuing_GetTicket;
    public long NpSN;
    public string NpToken;
    public string Npacode;
    public string OSType;
    public string AccessIP;
    public bool MakeStandby;
    public bool PassCheck;
    public bool PassCheckNexon;
    public string WaitingTicket;
    public string ClientVersion;
}

public class ManagementBannerListRequest : Request<ManagementBannerListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Management_BannerList;
}

public class ManagementContentsLockListRequest : Request<ManagementContentsLockListResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Management_ContentsLockList;
}

public class CommonCheatRequest : Request<CommonCheatResponse>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Common_Cheat;
    public string Cheat;
    public List<CheatCharacterCustomPreset> CharacterCustomPreset;
}

