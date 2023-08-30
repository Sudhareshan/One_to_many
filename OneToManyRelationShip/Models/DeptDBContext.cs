using Microsoft.EntityFrameworkCore;

namespace OneToManyRelationShip.Models
{
    public class DeptDBContext:DbContext
    {
        public DeptDBContext(DbContextOptions<DeptDBContext> options):base(options)
        { 

        }

        public DbSet<Employe> Employes { get; set; }    
        public DbSet<Department> Departments { get; set; }

    }
}
