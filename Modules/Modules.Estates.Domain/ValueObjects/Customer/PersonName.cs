// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Domain.ValueObjects.Customer;

public class PersonName
{
    public int TitleId { get; private set; }
    public string? SurName { get; private set; }
    public string? OtherNames { get; private set; }

    private PersonName() { }

    public static PersonName Create(int titleId, string surName, string otherNames)
    {
        if (string.IsNullOrWhiteSpace(surName))
            throw new ArgumentException("Surname cannot be empty");
        if (string.IsNullOrWhiteSpace(otherNames))
            throw new ArgumentException("Other names cannot be empty");

        return new PersonName
        {
            TitleId = titleId,
            SurName = surName.Trim(),
            OtherNames = otherNames.Trim()
        };
    }

    public string FullName => $"{SurName}, {OtherNames}";
}