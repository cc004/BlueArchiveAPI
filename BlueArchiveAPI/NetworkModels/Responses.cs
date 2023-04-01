namespace BlueArchiveAPI.NetworkModels;
using System.Collections.ObjectModel;

public class SystemVersionResponse : Response<SystemVersionRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.System_Version;
    public long CurrentVersion;
    public long MinimumVersion;
    public bool IsDevelopment;
}

public class SessionInfoResponse : Response<SessionInfoRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Session_Info;
    public SessionDB SessionDB;
}

public class AuditGachaStatisticsResponse : Response<AuditGachaStatisticsRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Audit_GachaStatistics;
    public Dictionary<long, long> GachaResult;
}

public class AccountCreateResponse : Response<AccountCreateRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_Create;
}

public class AccountNicknameResponse : Response<AccountNicknameRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_Nickname;
    public AccountDB AccountDB;
}

public class AccountAuthResponse : Response<AccountAuthRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_Auth;
    public long CurrentVersion;
    public long MinimumVersion;
    public bool IsDevelopment;
    public bool UpdateRequired;
    public string TTSCdnUri;
    public AccountDB AccountDB;
    public List<AttendanceBookReward> AttendanceBookRewards;
    public List<AttendanceHistoryDB> AttendanceHistoryDBs;
    public List<OpenConditionDB> OpenConditions;
    public List<PurchaseCountDB> RepurchasableMonthlyProductCountDBs;
    public List<ParcelInfo> MonthlyProductParcel;
    public List<ParcelInfo> MonthlyProductMail;
    public List<ParcelInfo> BiweeklyProductParcel;
    public List<ParcelInfo> BiweeklyProductMail;
    public List<ParcelInfo> WeeklyProductParcel;
    public List<ParcelInfo> WeeklyProductMail;
    public string EncryptedUID;
    public List<AccountBanByNexonDB> accountBanByNexonDBs;
}

public class AccountCurrencySyncResponse : Response<AccountCurrencySyncRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_CurrencySync;
    public AccountCurrencyDB AccountCurrencyDB;
}

public class AccountSetRepresentCharacterAndCommentResponse : Response<AccountSetRepresentCharacterAndCommentRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_SetRepresentCharacterAndComment;
    public AccountDB AccountDB;
    public CharacterDB RepresentCharacterDB;
}

public class AccountGetTutorialResponse : Response<AccountGetTutorialRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_GetTutorial;
    public List<long> TutorialIds;
}

public class AccountSetTutorialResponse : Response<AccountSetTutorialRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_SetTutorial;
}

public class AccountPassCheckResponse : Response<AccountPassCheckRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_PassCheck;
}

public class AccountCheckYostarResponse : Response<AccountCheckYostarRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_CheckYostar;
    public int ResultState;
    public string ResultMessag;
    public string Birth;
}

public class AccountCallNameResponse : Response<AccountCallNameRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_CallName;
    public AccountDB AccountDB;
}

public class AccountBirthDayResponse : Response<AccountBirthDayRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_BirthDay;
    public AccountDB AccountDB;
}

public class AccountAuth2Response : Response<AccountAuth2Request>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_Auth2;
}

public class AccountLinkRewardResponse : Response<AccountLinkRewardRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_LinkReward;
}

public class AccountCheckNexonResponse : Response<AccountCheckNexonRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_CheckNexon;
    public int ResultState;
    public string ResultMessage;
}

public class AccountDetachNexonResponse : Response<AccountDetachNexonRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_DetachNexon;
    public int ResultState;
    public string ResultMessage;
}

public class AccountReportXignCodeCheaterResponse : Response<AccountReportXignCodeCheaterRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_ReportXignCodeCheater;
}

public class AccountDismissRepurchasablePopupResponse : Response<AccountDismissRepurchasablePopupRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_DismissRepurchasablePopup;
}

public class AccountInvalidateTokenResponse : Response<AccountInvalidateTokenRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_InvalidateToken;
}

public class AccountLoginSyncResponse : Response<AccountLoginSyncRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_LoginSync;
    public ResponsePacket Responses;
    public CafeGetInfoResponse CafeGetInfoResponse;
    public AccountCurrencySyncResponse AccountCurrencySyncResponse;
    public CharacterListResponse CharacterListResponse;
    public EquipmentItemListResponse EquipmentItemListResponse;
    public CharacterGearListResponse CharacterGearListResponse;
    public ItemListResponse ItemListResponse;
    public EchelonListResponse EchelonListResponse;
    public MemoryLobbyListResponse MemoryLobbyListResponse;
    public CampaignListResponse CampaignListResponse;
    public ArenaLoginResponse ArenaLoginResponse;
    public RaidLoginResponse RaidLoginResponse;
    public CraftInfoListResponse CraftInfoListResponse;
    public ClanLoginResponse ClanLoginResponse;
    public MomoTalkOutLineResponse MomotalkOutlineResponse;
    public ScenarioListResponse ScenarioListResponse;
    public ShopGachaRecruitListResponse ShopGachaRecruitListResponse;
    public TimeAttackDungeonLoginResponse TimeAttackDungeonLoginResponse;
    public EventContentPermanentListResponse EventContentPermanentListResponse;
    public BillingPurchaseListByNexonResponse BillingPurchaseListByNexonResponse;
}

public class AccountVerifyAdultCheckResponse : Response<AccountVerifyAdultCheckRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Account_VerifyCheckAdultAgree;
    public bool CheckAdultAgree;
}

public class CharacterListResponse : Response<CharacterListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Character_List;
    public List<CharacterDB> CharacterDBs;
    public List<CharacterDB> TSSCharacterDBs;
    public List<WeaponDB> WeaponDBs;
}

public class CharacterTranscendenceResponse : Response<CharacterTranscendenceRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Character_Transcendence;
    public CharacterDB CharacterDB;
    public ParcelResultDB ParcelResultDB;
}

public class CharacterExpGrowthResponse : Response<CharacterExpGrowthRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Character_ExpGrowth;
    public CharacterDB CharacterDB;
    public AccountCurrencyDB AccountCurrencyDB;
    public ConsumeResultDB ConsumeResultDB;
}

public class CharacterFavorGrowthResponse : Response<CharacterFavorGrowthRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Character_FavorGrowth;
    public CharacterDB CharacterDB;
    public List<ItemDB> ConsumeStackableItemDBResult;
    public ParcelResultDB ParcelResultDB;
}

public class CharacterUnlockWeaponResponse : Response<CharacterUnlockWeaponRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Character_UnlockWeapon;
    public WeaponDB WeaponDB;
}

public class CharacterWeaponExpGrowthResponse : Response<CharacterWeaponExpGrowthRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Character_WeaponExpGrowth;
    public ParcelResultDB ParcelResultDB;
}

public class CharacterWeaponTranscendenceResponse : Response<CharacterWeaponTranscendenceRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Character_WeaponTranscendence;
    public ParcelResultDB ParcelResultDB;
}

public class CharacterSetFavoritesResponse : Response<CharacterSetFavoritesRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Character_SetFavorites;
    public List<CharacterDB> CharacterDBs;
}

public class EquipmentBatchGrowthResponse : Response<EquipmentBatchGrowthRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Equipment_BatchGrowth;
    public List<EquipmentDB> EquipmentDBs;
    public ParcelResultDB ParcelResultDB;
    public ConsumeResultDB ConsumeResultDB;
}

public class ItemListResponse : Response<ItemListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Item_List;
    public List<ItemDB> ItemDBs;
    public List<ItemDB> ExpiryItemDBs;
}

public class ItemSellResponse : Response<ItemSellRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Item_Sell;
    public AccountCurrencyDB AccountCurrencyDB;
}

public class ItemConsumeResponse : Response<ItemConsumeRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Item_Consume;
    public ItemDB UsedItemDB;
    public ParcelResultDB NewParcelResultDB;
}

public class ItemLockResponse : Response<ItemLockRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Item_Lock;
    public ItemDB ItemDB;
}

public class ItemBulkConsumeResponse : Response<ItemBulkConsumeRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Item_BulkConsume;
    public ItemDB UsedItemDB;
    public List<ParcelInfo> ParcelInfosInMailBox;
}

public class ItemSelectTicketResponse : Response<ItemSelectTicketRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Item_SelectTicket;
    public ItemDB UsedItemDB;
    public ParcelResultDB ParcelResultDB;
}

public class EchelonListResponse : Response<EchelonListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Echelon_List;
    public List<EchelonDB> EchelonDBs;
    public EchelonDB ArenaEchelonDB;
}

public class EchelonSaveResponse : Response<EchelonSaveRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Echelon_Save;
    public EchelonDB EchelonDB;
}

public class EchelonPresetListResponse : Response<EchelonPresetListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Echelon_PresetList;
    public EchelonPresetGroupDB[] PresetGroupDBs;
}

public class EchelonPresetSaveResponse : Response<EchelonPresetSaveRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Echelon_PresetSave;
    public EchelonPresetDB PresetDB;
}

