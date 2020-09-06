using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace RestApiDesign.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// Demo API for the REST API Course
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new[] {"value1", "value2"};
        }
    }
}
