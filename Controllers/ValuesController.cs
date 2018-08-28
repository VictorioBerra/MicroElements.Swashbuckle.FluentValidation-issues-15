using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GitHubIssue.Models;
using Microsoft.Extensions.Logging;

namespace GitHubIssue.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public ActionResult<int> Get(List<TestViewModel> vms)
        {
            _logger.LogDebug(string.Join(',', vms.Select(x => x.Id)));

            return 42;
        }
    }
}
