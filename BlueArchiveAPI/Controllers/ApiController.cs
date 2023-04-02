using BlueArchiveAPI.Handlers;
using BlueArchiveAPI.Models;
using BlueArchiveAPI.NetworkModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Xml;

namespace BlueArchiveAPI.Controllers
{
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly ILogger<ApiController> _logger;
        private const string API_URL = "https://nxm-tw-bagl.nexon.com:5000/api";
        private const string GATEWAY_URL = "https://nxm-tw-bagl.nexon.com:5100/api";

        private static readonly HttpClient _client = new HttpClient();

        static ApiController()
        {
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.TryAddWithoutValidation("TE", "identity");
            _client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Encoding", "gzip");
            _client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "BestHTTP/2 v2.4.0");
        }

        public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
        }

        private static Protocol ResolveProtocolOrRaise(string path, string hash)
        {
            var proto1 = Utils.ParseProtocolPath(path);
            var proto2 = Utils.ParseProtocolHash(hash);
            if (proto1 != proto2)
            {
                throw new Exception($"Protocol mismatch: {proto1} != {proto2}");
            }
            return proto1;
        }
        
        [HttpPost("gateway/{path1}/{path2}")]
        public async Task<ActionResult> GatewayApi(string path1, string path2,
            [FromForm] string protocol, [FromForm] bool encode, [FromForm] string packet)
        {
            _logger.LogInformation($"gateway: {protocol}@{path1}/{path2}");

            var proto = ResolveProtocolOrRaise($"{path1}/{path2}", protocol);

            var handler = HandlerManager.GetHandler(proto);
            /*
            var form = new MultipartFormDataContent();
            form.Add(new StringContent(Utils.GetProtocolHash(proto), Encoding.UTF8, "text/plain"), "protocol");
            form.Add(new StringContent(encode.ToString(), Encoding.UTF8, "text/plain"), "encode");
            form.Add(new StringContent(Utils.EncryptRequestPacket(reqData), Encoding.UTF8, "text/plain"), "packet");

            var resp = await _client.PostAsync($"https://nxm-tw-bagl.nexon.com:5100/api/{path1}/{path2}", form);
            var content = await resp.Content.ReadAsByteArrayAsync();
            var respData = Utils.DecryptResponsePacket(content, out proto);
            _logger.LogInformation($"{respData}");
            
            */
            return File(await handler.Handle(packet), "application/json; charset=utf-8");
        }
        
        [HttpPost("api/{path1}/{path2}")]
        public async Task<ActionResult> GameApi(string path1, string path2,
            [FromForm] string protocol, [FromForm] bool encode, [FromForm] string packet)
        {
            _logger.LogInformation($"api: {protocol}@{path1}/{path2}");
            
            var proto = ResolveProtocolOrRaise($"{path1}/{path2}", protocol);

            var handler = HandlerManager.GetHandler(proto);

            if (handler == null)
            {
                _logger.LogWarning($"api: {protocol}@{path1}/{path2} not implemented!");
                return NotFound();
            }

            /*
            var reqObj = reqData.ToObject(ProtoDefine.requestType[proto]);

            if (proto == Protocol.Account_LoginSync)
            {
            }

            reqData = JToken.FromObject(reqObj);

            _logger.LogInformation($"{reqData}");
            
            var form = new MultipartFormDataContent();
            form.Add(new StringContent(Utils.GetProtocolHash(proto), Encoding.UTF8, "text/plain"), "protocol");
            form.Add(new StringContent(encode.ToString(), Encoding.UTF8, "text/plain"), "encode");
            form.Add(new StringContent(Utils.EncryptRequestPacket(reqData), Encoding.UTF8, "text/plain"), "packet");

            object respData;

            if (proto == Protocol.Shop_BuyGacha3 || proto == Protocol.Shop_BuyGacha2 || proto == Protocol.Shop_BuyGacha)
            {
                var respObj = new ShopBuyGacha3Response
                {
                    GemBonusRemain = 114514,
                    ConsumedItems = new List<ItemDB>(),
                    GachaResults = new List<GachaResult>(),
                    AcquiredItems = new List<ItemDB>(),
                    ServerTimeTicks = DateTime.Now.Ticks,
                    MissionProgressDBs = new List<MissionProgressDB>()
                };

                for (int i = 0; i < 10; ++i)
                {
                    var c = 20002 + i;
                    respObj.GachaResults.Add(new GachaResult
                    {
                        CharacterId = c,
                        Character = new CharacterDB
                        {
                            Type = ParcelType.Character,
                            ServerId = 89988413 + i,
                            UniqueId = c,
                            StarGrade = 3,
                            Level = 1,
                            FavorRank = 1,
                            PublicSkillLevel = 1,
                            ExSkillLevel = 1,
                            PassiveSkillLevel = 1,
                            ExtraPassiveSkillLevel = 1,
                            LeaderSkillLevel = 1,
                            IsNew = true,
                            IsLocked = true
                        }
                    }); ;
                }

                respData = respObj;
            }
            else
            {
                var resp = await _client.PostAsync($"https://nxm-tw-bagl.nexon.com:5000/api/{path1}/{path2}", form);
                var content = await resp.Content.ReadAsByteArrayAsync();
                var respData2 = Utils.DecryptResponsePacket(content, out proto);

                _logger.LogInformation($"{respData2}");

                var respObj = respData2.ToObject(ProtoDefine.responseType[proto]);

                if (proto == Protocol.Account_LoginSync)
                {
                    var resp2 = respObj as AccountLoginSyncResponse;
                    foreach (var character in resp2.CharacterListResponse.CharacterDBs)
                    {
                        character.ExSkillLevel = 100;
                        character.ExtraPassiveSkillLevel = 100;
                        character.LeaderSkillLevel = 100;
                        character.PublicSkillLevel = 100;
                        character.ExtraPassiveSkillLevel = 100;
                        character.Level = 100;
                    }

                }

                respData = respObj;
            }
            
            _logger.LogInformation($"{JsonConvert.SerializeObject(respData, Newtonsoft.Json.Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore})}");
            */

            return File(await handler.Handle(packet), "application/json; charset=utf-8");
        }
    }
}