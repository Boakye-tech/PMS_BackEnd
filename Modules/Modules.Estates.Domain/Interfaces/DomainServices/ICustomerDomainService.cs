// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Domain.Interfaces.DomainServices
{
	public interface ICustomerDomainService
	{
        Task<bool> LocalityExists(int localityId);
        Task<bool> CustomerTypeExists(int customerTypeId);
        Task<bool> ResidentTypeExists(int residentTypeId);
        Task<bool> TitleExists(int titleId);
        Task<bool> GenderExists(int genderId);
        Task<bool> NationalityExists(int nationalityId);
        Task<bool> SocialMediaExists(int socialMediaTypeId);
        Task<bool> IdentificationTypeExists(int identificationTypeId);
        Task<bool> CustomerExists(int CustomerMasterId);

        Task<Locality> GetLocalityDetails(int localityId);

        Task<bool> ComplaintTypeExist(int complaintTypeId);
        Task<bool> ComplaintTypeExist(string complaintTypeName);

        Task<bool> NatureOfComplaintExist(int natureOfComplaintId);
        Task<bool> NatureOfComplaintExist(string natureOfComplaints);
    }
}

