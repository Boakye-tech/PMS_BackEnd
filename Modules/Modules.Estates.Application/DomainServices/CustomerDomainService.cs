// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


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

        public async Task<bool> ComplaintTypeExist(int complaintTypeId)
        {
            var result = await _unitOfWork.ComplaintType.Get(complaintTypeId);
            if (result is null)
            {
                return false;
            }

            return true;
        }

        public async Task<bool> ComplaintTypeExist(string complaintTypeName)
        {
            var result = await _unitOfWork.ComplaintType.Get(ct => ct.ComplaintTypes == complaintTypeName);
            if (result is null)
            {
                return false;
            }

            return true;
        }

        public async Task<bool> NatureOfComplaintExist(int natureOfComplaintId)
        {
            var result = await _unitOfWork.NatureOfComplaint.Get(natureOfComplaintId);
            if (result is null)
            {
                return false;
            }

            return true;

        }

        public async Task<bool> NatureOfComplaintExist(string natureOfComplaints)
        {
            var result = await _unitOfWork.NatureOfComplaint.Get(nc => nc.NatureOfComplaints == natureOfComplaints);
            if (result is null)
            {
                return false;
            }

            return true;

        }
    }
}

