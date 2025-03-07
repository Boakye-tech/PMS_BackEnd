using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using Modules.Estates.Domain.Entities.Setup.Customer;
using Modules.Estates.Domain.Entities.Setup.Property;

namespace Modules.Estates.Application.UseCases.Management
{
	public class CustomerMasterService : ICustomerMasterService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ICustomerDomainService _domainService;

        private readonly IModuleCommunicationServices _moduleComms;
        private readonly ILogger<CustomerMasterService> _logger;

        public CustomerMasterService(IUnitOfWork unitOfWork, IMapper mapper, ICustomerDomainService domainService, IModuleCommunicationServices moduleComms, ILogger<CustomerMasterService> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _domainService = domainService;
            _moduleComms = moduleComms;
            _logger = logger;
        }

        public async Task<ProspectiveCustomerResponseDto> CreateCustomer(ProspectiveCustomerDto values)
        {
            //throw new NotImplementedException();
            CustomerMaster customer = await CustomerMaster.CreateUpdateAsync
                (
                    customerMasterId: values.CustomerMasterId,
                    customerTypeId: values.CustomerTypeId,
                    residentTypeId: values.ResidentTypeId,
                    localityId: values.LocalityId,
                    customerCode: values.CustomerCode!,
                    titleId: values.TitleId,
                    surName: values.SurName!,
                    otherNames: values.OtherNames!,
                    companyName: values.CompanyName!,
                    dateOfBirth: Convert.ToDateTime("1900-01-01"),
                    tinNumber: string.Empty,
                    picture: string.Empty,
                    genderId: values.GenderId,
                    nationalityId: values.NationalityId,
                    postalAddress: values.PostalAddress!,
                    residentialAddress: values.ResidentialAddress!,
                    digitalAddress: values.DigitalAddress!,
                    primaryMobileNumber: values.PrimaryMobileNumber!,
                    secondaryMobileNumber: values.SecondaryMobileNumber!,
                    officeNumber: values.OfficeNumber!,
                    whatsAppNumber: values.WhatsAppNumber!,
                    emailAddress: values.EmailAddress,
                    residentPermitNumber: string.Empty,
                    residentPermitDateIssued: Convert.ToDateTime("1900-01-01"),
                    residentPermitExpiryDate: Convert.ToDateTime("1900-01-01"),
                    socialMediaTypeId: values.SocialMediaTypeId,
                    socialMediaAccount: values.SocialMediaAccount!,
                    identificationTypeId: 0,
                    identificationTypeNumber: string.Empty,
                    identificationTypeImageOne: string.Empty,
                    identificationTypeImageTwo: string.Empty,
                    comments: values.Comments!,
                    interestExpressed: values.InterestExpressed,
                    debtorStatus: 0,
                    parentCode: string.Empty,
                    contactPerson_FullName: string.Empty,
                    contactPerson_PhoneNumber: string.Empty,
                    contactPerson_EmailAddress: string.Empty,
                    contactPerson_Address: string.Empty,
                    contactPerson_IdentificationTypeId: 0,
                    contactPerson_IdentificationTypeNumber: string.Empty,
                    contactPerson_IdentificationTypeImage: string.Empty,
                    isDeleted: false,
                    _domainService
                ); ;

            customer.CreatedBy = values.CreatedBy;
            customer.CreatedOn = DateTime.UtcNow;

            _unitOfWork.CustomerMaster.Insert(customer);
            await _unitOfWork.Complete();

            //get dynamic variables
            var _customerType = (await _unitOfWork.CustomerType.Get(c => c.CustomerTypeId == customer.CustomerTypeId))!.CustomerTypes;
            var _residentType = (await _unitOfWork.ResidentType.Get(r => r.ResidentTypeId == customer.ResidentTypeId))!.ResidentTypes;
            var _locality = await _unitOfWork.Locality.Get(l => l.LocalityId == customer.LocalityId);
            var _title = (await _unitOfWork.Title.Get(t => t.TitleId == customer.TitleId))!.Titles;
            var _gender = (await _unitOfWork.Gender.Get(g => g.GenderId == customer.GenderId))!.GenderType;
            var _nationality = (await _unitOfWork.Nationality.Get(n => n.NationalityId == customer.NationalityId))!.Nationalities;
            var _socialMediaPlatform = (await _unitOfWork.SocialMedia.Get(s => s.SocialMediaId == customer.SocialMediaTypeId))!.SocialMediaPlatform;
            var _identificationType = (await _unitOfWork.IdentificationType.Get(i => i.IdentificationTypeId == customer.IdentificationTypeId))!.IdentificationTypes;


            return new ProspectiveCustomerResponseDto
            {
                InterestExpressed = customer.InterestExpressed!,
                //CustomerMasterId = customer.CustomerMasterId,
                CustomerType = _customerType,
                ResidentType = _residentType,
                Locality = _locality,
                CustomerCode = customer.CustomerCode,
                Title = _title,
                SurName = customer.SurName!,
                OtherNames = customer.OtherNames!,
                CompanyName = customer.CompanyName!,
                Gender = _gender,
                Nationality = _nationality,
                PostalAddress = customer.PostalAddress,
                ResidentialAddress = customer.ResidentialAddress,
                DigitalAddress = customer.DigitalAddress,
                PrimaryMobileNumber = customer.PrimaryMobileNumber,
                SecondaryMobileNumber = customer.SecondaryMobileNumber,
                OfficeNumber = customer.OfficeNumber,
                WhatsAppNumber = customer.WhatsAppNumber,
                EmailAddress = customer.EmailAddress!,
                SocialMediaType = _socialMediaPlatform,
                SocialMediaAccount = customer.SocialMediaAccount,
                
                Comments = customer.Comments,
            };
        }

