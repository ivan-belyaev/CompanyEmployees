using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CompanyEmployees.Controllers
{
    /// <summary>
    /// Companies V2 Controller
    /// </summary>
    [Route("api/companies")]
    [ApiController]
    public class CompaniesV2Controller : ControllerBase
    {
        /// <summary>
        /// Repository Manager
        /// </summary>
        private readonly IRepositoryManager _repository;

        /// <summary>
        /// ctor
        /// </summary>
        public CompaniesV2Controller(IRepositoryManager repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// GET: Get Companies
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetCompanies()
        {
            var companies = await _repository.Company.GetAllCompaniesAsync(trackChanges: false);

            return Ok(companies);
        }
    }
}