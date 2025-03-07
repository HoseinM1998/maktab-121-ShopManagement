using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SampleApi.WebFramework.ApiHelper
{
    public class ApiResultFilterAttribute : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            switch (context.Result)
            {
                case OkObjectResult objectResult:
                {
                    var apiResult = new ApiResult<object>()
                    {
                        IsSuccess = true,
                        Message = "درخواست با موفقیت اجرا شد.",
                        Data = objectResult.Value!
                    };
                    context.Result = new JsonResult(apiResult)
                    {
                        StatusCode = StatusCodes.Status200OK
                    };
                    break;
                }

                default:break;
            }
        }
    }
}
