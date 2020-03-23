namespace Scenariul5
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public class Inherited_hierarchy_Model : DbContext
    {
        // Your context has been configured to use a 'Inherited_hierarchy_Model' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Scenariul5.Inherited_hierarchy_Model' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Inherited_hierarchy_Model' 
        // connection string in the application configuration file.
        public Inherited_hierarchy_Model()
            : base("name=Inherited hierarchy_Model")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FullTimeEmployee>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("FullTimeEmployee");
            });

            modelBuilder.Entity<HourlyEmployee>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("HourlyEmployee");
            });
        }

        public virtual DbSet<Employee> Employees { get; set; }
    }

    public abstract class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; protected set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class FullTimeEmployee : Employee
    {
        public decimal? Salary { get; set; }
    }
    public class HourlyEmployee : Employee
    {
        public decimal? Wage { get; set; }
    }

}