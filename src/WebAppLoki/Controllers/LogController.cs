using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppLoki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private readonly ILogger<LogController> _logger;

        public LogController(ILogger<LogController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Debug")]
        public string Debug()
        {
            _logger.LogDebug($"{DateTime.UtcNow:yyyy-MM-dd}");
            return "Debug log";
        }

        [HttpGet("Info")]
        public string Info()
        {
            _logger.LogInformation($"{DateTime.UtcNow:yyyy-MM-dd}");
            return "Information log";
        }

        [HttpGet("Warn")]
        public string Warn()
        {
            _logger.LogWarning($"{DateTime.UtcNow:yyyy-MM-dd}");
            return "Warning log";
        }

        [HttpGet("Error")]
        public string Error()
        {
            _logger.LogError($"{DateTime.UtcNow:yyyy-MM-dd}");
            return "Error log";
        }

        [HttpGet("Critical")]
        public string Critical()
        {
            _logger.LogCritical($"{DateTime.UtcNow:yyyy-MM-dd}");
            return "Critical log";
        }
    }
}
