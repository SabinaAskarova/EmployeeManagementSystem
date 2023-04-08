using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Entitiy
{
    public class Branch:EntityBase
    {

        public string BranchName { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
