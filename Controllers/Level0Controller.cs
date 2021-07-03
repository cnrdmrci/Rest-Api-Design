using Microsoft.AspNetCore.Mvc;

namespace RestApiDesign.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Level0Controller : ControllerBase
    {
        // so bad code, only for example level zero
        [HttpPost]
        public Level0Response Service([FromBody] Level0Request request)
        {
            if(request.GetData)
            {
                return new Level0Response()
                {
                    Success = true,
                    Data = new object() // get data
                };
            }
            else if(request.SetData)
            {
                var data = request.Data;
                // insert
                return new Level0Response()
                {
                    Success = true
                };
            }
            else
            {
                return new Level0Response()
                {
                    Success = false
                };
            }
        }
    }
}