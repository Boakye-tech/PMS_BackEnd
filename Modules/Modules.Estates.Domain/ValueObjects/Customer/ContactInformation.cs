namespace Modules.Estates.Domain.ValueObjects.Customer;

public class ContactInformation
{
    public string PrimaryMobileNumber { get; private set; }
    public string SecondaryMobileNumber { get; private set; }
    public string OfficeNumber { get; private set; }
    public string WhatsAppNumber { get; private set; }
    public string EmailAddress { get; private set; }

    private ContactInformation() { }

    public static ContactInformation Create(
        string primaryMobileNumber,
        string emailAddress,
        string secondaryMobileNumber = null,
        string officeNumber = null,
        string whatsAppNumber = null)
    {
        if (string.IsNullOrWhiteSpace(primaryMobileNumber))
            throw new ArgumentException("Primary mobile number cannot be empty");
        if (string.IsNullOrWhiteSpace(emailAddress) || !emailAddress.Contains("@"))
            throw new ArgumentException("Invalid email address");

        return new ContactInformation
        {
            PrimaryMobileNumber = primaryMobileNumber.Trim(),
            SecondaryMobileNumber = secondaryMobileNumber?.Trim(),
            OfficeNumber = officeNumber?.Trim(),
            WhatsAppNumber = whatsAppNumber?.Trim(),
            EmailAddress = emailAddress.Trim().ToLower()
        };
    }
}