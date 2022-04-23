using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using S1.Domain;
using S1.Helper.Web.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace S1.Helper.Web.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MacrosController : ControllerBase
    {
        private readonly ILogger<MacrosController> _logger;
        private readonly IConfiguration configuration;

        public MacrosController(ILogger<MacrosController> logger, IConfiguration configuration)
        {
            _logger = logger;
            this.configuration = configuration;
        }

        [HttpGet]
        public IEnumerable<Macro> Get()
        {
            var usermacros = Macro.GetS1Macros(configuration.GetConnectionString("StudioOneUserData"));

            return usermacros;
        }
    }
}
