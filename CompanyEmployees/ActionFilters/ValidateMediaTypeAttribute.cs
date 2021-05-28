using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Net.Http.Headers;
using System.Linq;

namespace CompanyEmployees.ActionFilters
{
    /// <summary>
    /// Validate Media Type Attribute
    /// </summary>
    public class ValidateMediaTypeAttribute : IActionFilter
    {
        /// <summary>
        /// On Action Executing
        /// </summary>
        /// <param name="context">Action Executing Context</param>
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var acceptHeaderPresent = context.HttpContext.Request.Headers.ContainsKey("Accept");

            if (!acceptHeaderPresent)
            {
                context.Result = new BadRequestObjectResult($"Accept header is missing.");
                return;
            }

            var mediaType = context.HttpContext.Request.Headers["Accept"].FirstOrDefault();

            if (!MediaTypeHeaderValue.TryParse(mediaType, out MediaTypeHeaderValue outMediaType))
            {
                context.Result = new BadRequestObjectResult($"Media type not present. Please add Accept header with the required media type.");
                return;
            }

            context.HttpContext.Items.Add("AcceptHeaderMediaType", outMediaType);
        }

        /// <summary>
        /// On Action Executed
        /// </summary>
        /// <param name="context">Action Executing Context</param>
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}
