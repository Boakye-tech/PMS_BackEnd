namespace Modules.Estates.Infrastructure.Configuration;

public class LocalityConfiguration : IEntityTypeConfiguration<Locality>
{
    public void Configure(EntityTypeBuilder<Locality> builder)
    {
        builder.HasIndex(c => new { c.LocalityInitial, c.LocalityName })
               .IsUnique(true);


        builder.HasData(
                new Locality(1, "C01", "COMMUNITY 1", "2A",1052),
                new Locality(2, "C02", "COMMUNITY 2", "2B",0201),
                new Locality(3, "C03", "COMMUNITY 3", "2C",0123),
                new Locality(4, "C04", "COMMUNITY 4", "2D",0099),
                new Locality(5, "C05", "COMMUNITY 5", "2E",0101),
                new Locality(6, "C06", "COMMUNITY 6", "2F",0043),
                new Locality(7, "C07", "COMMUNITY 7", "2G",0076),
                new Locality(8, "C08", "COMMUNITY 8", "2H", 0076),
                new Locality(9, "C09", "COMMUNITY 9", "2I", 0076),
                new Locality(10, "C10", "COMMUNITY 10","2J", 0076),
                new Locality(11, "C11", "COMMUNITY 11", "2K", 0076),
                new Locality(12, "C12", "COMMUNITY 12", "2L", 0076),
                new Locality(13, "C13", "COMMUNITY 13", "2M", 0005),
                new Locality(14, "C14", "COMMUNITY 14", "2N", 0076),
                new Locality(15, "C15", "COMMUNITY 15", "2O", 0076),
                new Locality(16, "C16", "COMMUNITY 16", "2P", 0076),
                new Locality(17, "C17", "COMMUNITY 17", "2Q", 0076),
                new Locality(18, "C18", "COMMUNITY 18", "2R", 0076),
                new Locality(19, "C19", "COMMUNITY 19", "2S", 0076),
                new Locality(20, "C20", "COMMUNITY 20", "2T", 0076),
                new Locality(21, "C21", "COMMUNITY 21", "2AL",051),
                new Locality(22, "C22", "COMMUNITY 22", "2VV", 022),
                new Locality(23, "C23", "COMMUNITY 23", "2AT", 015),
                new Locality(24, "C24", "COMMUNITY 24", "2AQ", 051),
                new Locality(25, "C25", "COMMUNITY 25", "2AP", 053),
                new Locality(26, "C26", "COMMUNITY 26", "2AR", 031),
                new Locality(27, "ASH", "ASHIAMAN", "2W", 0501),
                new Locality(28, "AK", "AGYEI KODJO", "2AJ", 021),
                new Locality(29, "ZN", "ZENU", "2AM", 0411),
                new Locality(30, "SAK", "SAKUMONO", "2V", 051),
                new Locality(31, "KLNG", "KLANGON", "2AH", 224),
                new Locality(32, "BT", "BETHLEHEM", "2BT", 102),
                new Locality(33, "TB", "TSUI BLEOO", "2TE", 051),
                new Locality(34, "TM", "TEMA MANHEAN", "2AF", 103),
                new Locality(35, "HI", "H/INDUSTRIAL MKT","2HI", 103),
                new Locality(36, "KPN", "KPONE", "2AG", 103),
                new Locality(37, "LASH", "LASHIBI","2LA", 103),
                new Locality(38, "TC", "TOWN CENTER","2TC", 103),
                new Locality(39, "VC", "VERTICAL CENTER", "2AC", 103),
                new Locality(40, "LI", "LIGHT INDUSTRIAL", "2AB", 103),
                new Locality(41, "IND", "HEAVY INDUSTRIAL", "2AA", 103),
                new Locality(42, "HI/CMKT", "KPONE CAR MKT","2MK", 103),
                new Locality(43, "UA", "UNKNOWN AREA","2UA",103),
                new Locality(44, "CH", "CHINA TOWN","2CT", 103),
                new Locality(45, "GC", "GOLF CITY","2GC", 103),
                new Locality(46, "MI", "MOTORWAY INDUSTRIAL","2MI", 103),
                new Locality(47, "SK", "SAKI TOWN","2SK", 103),
                new Locality(48, "BTM", "BORTEYMAN", "2BM", 103),
                new Locality(49, "SBP", "SEBREPOR", "2SB", 103),
                new Locality(50, "MTK", "MLITSAKPO", "2MS", 103)

            );
    }
}

