using Microsoft.AspNetCore.Mvc;

namespace RestApiDesign.Controllers
{
    [ApiController]
    [Route("[controller]/actions")]
    public class Level1Controller : ControllerBase
    {
        [HttpPost]
        public Level1GetResponse GetData([FromBody] Level1GetRequest request)
        {
            //get data
            var id = request.Id;
            return new Level1GetResponse()
            {
                Success = true,
                Data = new object()
            };
        }

        [HttpPost]
        public Level1SetResponse SetData([FromBody] Level1SetRequest request)
        {
            //set data
            var data = request.Data;
            
            return new Level1SetResponse()
            {
                Success = true
            };
        }
    }
}
