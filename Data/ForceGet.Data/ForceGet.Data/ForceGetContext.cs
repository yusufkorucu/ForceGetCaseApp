using ForceGet.Entity.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace ForceGet.Context
{
    public class ForceGetContext:DbContext
    {
        //update-database -s 'ForceGet.WebApp'
        //add-migration mig1 -s 'ForceGet.WebApp'
        //Script-migration -From mig1 -To mig2 -s 'ForceGet.WebApp'
        public ForceGetContext(DbContextOptions<ForceGetContext> options) : base(options)
        {

        }
        public ForceGetContext() : base()
        {

        }

        public DbSet<ShippingInfo> ShippingInfos { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Unit1> Unit1 { get; set; }
        public DbSet<Unit2> Unit2 { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .HasMany(c => c.Cities)
                .WithOne(c => c.Country)
                .HasForeignKey(c => c.CountryId);

            modelBuilder.Entity<Country>()
                .HasMany(c => c.Units1)
                .WithOne(u => u.Country)
                .HasForeignKey(u => u.CountryId);

            modelBuilder.Entity<Country>()
                .HasMany(c => c.Units2)
                .WithOne(u => u.Country)
                .HasForeignKey(u => u.CountryId);


            modelBuilder.Entity<ShippingInfo>()
                .HasOne(s => s.Currency)
                .WithMany()
                .HasForeignKey(s => s.CurrencyId);

            modelBuilder.Entity<ShippingInfo>()
                .HasOne(s => s.Unit1)
                .WithMany()
                .HasForeignKey(s => s.Unit1Id);

            modelBuilder.Entity<ShippingInfo>()
                .HasOne(s => s.Unit2)
                .WithMany()
                .HasForeignKey(s => s.Unit2Id);
     
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

            string connectionString = configuration.GetConnectionString("SqlConnection");

            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
