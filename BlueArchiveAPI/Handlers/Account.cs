using BlueArchiveAPI.NetworkModels;
using Newtonsoft.Json;

namespace BlueArchiveAPI.Handlers
{
    public static class Account
    {
        public class CheckNexon : BaseHandler<AccountCheckNexonRequest, AccountCheckNexonResponse>
        {
            protected override async Task<AccountCheckNexonResponse> Handle(AccountCheckNexonRequest request)
            {
                var account = 14524177;

                var session = new SessionKey
                {
                    AccountServerId = account,
                    MxToken = string.Empty
                };

                return new AccountCheckNexonResponse
                {
                    ResultState = 1,
                    AccountId = account,
                    SessionKey = session
                };
            }
        }
        public class LoginSync : BaseHandler<AccountLoginSyncRequest, AccountLoginSyncResponse>
        {
            protected override async Task<AccountLoginSyncResponse> Handle(AccountLoginSyncRequest request)
            {
                var result = Utils.GetDataFromFile<AccountLoginSyncResponse>("Data/account.loginsync", false);

                result.AccountCurrencySyncResponse.AccountCurrencyDB.CurrencyDict[CurrencyTypes.Gem] = 99999999;
                result.AccountCurrencySyncResponse.AccountCurrencyDB.CurrencyDict[CurrencyTypes.GemBonus] = 99999999;

                return result;
            }
        }

        public class GetTutorial : BaseHandler<AccountGetTutorialRequest, AccountGetTutorialResponse>
        {
            protected override async Task<AccountGetTutorialResponse> Handle(AccountGetTutorialRequest request)
            {
                return new AccountGetTutorialResponse
                {
                    TutorialIds = new List<long> { 1, 2, 3, 4, 5 }
                };
            }
        }

        public class SetTutorial : BaseHandler<AccountSetTutorialRequest, AccountSetTutorialResponse>
        {
            protected override async Task<AccountSetTutorialResponse> Handle(AccountSetTutorialRequest request)
            {
                return new AccountSetTutorialResponse();
            }
        }

        public class Auth : BaseHandler<AccountAuthRequest, AccountAuthResponse>
        {
            protected override async Task<AccountAuthResponse> Handle(AccountAuthRequest request)
            {
                return new AccountAuthResponse
                {
                    AccountDB = new AccountDB
                    {
                        ServerId = request.SessionKey.AccountServerId,
                        Nickname = "佑树",
                        CallNameKatakana = string.Empty,
                        State = AccountState.Normal,
                        Level = 100,
                        RepresentCharacterServerId = 89919579,
                        PublisherAccountId = request.SessionKey.AccountServerId,
                    },
                    AttendanceBookRewards = new List<AttendanceBookReward>(),
                    RepurchasableMonthlyProductCountDBs = new List<PurchaseCountDB>(),
                    MonthlyProductParcel = new List<ParcelInfo>(),
                    MonthlyProductMail = new List<ParcelInfo>(),
                    BiweeklyProductParcel = new List<ParcelInfo>(),
                    BiweeklyProductMail = new List<ParcelInfo>(),
                    WeeklyProductMail = new List<ParcelInfo>(),
                    EncryptedUID = "M24ZF7PO3WZ2L7Q23SYITYAZMU",
                    MissionProgressDBs = new List<MissionProgressDB>()
                };
            }
        }
    }
}
