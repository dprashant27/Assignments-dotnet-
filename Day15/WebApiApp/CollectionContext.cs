namespace DAL;
using Microsoft.EntityFrameworkCore;
using BOL;

public class CollectionContext:DbContext{

    public DbSet<Product> Product{get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conString=@"server=localhost;port=3306;user=root;password=Sangharsh@27;database=dotnet";
        optionsBuilder.UseMySQL(conString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>(entity=>{
            entity.HasKey(e=>e.Id);
            entity.Property(e=>e.Name);
            entity.Property(e=>e.Quantity);
            entity.Property(e=>e.Price);
            entity.Property(e=>e.Image);
        });

        modelBuilder.Entity<Product>().ToTable("product");
    }

}