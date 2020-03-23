using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Scenariul2
{
    public class Model1 : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Scenariul2.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public Model1()
            : base("name=Model1")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .Map(m =>
            {
                m.Properties(p => new { p.SKU, p.Description, p.Price });
                m.ToTable("Product", "BazaDeDate");
            })
            .Map(m =>
            {
                m.Properties(p => new { p.SKU, p.ImageURL });
                m.ToTable("ProductWebInfo", "BazaDeDate");
            });
        }

        public DbSet<Product> Products { get; set; }
    }

    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SKU { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
    }
}