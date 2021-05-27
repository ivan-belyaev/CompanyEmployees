using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Threading.Tasks;

namespace CompanyEmployees.ActionFilters
{
    /// <summary>
    /// Validate CompanyExists Attribute
    /// </summary>
    public class ValidateCompanyExistsAttribute : IAsyncActionFilter
    {
        /// <summary>
        /// Repository Manager
        /// </summary>
        private readonly IRepositoryManager _repository;

        /// <summary>
        /// Logger Manager
        /// </summary>
        private readonly ILoggerManager _logger;

        /// <summary>
        /// ctor
        /// </summary>
        public ValidateCompanyExistsAttribute(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        /// <summary>
        /// On Action Execution Async
        /// </summary>
        /// <param name="context">Context</param>
        /// <param name="next">Action Execution Delegate</param>
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var trackChanges = context.HttpContext.Request.Method.Equals("PUT");
            var id = (Guid)context.ActionArguments["id"];
            var company = await _repository.Company.GetCompanyAsync(id, trackChanges);

            if (company == null)
            {
                _logger.LogInfo($"Company with id: {id} doesn't exist in the database.");
                context.Result = new NotFoundResult();
            }
            else
            {
                context.HttpContext.Items.Add("company", company);
                await next();
            }
        }
    }
}
