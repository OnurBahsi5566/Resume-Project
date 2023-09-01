using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace MyCvProjectAPI.Filters
{
    public class LogFilter : Attribute,IActionFilter
    {
        //logları tutabilen sınıf

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine(context.ActionDescriptor.DisplayName, context.Controller);
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            
        }
    }

}