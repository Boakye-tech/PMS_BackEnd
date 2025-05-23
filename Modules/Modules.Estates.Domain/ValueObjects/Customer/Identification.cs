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

public class Identification
{
    public int TypeId { get; private set; }
    public string? Number { get; private set; }
    public IReadOnlyList<string>? Images { get; private set; }

    private Identification() { }

    public static Identification Create(int typeId, string number, List<string> images)
    {
        if (typeId <= 0)
            throw new ArgumentException("Invalid identification type");
        if (string.IsNullOrWhiteSpace(number))
            throw new ArgumentException("Identification number cannot be empty");

        return new Identification
        {
            TypeId = typeId,
            Number = number.Trim(),
            Images = images?.AsReadOnly() ?? new List<string>().AsReadOnly()
        };
    }
}