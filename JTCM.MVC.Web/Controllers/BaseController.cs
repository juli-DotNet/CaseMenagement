using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace JTCM.MVC.Web.Controllers
{
    public class BaseController:Controller
    {
        public BaseController():base()
        {
            
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (!ModelState.IsValid)
            {
                foreach (var error in ModelState.Values)
                {
                    Console.WriteLine(error);
                }
            }
            base.OnActionExecuted(context);
        }
    }
}