        public async Task<CompanyCustomerResponseDto> CreateCustomer(CompanyCustomerDto values)
        {
            //throw new NotImplementedException();
            CustomerMaster customer = await CustomerMaster.CreateUpdateAsync
                (
                    customerMasterId: values.CustomerMasterId,
                    customerTypeId: values.CustomerTypeId,
                    residentTypeId: values.ResidentTypeId,
                    localityId: values.LocalityId,
                    customerCode: values.CustomerCode!,
                    titleId: values.TitleId,
                    surName: values.SurName,
                    otherNames: values.OtherNames,
                    companyName: values.CompanyName,
                    dateOfBirth: values.DateOfBirth,
                    tinNumber: values.TinNumber!,
                    picture: values.Picture!,
                    genderId: values.GenderId,
                    nationalityId: values.NationalityId,
                    postalAddress: values.PostalAddress!,
                    residentialAddress: values.ResidentialAddress!,
                    digitalAddress: values.DigitalAddress!,
                    primaryMobileNumber: values.PrimaryMobileNumber!,
                    secondaryMobileNumber: values.SecondaryMobileNumber!,
                    officeNumber: values.OfficeNumber!,
                    whatsAppNumber: values.WhatsAppNumber!,
                    emailAddress: values.EmailAddress,
                    residentPermitNumber: string.Empty,
                    residentPermitDateIssued: Convert.ToDateTime("1900-01-01"),
                    residentPermitExpiryDate: Convert.ToDateTime("1900-01-01"),
                    socialMediaTypeId: values.SocialMediaTypeId,
                    socialMediaAccount: values.SocialMediaAccount!,
                    identificationTypeId: values.IdentificationTypeId,
                    identificationTypeNumber: values.IdentificationTypeNumber!,
                    identificationTypeImageOne: values.IdentificationTypeImageOne!,
                    identificationTypeImageTwo: values.IdentificationTypeImageTwo!,
                    comments: values.Comments!,
                    interestExpressed: string.Empty,
                    debtorStatus: 0,
                    parentCode: string.Empty,
                    contactPerson_FullName: string.Empty,
                    contactPerson_PhoneNumber: string.Empty,
                    contactPerson_EmailAddress: string.Empty,
                    contactPerson_Address: string.Empty,
                    contactPerson_IdentificationTypeId: 0,
                    contactPerson_IdentificationTypeNumber: string.Empty,
                    contactPerson_IdentificationTypeImage: string.Empty,
                    isDeleted: false,
                    _domainService
                );

            customer.CreatedBy = values.CreatedBy;
            customer.CreatedOn = DateTime.UtcNow;

            _unitOfWork.CustomerMaster.Insert(customer);
            await _unitOfWork.Complete();
        }