public class EchelonPresetGroupRenameResponse : Response<EchelonPresetGroupRenameRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Echelon_PresetGroupRename;
    public EchelonPresetGroupDB PresetGroupDB;
}

public class CampaignListResponse : Response<CampaignListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_List;
    public List<CampaignChapterClearRewardHistoryDB> CampaignChapterClearRewardHistoryDBs;
    public List<CampaignStageHistoryDB> StageHistoryDBs;
    public List<StrategyObjectHistoryDB> StrategyObjecthistoryDBs;
    public DailyResetCountDB DailyResetCountDB;
}

public class CampaignEnterMainStageResponse : Response<CampaignEnterMainStageRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_EnterMainStage;
    public CampaignMainStageSaveDB SaveDataDB;
}

public class CampaignConfirmMainStageResponse : Response<CampaignConfirmMainStageRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_ConfirmMainStage;
    public ParcelResultDB ParcelResultDB;
    public CampaignMainStageSaveDB SaveDataDB;
    public List<long> ScenarioIds;
}

public class CampaignDeployEchelonResponse : Response<CampaignDeployEchelonRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_DeployEchelon;
    public CampaignMainStageSaveDB SaveDataDB;
}

public class CampaignWithdrawEchelonResponse : Response<CampaignWithdrawEchelonRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_WithdrawEchelon;
    public CampaignMainStageSaveDB SaveDataDB;
    public List<EchelonDB> WithdrawEchelonDBs;
}

public class CampaignMapMoveResponse : Response<CampaignMapMoveRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_MapMove;
    public CampaignMainStageSaveDB SaveDataDB;
    public List<long> ScenarioIds;
    public long EchelonEntityId;
    public Strategy StrategyObject;
    public List<ParcelInfo> StrategyObjectParcelInfos;
}

public class CampaignEndTurnResponse : Response<CampaignEndTurnRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_EndTurn;
    public CampaignMainStageSaveDB SaveDataDB;
    public AccountCurrencyDB AccountCurrencyDB;
    public List<long> ScenarioIds;
}

public class CampaignEnterTacticResponse : Response<CampaignEnterTacticRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_EnterTactic;
}

public class CampaignTacticResultResponse : Response<CampaignTacticResultRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_TacticResult;
    public long TacticRank;
    public CampaignStageHistoryDB CampaignStageHistoryDB;
    public List<CharacterDB> LevelUpCharacterDBs;
    public List<ParcelInfo> FirstClearReward;
    public List<ParcelInfo> ThreeStarReward;
    public Strategy StrategyObject;
    public Dictionary<long, List<ParcelInfo>> StrategyObjectRewards;
    public ParcelResultDB ParcelResultDB;
    public CampaignMainStageSaveDB SaveDataDB;
    public List<long> ScenarioIds;
}

public class CampaignRetreatResponse : Response<CampaignRetreatRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_Retreat;
    public List<long> ReleasedEchelonNumbers;
    public ParcelResultDB ParcelResultDB;
}

public class CampaignChapterClearRewardResponse : Response<CampaignChapterClearRewardRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_ChapterClearReward;
    public CampaignChapterClearRewardHistoryDB CampaignChapterClearRewardHistoryDB;
    public ParcelResultDB ParcelResultDB;
}

public class CampaignHealResponse : Response<CampaignHealRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_Heal;
    public AccountCurrencyDB AccountCurrencyDB;
    public DailyResetCountDB DailyResetCountDB;
    public CampaignMainStageSaveDB SaveDataDB;
}

public class CampaignEnterSubStageResponse : Response<CampaignEnterSubStageRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_EnterSubStage;
    public ParcelResultDB ParcelResultDB;
    public CampaignSubStageSaveDB SaveDataDB;
}

public class CampaignSubStageResultResponse : Response<CampaignSubStageResultRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_SubStageResult;
    public long TacticRank;
    public CampaignStageHistoryDB CampaignStageHistoryDB;
    public List<CharacterDB> LevelUpCharacterDBs;
    public ParcelResultDB ParcelResultDB;
    public List<ParcelInfo> FirstClearReward;
    public List<long> ScenarioIds;
}

public class CampaignPortalResponse : Response<CampaignPortalRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_Portal;
    public CampaignMainStageSaveDB CampaignMainStageSaveDB;
    public List<long> ScenarioIds;
}

public class CampaignConfirmTutorialStageResponse : Response<CampaignConfirmTutorialStageRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_ConfirmTutorialStage;
    public CampaignMainStageSaveDB SaveDataDB;
    public List<long> ScenarioIds;
}

public class CampaignPurchasePlayCountHardStageResponse : Response<CampaignPurchasePlayCountHardStageRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_PurchasePlayCountHardStage;
    public AccountCurrencyDB AccountCurrencyDB;
    public CampaignStageHistoryDB CampaignStageHistoryDB;
}

public class CampaignEnterTutorialStageResponse : Response<CampaignEnterTutorialStageRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_EnterTutorialStage;
    public ParcelResultDB ParcelResultDB;
    public CampaignTutorialStageSaveDB SaveDataDB;
}

public class CampaignTutorialStageResultResponse : Response<CampaignTutorialStageResultRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_TutorialStageResult;
    public CampaignStageHistoryDB CampaignStageHistoryDB;
    public ParcelResultDB ParcelResultDB;
    public List<ParcelInfo> ClearReward;
    public List<ParcelInfo> FirstClearReward;
}

public class CampaignRestartMainStageResponse : Response<CampaignRestartMainStageRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Campaign_RestartMainStage;
    public ParcelResultDB ParcelResultDB;
    public CampaignMainStageSaveDB SaveDataDB;
}

public class MailListResponse : Response<MailListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Mail_List;
    public List<MailDB> MailDBs;
    public long Count;
}

public class MailCheckResponse : Response<MailCheckRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Mail_Check;
    public long Count;
}

public class MailReceiveResponse : Response<MailReceiveRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Mail_Receive;
    public List<long> MailServerIds;
    public ParcelResultDB ParcelResultDB;
}

public class MissionListResponse : Response<MissionListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Mission_List;
    public List<MissionHistoryDB> HistoryDBs;
    public List<MissionProgressDB> ProgressDBs;
    public List<GuideMissionSeasonDB> GuideMissionSeasonDBs;
    public MissionInfo DailySuddenMissionInfo;
    public List<long> ClearedOrignalMissionIds;
}

public class MissionRewardResponse : Response<MissionRewardRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Mission_Reward;
    public MissionHistoryDB AddedHistoryDB;
    public ParcelResultDB ParcelResultDB;
}

public class MissionMultipleRewardResponse : Response<MissionMultipleRewardRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Mission_MultipleReward;
    public List<MissionHistoryDB> AddedHistoryDBs;
    public ParcelResultDB ParcelResultDB;
}

public class MissionSyncResponse : Response<MissionSyncRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Mission_Sync;
    public List<MissionHistoryDB> HistoryDBs;
    public List<MissionProgressDB> ProgressDBs;
    public Dictionary<long, List<MissionHistoryDB>> EventHistoryDBs;
    public Dictionary<long, List<MissionProgressDB>> EventProgressDBs;
    public Dictionary<long, List<MissionHistoryDB>> MiniGameHistoryDBs;
    public Dictionary<long, List<MissionProgressDB>> MiniGameProgressDBs;
}

public class AttendanceRewardResponse : Response<AttendanceRewardRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Attendance_Reward;
    public List<AttendanceBookReward> AttendanceBookRewards;
    public List<AttendanceHistoryDB> AttendanceHistoryDBs;
    public ParcelResultDB ParcelResultDB;
}

public class ShopBuyMerchandiseResponse : Response<ShopBuyMerchandiseRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Shop_BuyMerchandise;
    public AccountCurrencyDB AccountCurrencyDB;
    public ConsumeResultDB ConsumeResultDB;
    public ParcelResultDB ParcelResultDB;
    public MailDB MailDB;
    public ShopProductDB ShopProductDB;
}

public class ShopBuyGachaResponse : Response<ShopBuyGachaRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Shop_BuyGacha;
    public ConsumeResultDB ConsumeResultDB;
    public ParcelResultDB ParcelResultDB;
}

public class ShopListResponse : Response<ShopListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Shop_List;
    public List<ShopInfoDB> ShopInfos;
    public List<ShopEligmaHistoryDB> ShopEligmaHistoryDBs;
}

public class ShopRefreshResponse : Response<ShopRefreshRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Shop_Refresh;
    public ParcelResultDB ParcelResultDB;
    public ShopInfoDB ShopInfoDB;
}

public class ShopBuyEligmaResponse : Response<ShopBuyEligmaRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Shop_BuyEligma;
    public ParcelResultDB ParcelResultDB;
    public ConsumeResultDB ConsumeResultDB;
    public ShopProductDB ShopProductDB;
}

public class ShopBuyGacha2Response : Response<ShopBuyGacha2Request>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Shop_BuyGacha2;
    public DateTime UpdateTime;
    public long GemBonusRemain;
    public long GemPaidRemain;
    public List<ItemDB> ConsumedItems;
    public List<GachaResult> GachaResults;
    public List<ItemDB> AcquiredItems;
}

