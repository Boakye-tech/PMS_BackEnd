
namespace Modules.Customers.Domain.Interfaces
{
	public interface IUnitOfWork : IDisposable
    {
        ICustomerTypeRepository CustomerType { get; }
        IGenderRepository Gender { get; }
        IIdentificationTypeRepository IdentificationType { get; }
        INationalityRepository Nationality { get; }
        IResidentTypeRepository ResidentType { get; }
        ISocialMediaRepository SocialMedia { get; }
        ITitleRepository Title { get; }


        int Complete();
    }
}

