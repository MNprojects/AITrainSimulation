using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace aitrainsimulation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SimulatorController : ControllerBase
    {

        private readonly ILogger<SimulatorController> _logger;

        public SimulatorController(ILogger<SimulatorController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public string Post()
        {
            return "test";
        }
    }
}
