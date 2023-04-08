using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Entitiy
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
