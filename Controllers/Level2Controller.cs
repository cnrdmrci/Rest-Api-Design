using Microsoft.AspNetCore.Mvc;

namespace RestApiDesign.Controllers
{
    [ApiController]
    [Route("[controller]/actions")]
    public class Level2Controller : ControllerBase
    {
        [HttpGet("id")]
        public ActionResult<Level2GetResponse> Get(int id)
        {
            //get data

            return Ok(new Level2GetResponse(){Data = new object()});
        }

        [HttpPost]
        public ActionResult Set([FromBody] Level2SetRequest request)
        {
            //set data
            var data = request.Data;

            return Ok();
        }
    }
}
