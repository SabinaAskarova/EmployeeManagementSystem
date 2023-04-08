using EmployeeManagementSystem.Entitiy;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.MyDbContext
{
    public class MyDbContextClass:DbContext
    {
        public MyDbContextClass(DbContextOptions options):base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Branch> Beanches { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
        .HasMany(e => e.Branches)
        .WithOne(e => e.Company)
        .HasForeignKey(e => e.CompanyId)
        .HasPrincipalKey(e => e.Id);

            modelBuilder.Entity<Branch>()
        .HasMany(e => e.Departments)
        .WithOne(e => e.Branch)
        .HasForeignKey(e => e.BracnhId)
        .HasPrincipalKey(e => e.Id);

            modelBuilder.Entity<Department>()
        .HasMany(e => e.Employees)
        .WithOne(e => e.Department)
        .HasForeignKey(e => e.DepartmentId)
        .HasPrincipalKey(e => e.Id);
        }
    }
}
