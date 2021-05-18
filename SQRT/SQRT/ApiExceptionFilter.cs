using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SQRT
{
    public class ApiExceptionFilter : ExceptionFilterAttribute
    {

        public override void OnException(ExceptionContext context)
        {
            var exception = context.Exception.GetBaseException();
            var stackTrace = exception.StackTrace;
            var msg = exception.Message;

            context.HttpContext.Response.StatusCode = 500;
            context.Result = new JsonResult(new
            {
                status = "error",
                message = msg + ":" + stackTrace
            });

            base.OnException(context);
        }
    }
}
