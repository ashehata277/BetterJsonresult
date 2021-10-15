using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Json.Controllers
{
    [ApiController]
    public class Test : Controller
    {
        public Test()
        {

        }
        [HttpGet]
        [Route("api/Test")]
        public IActionResult TestApi()
        {

            return new BetterJsonResult<string>
            {
                
            }.ExcuteResultOk();
        }


        [HttpGet]
        [Route("api/Test2")]
        public IActionResult TestApi2()
        {

            return new BetterJsonResult<List<string>>
            {
                Data = new List<string>() 
                {
                    "Ahmed",
                    "Mohamed"
                }

            }.ExcuteResult(200);
        }

         [HttpGet]
        [Route("api/Test3")]
        public IActionResult TestApi3()
        {

            return new BetterJsonResult
            {
                Data = new List<string>() 
                {
                    "Ahmed",
                    "Mohamed"
                }

            }.ExcuteResult(200);
        }


      
    }
}