public class ShopGachaRecruitListResponse : Response<ShopGachaRecruitListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Shop_GachaRecruitList;
    public List<ShopRecruitDB> ShopRecruits;
    public List<ShopFreeRecruitHistoryDB> ShopFreeRecruitHistoryDBs;
}

public class ShopBuyRefreshMerchandiseResponse : Response<ShopBuyRefreshMerchandiseRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Shop_BuyRefreshMerchandise;
    public AccountCurrencyDB AccountCurrencyDB;
    public ConsumeResultDB ConsumeResultDB;
    public ParcelResultDB ParcelResultDB;
    public List<ShopProductDB> ShopProductDB;
    public MailDB MailDB;
}

public class ShopBuyGacha3Response : Response<ShopBuyGacha3Request>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Shop_BuyGacha3;
    public ShopFreeRecruitHistoryDB FreeRecruitHistoryDB;
}

public class ShopBuyAPResponse : Response<ShopBuyAPRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Shop_BuyAP;
    public AccountCurrencyDB AccountCurrencyDB;
    public ConsumeResultDB ConsumeResultDB;
    public ParcelResultDB ParcelResultDB;
    public MailDB MailDB;
    public ShopProductDB ShopProductDB;
}

public class RecipeCraftResponse : Response<RecipeCraftRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Recipe_Craft;
    public ParcelResultDB ParcelResultDB;
    public ConsumeResultDB EquipmentConsumeResultDB;
    public ConsumeResultDB ItemConsumeResultDB;
}

public class MemoryLobbyListResponse : Response<MemoryLobbyListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.MemoryLobby_List;
    public List<MemoryLobbyDB> MemoryLobbyDBs;
}

public class MemoryLobbySetMainResponse : Response<MemoryLobbySetMainRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.MemoryLobby_SetMain;
    public AccountDB AccountDB;
}

public class MemoryLobbyUpdateLobbyModeResponse : Response<MemoryLobbyUpdateLobbyModeRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.MemoryLobby_UpdateLobbyMode;
}

public class MemoryLobbyInteractResponse : Response<MemoryLobbyInteractRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.MemoryLobby_Interact;
}

public class CumulativeTimeRewardListResponse : Response<CumulativeTimeRewardListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.CumulativeTimeReward_List;
    public CumulativeTimeRewardInfo RewardInfo;
    public List<CumulativeTimeRewardDB> RewardHistoryDBs;
}

public class OpenConditionListResponse : Response<OpenConditionListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.OpenCondition_List;
    public List<OpenConditionContent> ConditionContents;
}

public class OpenConditionSetResponse : Response<OpenConditionSetRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.OpenCondition_Set;
    public List<OpenConditionDB> ConditionDBs;
}

public class OpenConditionEventListResponse : Response<OpenConditionEventListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.OpenCondition_EventList;
    public Dictionary<long, List<ConquestTileDB>> ConquestTiles;
    public Dictionary<long, List<WorldRaidLocalBossDB>> WorldRaidLocalBossDBs;
}

public class ToastListResponse : Response<ToastListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Toast_List;
    public List<ToastDB> ToastDBs;
}

public class RaidListResponse : Response<RaidListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_List;
    public List<RaidDB> CreateRaidDBs;
    public List<RaidDB> EnterRaidDBs;
    public List<RaidDB> ListRaidDBs;
}

public class RaidCompleteListResponse : Response<RaidCompleteListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_CompleteList;
    public List<RaidDB> RaidDBs;
    public long StackedDamage;
    public List<long> ReceiveRewardId;
    public long CurSeasonUniqueId;
}

public class RaidDetailResponse : Response<RaidDetailRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_Detail;
    public RaidDetailDB RaidDetailDB;
    public List<long> ParticipateCharacterServerIds;
}

public class RaidSearchResponse : Response<RaidSearchRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_Search;
    public List<RaidDB> RaidDBs;
}

public class RaidCreateBattleResponse : Response<RaidCreateBattleRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_CreateBattle;
    public RaidDB RaidDB;
    public RaidBattleDB RaidBattleDB;
    public AccountCurrencyDB AccountCurrencyDB;
    public AssistCharacterDB AssistCharacterDB;
}

public class RaidEnterBattleResponse : Response<RaidEnterBattleRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_EnterBattle;
    public RaidDB RaidDB;
    public RaidBattleDB RaidBattleDB;
    public AccountCurrencyDB AccountCurrencyDB;
    public AssistCharacterDB AssistCharacterDB;
}

public class RaidBattleUpdateResponse : Response<RaidBattleUpdateRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_BattleUpdate;
    public RaidBattleDB RaidBattleDB;
}

public class RaidEndBattleResponse : Response<RaidEndBattleRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_EndBattle;
    public long RankingPoint;
    public long BestRankingPoint;
    public long ClearTimePoint;
    public long HPPercentScorePoint;
    public long DefaultClearPoint;
    public ParcelResultDB ParcelResultDB;
}

public class RaidRewardResponse : Response<RaidRewardRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_Reward;
    public long RankingPoint;
    public long BestRankingPoint;
    public ParcelResultDB ParcelResultDB;
}

public class RaidRewardAllResponse : Response<RaidRewardAllRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_RewardAll;
    public ParcelResultDB ParcelResultDB;
}

public class RaidShareResponse : Response<RaidShareRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_Share;
    public RaidDB RaidDB;
}

public class RaidSeasonRewardResponse : Response<RaidSeasonRewardRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_SeasonReward;
    public ParcelResultDB ParcelResultDB;
    public List<long> ReceiveRewardIds;
}

public class RaidLobbyResponse : Response<RaidLobbyRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_Lobby;
    public RaidSeasonType SeasonType;
    public RaidGiveUpDB RaidGiveUpDB;
    public RaidLobbyInfoDB RaidLobbyInfoDB;
}

public class RaidGiveUpResponse : Response<RaidGiveUpRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_GiveUp;
    public int Tier;
    public RaidGiveUpDB RaidGiveUpDB;
}

public class RaidOpponentListResponse : Response<RaidOpponentListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_OpponentList;
    public List<RaidUserDB> OpponentUserDBs;
}

public class RaidRankingRewardResponse : Response<RaidRankingRewardRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_RankingReward;
    public long ReceivedRankingRewardId;
    public ParcelResultDB ParcelResultDB;
}

public class RaidLoginResponse : Response<RaidLoginRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_Login;
    public RaidSeasonType SeasonType;
    public bool CanReceiveRankingReward;
}

public class RaidSweepResponse : Response<RaidSweepRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_Sweep;
    public long TotalSeasonPoint;
    public List<List<ParcelInfo>> Rewards;
    public ParcelResultDB ParcelResultDB;
}

public class RaidGetBestTeamResponse : Response<RaidGetBestTeamRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Raid_GetBestTeam;
    public List<RaidTeamSettingDB> RaidTeamSettingDBs;
}

public class SkipHistoryListResponse : Response<SkipHistoryListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.SkipHistory_List;
    public SkipHistoryDB SkipHistoryDB;
}

public class SkipHistorySaveResponse : Response<SkipHistorySaveRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.SkipHistory_Save;
    public SkipHistoryDB SkipHistoryDB;
}

public class ScenarioListResponse : Response<ScenarioListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_List;
    public List<ScenarioHistoryDB> ScenarioHistoryDBs;
    public List<ScenarioGroupHistoryDB> ScenarioGroupHistoryDBs;
}

public class ScenarioClearResponse : Response<ScenarioClearRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_Clear;
    public ScenarioHistoryDB ScenarioHistoryDB;
    public ParcelResultDB ParcelResultDB;
}

public class ScenarioGroupHistoryUpdateResponse : Response<ScenarioGroupHistoryUpdateRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_GroupHistoryUpdate;
    public ScenarioGroupHistoryDB ScenarioGroupHistoryDB;
}

public class ScenarioSkipResponse : Response<ScenarioSkipRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_Skip;
}

public class ScenarioSelectResponse : Response<ScenarioSelectRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_Select;
}

public class ScenarioAccountStudentChangeResponse : Response<ScenarioAccountStudentChangeRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_AccountStudentChange;
}

public class ScenarioLobbyStudentChangeResponse : Response<ScenarioLobbyStudentChangeRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_LobbyStudentChange;
}

public class ScenarioSpecialLobbyChangeResponse : Response<ScenarioSpecialLobbyChangeRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_SpecialLobbyChange;
}

public class ScenarioEnterResponse : Response<ScenarioEnterRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_Enter;
}

public class ScenarioEnterMainStageResponse : Response<ScenarioEnterMainStageRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_EnterMainStage;
    public StoryStrategyStageSaveDB SaveDataDB;
}

public class ScenarioConfirmMainStageResponse : Response<ScenarioConfirmMainStageRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_ConfirmMainStage;
    public ParcelResultDB ParcelResultDB;
    public StoryStrategyStageSaveDB SaveDataDB;
    public List<long> ScenarioIds;
}

public class ScenarioDeployEchelonResponse : Response<ScenarioDeployEchelonRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_DeployEchelon;
    public StoryStrategyStageSaveDB SaveDataDB;
}

