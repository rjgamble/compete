using System.Collections.Generic;
using Compete.Common.Entities.Library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Compete.Library.Api.Controllers
{
    [Route("api/[controller]")]
    public class TitlesController : BaseController
    {
        public TitlesController(ILogger logger) : base(logger)
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new List<Title>());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(new Title());
        }

        [HttpPost]
        public IActionResult Post([FromBody]Title title)
        {
            return Created(Url.RouteUrl(title), new Title());
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Title title)
        {
            return Ok(new Title());
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
