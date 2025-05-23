﻿// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.UseCases.Management.Customer
{
    public partial class CustomerMasterService : ICustomerMasterService
    {

        public async Task<CustomerMasterDto> GetCustomer(string customerCode)
        {
            var result = await _unitOfWork.CustomerMaster.Get(cm => cm.CustomerCode == customerCode);
            var response = _mapper.Map<CustomerMasterDto>(result);
            return response;
        }

        public async Task<ProspectiveCustomerResponseDto> GetProspectiveCustomerDetails(string customerCode)
        {
            var customer = await _unitOfWork.CustomerMaster.Get(cm => cm.CustomerCode == customerCode);

            string _residentType = string.Empty; string _title = string.Empty; string _socialMediaPlatform = string.Empty;

            //get dynamic variables
            var _customerType = (await _unitOfWork.CustomerType.Get(c => c.CustomerTypeId == customer!.CustomerTypeId))!.CustomerTypes;
            var _locality = (await _unitOfWork.Locality.Get(l => l.LocalityId == customer!.LocalityId))!.LocalityName;
            var _gender = (await _unitOfWork.Gender.Get(g => g.GenderId == customer!.GenderId))!.GenderType;
            var _nationality = (await _unitOfWork.Nationality.Get(n => n.NationalityId == customer!.NationalityId))!.Nationalities;

            if (customer!.ResidentTypeId != 0)
            {
                _residentType = (await _unitOfWork.ResidentType.Get(r => r.ResidentTypeId == customer!.ResidentTypeId))!.ResidentTypes;
            }

            if (customer!.TitleId != 0)
            {
                _title = (await _unitOfWork.Title.Get(t => t.TitleId == customer!.TitleId))!.Titles;
            }

            if (customer!.SocialMediaTypeId != 0)
            {
                _socialMediaPlatform = (await _unitOfWork.SocialMedia.Get(s => s.SocialMediaId == customer!.SocialMediaTypeId))!.SocialMediaPlatform;
            }

            var registeredCustomer = new ProspectiveCustomerResponseDto
            {
                CustomerMasterId = customer.CustomerMasterId,
                InterestExpressed = customer.InterestExpressed!,
                CustomerTypeId = customer.CustomerTypeId,
                CustomerType = _customerType,
                ResidentTypeId = customer.ResidentTypeId,
                ResidentType = _residentType,
                LocalityId = customer.LocalityId,
                Locality = _locality,
                CustomerCode = customer.CustomerCode,
                TitleId = customer.TitleId,
                Title = _title,
                SurName = customer.SurName!,
                OtherNames = customer.OtherNames!,
                CompanyName = customer.CompanyName!,
                GenderId = customer.GenderId,
                Gender = _gender,
                NationalityId = customer.NationalityId,
                Nationality = _nationality,
                PostalAddress = customer.PostalAddress,
                ResidentialAddress = customer.ResidentialAddress,
                DigitalAddress = customer.DigitalAddress,
                PrimaryMobileNumber = customer.PrimaryMobileNumber,
                SecondaryMobileNumber = customer.SecondaryMobileNumber,
                OfficeNumber = customer.OfficeNumber,
                WhatsAppNumber = customer.WhatsAppNumber,
                EmailAddress = customer.EmailAddress!,
                SocialMediaTypeId = customer.SocialMediaTypeId,
                SocialMediaType = _socialMediaPlatform,
                SocialMediaAccount = customer.SocialMediaAccount,

                Comments = customer.Comments,
            };

            return registeredCustomer;
        }

        public async Task<CompanyCustomerResponseDto> GetCompanyCustomerDetails(string customerCode)
        {
            var customer = await _unitOfWork.CustomerMaster.Get(cm => cm.CustomerCode == customerCode);

            string _residentType = string.Empty; string _socialMediaPlatform = string.Empty;

            //get dynamic variables
            var _customerType = (await _unitOfWork.CustomerType.Get(c => c.CustomerTypeId == customer!.CustomerTypeId))!.CustomerTypes;
            var _localityName = (await _unitOfWork.Locality.Get(l => l.LocalityId == customer!.LocalityId))!.LocalityName;
            var _nationality = (await _unitOfWork.Nationality.Get(n => n.NationalityId == customer!.NationalityId))!.Nationalities;
            var _identificationType = (await _unitOfWork.IdentificationType.Get(i => i.IdentificationTypeId == customer!.ContactPerson_IdentificationTypeId))!.IdentificationTypes;

            if (customer!.ResidentTypeId > 0)
            {
                _residentType = (await _unitOfWork.ResidentType.Get(r => r.ResidentTypeId == customer!.ResidentTypeId))!.ResidentTypes;
            }

            if (customer.SocialMediaTypeId > 0)
            {
                _socialMediaPlatform = (await _unitOfWork.SocialMedia.Get(s => s.SocialMediaId == customer!.SocialMediaTypeId))!.SocialMediaPlatform;
            }

            var registeredCustomer = new CompanyCustomerResponseDto
            {
                CustomerMasterId = customer.CustomerMasterId,
                CustomerTypeId = customer.CustomerTypeId,
                CustomerType = _customerType,
                ResidentTypeId = customer.ResidentTypeId,
                ResidentType = _residentType,
                LocalityId = customer.LocalityId,
                Locality = _localityName,
                CustomerCode = customer.CustomerCode,
                CompanyName = customer.CompanyName,
                EmailAddress = customer.EmailAddress,
                CompanyAddress = customer.PostalAddress,
                DigitalAddress = customer.DigitalAddress,
                PrimaryMobileNumber = customer.PrimaryMobileNumber,
                SecondaryMobileNumber = customer.SecondaryMobileNumber,
                OfficeNumber = customer.OfficeNumber,
                WhatsAppNumber = customer.WhatsAppNumber,
                BusinessRegistrationNumber = customer.IdentificationTypeNumber,
                NationalityId = customer.NationalityId,
                Nationality = _nationality,
                TinNumber = customer.TinNumber,
                Picture = customer.Picture,
                SocialMediaTypeId = customer.SocialMediaTypeId,
                SocialMediaType = _socialMediaPlatform,
                SocialMediaAccount = customer.SocialMediaAccount,
                IdentificationImages = new string[] { customer.IdentificationTypeImageOne!, customer.IdentificationTypeImageTwo! },
                DebtorStatus = customer.DebtorStatus == 0 ? "Active" :
                               customer.DebtorStatus == 1 ? "Pending" :
                               customer.DebtorStatus == 90 ? "STOP DEBIT" : "Unknown",
                Comments = customer.Comments,

                ContactPerson = new CompanyContactPersonResponseDto
                {
                    ContactPerson_FullName = customer.ContactPerson_FullName,
                    ContactPerson_Address = customer.ContactPerson_Address,
                    ContactPerson_EmailAddress = customer.ContactPerson_EmailAddress,
                    ContactPerson_PhoneNumber = customer.ContactPerson_PhoneNumber,
                    ContactPerson_IdentificationTypeId = customer.ContactPerson_IdentificationTypeId,
                    ContactPerson_IdentificationType = _identificationType,
                    ContactPerson_IdentificationTypeNumber = customer.ContactPerson_IdentificationTypeNumber,
                    ContactPerson_IdentificationImages = new string[] { customer.ContactPerson_IdentificationTypeImageOne!, customer.ContactPerson_IdentificationTypeImageTwo! }
                }
            };

            return registeredCustomer;
        }

        public async Task<IndividualResidentCustomerResponseDto> GetIndividualCustomerDetails(string customerCode)
        {
            var customer = await _unitOfWork.CustomerMaster.Get(cm => cm.CustomerCode == customerCode);
            if (customer == null)
            {
                throw new Exception("Customer not found");
            }


            string _socialMediaPlatform = string.Empty; string _contactperson_identification = string.Empty;

            //get dynamic variables
            var _customerType = (await _unitOfWork.CustomerType.Get(c => c.CustomerTypeId == customer!.CustomerTypeId))!.CustomerTypes;
            var _residentType = (await _unitOfWork.ResidentType.Get(r => r.ResidentTypeId == customer!.ResidentTypeId))!.ResidentTypes;
            var _localityName = (await _unitOfWork.Locality.Get(l => l.LocalityId == customer!.LocalityId))!.LocalityName;
            var _title = (await _unitOfWork.Title.Get(t => t.TitleId == customer!.TitleId))!.Titles;
            var _gender = (await _unitOfWork.Gender.Get(g => g.GenderId == customer!.GenderId))!.GenderType;
            var _nationality = (await _unitOfWork.Nationality.Get(n => n.NationalityId == customer!.NationalityId))!.Nationalities;
            var _identificationType = (await _unitOfWork.IdentificationType.Get(i => i.IdentificationTypeId == customer!.IdentificationTypeId))!.IdentificationTypes;

            if (customer!.SocialMediaTypeId > 0)
            {
                _socialMediaPlatform = (await _unitOfWork.SocialMedia.Get(s => s.SocialMediaId == customer.SocialMediaTypeId))!.SocialMediaPlatform;
            }

            if (customer.ContactPerson_IdentificationTypeId != 0)
            {
                _contactperson_identification = (await _unitOfWork.IdentificationType.Get(i => i.IdentificationTypeId == customer.ContactPerson_IdentificationTypeId))!.IdentificationTypes!;
            }

            return new IndividualResidentCustomerResponseDto
            {
                CustomerMasterId = customer.CustomerMasterId,
                CustomerTypeId = customer.CustomerTypeId,
                CustomerType = _customerType,
                ResidentTypeId = customer.ResidentTypeId,
                ResidentType = _residentType,
                LocalityId = customer.LocalityId,
                Locality = _localityName,
                CustomerCode = customer.CustomerCode,
                TitleId = customer.TitleId,
                Title = _title,
                SurName = customer.SurName!,
                OtherNames = customer.OtherNames!,
                DateOfBirth = customer.DateOfBirth,
                TinNumber = customer.TinNumber,
                Picture = customer.Picture,
                GenderId = customer.GenderId,
                Gender = _gender,
                NationalityId = customer.NationalityId,
                Nationality = _nationality,
                PostalAddress = customer.PostalAddress,
                ResidentialAddress = customer.ResidentialAddress,
                DigitalAddress = customer.DigitalAddress,
                PrimaryMobileNumber = customer.PrimaryMobileNumber,
                SecondaryMobileNumber = customer.SecondaryMobileNumber,
                OfficeNumber = customer.OfficeNumber,
                WhatsAppNumber = customer.WhatsAppNumber,
                EmailAddress = customer.EmailAddress!,
                SocialMediaTypeId = customer.SocialMediaTypeId,
                SocialMediaPlatform = _socialMediaPlatform,
                SocialMediaAccount = customer.SocialMediaAccount,
                IdentificationTypeId = customer.IdentificationTypeId,
                IdentificationType = _identificationType,
                IdentificationImages = new string[] { customer.IdentificationTypeImageOne!, customer.IdentificationTypeImageTwo!, },
                IdentificationTypeNumber = customer.IdentificationTypeNumber,
                Comments = customer.Comments,
                DebtorStatus = customer.DebtorStatus == 0 ? "Active" :
                               customer.DebtorStatus == 1 ? "Pending" :
                               customer.DebtorStatus == 90 ? "STOP DEBIT" : "Unknown",
                NonResident = new IndividualNonResidentCustomerResponseDto
                {
                    ContactPerson_FullName = customer.ContactPerson_FullName,
                    ContactPerson_Address = customer.ContactPerson_Address,
                    ContactPerson_EmailAddress = customer.ContactPerson_EmailAddress,
                    ContactPerson_PhoneNumber = customer.ContactPerson_PhoneNumber,
                    ContactPerson_IdentificationTypeId = customer.ContactPerson_IdentificationTypeId,
                    ContactPerson_IdentificationTypeNumber = customer.ContactPerson_IdentificationTypeNumber,
                    ContactPerson_IdentificationType = _contactperson_identification,
                    ContactPerson_IdentificationImages = new string[] { customer.ContactPerson_IdentificationTypeImageOne!, customer.ContactPerson_IdentificationTypeImageTwo! }
                },
                Expatriate = new IndividualExpatriateCustomerResponseDto { ResidentPermitNumber = customer.ResidentPermitNumber, ResidentPermitDateIssued = customer.ResidentPermitDateIssued!, ResidentPermitExpiryDate = customer.ResidentPermitExpiryDate }
            };
        }

        public async Task<JointOwnershipCustomerResponseDto> GetJointCustomerDetails(string customerCode)
        {
            var pr_customer = await _unitOfWork.CustomerMaster.Get(cm => cm.CustomerCode == customerCode);
            pr_customer = await _unitOfWork.CustomerMaster.Get(cm => cm.CustomerCode == customerCode);

            string _socialMediaPlatform = string.Empty; string _contactperson_identification = string.Empty;

            //get dynamic variables
            var _customerType = (await _unitOfWork.CustomerType.Get(c => c.CustomerTypeId == pr_customer!.CustomerTypeId))!.CustomerTypes;
            var _residentType = (await _unitOfWork.ResidentType.Get(r => r.ResidentTypeId == pr_customer!.ResidentTypeId))!.ResidentTypes;
            var _localityName = (await _unitOfWork.Locality.Get(l => l.LocalityId == pr_customer!.LocalityId))!.LocalityName;
            var _title = (await _unitOfWork.Title.Get(t => t.TitleId == pr_customer!.TitleId))!.Titles;
            var _gender = (await _unitOfWork.Gender.Get(g => g.GenderId == pr_customer!.GenderId))!.GenderType;
            var _nationality = (await _unitOfWork.Nationality.Get(n => n.NationalityId == pr_customer!.NationalityId))!.Nationalities;
            var _identificationType = (await _unitOfWork.IdentificationType.Get(i => i.IdentificationTypeId == pr_customer!.IdentificationTypeId))!.IdentificationTypes;

            if (pr_customer!.SocialMediaTypeId > 0)
            {
                _socialMediaPlatform = (await _unitOfWork.SocialMedia.Get(s => s.SocialMediaId == pr_customer.SocialMediaTypeId))!.SocialMediaPlatform;
            }

            if (pr_customer.ContactPerson_IdentificationTypeId != 0)
            {
                _contactperson_identification = (await _unitOfWork.IdentificationType.Get(i => i.IdentificationTypeId == pr_customer.ContactPerson_IdentificationTypeId))!.IdentificationTypes!;
            }

            var joint_customer = new JointOwnershipCustomerResponseDto
            {
                CustomerMasterId = pr_customer.CustomerMasterId,
                CustomerTypeId = pr_customer.CustomerTypeId,
                CustomerType = _customerType,
                ResidentTypeId = pr_customer.ResidentTypeId,
                ResidentType = _residentType,
                LocalityId = pr_customer.LocalityId,
                Locality = _localityName,
                CustomerCode = pr_customer.CustomerCode,
                TitleId = pr_customer.TitleId,
                Title = _title,
                SurName = pr_customer.SurName!,
                OtherNames = pr_customer.OtherNames!,
                DateOfBirth = pr_customer.DateOfBirth,
                TinNumber = pr_customer.TinNumber,
                Picture = pr_customer.Picture,
                GenderId = pr_customer.GenderId,
                Gender = _gender,
                NationalityId = pr_customer.NationalityId,
                Nationality = _nationality,
                PostalAddress = pr_customer.PostalAddress,
                ResidentialAddress = pr_customer.ResidentialAddress,
                DigitalAddress = pr_customer.DigitalAddress,
                PrimaryMobileNumber = pr_customer.PrimaryMobileNumber,
                SecondaryMobileNumber = pr_customer.SecondaryMobileNumber,
                OfficeNumber = pr_customer.OfficeNumber,
                WhatsAppNumber = pr_customer.WhatsAppNumber,
                EmailAddress = pr_customer.EmailAddress!,
                SocialMediaTypeId = pr_customer.SocialMediaTypeId,
                SocialMediaPlatform = _socialMediaPlatform,
                SocialMediaAccount = pr_customer.SocialMediaAccount,
                IdentificationTypeId = pr_customer.IdentificationTypeId,
                IdentificationType = _identificationType,
                IdentificationImages = new string[] { pr_customer.IdentificationTypeImageOne!, pr_customer.IdentificationTypeImageTwo!, },
                IdentificationTypeNumber = pr_customer.IdentificationTypeNumber,
                MaritalStatus = pr_customer.MaritalStatus,
                DateOfMarriage = pr_customer.DateOfMarriage,
                Comments = pr_customer.Comments,
                DebtorStatus = pr_customer.DebtorStatus == 0 ? "Active" :
                               pr_customer.DebtorStatus == 1 ? "Pending" :
                               pr_customer.DebtorStatus == 90 ? "STOP DEBIT" : "Unknown",
                NonResident = new IndividualNonResidentCustomerResponseDto
                {
                    ContactPerson_FullName = pr_customer.ContactPerson_FullName,
                    ContactPerson_Address = pr_customer.ContactPerson_Address,
                    ContactPerson_EmailAddress = pr_customer.ContactPerson_EmailAddress,
                    ContactPerson_PhoneNumber = pr_customer.ContactPerson_PhoneNumber,
                    ContactPerson_IdentificationTypeId = pr_customer.ContactPerson_IdentificationTypeId,
                    ContactPerson_IdentificationTypeNumber = pr_customer.ContactPerson_IdentificationTypeNumber,
                    ContactPerson_IdentificationType = _contactperson_identification,
                    ContactPerson_IdentificationImages = new string[] { pr_customer.ContactPerson_IdentificationTypeImageOne!, pr_customer.ContactPerson_IdentificationTypeImageTwo! }
                },
                Expatriate = new IndividualExpatriateCustomerResponseDto { ResidentPermitNumber = pr_customer.ResidentPermitNumber, ResidentPermitDateIssued = pr_customer.ResidentPermitDateIssued!, ResidentPermitExpiryDate = pr_customer.ResidentPermitExpiryDate },
            };


            return joint_customer;
        }

        public async Task<MultiOwnershipCustomerResponseDto> GetMultiCustomerDetails(string customerCode)
        {
            var pr_customer = await _unitOfWork.CustomerMaster.Get(cm => cm.CustomerCode == customerCode);

            string _socialMediaPlatform = string.Empty; string _contactperson_identification = string.Empty;

            //get dynamic variables
            var _customerType = (await _unitOfWork.CustomerType.Get(c => c.CustomerTypeId == pr_customer!.CustomerTypeId))!.CustomerTypes;
            var _residentType = (await _unitOfWork.ResidentType.Get(r => r.ResidentTypeId == pr_customer!.ResidentTypeId))!.ResidentTypes;
            var _localityName = (await _unitOfWork.Locality.Get(l => l.LocalityId == pr_customer!.LocalityId))!.LocalityName;
            var _title = (await _unitOfWork.Title.Get(t => t.TitleId == pr_customer!.TitleId))!.Titles;
            var _gender = (await _unitOfWork.Gender.Get(g => g.GenderId == pr_customer!.GenderId))!.GenderType;
            var _nationality = (await _unitOfWork.Nationality.Get(n => n.NationalityId == pr_customer!.NationalityId))!.Nationalities;
            var _identificationType = (await _unitOfWork.IdentificationType.Get(i => i.IdentificationTypeId == pr_customer!.IdentificationTypeId))!.IdentificationTypes;

            if (pr_customer!.SocialMediaTypeId > 0)
            {
                _socialMediaPlatform = (await _unitOfWork.SocialMedia.Get(s => s.SocialMediaId == pr_customer.SocialMediaTypeId))!.SocialMediaPlatform;
            }

            if (pr_customer.ContactPerson_IdentificationTypeId != 0)
            {
                _contactperson_identification = (await _unitOfWork.IdentificationType.Get(i => i.IdentificationTypeId == pr_customer.ContactPerson_IdentificationTypeId))!.IdentificationTypes!;
            }

            var multi_customer = new MultiOwnershipCustomerResponseDto
            {
                CustomerMasterId = pr_customer.CustomerMasterId,
                CustomerTypeId = pr_customer.CustomerTypeId,
                CustomerType = _customerType,
                ResidentTypeId = pr_customer.ResidentTypeId,
                ResidentType = _residentType,
                LocalityId = pr_customer.LocalityId,
                Locality = _localityName,
                CustomerCode = pr_customer.CustomerCode,
                TitleId = pr_customer.TitleId,
                Title = _title,
                SurName = pr_customer.SurName!,
                OtherNames = pr_customer.OtherNames!,
                DateOfBirth = pr_customer.DateOfBirth,
                TinNumber = pr_customer.TinNumber,
                Picture = pr_customer.Picture,
                GenderId = pr_customer.GenderId,
                Gender = _gender,
                NationalityId = pr_customer.NationalityId,
                Nationality = _nationality,
                PostalAddress = pr_customer.PostalAddress,
                ResidentialAddress = pr_customer.ResidentialAddress,
                DigitalAddress = pr_customer.DigitalAddress,
                PrimaryMobileNumber = pr_customer.PrimaryMobileNumber,
                SecondaryMobileNumber = pr_customer.SecondaryMobileNumber,
                OfficeNumber = pr_customer.OfficeNumber,
                WhatsAppNumber = pr_customer.WhatsAppNumber,
                EmailAddress = pr_customer.EmailAddress!,
                SocialMediaTypeId = pr_customer.SocialMediaTypeId,
                SocialMediaPlatform = _socialMediaPlatform,
                SocialMediaAccount = pr_customer.SocialMediaAccount,
                IdentificationTypeId = pr_customer.IdentificationTypeId,
                IdentificationType = _identificationType,
                IdentificationImages = new string[] { pr_customer.IdentificationTypeImageOne!, pr_customer.IdentificationTypeImageTwo!, },
                IdentificationTypeNumber = pr_customer.IdentificationTypeNumber,
                MaritalStatus = pr_customer.MaritalStatus,
                DateOfMarriage = pr_customer.DateOfMarriage,
                Comments = pr_customer.Comments,
                DebtorStatus = pr_customer.DebtorStatus == 0 ? "Active" :
                               pr_customer.DebtorStatus == 1 ? "Pending" :
                               pr_customer.DebtorStatus == 90 ? "STOP DEBIT" : "Unknown",
                NonResident = new IndividualNonResidentCustomerResponseDto
                {
                    ContactPerson_FullName = pr_customer.ContactPerson_FullName,
                    ContactPerson_Address = pr_customer.ContactPerson_Address,
                    ContactPerson_EmailAddress = pr_customer.ContactPerson_EmailAddress,
                    ContactPerson_PhoneNumber = pr_customer.ContactPerson_PhoneNumber,
                    ContactPerson_IdentificationTypeId = pr_customer.ContactPerson_IdentificationTypeId,
                    ContactPerson_IdentificationTypeNumber = pr_customer.ContactPerson_IdentificationTypeNumber,
                    ContactPerson_IdentificationType = _contactperson_identification,
                    ContactPerson_IdentificationImages = new string[] { pr_customer.ContactPerson_IdentificationTypeImageOne!, pr_customer.ContactPerson_IdentificationTypeImageTwo! }
                },
                Expatriate = new IndividualExpatriateCustomerResponseDto { ResidentPermitNumber = pr_customer.ResidentPermitNumber, ResidentPermitDateIssued = pr_customer.ResidentPermitDateIssued!, ResidentPermitExpiryDate = pr_customer.ResidentPermitExpiryDate },
            };


            return multi_customer;
        }

        public async Task<IEnumerable<CustomerListDto>> GetPendingCustomerListAsync()
        {
            var customersQuery = from a in await _unitOfWork.CustomerMaster.GetAll(cm => cm.DebtorStatus == 1 && cm.IsDeleted == false)
                                 join b in await _unitOfWork.Title.GetAll()
                                 on a.TitleId equals b.TitleId into titleGroup
                                 from title in titleGroup.DefaultIfEmpty() // Left join on Title

                                 join c in await _unitOfWork.Locality.GetAll()
                                 on a.LocalityId equals c.LocalityId into localityGroup
                                 from locality in localityGroup.DefaultIfEmpty() // Left join on Locality
                                 orderby a.CreatedOn descending
                                 select new CustomerListDto
                                 {
                                     CustomerCode = a.CustomerCode,
                                     FullName = string.Concat(title != null ? title.Titles : null, " ", a.SurName, " ", a.OtherNames, " ", a.CompanyName),
                                     Locality = locality != null ? locality.LocalityName : string.Empty,
                                     EmailAddress = a.EmailAddress,
                                     PrimaryMobileNumber = a.PrimaryMobileNumber,
                                     DebtorStatus = a.DebtorStatus == 0 ? "Active" :
                                                    a.DebtorStatus == 1 ? "Pending" :
                                                    a.DebtorStatus == 90 ? "STOP DEBIT" : "Unknown"
                                 };

            return customersQuery.ToList();

        }

        public async Task<IEnumerable<CustomerListDto>> GetCustomerListAsync(string? searchParam,string? locality)
        {
            var customersQuery = from a in await _unitOfWork.CustomerMaster.GetAll(cm => cm.IsDeleted == false)

                                 join b in await _unitOfWork.CustomerType.GetAll()
                                 on a.CustomerTypeId equals b.CustomerTypeId into customerTypeGroup
                                 from customerType in customerTypeGroup.DefaultIfEmpty() // Left join on CustomerType

                                 join d in await _unitOfWork.Locality.GetAll()
                                 on a.LocalityId equals d.LocalityId into localityGroup
                                 from area in localityGroup.DefaultIfEmpty() // Left join on Locality

                                 join e in await _unitOfWork.Title.GetAll()
                                 on a.TitleId equals e.TitleId into titleGroup
                                 from title in titleGroup.DefaultIfEmpty() // Left join on Title

                                 orderby a.CreatedOn descending
                                 select new CustomerListDto
                                 {
                                     CustomerCode = a.CustomerCode,
                                     CustomerType = customerType != null ? customerType.CustomerTypes : string.Empty,
                                     DebtorStatus = a.DebtorStatus == 0 ? "Active" :
                                                    a.DebtorStatus == 1 ? "Pending" :
                                                    a.DebtorStatus == 90 ? "STOP DEBIT" : "Unknown",
                                     EmailAddress = a.EmailAddress,
                                     FullName = string.Join(" ", title != null ? title.Titles : "", a.SurName, a.OtherNames, a.CompanyName).Trim(),
                                     Locality = area != null ? area.LocalityName : string.Empty,
                                     PrimaryMobileNumber = a.PrimaryMobileNumber,
                                 };

            // Apply filters only if parameters are provided
            if (!string.IsNullOrWhiteSpace(locality))
            {
                customersQuery = customersQuery.Where(c => c.Locality!.Contains(locality));
            }

            // Apply search only if a query is provided
            if (!string.IsNullOrWhiteSpace(searchParam))
            {
                customersQuery = customersQuery.Where(c =>
                    c.CustomerCode!.Contains(searchParam) ||
                    c.FullName!.Contains(searchParam) ||
                    c.Locality!.Contains(searchParam) ||
                    c.EmailAddress!.Contains(searchParam) ||
                    c.PrimaryMobileNumber!.Contains(searchParam)
                );
            }


            return customersQuery;
        }




    }
}

