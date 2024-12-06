using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Modules.Estates.Infrastructure.Configuration;

namespace Modules.Estates.Infrastructure;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }


    //----customer related tables
    public DbSet<CustomerType> CustomerType { get; set; }
    public DbSet<Gender> Gender { get; set; }
    public DbSet<IdentificationType> IdentificationType { get; set; }
    public DbSet<Nationality> Nationality { get; set; }
    public DbSet<ResidentType> ResidentType { get; set; }
    public DbSet<SocialMedia> SocialMedia { get; set; }
    public DbSet<Title> Title { get; set; }


    //----property related tables
    public DbSet<AllocationType> AllocationType { get; set; }
    public DbSet<ApartmentTypes> ApartmentTypes { get; set; }
    public DbSet<BlockNumber> BlockNumber { get; set; }
    public DbSet<BlockSides> BlockSides { get; set; }
    public DbSet<BlockStatus> BlockStatus { get; set; }
    public DbSet<BlockTypes> BlockTypes { get; set; }
    public DbSet<BlockUnit> BlockUnit { get; set; }
    public DbSet<Facilities> Facilities { get; set; }
    public DbSet<FloorNumbering> FloorNumbering { get; set; }
    public DbSet<LandUse> LandUse { get; set; }
    public DbSet<LandUseType> LandUseType { get; set; }
    public DbSet<Locality> Locality { get; set; }
    public DbSet<PlotSize> PlotSize { get; set; }
    public DbSet<PropertyHeight> PropertyHeight { get; set; }
    public DbSet<PropertyType> PropertyType { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //set custom schema
        modelBuilder.HasDefaultSchema("est");

        //modelBuilder.Entity<ApartmentTypes>

        modelBuilder.ApplyConfiguration(new AllocationTypeConfiguration());
        modelBuilder.ApplyConfiguration(new ApartmentTypesConfiguration());
        modelBuilder.ApplyConfiguration(new LandUseConfiguration());
        modelBuilder.ApplyConfiguration(new LandUseTypeConfiguration());
        modelBuilder.ApplyConfiguration(new LocalityConfiguration());
        modelBuilder.ApplyConfiguration(new PropertyTypeConfiguration());

        //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}