        public async Task<IndividualResidentCustomerResponseDto> CreateCustomer(IndividualResidentCustomerDto values)
        {
            //throw new NotImplementedException();
            CustomerMaster customer = await CustomerMaster.CreateUpdateAsync
                (
                    customerMasterId : values.CustomerMasterId,
                    customerTypeId : values.CustomerTypeId,
                    residentTypeId : values.ResidentTypeId,
                    localityId  : values.LocalityId,
                    customerCode  : values.CustomerCode!,
                    titleId  : values.TitleId,
                    surName  : values.SurName,
                    otherNames  : values.OtherNames,
                    companyName  : string.Empty,
                    dateOfBirth  : values.DateOfBirth,
                    tinNumber  : values.TinNumber!,
                    picture  : values.Picture!,
                    genderId  : values.GenderId,
                    nationalityId  : values.NationalityId,
                    postalAddress  : values.PostalAddress!,
                    residentialAddress  : values.ResidentialAddress!,
                    digitalAddress  : values.DigitalAddress!,
                    primaryMobileNumber  : values.PrimaryMobileNumber!,
                    secondaryMobileNumber  : values.SecondaryMobileNumber!,
                    officeNumber  : values.OfficeNumber!,
                    whatsAppNumber  : values.WhatsAppNumber!,
                    emailAddress  : values.EmailAddress,
                    residentPermitNumber  : string.Empty,
                    residentPermitDateIssued  : Convert.ToDateTime("1900-01-01"),
                    residentPermitExpiryDate  : Convert.ToDateTime("1900-01-01"),
                    socialMediaTypeId  : values.SocialMediaTypeId,
                    socialMediaAccount  : values.SocialMediaAccount!,
                    identificationTypeId  : values.IdentificationTypeId,
                    identificationTypeNumber  : values.IdentificationTypeNumber!,
                    identificationTypeImageOne  : values.IdentificationTypeImageOne!,
                    identificationTypeImageTwo  : values.IdentificationTypeImageTwo!,
                    comments  : values.Comments!,
                    interestExpressed  : string.Empty,
                    debtorStatus  : 0,
                    parentCode  : string.Empty,
                    contactPerson_FullName  : string.Empty,
                    contactPerson_PhoneNumber  : string.Empty,
                    contactPerson_EmailAddress  : string.Empty,
                    contactPerson_Address  : string.Empty,
                    contactPerson_IdentificationTypeId  : 0,
                    contactPerson_IdentificationTypeNumber  : string.Empty,
                    contactPerson_IdentificationTypeImage  : string.Empty,
                    isDeleted : false,
                    _domainService
                );

            customer.CreatedBy = values.CreatedBy;
            customer.CreatedOn = DateTime.UtcNow;

            _unitOfWork.CustomerMaster.Insert(customer);
            await _unitOfWork.Complete();
            
            var _locality = await _unitOfWork.Locality.Get(l => l.LocalityId == customer.LocalityId);

            //update counter
            var code = values.CustomerCode!.Substring(Math.Max(0, values.CustomerCode.Length - 4));
            _locality!.CustomerCodeCounter = Convert.ToInt32(code);

            _unitOfWork.Locality.Update(_locality);
            await _unitOfWork.Complete();


            //get dynamic variables
            var _customerType = (await _unitOfWork.CustomerType.Get(c => c.CustomerTypeId == customer.CustomerTypeId))!.CustomerTypes;
            var _residentType = (await _unitOfWork.ResidentType.Get(r => r.ResidentTypeId == customer.ResidentTypeId))!.ResidentTypes;
            var _localityName = _locality.LocalityName;
            var _title = (await _unitOfWork.Title.Get(t => t.TitleId == customer.TitleId))!.Titles;
            var _gender = (await _unitOfWork.Gender.Get(g => g.GenderId == customer.GenderId))!.GenderType;
            var _nationality = (await _unitOfWork.Nationality.Get(n => n.NationalityId == customer.NationalityId))!.Nationalities;
            var _socialMediaPlatform = (await _unitOfWork.SocialMedia.Get(s => s.SocialMediaId == customer.SocialMediaTypeId))!.SocialMediaPlatform;
            var _identificationType = (await _unitOfWork.IdentificationType.Get(i => i.IdentificationTypeId == customer.IdentificationTypeId))!.IdentificationTypes;

            var customername = string.Concat(_title," ",customer.OtherNames," ",customer.SurName);
            //prepare payload and call api

            OnlineCustomerDetailsDto customer_payload = new OnlineCustomerDetailsDto
            {
                CustomerType = _customerType,
                ResidentType = _residentType,
                Locality = _localityName!,
                CustomerCode = customer.CustomerCode!,
                CustomerName = customername,
                Picture = customer.Picture,
                Gender = _gender,
                Nationality = _nationality,
                PostalAddress = customer.PostalAddress,
                ResidentialAddress = customer.ResidentialAddress,
                DigitalAddress = customer.DigitalAddress,
                PrimaryMobileNumber = customer.PrimaryMobileNumber!,
                SecondaryMobileNumber = customer.SecondaryMobileNumber,
                OfficeNumber = customer.OfficeNumber,
                WhatsAppNumber = customer.WhatsAppNumber,
                EmailAddress = customer.EmailAddress!,
                SocialMediaType = _socialMediaPlatform,
                SocialMediaAccount = customer.SocialMediaAccount
            };

            var result = await _moduleComms.SendCustomerDetailsAsync(customer_payload);
            if (!result)
            {
                _logger.LogWarning($"Failed to send customer details to online customer module {customer_payload.CustomerCode}", customer_payload.CustomerCode);
            }


            return new IndividualResidentCustomerResponseDto
            {
                CustomerMasterId = customer.CustomerMasterId,
                CustomerType = _customerType,
                ResidentType = _residentType,
                Locality = _localityName,
                CustomerCode = customer.CustomerCode,
                Title = _title,
                SurName = customer.SurName!,
                OtherNames = customer.OtherNames!,
                DateOfBirth = customer.DateOfBirth,
                TinNumber = customer.TinNumber,
                Picture = customer.Picture,
                Gender = _gender,
                Nationality = _nationality,
                PostalAddress = customer.PostalAddress,
                ResidentialAddress = customer.ResidentialAddress,
                DigitalAddress = customer.DigitalAddress,
                PrimaryMobileNumber = customer.PrimaryMobileNumber,
                SecondaryMobileNumber = customer.SecondaryMobileNumber,
                OfficeNumber = customer.OfficeNumber,
                WhatsAppNumber = customer.WhatsAppNumber,
                EmailAddress = customer.EmailAddress!,
                SocialMediaPlatform = _socialMediaPlatform,
                SocialMediaAccount = customer.SocialMediaAccount,
                IdentificationType = _identificationType,
                IdentificationTypeNumber = customer.IdentificationTypeNumber,
                IdentificationTypeImageOne = customer.IdentificationTypeImageOne,
                IdentificationTypeImageTwo = customer.IdentificationTypeImageTwo,
                Comments = customer.Comments,
                DebtorStatus = "Active"
            };
        }