public class ScenarioWithdrawEchelonResponse : Response<ScenarioWithdrawEchelonRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_WithdrawEchelon;
    public StoryStrategyStageSaveDB SaveDataDB;
    public List<EchelonDB> WithdrawEchelonDBs;
}

public class ScenarioMapMoveResponse : Response<ScenarioMapMoveRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_MapMove;
    public StoryStrategyStageSaveDB SaveDataDB;
    public List<long> ScenarioIds;
    public long EchelonEntityId;
    public Strategy StrategyObject;
    public List<ParcelInfo> StrategyObjectParcelInfos;
}

public class ScenarioEndTurnResponse : Response<ScenarioEndTurnRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_EndTurn;
    public StoryStrategyStageSaveDB SaveDataDB;
    public AccountCurrencyDB AccountCurrencyDB;
    public List<long> ScenarioIds;
}

public class ScenarioEnterTacticResponse : Response<ScenarioEnterTacticRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_EnterTactic;
}

public class ScenarioTacticResultResponse : Response<ScenarioTacticResultRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_TacticResult;
    public Strategy StrategyObject;
    public StoryStrategyStageSaveDB SaveDataDB;
    public bool IsPlayerWin;
    public List<long> ScenarioIds;
}

public class ScenarioRetreatResponse : Response<ScenarioRetreatRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_Retreat;
    public List<long> ReleasedEchelonNumbers;
    public ParcelResultDB ParcelResultDB;
}

public class ScenarioPortalResponse : Response<ScenarioPortalRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_Portal;
    public StoryStrategyStageSaveDB StoryStrategyStageSaveDB;
    public List<long> ScenarioIds;
}

public class ScenarioRestartMainStageResponse : Response<ScenarioRestartMainStageRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_RestartMainStage;
    public ParcelResultDB ParcelResultDB;
    public StoryStrategyStageSaveDB SaveDataDB;
}

public class ScenarioSkipMainStageResponse : Response<ScenarioSkipMainStageRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Scenario_SkipMainStage;
}

public class CafeGetInfoResponse : Response<CafeGetInfoRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Cafe_Get;
    public CafeDB CafeDB;
}

public class CafeAckResponse : Response<CafeAckRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Cafe_Ack;
    public CafeDB CafeDB;
}

public class CafeListPresetResponse : Response<CafeListPresetRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Cafe_ListPreset;
    public List<CafePresetDB> CafePresetDBs;
}

public class CafeRenamePresetResponse : Response<CafeRenamePresetRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Cafe_RenamePreset;
}

public class CafeClearPresetResponse : Response<CafeClearPresetRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Cafe_ClearPreset;
}

public class CafeUpdatePresetFurnitureResponse : Response<CafeUpdatePresetFurnitureRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Cafe_UpdatePresetFurniture;
}

public class CafeApplyPresetResponse : Response<CafeApplyPresetRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Cafe_ApplyPreset;
    public CafeDB CafeDB;
}

public class CafeRankUpResponse : Response<CafeRankUpRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Cafe_RankUp;
    public CafeDB CafeDB;
    public ParcelResultDB ParcelResultDB;
    public ConsumeResultDB ConsumeResultDB;
}

public class CafeReceiveCurrencyResponse : Response<CafeReceiveCurrencyRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Cafe_ReceiveCurrency;
    public CafeDB CafeDB;
    public ParcelResultDB ParcelResultDB;
}

public class CafeGiveGiftResponse : Response<CafeGiveGiftRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Cafe_GiveGift;
    public ParcelResultDB ParcelResultDB;
    public ConsumeResultDB ConsumeResultDB;
}

public class CafeSummonCharacterResponse : Response<CafeSummonCharacterRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Cafe_SummonCharacter;
    public CafeDB CafeDB;
}

public class CafeTrophyHistoryResponse : Response<CafeTrophyHistoryRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Cafe_TrophyHistory;
    public List<RaidSeasonRankingHistoryDB> RaidSeasonRankingHistoryDBs;
}

public class CraftSelectNodeResponse : Response<CraftSelectNodeRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Craft_SelectNode;
    public CraftNodeDB SelectedNodeDB;
}

public class CraftUpdateNodeLevelResponse : Response<CraftUpdateNodeLevelRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Craft_UpdateNodeLevel;
    public CraftInfoDB CraftInfoDB;
    public CraftNodeDB CraftNodeDB;
    public AccountCurrencyDB AccountCurrencyDB;
    public ConsumeResultDB ConsumeResultDB;
}

public class CraftBeginProcessResponse : Response<CraftBeginProcessRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Craft_BeginProcess;
    public CraftInfoDB CraftInfoDB;
}

public class CraftCompleteProcessResponse : Response<CraftCompleteProcessRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Craft_CompleteProcess;
    public AccountCurrencyDB AccountCurrencyDB;
    public CraftInfoDB CraftInfoDB;
    public ItemDB TicketItemDB;
}

public class CraftRewardResponse : Response<CraftRewardRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Craft_Reward;
    public ParcelResultDB ParcelResultDB;
    public List<CraftInfoDB> CraftInfos;
}

public class CraftShiftingBeginProcessResponse : Response<CraftShiftingBeginProcessRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Craft_ShiftingBeginProcess;
    public ShiftingCraftInfoDB CraftInfoDB;
    public ParcelResultDB ParcelResultDB;
}

public class CraftShiftingCompleteProcessResponse : Response<CraftShiftingCompleteProcessRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Craft_ShiftingCompleteProcess;
    public ShiftingCraftInfoDB CraftInfoDB;
    public ParcelResultDB ParcelResultDB;
}

public class CraftShiftingRewardResponse : Response<CraftShiftingRewardRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Craft_ShiftingReward;
    public ParcelResultDB ParcelResultDB;
    public List<ShiftingCraftInfoDB> TargetCraftInfos;
}

public class ArenaEnterLobbyResponse : Response<ArenaEnterLobbyRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Arena_EnterLobby;
    public ArenaPlayerInfoDB ArenaPlayerInfoDB;
    public List<ArenaUserDB> OpponentUserDBs;
    public long MapId;
    public DateTime AutoRefreshTime;
}

public class ArenaLoginResponse : Response<ArenaLoginRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Arena_Login;
    public ArenaPlayerInfoDB ArenaPlayerInfoDB;
}

public class ArenaSettingChangeResponse : Response<ArenaSettingChangeRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Arena_SettingChange;
}

public class ArenaOpponentListResponse : Response<ArenaOpponentListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Arena_OpponentList;
    public long PlayerRank;
    public List<ArenaUserDB> OpponentUserDBs;
    public DateTime AutoRefreshTime;
}

public class ArenaEnterBattleResponse : Response<ArenaEnterBattleRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Arena_EnterBattle;
    public AccountCurrencyDB AccountCurrencyDB;
    public ArenaBattleDB ArenaBattleDB;
    public ArenaPlayerInfoDB ArenaPlayerInfoDB;
    public ParcelResultDB VictoryRewards;
    public ParcelResultDB SeasonRewards;
    public ParcelResultDB AllTimeRewards;
}

public class ArenaEnterBattlePart1Response : Response<ArenaEnterBattlePart1Request>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Arena_EnterBattlePart1;
    public ArenaBattleDB ArenaBattleDB;
}

public class ArenaEnterBattlePart2Response : Response<ArenaEnterBattlePart2Request>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Arena_EnterBattlePart2;
    public ArenaBattleDB ArenaBattleDB;
    public ArenaPlayerInfoDB ArenaPlayerInfoDB;
    public AccountCurrencyDB AccountCurrencyDB;
    public ParcelResultDB VictoryRewards;
    public ParcelResultDB SeasonRewards;
    public ParcelResultDB AllTimeRewards;
}

public class ArenaBattleResultResponse : Response<ArenaBattleResultRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Arena_BattleResult;
}

public class ArenaCumulativeTimeRewardResponse : Response<ArenaCumulativeTimeRewardRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Arena_CumulativeTimeReward;
    public long TimeRewardAmount;
    public DateTime TimeRewardLastUpdateTime;
    public ParcelResultDB ParcelResult;
}

public class ArenaDailyRewardResponse : Response<ArenaDailyRewardRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Arena_DailyReward;
    public ParcelResultDB ParcelResult;
    public DateTime DailyRewardActiveTime;
}

public class ArenaRankListResponse : Response<ArenaRankListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Arena_RankList;
    public List<ArenaUserDB> TopRankedUserDBs;
}

public class ArenaHistoryResponse : Response<ArenaHistoryRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Arena_History;
    public List<ArenaHistoryDB> ArenaHistoryDBs;
    public List<ArenaDamageReportDB> ArenaDamageReportDB;
}

public class ArenaCheckSeasonCloseRewardResponse : Response<ArenaCheckSeasonCloseRewardRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Arena_CheckSeasonCloseReward;
}

public class ArenaSyncEchelonSettingTimeResponse : Response<ArenaSyncEchelonSettingTimeRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Arena_SyncEchelonSettingTime;
    public DateTime EchelonSettingTime;
}

