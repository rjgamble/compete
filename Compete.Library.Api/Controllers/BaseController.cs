using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Compete.Library.Api.Controllers
{
    public class BaseController : Controller
    {
        protected readonly ILogger _logger;

        public BaseController(ILogger logger)
        {
            _logger = logger;
        }
    }
}