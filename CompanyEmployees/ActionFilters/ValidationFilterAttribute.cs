using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyEmployees.ActionFilters
{
    /// <summary>
    /// Validation Filter Attribute
    /// </summary>
    public class ValidationFilterAttribute : IActionFilter
    {
        /// <summary>
        /// Logger Manager
        /// </summary>
        private readonly ILoggerManager _logger;

        /// <summary>
        /// ctor
        /// </summary>
        public ValidationFilterAttribute(ILoggerManager logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// On Action Executing
        /// </summary>
        /// <param name="context">Action Executing Context</param>
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var action = context.RouteData.Values["action"];
            var controller = context.RouteData.Values["controller"];

            var param = context.ActionArguments
                .SingleOrDefault(x => x.Value.ToString().Contains("Dto")).Value;
            if (param == null)
            {
                _logger.LogError($"Object sent from client is null. Controller: {controller}, action: {action}");
                context.Result = new BadRequestObjectResult($"Object is null. Controller: {controller}, action: {action}");
                return;
            }

            if (!context.ModelState.IsValid)
            {
                _logger.LogError($"Invalid model state for the object. Controller: {controller}, action: {action}");
                context.Result = new UnprocessableEntityObjectResult(context.ModelState);
            }
        }

        public void OnActionExecuted(ActionExecutedContext context) { }
    }
}