public class WeekDungeonListResponse : Response<WeekDungeonListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.WeekDungeon_List;
    public List<long> AdditionalStageIdList;
    public List<WeekDungeonStageHistoryDB> WeekDungeonStageHistoryDBList;
}

public class WeekDungeonEnterBattleResponse : Response<WeekDungeonEnterBattleRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.WeekDungeon_EnterBattle;
    public ParcelResultDB ParcelResultDB;
    public int Seed;
    public int Sequence;
}

public class WeekDungeonBattleResultResponse : Response<WeekDungeonBattleResultRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.WeekDungeon_BattleResult;
    public WeekDungeonStageHistoryDB WeekDungeonStageHistoryDB;
    public List<CharacterDB> LevelUpCharacterDBs;
    public ParcelResultDB ParcelResultDB;
}

public class WeekDungeonRetreatResponse : Response<WeekDungeonRetreatRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.WeekDungeon_Retreat;
    public ParcelResultDB ParcelResultDB;
}

public class AcademyGetInfoResponse : Response<AcademyGetInfoRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Academy_GetInfo;
    public AcademyDB AcademyDB;
    public List<AcademyLocationDB> AcademyLocationDBs;
}

public class AcademyAttendScheduleResponse : Response<AcademyAttendScheduleRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Academy_AttendSchedule;
    public ParcelResultDB ParcelResultDB;
    public AcademyDB AcademyDB;
    public List<ParcelInfo> ExtraRewards;
}

public class EventRewardIncreaseResponse : Response<EventRewardIncreaseRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Event_RewardIncrease;
    public List<EventRewardIncreaseDB> EventRewardIncreaseDBs;
}

public class ContentSaveGetResponse : Response<ContentSaveGetRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.ContentSave_Get;
    public bool HasValidData;
    public ContentSaveDB ContentSaveDB;
    public EventContentChangeDB EventContentChangeDB;
}

public class ContentSaveDiscardResponse : Response<ContentSaveDiscardRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.ContentSave_Discard;
    public ParcelResultDB ParcelResultDB;
}

public class ClanLobbyResponse : Response<ClanLobbyRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_Lobby;
    public IrcServerConfig IrcConfig;
    public ClanDB AccountClanDB;
    public List<ClanDB> DefaultExposedClanDBs;
    public ClanMemberDB AccountClanMemberDB;
    public List<ClanMemberDB> ClanMemberDBs;
}

public class ClanLoginResponse : Response<ClanLoginRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_Login;
    public ClanDB AccountClanDB;
    public ClanMemberDB AccountClanMemberDB;
}

public class ClanSearchResponse : Response<ClanSearchRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_Search;
    public List<ClanDB> ClanDBs;
}

public class ClanCreateResponse : Response<ClanCreateRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_Create;
    public ClanDB ClanDB;
    public ClanMemberDB ClanMemberDB;
    public AccountCurrencyDB AccountCurrencyDB;
}

public class ClanMemberResponse : Response<ClanMemberRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_Member;
    public ClanDB ClanDB;
    public ClanMemberDB ClanMemberDB;
    public ClanMemberDescriptionDB ClanMemberDescriptionDB;
}

public class ClanApplicantResponse : Response<ClanApplicantRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_Applicant;
    public List<ClanMemberDB> ClanMemberDBs;
}

public class ClanJoinResponse : Response<ClanJoinRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_Join;
    public IrcServerConfig IrcConfig;
    public ClanDB ClanDB;
    public ClanMemberDB ClanMemberDB;
}

public class ClanQuitResponse : Response<ClanQuitRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_Quit;
}

public class ClanPermitResponse : Response<ClanPermitRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_Permit;
    public ClanDB ClanDB;
    public ClanMemberDB ClanMemberDB;
}

public class ClanKickResponse : Response<ClanKickRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_Kick;
}

public class ClanSettingResponse : Response<ClanSettingRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_Setting;
    public ClanDB ClanDB;
}

public class ClanConferResponse : Response<ClanConferRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_Confer;
    public ClanMemberDB ClanMemberDB;
    public ClanMemberDB AccountClanMemberDB;
    public ClanDB ClanDB;
    public ClanMemberDescriptionDB ClanMemberDescriptionDB;
}

public class ClanDismissResponse : Response<ClanDismissRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_Dismiss;
}

public class ClanAutoJoinResponse : Response<ClanAutoJoinRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_AutoJoin;
    public IrcServerConfig IrcConfig;
    public ClanDB ClanDB;
    public ClanMemberDB ClanMemberDB;
}

public class ClanMemberListResponse : Response<ClanMemberListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_MemberList;
    public ClanDB ClanDB;
    public List<ClanMemberDB> ClanMemberDBs;
}

public class ClanCancelApplyResponse : Response<ClanCancelApplyRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_CancelApply;
}

public class ClanMyAssistListResponse : Response<ClanMyAssistListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_MyAssistList;
    public List<ClanAssistSlotDB> ClanAssistSlotDBs;
}

public class ClanSetAssistResponse : Response<ClanSetAssistRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_SetAssist;
    public ClanAssistSlotDB ClanAssistSlotDB;
    public ParcelResultDB ParcelResultDB;
    public ClanAssistRewardInfo RewardInfo;
}

public class ClanChatLogResponse : Response<ClanChatLogRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_ChatLog;
    public string ClanChatLog;
}

public class ClanCheckResponse : Response<ClanCheckRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_Check;
}

public class ClanAllAssistListResponse : Response<ClanAllAssistListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Clan_AllAssistList;
    public List<AssistCharacterDB> AssistCharacterDBs;
    public List<ClanAssistRentHistoryDB> AssistCharacterRentHistoryDBs;
    public long ClanDBId;
}

public class BillingTransactionStartByYostarResponse : Response<BillingTransactionStartByYostarRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Billing_TransactionStartByYostar;
    public long PurchaseCount;
    public DateTime PurchaseResetDate;
    public long PurchaseOrderId;
    public string MXSeedKey;
    public PurchaseServerTag PurchaseServerTag;
}

public class BillingTransactionEndByYostarResponse : Response<BillingTransactionEndByYostarRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Billing_TransactionEndByYostar;
    public ParcelResultDB ParcelResult;
    public MailDB MailDB;
    public List<PurchaseCountDB> CountList;
    public int PurchaseCount;
    public List<MonthlyProductPurchaseDB> MonthlyProductList;
}

public class BillingPurchaseListByYostarResponse : Response<BillingPurchaseListByYostarRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Billing_PurchaseListByYostar;
    public List<PurchaseCountDB> CountList;
    public List<PurchaseOrderDB> OrderList;
    public List<MonthlyProductPurchaseDB> MonthlyProductList;
    public List<BlockedProductDB> BlockedProductDBs;
}

public class BillingPurchaseCashShopVerifyByNexonResponse : Response<BillingPurchaseCashShopVerifyByNexonRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Billing_PurchaseCashShopVerifyByNexon;
    public ParcelResultDB ParcelResult;
    public MailDB MailDB;
    public List<PurchaseCountDB> CountList;
    public int PurchaseCount;
    public List<MonthlyProductPurchaseDB> MonthlyProductList;
    public List<long> ProductMonthlyIdInMailList;
    public List<long> GachaTicketItemIdList;
    public string shopId;
    public double itemPrice;
    public string currency;
}

public class BillingPurchaseListByNexonResponse : Response<BillingPurchaseListByNexonRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Billing_PurchaseListByNexon;
    public List<PurchaseCountDB> CountList;
    public List<PurchaseOrderDB> OrderList;
    public List<MonthlyProductPurchaseDB> MonthlyProductList;
    public List<long> ProductMonthlyIdInMailList;
    public List<long> GachaTicketItemIdList;
    public List<BlockedProductDB> BlockedProductDBs;
}

public class EventContentAdventureListResponse : Response<EventContentAdventureListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_AdventureList;
    public List<CampaignStageHistoryDB> StageHistoryDBs;
    public List<StrategyObjectHistoryDB> StrategyObjecthistoryDBs;
    public List<EventContentBonusRewardDB> EventContentBonusRewardDBs;
    public List<long> AlreadyReceiveRewardId;
    public long StagePoint;
}

public class EventContentEnterMainStageResponse : Response<EventContentEnterMainStageRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_EnterMainStage;
    public EventContentMainStageSaveDB SaveDataDB;
    public bool IsOnSubEvent;
}

public class EventContentConfirmMainStageResponse : Response<EventContentConfirmMainStageRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_ConfirmMainStage;
    public ParcelResultDB ParcelResultDB;
    public EventContentMainStageSaveDB SaveDataDB;
    public List<long> ScenarioIds;
}

public class EventContentEnterTacticResponse : Response<EventContentEnterTacticRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_EnterTactic;
}

