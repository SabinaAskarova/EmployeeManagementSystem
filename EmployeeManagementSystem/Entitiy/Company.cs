using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Entitiy
{
    public class Company : EntityBase
    {

        public string CompanyName { get; set; }
        public ICollection<Branch> Branches { get; set; }


    }
}
