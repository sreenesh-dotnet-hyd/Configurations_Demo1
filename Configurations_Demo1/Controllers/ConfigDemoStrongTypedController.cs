using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Configurations_Demo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigDemoStrongTypedController : ControllerBase
    {
        private readonly AppSettings _settings;

        public ConfigDemoStrongTypedController(IOptions<AppSettings> settings)
        {
            _settings = settings.Value;
        }


        [HttpGet]
        public IActionResult Get()
        {
            string appName = _settings.AppName;
            string appVersion = _settings.AppVersion;

            return Ok(new {appName, appVersion});
        }
    }
}