public class EventContentTacticResultResponse : Response<EventContentTacticResultRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_TacticResult;
    public long TacticRank;
    public CampaignStageHistoryDB CampaignStageHistoryDB;
    public List<CharacterDB> LevelUpCharacterDBs;
    public List<ParcelInfo> FirstClearReward;
    public Strategy StrategyObject;
    public Dictionary<long, List<ParcelInfo>> StrategyObjectRewards;
    public List<ParcelInfo> BonusReward;
    public ParcelResultDB ParcelResultDB;
    public EventContentMainStageSaveDB SaveDataDB;
    public List<long> ScenarioIds;
    public List<EventContentCollectionDB> EventContentCollectionDBs;
}

public class EventContentEnterSubStageResponse : Response<EventContentEnterSubStageRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_EnterSubStage;
    public ParcelResultDB ParcelResultDB;
    public EventContentSubStageSaveDB SaveDataDB;
    public CampaignStageHistoryDB CampaignStageHistoryDB;
}

public class EventContentSubStageResultResponse : Response<EventContentSubStageResultRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_SubStageResult;
    public long TacticRank;
    public CampaignStageHistoryDB CampaignStageHistoryDB;
    public List<CharacterDB> LevelUpCharacterDBs;
    public ParcelResultDB ParcelResultDB;
    public List<ParcelInfo> FirstClearReward;
    public List<ParcelInfo> BonusReward;
    public List<long> ScenarioIds;
    public List<EventContentCollectionDB> EventContentCollectionDBs;
}

public class EventContentDeployEchelonResponse : Response<EventContentDeployEchelonRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_DeployEchelon;
    public EventContentMainStageSaveDB SaveDataDB;
}

public class EventContentWithdrawEchelonResponse : Response<EventContentWithdrawEchelonRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_WithdrawEchelon;
    public EventContentMainStageSaveDB SaveDataDB;
    public List<EchelonDB> WithdrawEchelonDBs;
}

public class EventContentMapMoveResponse : Response<EventContentMapMoveRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_MapMove;
    public EventContentMainStageSaveDB SaveDataDB;
    public List<long> ScenarioIds;
    public long EchelonEntityId;
    public Strategy StrategyObject;
    public List<ParcelInfo> StrategyObjectParcelInfos;
}

public class EventContentEndTurnResponse : Response<EventContentEndTurnRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_EndTurn;
    public EventContentMainStageSaveDB SaveDataDB;
    public AccountCurrencyDB AccountCurrencyDB;
    public List<long> ScenarioIds;
}

public class EventContentRetreatResponse : Response<EventContentRetreatRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_Retreat;
    public List<long> ReleasedEchelonNumbers;
    public ParcelResultDB ParcelResultDB;
}

public class EventContentPortalResponse : Response<EventContentPortalRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_Portal;
    public EventContentMainStageSaveDB SaveDataDB;
    public List<long> ScenarioIds;
}

public class EventContentPurchasePlayCountHardStageResponse : Response<EventContentPurchasePlayCountHardStageRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_PurchasePlayCountHardStage;
    public AccountCurrencyDB AccountCurrencyDB;
    public CampaignStageHistoryDB CampaignStageHistoryDB;
}

public class EventContentShopListResponse : Response<EventContentShopListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_ShopList;
    public List<ShopInfoDB> ShopInfos;
    public List<ShopEligmaHistoryDB> ShopEligmaHistoryDBs;
}

public class EventContentShopRefreshResponse : Response<EventContentShopRefreshRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_ShopRefresh;
    public ParcelResultDB ParcelResultDB;
    public ShopInfoDB ShopInfoDB;
}

public class EventContentReceiveStageTotalRewardResponse : Response<EventContentReceiveStageTotalRewardRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_ReceiveStageTotalReward;
    public long EventContentId;
    public List<long> AlreadyReceiveRewardId;
    public ParcelResultDB ParcelResultDB;
}

public class EventContentEnterMainGroundStageResponse : Response<EventContentEnterMainGroundStageRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_EnterMainGroundStage;
    public ParcelResultDB ParcelResultDB;
    public EventContentMainGroundStageSaveDB SaveDataDB;
    public CampaignStageHistoryDB CampaignStageHistoryDB;
}

public class EventContentMainGroundStageResultResponse : Response<EventContentMainGroundStageResultRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_MainGroundStageResult;
    public long TacticRank;
    public CampaignStageHistoryDB CampaignStageHistoryDB;
    public List<CharacterDB> LevelUpCharacterDBs;
    public ParcelResultDB ParcelResultDB;
    public List<ParcelInfo> FirstClearReward;
    public List<ParcelInfo> BonusReward;
    public List<long> ScenarioIds;
    public List<EventContentCollectionDB> EventContentCollectionDBs;
}

public class EventContentShopBuyMerchandiseResponse : Response<EventContentShopBuyMerchandiseRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_ShopBuyMerchandise;
    public AccountCurrencyDB AccountCurrencyDB;
    public ConsumeResultDB ConsumeResultDB;
    public ParcelResultDB ParcelResultDB;
    public MailDB MailDB;
    public ShopProductDB ShopProductDB;
    public List<EventContentCollectionDB> EventContentCollectionDBs;
}

public class EventContentShopBuyRefreshMerchandiseResponse : Response<EventContentShopBuyRefreshMerchandiseRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_ShopBuyRefreshMerchandise;
    public AccountCurrencyDB AccountCurrencyDB;
    public ConsumeResultDB ConsumeResultDB;
    public ParcelResultDB ParcelResultDB;
    public MailDB MailDB;
    public List<ShopProductDB> ShopProductDB;
    public List<EventContentCollectionDB> EventContentCollectionDBs;
}

public class EventContentSelectBuffResponse : Response<EventContentSelectBuffRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_SelectBuff;
    public EventContentMainStageSaveDB SaveDataDB;
}

public class EventContentBoxGachaShopListResponse : Response<EventContentBoxGachaShopListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_BoxGachaShopList;
    public EventContentBoxGachaDB BoxGachaDB;
    public Dictionary<long, long> BoxGachaGroupIdByCount;
}

public class EventContentBoxGachaShopPurchaseResponse : Response<EventContentBoxGachaShopPurchaseRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_BoxGachaShopPurchase;
    public ParcelResultDB ParcelResultDB;
    public EventContentBoxGachaDB BoxGachaDB;
    public Dictionary<long, long> BoxGachaGroupIdByCount;
    public List<EventContentBoxGachaElement> BoxGachaElements;
}

public class EventContentBoxGachaShopRefreshResponse : Response<EventContentBoxGachaShopRefreshRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_BoxGachaShopRefresh;
    public EventContentBoxGachaDB BoxGachaDB;
    public Dictionary<long, long> BoxGachaGroupIdByCount;
}

public class EventContentCollectionListResponse : Response<EventContentCollectionListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_CollectionList;
    public List<EventContentCollectionDB> EventContentUnlockCGDBs;
}

public class EventContentCollectionForMissionResponse : Response<EventContentCollectionForMissionRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_CollectionForMission;
    public List<EventContentCollectionDB> EventContentCollectionDBs;
}

public class EventContentScenarioGroupHistoryUpdateResponse : Response<EventContentScenarioGroupHistoryUpdateRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_ScenarioGroupHistoryUpdate;
    public List<ScenarioGroupHistoryDB> ScenarioGroupHistoryDBs;
    public List<EventContentCollectionDB> EventContentCollectionDBs;
    public ParcelResultDB ParcelResultDB;
}

public class EventContentCardShopListResponse : Response<EventContentCardShopListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_CardShopList;
    public List<CardShopElementDB> CardShopElementDBs;
    public Dictionary<long, List<ParcelInfo>> RewardHistory;
}

public class EventContentCardShopShuffleResponse : Response<EventContentCardShopShuffleRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_CardShopShuffle;
    public List<CardShopElementDB> CardShopElementDBs;
}

public class EventContentCardShopPurchaseResponse : Response<EventContentCardShopPurchaseRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_CardShopPurchase;
    public ParcelResultDB ParcelResultDB;
    public CardShopElementDB CardShopElementDB;
    public List<CardShopPurchaseHistoryDB> CardShopPurchaseHistoryDBs;
}

public class EventContentRestartMainStageResponse : Response<EventContentRestartMainStageRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_RestartMainStage;
    public ParcelResultDB ParcelResultDB;
    public EventContentMainStageSaveDB SaveDataDB;
}

public class EventContentLocationGetInfoResponse : Response<EventContentLocationGetInfoRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_LocationGetInfo;
    public EventContentLocationDB EventContentLocationDB;
}

public class EventContentLocationAttendScheduleResponse : Response<EventContentLocationAttendScheduleRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_LocationAttendSchedule;
    public EventContentLocationDB EventContentLocationDB;
    public List<EventContentCollectionDB> EventContentCollectionDBs;
    public ParcelResultDB ParcelResultDB;
    public List<ParcelInfo> ExtraRewards;
}

public class EventContentFortuneGachaPurchaseResponse : Response<EventContentFortuneGachaPurchaseRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_FortuneGachaPurchase;
    public ParcelResultDB ParcelResultDB;
    public long FortuneGachaShopUniqueId;
}

public class EventContentSubEventLobbyResponse : Response<EventContentSubEventLobbyRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_SubEventLobby;
    public EventContentChangeDB EventContentChangeDB;
    public bool IsOnSubEvent;
}

