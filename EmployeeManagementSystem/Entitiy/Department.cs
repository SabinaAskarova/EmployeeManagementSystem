using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Entitiy
{
    public class Department : EntityBase
    {

        public string DepartmentName { get; set; }
        public int BracnhId { get; set; }
        public Branch Branch { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
