using System;

namespace Modules.Estates.Domain.ValueObjects.Customer;

public class ContactPerson
{
    public string? FullName { get; private set; }
    public string? PhoneNumber { get; private set; }
    public string? EmailAddress { get; private set; }
    public string? Address { get; private set; }
    public Identification? Identification { get; private set; }

    private ContactPerson() { }

    public static ContactPerson Create(
        string fullName,
        string phoneNumber,
        string emailAddress,
        string address,
        Identification identification)
    {
        if (string.IsNullOrWhiteSpace(fullName))
            throw new ArgumentException("Contact person name cannot be empty");
        if (string.IsNullOrWhiteSpace(phoneNumber))
            throw new ArgumentException("Contact person phone cannot be empty");

        return new ContactPerson
        {
            FullName = fullName.Trim(),
            PhoneNumber = phoneNumber.Trim(),
            EmailAddress = emailAddress?.Trim(),
            Address = address?.Trim(),
            Identification = identification
        };
    }
}