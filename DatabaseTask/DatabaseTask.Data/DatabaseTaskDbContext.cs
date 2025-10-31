using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<BuildingCompany> BuildingCompany { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<JobTitle> JobTitle { get; set; }
        public DbSet<Machine> MachineEmployee { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<ProjectSite> ProjectSite { get; set; }
        public DbSet<Supplys> SupplysEmployee { get; set; }
       

    }
}
