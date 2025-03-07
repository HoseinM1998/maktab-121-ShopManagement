using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ShopManagement.Framework.CustomExceptions;

namespace SampleApi.WebFramework.ApiHelper
{
    public class ApiResultExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var apiResult = new ApiResult()
            {
                IsSuccess = false
            };

            var exType = context.Exception.GetType();
            if (exType == typeof(NotFoundException))
            {
                apiResult.Message = "رکورد مورد نظر یافت نشد.";
            }
            //else if(exType == typeof(Exception))
            else
            {
                apiResult.Message = "اجرای درخواست با خطا متوقف شد.";
            }

            context.Result = new BadRequestObjectResult(apiResult);
            context.ExceptionHandled = true;
        }
    }
}
