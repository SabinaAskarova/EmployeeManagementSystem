using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Entitiy
{
    public class Employee : EntityBase
    {
        public string EmployeeName { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