public class EventContentEnterStoryStageResponse : Response<EventContentEnterStoryStageRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_EnterStoryStage;
    public ParcelResultDB ParcelResultDB;
    public EventContentStoryStageSaveDB SaveDataDB;
}

public class EventContentStoryStageResultResponse : Response<EventContentStoryStageResultRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_StoryStageResult;
    public CampaignStageHistoryDB CampaignStageHistoryDB;
    public ParcelResultDB ParcelResultDB;
    public List<ParcelInfo> FirstClearReward;
    public List<EventContentCollectionDB> EventContentCollectionDBs;
}

public class EventContentDiceRaceLobbyResponse : Response<EventContentDiceRaceLobbyRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_DiceRaceLobby;
    public EventContentDiceRaceDB DiceRaceDB;
}

public class EventContentDiceRaceRollResponse : Response<EventContentDiceRaceRollRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_DiceRaceRoll;
    public ParcelResultDB ParcelResultDB;
    public EventContentDiceRaceDB DiceRaceDB;
    public List<EventContentDiceResult> DiceResults;
    public List<EventContentCollectionDB> EventContentCollectionDBs;
}

public class EventContentDiceRaceLapRewardResponse : Response<EventContentDiceRaceLapRewardRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_DiceRaceLapReward;
    public EventContentDiceRaceDB DiceRaceDB;
    public ParcelResultDB ParcelResultDB;
}

public class EventContentPermanentListResponse : Response<EventContentPermanentListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.EventContent_PermanentList;
    public List<EventContentPermanentDB> PermanentDBs;
}

public class TTSGetFileResponse : Response<TTSGetFileRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.TTS_GetFile;
    public bool IsFileReady;
    public string TTSFileS3Uri;
}

public class TTSGetKanaResponse : Response<TTSGetKanaRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.TTS_GetKana;
    public string CallName;
    public string ActualCallName;
    public string CallNameKatakana;
}

public class ContentLogUIOpenStatisticsResponse : Response<ContentLogUIOpenStatisticsRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.ContentLog_UIOpenStatistics;
}

public class MomoTalkOutLineResponse : Response<MomoTalkOutLineRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.MomoTalk_OutLine;
    public List<MomoTalkOutLineDB> MomoTalkOutLineDBs;
    public Dictionary<long, List<long>> FavorScheduleRecords;
}

public class MomoTalkMessageListResponse : Response<MomoTalkMessageListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.MomoTalk_MessageList;
    public MomoTalkOutLineDB MomoTalkOutLineDB;
    public List<MomoTalkChoiceDB> MomoTalkChoiceDBs;
}

public class MomoTalkReadResponse : Response<MomoTalkReadRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.MomoTalk_Read;
    public MomoTalkOutLineDB MomoTalkOutLineDB;
    public List<MomoTalkChoiceDB> MomoTalkChoiceDBs;
}

public class MomoTalkFavorScheduleResponse : Response<MomoTalkFavorScheduleRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.MomoTalk_FavorSchedule;
    public ParcelResultDB ParcelResultDB;
    public Dictionary<long, List<long>> FavorScheduleRecords;
}

public class ClearDeckListResponse : Response<ClearDeckListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.ClearDeck_List;
    public List<ClearDeckDB> ClearDeckDBs;
}

public class MiniGameStageListResponse : Response<MiniGameStageListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.MiniGame_StageList;
    public List<MiniGameHistoryDB> MiniGameHistoryDBs;
}

public class MiniGameEnterStageResponse : Response<MiniGameEnterStageRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.MiniGame_EnterStage;
}

public class MiniGameResultResponse : Response<MiniGameResultRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.MiniGame_Result;
}

public class MiniGameMissionListResponse : Response<MiniGameMissionListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.MiniGame_MissionList;
    public List<MissionHistoryDB> HistoryDBs;
    public List<MissionProgressDB> ProgressDBs;
}

public class MiniGameMissionRewardResponse : Response<MiniGameMissionRewardRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.MiniGame_MissionReward;
    public MissionHistoryDB AddedHistoryDB;
    public ParcelResultDB ParcelResultDB;
}

public class MiniGameMissionMultipleRewardResponse : Response<MiniGameMissionMultipleRewardRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.MiniGame_MissionMultipleReward;
    public List<MissionHistoryDB> AddedHistoryDBs;
    public ParcelResultDB ParcelResultDB;
}

public class NotificationLobbyCheckResponse : Response<NotificationLobbyCheckRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Notification_LobbyCheck;
    public long UnreadMailCount;
    public List<EventRewardIncreaseDB> EventRewardIncreaseDBs;
}

public class ProofTokenRequestQuestionResponse : Response<ProofTokenRequestQuestionRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.ProofToken_RequestQuestion;
    public long Hint;
    public string Question;
}

public class ProofTokenSubmitResponse : Response<ProofTokenSubmitRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.ProofToken_Submit;
}

public class SchoolDungeonListResponse : Response<SchoolDungeonListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.SchoolDungeon_List;
    public List<SchoolDungeonStageHistoryDB> SchoolDungeonStageHistoryDBList;
}

public class SchoolDungeonEnterBattleResponse : Response<SchoolDungeonEnterBattleRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.SchoolDungeon_EnterBattle;
    public ParcelResultDB ParcelResultDB;
}

public class SchoolDungeonBattleResultResponse : Response<SchoolDungeonBattleResultRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.SchoolDungeon_BattleResult;
    public SchoolDungeonStageHistoryDB SchoolDungeonStageHistoryDB;
    public List<CharacterDB> LevelUpCharacterDBs;
    public List<ParcelInfo> FirstClearReward;
    public List<ParcelInfo> ThreeStarReward;
    public ParcelResultDB ParcelResultDB;
}

public class SchoolDungeonRetreatResponse : Response<SchoolDungeonRetreatRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.SchoolDungeon_Retreat;
    public ParcelResultDB ParcelResultDB;
}

public class TimeAttackDungeonLobbyResponse : Response<TimeAttackDungeonLobbyRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.TimeAttackDungeon_Lobby;
    public Dictionary<long, TimeAttackDungeonRoomDB> RoomDBs;
    public TimeAttackDungeonRoomDB PreviousRoomDB;
    public ParcelResultDB ParcelResultDB;
    public bool AchieveSeasonBestRecord;
    public long SeasonBestRecord;
}

public class TimeAttackDungeonCreateBattleResponse : Response<TimeAttackDungeonCreateBattleRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.TimeAttackDungeon_CreateBattle;
    public TimeAttackDungeonRoomDB RoomDB;
    public ParcelResultDB ParcelResultDB;
}

public class TimeAttackDungeonEnterBattleResponse : Response<TimeAttackDungeonEnterBattleRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.TimeAttackDungeon_EnterBattle;
    public AssistCharacterDB AssistCharacterDB;
}

public class TimeAttackDungeonEndBattleResponse : Response<TimeAttackDungeonEndBattleRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.TimeAttackDungeon_EndBattle;
    public TimeAttackDungeonRoomDB RoomDB;
    public long TotalPoint;
    public long DefaultPoint;
    public long TimePoint;
    public ParcelResultDB ParcelResultDB;
}

public class TimeAttackDungeonSweepResponse : Response<TimeAttackDungeonSweepRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.TimeAttackDungeon_Sweep;
    public List<List<ParcelInfo>> Rewards;
    public ParcelResultDB ParcelResultDB;
    public TimeAttackDungeonRoomDB RoomDB;
}

public class TimeAttackDungeonGiveUpResponse : Response<TimeAttackDungeonGiveUpRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.TimeAttackDungeon_GiveUp;
    public TimeAttackDungeonRoomDB RoomDB;
    public ParcelResultDB ParcelResultDB;
    public bool AchieveSeasonBestRecord;
    public long SeasonBestRecord;
}

public class TimeAttackDungeonLoginResponse : Response<TimeAttackDungeonLoginRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.TimeAttackDungeon_Login;
    public TimeAttackDungeonRoomDB PreviousRoomDB;
}

public class WorldRaidLobbyResponse : Response<WorldRaidLobbyRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.WorldRaid_Lobby;
    public List<WorldRaidClearHistoryDB> ClearHistoryDBs;
    public List<WorldRaidLocalBossDB> LocalBossDBs;
    public List<WorldRaidBossGroup> BossGroups;
}

public class WorldRaidBossListResponse : Response<WorldRaidBossListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.WorldRaid_BossList;
    public List<WorldRaidBossListInfoDB> BossListInfoDBs;
}

public class WorldRaidEnterBattleResponse : Response<WorldRaidEnterBattleRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.WorldRaid_EnterBattle;
    public RaidBattleDB RaidBattleDB;
    public List<AssistCharacterDB> AssistCharacterDBs;
}

public class WorldRaidBattleResultResponse : Response<WorldRaidBattleResultRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.WorldRaid_BattleResult;
    public ParcelResultDB ParcelResultDB;
}

public class WorldRaidReceiveRewardResponse : Response<WorldRaidReceiveRewardRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.WorldRaid_ReceiveReward;
    public ParcelResultDB ParcelResultDB;
}

