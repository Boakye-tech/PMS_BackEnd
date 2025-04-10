using System;
using Modules.Estates.Domain.Entities.Setup.Customer;
using Modules.Estates.Domain.Interfaces.DomainServices;

namespace Modules.Estates.Application.DomainServices
{
	public class CustomerDomainService : ICustomerDomainService
    {
        private readonly IUnitOfWork _unitOfWork;

		public CustomerDomainService(IUnitOfWork unitOfWork)
		{
            _unitOfWork = unitOfWork;
		}

        public async Task<bool> CustomerTypeExists(int customerTypeId)
        {
            var result = await _unitOfWork.CustomerType.Get(customerTypeId);
            if(result is null)
            {
                return false;
            }

            return true;
        }

        public async Task<bool> GenderExists(int genderId)
        {
            var result = await _unitOfWork.Gender.Get(genderId);
            if (result is null)
            {
                return false;
            }

            return true;
        }

        public async Task<Locality> GetLocalityDetails(int localityId)
        {
            var result = await _unitOfWork.Locality.Get(localityId);
            if (result is null)
            {
                return null!;
            }

            return result;
        }

        public async Task<bool> IdentificationTypeExists(int identificationTypeId)
        {
            var result = await _unitOfWork.IdentificationType.Get(identificationTypeId);
            if (result is null)
            {
                return false;
            }

            return true;
        }

        public async Task<bool> LocalityExists(int localityId)
        {
            var result = await _unitOfWork.Locality.Get(localityId);
            if (result is null)
            {
                return false;
            }

            return true;
        }

        public async Task<bool> NationalityExists(int nationalityId)
        {
            var result = await _unitOfWork.Nationality.Get(nationalityId);
            if (result is null)
            {
                return false;
            }

            return true;
        }

        public async Task<bool> ResidentTypeExists(int residentTypeId)
        {
            var result = await _unitOfWork.ResidentType.Get(residentTypeId);
            if (result is null)
            {
                return false;
            }

            return true;
        }

        public async Task<bool> SocialMediaExists(int socialMediaTypeId)
        {
            var result = await _unitOfWork.SocialMedia.Get(socialMediaTypeId);
            if (result is null)
            {
                return false;
            }

            return true;
        }

        public async Task<bool> TitleExists(int titleId)
        {
            var result = await _unitOfWork.Title.Get(titleId);
            if (result is null)
            {
                return false;
            }

            return true;
        }

        public async Task<bool> CustomerExists(int CustomerMasterId)
        {
            var result = await _unitOfWork.CustomerMaster.Get(CustomerMasterId);
            if (result is null)
            {
                return false;
            }

            return true;
        }




    }
}

