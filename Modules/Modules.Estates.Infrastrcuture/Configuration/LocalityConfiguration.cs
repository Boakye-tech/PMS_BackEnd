namespace Modules.Estates.Infrastructure.Configuration;

public class LocalityConfiguration : IEntityTypeConfiguration<Locality>
{
    public void Configure(EntityTypeBuilder<Locality> builder)
    {
        builder.HasIndex(c => new { c.LocalityInitial, c.LocalityName })
               .IsUnique(true);


        builder.HasData(
                new Locality(1, "C01", "COMMUNITY 1", "2A"),
                new Locality(2, "C02", "COMMUNITY 2", "2B"),
                new Locality(3, "C03", "COMMUNITY 3", "2C"),
                new Locality(4, "C04", "COMMUNITY 4", "2D"),
                new Locality(5, "C05", "COMMUNITY 5", "2E"),
                new Locality(6, "C06", "COMMUNITY 6", "2F"),
                new Locality(7, "C07", "COMMUNITY 7", "2G"),
                new Locality(8, "C08", "COMMUNITY 8", "2H"),
                new Locality(9, "C09", "COMMUNITY 9", "2I"),
                new Locality(10, "C10", "COMMUNITY 10","2J"),
                new Locality(11, "C11", "COMMUNITY 11", "2K"),
                new Locality(12, "C12", "COMMUNITY 12", "2L"),
                new Locality(13, "C13", "COMMUNITY 13", "2M"),
                new Locality(14, "C14", "COMMUNITY 14", "2N"),
                new Locality(15, "C15", "COMMUNITY 15", "2O"),
                new Locality(16, "C16", "COMMUNITY 16", "2P"),
                new Locality(17, "C17", "COMMUNITY 17", "2Q"),
                new Locality(18, "C18", "COMMUNITY 18", "2R"),
                new Locality(19, "C19", "COMMUNITY 19", "2S"),
                new Locality(20, "C20", "COMMUNITY 20", "2T"),
                new Locality(21, "C21", "COMMUNITY 21", "2AL"),
                new Locality(22, "C22", "COMMUNITY 22", "2VV"),
                new Locality(23, "C23", "COMMUNITY 23", "2AT"),
                new Locality(24, "C24", "COMMUNITY 24", "2AQ"),
                new Locality(25, "C25", "COMMUNITY 25", "2AP"),
                new Locality(26, "C26", "COMMUNITY 26", "2AR"),
                new Locality(27, "ASH", "ASHIAMAN", "2W"),
                new Locality(28, "AK", "AGYEI KODJO", "2AJ"),
                new Locality(29, "ZN", "ZENU", "2AM"),
                new Locality(30, "SAK", "SAKUMONO", "2V"),
                new Locality(31, "KLNG", "KLANGON", "2AH"),
                new Locality(32, "BT", "BETHLEHEM", "2BT"),
                new Locality(33, "TB", "TSUI BLEOO", "2TE"),
                new Locality(34, "TM", "TEMA MANHEAN", "2AF"),
                new Locality(35, "HI", "H/INDUSTRIAL MKT",""),
                new Locality(36, "KPN", "KPONE", "2AG"),
                new Locality(37, "LASH", "LASHIBI",""),
                new Locality(38, "TC", "TOWN CENTER",""),
                new Locality(39, "VC", "VERTICAL CENTER", "2AC"),
                new Locality(40, "LI", "LIGHT INDUSTRIAL", "2AB"),
                new Locality(41, "IND", "HEAVY INDUSTRIAL", "2AA"),
                new Locality(42, "HI/CMKT", "KPONE CAR MKT",""),
                new Locality(43, "UA", "UNKNOWN AREA","2UA"),
                new Locality(44, "CH", "CHINA TOWN","2CT"),
                new Locality(45, "GC", "GOLF CITY","2GC"),
                new Locality(46, "MI", "MOTORWAY INDUSTRIAL",""),
                new Locality(47, "SK", "SAKI TOWN","2SK"),
                new Locality(48, "BTM", "BORTEYMAN", "2BM"),
                new Locality(49, "SBP", "SEBREPOR", "2SB"),
                new Locality(50, "MTK", "MLITSAKPO", "")

            );
    }
}