public class ResetableContentGetResponse : Response<ResetableContentGetRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.ResetableContent_Get;
    public List<ResetableContentValueDB> ResetableContentValueDBs;
}

public class ConquestGetInfoResponse : Response<ConquestGetInfoRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Conquest_GetInfo;
    public ConquestInfoDB ConquestInfoDB;
    public List<ConquestTileDB> ConquestedTileDBs;
    public TypedJsonWrapper<List<ConquestEventObjectDB>> ConquestObjectDBsWrapper;
    public List<ConquestEchelonDB> ConquestEchelonDBs;
    public Dictionary<StageDifficulty, int> DifficultyToStepDict;
    public ParcelResultDB InitializeParcelResultDB;
}

public class ConquestConquerResponse : Response<ConquestConquerRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Conquest_Conquer;
    public ParcelResultDB ParcelResultDB;
    public ConquestTileDB ConquestTileDB;
    public ConquestInfoDB ConquestInfoDB;
    public TypedJsonWrapper<List<ConquestEventObjectDB>> ConquestEventObjectDBWrapper;
    public List<ConquestDisplayInfo> DisplayInfos;
}

public class ConquestConquerWithBattleStartResponse : Response<ConquestConquerWithBattleStartRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Conquest_ConquerWithBattleStart;
    public ParcelResultDB ParcelResultDB;
    public ConquestStageSaveDB ConquestStageSaveDB;
}

public class ConquestConquerWithBattleResultResponse : Response<ConquestConquerWithBattleResultRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Conquest_ConquerWithBattleResult;
    public ParcelResultDB ParcelResultDB;
    public ConquestTileDB ConquestTileDB;
    public ConquestInfoDB ConquestInfoDB;
    public TypedJsonWrapper<List<ConquestEventObjectDB>> ConquestEventObjectDBWrapper;
    public List<ConquestDisplayInfo> DisplayInfos;
    public int StepAfterBattle;
}

public class ConquestManageBaseResponse : Response<ConquestManageBaseRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Conquest_ManageBase;
    public List<List<ParcelInfo>> ClearParcels;
    public List<List<ParcelInfo>> ConquerBonusParcels;
    public List<ParcelInfo> BonusParcels;
    public ParcelResultDB ParcelResultDB;
    public ConquestInfoDB ConquestInfoDB;
    public TypedJsonWrapper<List<ConquestEventObjectDB>> ConquestEventObjectDBWrapper;
    public List<ConquestDisplayInfo> DisplayInfos;
}

public class ConquestUpgradeBaseResponse : Response<ConquestUpgradeBaseRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Conquest_UpgradeBase;
    public List<ParcelInfo> UpgradeRewards;
    public ParcelResultDB ParcelResultDB;
    public ConquestTileDB ConquestTileDB;
    public ConquestInfoDB ConquestInfoDB;
    public TypedJsonWrapper<List<ConquestEventObjectDB>> ConquestEventObjectDBWrapper;
    public List<ConquestDisplayInfo> DisplayInfos;
}

public class ConquestTakeEventObjectResponse : Response<ConquestTakeEventObjectRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Conquest_TakeEventObject;
    public ParcelResultDB ParcelResultDB;
    public TypedJsonWrapper<ConquestEventObjectDB> ConquestEventObjectDBWrapper;
}

public class ConquestEventObjectBattleStartResponse : Response<ConquestEventObjectBattleStartRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Conquest_EventObjectBattleStart;
    public ParcelResultDB ParcelResultDB;
    public ConquestStageSaveDB ConquestStageSaveDB;
}

public class ConquestEventObjectBattleResultResponse : Response<ConquestEventObjectBattleResultRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Conquest_EventObjectBattleResult;
    public ParcelResultDB ParcelResultDB;
    public TypedJsonWrapper<ConquestEventObjectDB> ConquestEventObjectDBWrapper;
    public ConquestInfoDB ConquestInfoDB;
    public ConquestTileDB ConquestTileDB;
    public List<ConquestDisplayInfo> DisplayInfos;
}

public class ConquestNormalizeEchelonResponse : Response<ConquestNormalizeEchelonRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Conquest_NormalizeEchelon;
    public ConquestEchelonDB ConquestEchelonDB;
}

public class ConquestCheckResponse : Response<ConquestCheckRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Conquest_Check;
    public bool CanReceiveCalculateReward;
}

public class FriendListResponse : Response<FriendListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Friend_List;
    public FriendIdCardDB FriendIdCardDB;
    public IdCardBackgroundDB[] IdCardBackgroundDBs;
    public FriendDB[] FriendDBs;
    public FriendDB[] SentRequestFriendDBs;
    public FriendDB[] ReceivedRequestFriendDBs;
}

public class FriendRemoveResponse : Response<FriendRemoveRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Friend_Remove;
    public FriendDB[] FriendDBs;
    public FriendDB[] SentRequestFriendDBs;
    public FriendDB[] ReceivedRequestFriendDBs;
}

public class FriendGetFriendDetailedInfoResponse : Response<FriendGetFriendDetailedInfoRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Friend_GetFriendDetailedInfo;
    public string Nickname;
    public long Level;
    public string ClanName;
    public string Comment;
    public long FriendCount;
    public string FriendCode;
    public long RepresentCharacterUniqueId;
    public long CharacterCount;
    public Int64? LastNormalCampaignClearStageId;
    public Int64? LastHardCampaignClearStageId;
    public Int64? ArenaRanking;
    public Int64? RaidRanking;
    public Int32? RaidTier;
    public AssistCharacterDB[] AssistCharacterDBs;
}

public class FriendGetIdCardResponse : Response<FriendGetIdCardRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Friend_GetIdCard;
    public FriendIdCardDB FriendIdCardDB;
}

public class FriendSetIdCardResponse : Response<FriendSetIdCardRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Friend_SetIdCard;
}

public class FriendSearchResponse : Response<FriendSearchRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Friend_Search;
    public FriendDB[] SearchResult;
}

public class FriendSendFriendRequestResponse : Response<FriendSendFriendRequestRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Friend_SendFriendRequest;
    public FriendDB[] FriendDBs;
    public FriendDB[] SentRequestFriendDBs;
    public FriendDB[] ReceivedRequestFriendDBs;
}

public class FriendAcceptFriendRequestResponse : Response<FriendAcceptFriendRequestRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Friend_AcceptFriendRequest;
    public FriendDB[] FriendDBs;
    public FriendDB[] SentRequestFriendDBs;
    public FriendDB[] ReceivedRequestFriendDBs;
}

public class FriendDeclineFriendRequestResponse : Response<FriendDeclineFriendRequestRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Friend_DeclineFriendRequest;
    public FriendDB[] FriendDBs;
    public FriendDB[] SentRequestFriendDBs;
    public FriendDB[] ReceivedRequestFriendDBs;
}

public class FriendCancelFriendRequestResponse : Response<FriendCancelFriendRequestRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Friend_CancelFriendRequest;
    public FriendDB[] FriendDBs;
    public FriendDB[] SentRequestFriendDBs;
    public FriendDB[] ReceivedRequestFriendDBs;
}

public class FriendCheckResponse : Response<FriendCheckRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Friend_Check;
}

public class CharacterGearListResponse : Response<CharacterGearListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.CharacterGear_List;
    public List<GearDB> GearDBs;
}

public class CharacterGearUnlockResponse : Response<CharacterGearUnlockRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.CharacterGear_Unlock;
    public GearDB GearDB;
    public CharacterDB CharacterDB;
}

public class CharacterGearTierUpResponse : Response<CharacterGearTierUpRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.CharacterGear_TierUp;
    public GearDB GearDB;
    public ParcelResultDB ParcelResultDB;
    public ConsumeResultDB ConsumeResultDB;
}

public class QueuingGetTicketResponse : Response<QueuingGetTicketRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Queuing_GetTicket;
    public string WaitingTicket;
    public string EnterTicket;
    public long TicketSequence;
    public long AllowedSequence;
    public double RequiredSecondsPerUser;
    public string Birth;
    public string ServerSeed;
}

public class ManagementBannerListResponse : Response<ManagementBannerListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Management_BannerList;
    public List<BannerDB> BannerDBs;
}

public class ManagementContentsLockListResponse : Response<ManagementContentsLockListRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Management_ContentsLockList;
    public List<ContentsLockDB> ContentsLockDBs;
}

public class CommonCheatResponse : Response<CommonCheatRequest>
{
    public override Protocol Protocol =>  BlueArchiveAPI.NetworkModels.Protocol.Common_Cheat;
    public AccountDB Account;
    public AccountCurrencyDB AccountCurrency;
    public List<CharacterDB> CharacterDBs;
    public List<EquipmentDB> EquipmentDBs;
    public List<WeaponDB> WeaponDBs;
    public List<ItemDB> ItemDBs;
    public List<ScenarioHistoryDB> ScenarioHistoryDBs;
    public List<ScenarioGroupHistoryDB> ScenarioGroupHistoryDBs;
    public CheatFlags CheatFlags;
}

