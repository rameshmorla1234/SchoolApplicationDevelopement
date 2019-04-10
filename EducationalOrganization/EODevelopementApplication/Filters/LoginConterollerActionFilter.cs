using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace EODevelopementApplication.Filters
{
    public class LoginConterollerActionFilterAttribute:Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
           
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            try
            {
             if(!context.ModelState.IsValid)
                {
                    context.Result = new BadRequestObjectResult(context.ModelState);
                    return;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
    }
}
