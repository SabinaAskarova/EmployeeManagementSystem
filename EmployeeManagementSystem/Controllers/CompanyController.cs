using EmployeeManagementSystem.Entitiy;
using EmployeeManagementSystem.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CompanyController : ControllerBase
    {
        private IRepository<Company> _companyrepo { get; set; }
        public CompanyController(IRepository<Company> companyrepo)
        {
            _companyrepo = companyrepo;
        }
        [HttpPost(Name = "insertcompany")]

        public ActionResult Insert(Company company)
        {
            _companyrepo.Insert(company);
            return Ok(company);
        }
        [HttpGet(Name = "updatecompany")]

        public ActionResult Update(Company company)
        {
            _companyrepo.Update(company);
            return Ok();
        }
        [HttpPut(Name = "deletecompany")]

        public ActionResult Delete(int id)
        {
            _companyrepo.Delete(id);
            return Ok();
        }
        [HttpGet(Name = "getcompany")]

        public ActionResult GetCompany(int id)
        {
            var result = _companyrepo.GetById(id);
            return Ok(result);
        }
        [HttpGet]

        public ActionResult GetAllCompany()
        {
            var result = _companyrepo.GetAll;
            return Ok(result);
        }
    }
}
