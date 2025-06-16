// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/



using System.Text.Json;

namespace Modules.Estates.Infrastructure;

public class ApplicationDbContext : ModuleDbContext
{
    protected override string Schema => "est";

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
    public DbSet<ApartmentFeatures> ApartmentFeatures { get; set; }
    public DbSet<Features> Features { get; set; } 
    public DbSet<BlockNumber> BlockNumber { get; set; }
    public DbSet<BlockSides> BlockSides { get; set; }
    public DbSet<BlockStatus> BlockStatus { get; set; }
    public DbSet<BlockTypes> BlockTypes { get; set; }
    public DbSet<BlockUnit> BlockUnit { get; set; }
    public DbSet<FloorArea> FloorArea { get; set; }
    public DbSet<FloorNumbering> FloorNumbering { get; set; }
    public DbSet<LandUse> LandUse { get; set; }
    public DbSet<LandUseType> LandUseType { get; set; }
    public DbSet<Locality> Locality { get; set; }
    public DbSet<PlotDimension> PlotDimension { get; set; }
    public DbSet<PropertyHeight> PropertyHeight { get; set; }
    public DbSet<PlotType> PlotType { get; set; }

    public DbSet<Activity> Activity { get; set; }
    public DbSet<ActivityType> ActivityType { get; set; }

    public DbSet<CustomerMaster> CustomerMaster { get; set; }
    public DbSet<PropertyMaster> PropertyMaster { get; set; }

    public DbSet<OwnershipType> OwnershipType { get; set; }

    public DbSet<StopDebit> StopDebit { get; set; }

    public DbSet<InterestExpressed> InterestExpressed { get; set; }

    public DbSet<ComplaintType> ComplaintType { get; set; }
    public DbSet<NatureOfComplaint> NatureOfComplaint { get; set; }
    public DbSet<Complaint> Complaints { get; set; }
    public DbSet<ComplaintHistory> ComplaintHistory { get; set; }
    public DbSet<ComplaintStatuses> ComplaintStatuses { get; set; }

    public DbSet<LeaseTypeAndPeriod> LeaseTypeAndPeriod { get; set; }
    public DbSet<PropertyStatus> PropertyStatus { get; set; }

    public DbSet<CurrencyExchangeRate> CurrencyExchangeRate { get; set; }

    //23 May 2025
    public DbSet<RentalCategory> RentalCategory { get; set; }
    public DbSet<RentalType> RentalType { get; set; }
    public DbSet<ShopOfficeTypes> ShopOfficeTypes { get; set; }
    public DbSet<HouseTypes> HouseTypes { get; set; }

    //4 June, 2025
    public DbSet<Sites> Sites { get; set; }

    //15 June, 2025
    public DbSet<Types> Types { get; set; }
    public DbSet<SchemeType> SchemeType { get; set; }

    //16 JUne, 2025
    public DbSet<ApartmentCategory> ApartmentCategory { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        base.OnModelCreating(modelBuilder);

        //set custom schema
        modelBuilder.HasDefaultSchema("est");

        modelBuilder.Entity<PropertyMaster>(builder =>
        {
            builder.OwnsOne(p => p.PropertyNumber, owned =>
            {
                owned.Property(pm => pm.Value)
                .HasColumnName("PropertyNumber")
                .IsRequired();
            });

            builder.OwnsOne(e => e.PlotSize, owned =>
            {
                owned.Property(p => p.Dimension)
                     .HasColumnName("PlotDimension")
                     .IsRequired();

                owned.Property(p => p.Acreage)
                     .HasColumnName("PlotAcreage")
                     .IsRequired();
            });


            builder.OwnsOne(e => e.Coordinates, owned =>
            {
                owned.Property(p => p.CoordinateOne).HasColumnName("CoordinateOne").HasMaxLength(50).IsRequired();
                owned.Property(p => p.CoordinateTwo).HasColumnName("CoordinateTwo").HasMaxLength(50).IsRequired();
                owned.Property(p => p.CoordinateThree).HasColumnName("CoordinateThree").HasMaxLength(50);
                owned.Property(p => p.CoordinateFour).HasColumnName("CoordinateFour").HasMaxLength(50);
                owned.Property(p => p.CoordinateFive).HasColumnName("CoordinateFive").HasMaxLength(50);
                owned.Property(p => p.CoordinateSix).HasColumnName("CoordinateSix").HasMaxLength(50);
            });

            builder.OwnsOne(e => e.Lease, owned =>
            {
                owned.Property(p => p.CommencementDate).HasColumnName("CommencementDate");
                owned.Property(p => p.TermInYears).HasColumnName("LeaseTermInYears");
                owned.Property(p => p.ExpiryDate).HasColumnName("LeaseExpiryDate");
            });
        });



        modelBuilder.Entity<CustomerMaster>()
            .HasIndex(cm => cm.CustomerCode)
            .IsUnique(true);

        modelBuilder.Entity<Complaint>()
            .HasIndex(c => c.ComplaintNumber)
            .IsUnique(true);

        modelBuilder.Entity<Complaint>().Property(x => x.DocumentList)
           .HasConversion(
               v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null!),
               v => JsonSerializer.Deserialize<string[]>(v, (JsonSerializerOptions)null!)!)
           .HasColumnType("nvarchar(max)");

        modelBuilder.Entity<ComplaintStatuses>()
            .HasIndex(c => c.ComplaintStatus)
            .IsUnique(true);

        modelBuilder.Entity<ComplaintHistory>()
            .HasIndex(ch => new { ch.ComplaintNumber, ch.ComplaintStatus })
            .IsUnique(true);

        modelBuilder.Entity<CustomerMaster>().Ignore(x => x.DomainEvents);

        modelBuilder.Entity<CurrencyExchangeRate>()
            .Property(c => c.BuyingRate)
            .HasColumnType("decimal(18,4)");

        modelBuilder.Entity<CurrencyExchangeRate>()
            .Property(c => c.SellingRate)
            .HasColumnType("decimal(18,4)");


        //modelBuilder.Entity<ApartmentTypes>

        //modelBuilder.ApplyConfiguration(new AllocationTypeConfiguration());
        //modelBuilder.ApplyConfiguration(new ApartmentTypesConfiguration());
        //modelBuilder.ApplyConfiguration(new LandUseConfiguration());
        //modelBuilder.ApplyConfiguration(new LandUseTypeConfiguration());
        //modelBuilder.ApplyConfiguration(new LocalityConfiguration());
        //modelBuilder.ApplyConfiguration(new PropertyTypeConfiguration());
        //modelBuilder.ApplyConfiguration(new ApartmentTypesConfiguration());

        //modelBuilder.ApplyConfiguration(new ActivityConfiguration());
        //modelBuilder.ApplyConfiguration(new ActivityTypeConfiguration());
        //modelBuilder.ApplyConfiguration(new ComplaintStatusConfiguration());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();
    }

}
