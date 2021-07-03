using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace RestApiDesign.Controllers
{
    [ApiController]
    [Route("[controller]/actions")]
    public class Level3Controller : ControllerBase
    {
        [HttpGet("id")]
        public ActionResult<Level3GetResponse> Get(int id)
        {
            //get data with id
            var data = "from db";

            return Ok(new Level3GetResponse()
            {
                Data = data,
                LinkList = new List<HateoasLink>()
                {
                    GetHateoasLinkForDelete(id),
                    GetHateoasLinkForPost()
                }
            });
        }

        [HttpPost]
        public ActionResult<Level3SetResponse> Set([FromBody] Level3SetRequest request)
        {
            //insert data and get id
            var fromDbId = 1;

            return Ok(new Level3SetResponse()
            {
                LinkList = new List<HateoasLink>()
                {
                    GetHateoasLinkForGet(fromDbId),
                    GetHateoasLinkForDelete(fromDbId)
                }
            });
        }

        [HttpGet("id")]
        public ActionResult<Level3DeleteResponse> Delete(int id)
        {
            //delete data form db

            return Ok(new Level3DeleteResponse()
            {
                LinkList = new List<HateoasLink>()
                {
                    GetHateoasLinkForGet(id),
                    GetHateoasLinkForPost()
                }
            });
        }

        private HateoasLink GetHateoasLinkForGet(int id)
        {
            return new HateoasLink()
            {
                Uri = "http://localhost:5000/Level3/" + id,
                Method = "Get"
            };
        }
        private HateoasLink GetHateoasLinkForDelete(int id)
        {
            return new HateoasLink()
            {
                Uri = "http://localhost:5000/Level3/" + id,
                Method = "Delete"
            };
        }
        private HateoasLink GetHateoasLinkForPost()
        {
            return new HateoasLink()
            {
                Uri = "http://localhost:5000/Level3",
                Method = "Post"
            };
        }
    }
}
