// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/SchemeType.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/06/2025 12:10 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Domain.Entities.Setup.Property;

public class SchemeType : AuditableEntity
{
    [Key]
    [Required]
    public int SchemeTypeId { get; private set; }

    [Required]
    [StringLength(50)]
    public string SchemeTypeName { get; private set; }

    public SchemeType(int schemeTypeId, string schemeTypeName)
    {
        SchemeTypeId = schemeTypeId;
        SchemeTypeName = schemeTypeName;
    }

    public static SchemeType Create(int schemeTypeId, string schemeTypeName)
    {
        Validate(schemeTypeId, schemeTypeName);
        return new SchemeType(schemeTypeId, schemeTypeName);
    }

    public void Update(int schemeTypeId, string schemeTypeName)
    {
        Validate(schemeTypeId, schemeTypeName);

        SchemeTypeId = schemeTypeId;
        SchemeTypeName = schemeTypeName;
    }

    private static void Validate(int schemeTypeId, string schemeTypeName)
    {
        if (schemeTypeId < 0)
            throw new ArgumentException("Scheme Type Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(schemeTypeName))
            throw new ArgumentException("Scheme Type Name cannot be empty or exceed 50 characters.");
    }
}