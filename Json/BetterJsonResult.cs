using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    public class BetterJsonResult : JsonResult
    {
        public Object Data { get; init; }
        public BetterJsonResult(object value) : base(value)
        {
            Data = value;

        }

        public BetterJsonResult() : base(new object())
        {

        }



        public JsonResult ExcuteResult()
        {
            var x = new BetterJsonResult(
                Value = new
                {
                    ContentType = "",
                    data = Data
                });


            return x;

        }
        public JsonResult ExcuteResultOk()
        {
            var x = new BetterJsonResult(
                Value = new
                {
                    StatusCode=200,
                    ContentType = "",
                    data = Data
                });


            return x;

        }
        public JsonResult ExcuteResultBadRequest()
        {
            var x = new BetterJsonResult(
                Value = new
                {
                    StatusCode=400,
                    ContentType = "",
                    data = Data
                });


            return x;

        }
    }




    public class BetterJsonResult<T> : JsonResult
    {
        public T  Data 
        {
            get
            {
                return (T) Value;
            }
            init 
            {
                Value = (T) value;
            } 
        }
        public BetterJsonResult(object value) : base(value)
        {
        }


        public BetterJsonResult():base(new Object())
        {

        }

        public JsonResult ExcuteResult(int? statuscode)
        {
            var x = new BetterJsonResult(
                Value = new
                {
                    StatusCode = statuscode,
                    ContentType = "",
                    data = Data
                });


            return x;

        }
        public JsonResult ExcuteResultOk()
        {
            var x = new BetterJsonResult(
                Value = new
                {
                    StatusCode = 200,
                    ContentType = "",
                    data = Data
                });


            return x;

        }
        public JsonResult ExcuteResultBadRequest()
        {
            var x = new BetterJsonResult(
                Value = new
                {
                    StatusCode = 400,
                    ContentType = "",
                    data = Data
                });


            return x;

        }

    }


    


}
