using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ShopManagement.MvcUI.WebFramework.Mvc.Fillters
{
    public class SampleActionFilter : ActionFilterAttribute // Attribute, IActionFilter
    {
        private readonly ILogger<SampleActionFilter> _logger;
        private readonly Stopwatch _sw;

        public SampleActionFilter(ILogger<SampleActionFilter> logger)
        {
            _logger = logger;
            _sw = new Stopwatch();
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
        }


        public override void OnResultExecuted(ResultExecutedContext context)
        {
            base.OnResultExecuted(context);
        }

        //public void OnActionExecuting(ActionExecutingContext context)
        //{
        //    context.ModelState.
        //    _sw.Start();
        //    _logger.LogInformation("********************* Start Sample Action Filter");
        //}

        //public void OnActionExecuted(ActionExecutedContext context)
        //{
        //    _sw.Stop();
        //    _logger.LogInformation($"********************* Finish Sample Action Filter -- {_sw.ElapsedMilliseconds}");
        //}
    }
}
