using BlueArchiveAPI.Models;
using BlueArchiveAPI.NetworkModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

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
            var proto = ResolveProtocolOrRaise($"{path1}/{path2}", protocol);
            var reqData = Utils.DecryptRequestPacket(packet);

            _logger.LogInformation($"gateway: {proto}");
            _logger.LogInformation($"{reqData}");

            var form = new MultipartFormDataContent();
            form.Add(new StringContent(Utils.GetProtocolHash(proto), Encoding.UTF8, "text/plain"), "protocol");
            form.Add(new StringContent(encode.ToString(), Encoding.UTF8, "text/plain"), "encode");
            form.Add(new StringContent(Utils.EncryptRequestPacket(reqData), Encoding.UTF8, "text/plain"), "packet");

            var resp = await _client.PostAsync($"https://nxm-tw-bagl.nexon.com:5100/api/{path1}/{path2}", form);
            var content = await resp.Content.ReadAsByteArrayAsync();
            var respData = Utils.DecryptResponsePacket(content, out proto);
            
            _logger.LogInformation($"{respData}");

            return File(Utils.EncryptResponsePacket(respData, proto), "application/json; charset=utf-8");
        }
        
        [HttpPost("api/{path1}/{path2}")]
        public async Task<ActionResult> GameApi(string path1, string path2,
            [FromForm] string protocol, [FromForm] bool encode, [FromForm] string packet)
        {
            var proto = ResolveProtocolOrRaise($"{path1}/{path2}", protocol);
            var reqData = Utils.DecryptRequestPacket(packet);

            _logger.LogInformation($"api: {proto}");
            _logger.LogInformation($"{reqData}");

            var form = new MultipartFormDataContent();
            form.Add(new StringContent(Utils.GetProtocolHash(proto), Encoding.UTF8, "text/plain"), "protocol");
            form.Add(new StringContent(encode.ToString(), Encoding.UTF8, "text/plain"), "encode");
            form.Add(new StringContent(Utils.EncryptRequestPacket(reqData), Encoding.UTF8, "text/plain"), "packet");

            var resp = await _client.PostAsync($"https://nxm-tw-bagl.nexon.com:5000/api/{path1}/{path2}", form);
            var content = await resp.Content.ReadAsByteArrayAsync();
            var respData = Utils.DecryptResponsePacket(content, out proto);

            _logger.LogInformation($"{respData}");
            
            if (proto == Protocol.Account_LoginSync)
            {
                var respObj = respData.ToObject<AccountLoginSyncResponse>();

                
                foreach (var character in respObj.CharacterListResponse.CharacterDBs)
                {
                    character.ExSkillLevel = 100;
                    character.ExtraPassiveSkillLevel = 100;
                    character.LeaderSkillLevel = 100;
                    character.PublicSkillLevel = 100;
                    character.ExtraPassiveSkillLevel = 100;
                    character.Level = 100;
                }

                respData = JToken.FromObject(respObj);
            }
            
            return File(Utils.EncryptResponsePacket(respData, proto), "application/json; charset=utf-8");
        }
    }
}