        public Task<IndividualNonResidentCustomerResponseDto> CreateCustomer(IndividualNonResidentCustomerDto values)
        {
            throw new NotImplementedException();
        }

        public Task<IndividualExpatriateCustomerResponseDto> CreateCustomer(IndividualExpatriateCustomerDto values)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AllocationTypeReadDto>> GetAllocationTypeAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CustomerListDto>> GetCustomerListAsync()
        {
            //throw new NotImplementedException();

            var customersQuery = from a in await _unitOfWork.CustomerMaster.GetAll()
                                 join b in await _unitOfWork.Title.GetAll()
                                 on a.TitleId equals b.TitleId into titleGroup
                                 from title in titleGroup.DefaultIfEmpty() // Left join on Title

                                 join c in await _unitOfWork.Locality.GetAll()
                                 on a.LocalityId equals c.LocalityId into localityGroup
                                 from locality in localityGroup.DefaultIfEmpty() // Left join on Locality
                                 orderby a.CreatedBy descending
                                 select new CustomerListDto
                                 {
                                     CustomerCode = a.CustomerCode,
                                     //Title = title != null ? title.Titles : null, // Handle NULL values from left join
                                     //SurName = a.SurName,
                                     //OtherNames = a.OtherNames,
                                     //CompanyName = a.CompanyName,
                                     FullName = string.Concat(title != null ? title.Titles : null, a.SurName, a.OtherNames, a.CompanyName),
                                     Locality = locality != null ? locality.LocalityName : string.Empty, // Handle NULL values from left join
                                     EmailAddress = a.EmailAddress,
                                     PrimaryMobileNumber = a.PrimaryMobileNumber,
                                     DebtorStatus = a.DebtorStatus == 90 ? "STOP DEBIT" : string.Empty 
                                 };

            // Execute asynchronously
            //var customers = customersQuery.ToList();// .ToListAsync();

            //return customers;

            return customersQuery.ToList();

        }


    }
}

