using BlueArchiveAPI;
using BlueArchiveAPI.Controllers;
using BlueArchiveAPI.Models;
using BlueArchiveAPI.NetworkModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

var js = JToken.Parse(File.ReadAllText("temp1.json"));

var d = js.ToObject<AccountLoginSyncResponse>();

var setting = new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore};

File.WriteAllText("temp2.json", JsonConvert.SerializeObject(d, Formatting.Indented, setting));

// Add services to the container.

builder.Services.AddResponseCompression(options =>
{
    options.EnableForHttps = true;
});


builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseResponseCompression();
app.MapControllers();

// app.UseMiddleware<BodyMiddleware>();

app.Run();
