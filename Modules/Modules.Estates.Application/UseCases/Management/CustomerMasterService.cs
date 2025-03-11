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

        public async Task<ProspectiveCustomerRegistrationResponseDto> CreateCustomer(ProspectiveCustomerDto values)
        {
            string _residentType = string.Empty;
            string _title = string.Empty;
            string _socialMediaPlatform = string.Empty;
            string _identificationType = string.Empty;

            try
            {
                CustomerMaster customer = await CustomerMaster.CreateProspectiveAsync
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
                        socialMediaTypeId: values.SocialMediaTypeId,
                        socialMediaAccount: values.SocialMediaAccount!,
                        comments: values.Comments!,
                        interestExpressed: values.InterestExpressed,
                        CreatedBy: values.CreatedBy!,
                        _domainService
                    );

                customer.CreatedOn = DateTime.UtcNow;

                _unitOfWork.CustomerMaster.Insert(customer);
                await _unitOfWork.Complete();

                //get dynamic variables
                var _customerType = (await _unitOfWork.CustomerType.Get(c => c.CustomerTypeId == customer.CustomerTypeId))!.CustomerTypes;
                var _locality = (await _unitOfWork.Locality.Get(l => l.LocalityId == customer.LocalityId))!.LocalityName;
                var _gender = (await _unitOfWork.Gender.Get(g => g.GenderId == customer.GenderId))!.GenderType;
                var _nationality = (await _unitOfWork.Nationality.Get(n => n.NationalityId == customer.NationalityId))!.Nationalities;

                if (values.ResidentTypeId != 0)
                {
                    _residentType = (await _unitOfWork.ResidentType.Get(r => r.ResidentTypeId == customer.ResidentTypeId))!.ResidentTypes;
                }

                if (values.TitleId != 0)
                {
                    _title = (await _unitOfWork.Title.Get(t => t.TitleId == customer.TitleId))!.Titles;
                }

                if (values.SocialMediaTypeId != 0)
                {
                    _socialMediaPlatform = (await _unitOfWork.SocialMedia.Get(s => s.SocialMediaId == customer.SocialMediaTypeId))!.SocialMediaPlatform;
                }

                var registeredCustomer = new ProspectiveCustomerResponseDto
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

                return new ProspectiveCustomerRegistrationResponseDto { IsSuccess = true, SuccessResponse = registeredCustomer };

            }
            catch (Exception ex)
            {
                var err = new ProspectiveCustomerErrorResponseDto { StatusCode = 500, StatusMessage = ex.InnerException!.Message };
                return new ProspectiveCustomerRegistrationResponseDto { IsSuccess = false, ErrorResponse = err };

            }
        }

        public async Task<CompanyRegistrationResponseDto> CreateCustomer(CompanyCustomerDto values) 
        {
            string _socialMediaPlatform = string.Empty; string _residentType = string.Empty;
            string _imageOne = string.Empty; string _imageTwo = string.Empty;
            string c_imageOne = string.Empty; string c_imageTwo = string.Empty;
            int imageCount;

            imageCount = values.IdentificationImages!.Count();
            switch (imageCount)
            {
                case 1:
                    _imageOne = values.IdentificationImages![0];
                    break;

                case 2:
                    _imageOne = values.IdentificationImages![0];
                    _imageTwo = values.IdentificationImages![1];
                    break;
            }


            imageCount = values.ContactPerson!.ContactPerson_IdentificationImages!.Count();
            switch (imageCount)
            {
                case 1:
                    c_imageOne = values.IdentificationImages![0];
                    break;

                case 2:
                    c_imageOne = values.IdentificationImages![0];
                    c_imageTwo = values.IdentificationImages![1];
                    break;
            }


            try
            {
                CustomerMaster customer = await CustomerMaster.CreateCompanyAsync
                    (
                        customerMasterId: values.CustomerMasterId,
                        customerTypeId: values.CustomerTypeId,
                        residentTypeId: values.ResidentTypeId,
                        localityId: values.LocalityId,
                        customerCode: values.CustomerCode!,
                        companyName: values.CompanyName!,
                        nationalityId: values.NationalityId,
                        companyAddress: values.CompanyAddress!,
                        digitalAddress: values.DigitalAddress!,
                        primaryMobileNumber: values.PrimaryMobileNumber!,
                        secondaryMobileNumber: values.SecondaryMobileNumber!,
                        officeNumber: values.OfficeNumber!,
                        whatsAppNumber: values.WhatsAppNumber!,
                        emailAddress: values.EmailAddress!,
                        businessRegistrationNumber: values.BusinessRegistrationNumber!,
                        tinNumber: values.TinNumber!,
                        socialMediaTypeId: values.SocialMediaTypeId,
                        socialMediaAccount: values.SocialMediaAccount!,
                        identificationTypeImageOne: _imageOne,
                        identificationTypeImageTwo: _imageTwo,
                        contactPerson_FullName: values.ContactPerson!.ContactPerson_FullName!,
                        contactPerson_PhoneNumber: values.ContactPerson.ContactPerson_PhoneNumber!,
                        contactPerson_EmailAddress: values.ContactPerson.ContactPerson_EmailAddress!,
                        contactPerson_Address: values.ContactPerson.ContactPerson_Address!,
                        contactPerson_IdentificationTypeId: values.ContactPerson.ContactPerson_IdentificationTypeId,
                        contactPerson_IdentificationTypeNumber: values.ContactPerson.ContactPerson_IdentificationTypeNumber!,
                        contactPerson_IdentificationTypeImageOne: c_imageOne,
                        contactPerson_IdentificationTypeImageTwo: c_imageTwo,
                        comments: values.Comments!,
                        isDeleted: false,
                        _domainService
                    );
                customer.PostalAddress = values.CompanyAddress;
                customer.ResidentialAddress = values.CompanyAddress;
                customer.CreatedBy = values.CreatedBy;
                customer.CreatedOn = DateTime.UtcNow;

                _unitOfWork.CustomerMaster.Insert(customer);
                //await _unitOfWork.Complete();

                //update counter
                var _locality = await _unitOfWork.Locality.Get(values.LocalityId);
                var code = customer.CustomerCode!.Substring(Math.Max(0, customer.CustomerCode!.Length - 4));
                _locality!.CustomerCodeCounter = Convert.ToInt32(code);
                _unitOfWork.Locality.Update(_locality);
                await _unitOfWork.Complete();

                //get dynamic variables
                var _customerType = (await _unitOfWork.CustomerType.Get(c => c.CustomerTypeId == customer.CustomerTypeId))!.CustomerTypes;
                var _localityName = (await _unitOfWork.Locality.Get(l => l.LocalityId == customer.LocalityId))!.LocalityName;
                var _nationality = (await _unitOfWork.Nationality.Get(n => n.NationalityId == customer.NationalityId))!.Nationalities;
                var _identificationType = (await _unitOfWork.IdentificationType.Get(i => i.IdentificationTypeId == customer.ContactPerson_IdentificationTypeId))!.IdentificationTypes;

                if (values.ResidentTypeId > 0)
                {
                    _residentType = (await _unitOfWork.ResidentType.Get(r => r.ResidentTypeId == customer.ResidentTypeId))!.ResidentTypes;
                }

                if(values.SocialMediaTypeId > 0)
                {
                    _socialMediaPlatform = (await _unitOfWork.SocialMedia.Get(s => s.SocialMediaId == customer.SocialMediaTypeId))!.SocialMediaPlatform;
                }

                var registeredCustomer = new CompanyCustomerResponseDto
                {
                    CustomerMasterId = customer.CustomerMasterId,
                    CustomerType = _customerType,
                    ResidentType = _residentType,
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
                    TinNumber = customer.TinNumber,
                    Picture = customer.Picture,
                    SocialMediaType = _socialMediaPlatform,
                    SocialMediaAccount = customer.SocialMediaAccount,
                    IdentificationImages = new string[] { customer.IdentificationTypeImageOne!, customer.IdentificationTypeImageTwo! },
                    DebtorStatus = customer.DebtorStatus.ToString(),
                    Comments = customer.Comments,

                    ContactPerson = new CompanyContactPersonResponseDto
                    {
                        ContactPerson_FullName = customer.ContactPerson_FullName,
                        ContactPerson_Address = customer.ContactPerson_Address,
                        ContactPerson_EmailAddress = customer.ContactPerson_EmailAddress,
                        ContactPerson_PhoneNumber = customer.ContactPerson_PhoneNumber,
                        ContactPerson_IdentificationType = _identificationType,
                        ContactPerson_IdentificationTypeNumber = customer.ContactPerson_IdentificationTypeNumber,
                        ContactPerson_IdentificationImages = new string[] { customer.ContactPerson_IdentificationTypeImageOne!, customer.ContactPerson_IdentificationTypeImageTwo! }
                    }
                };

                //prepare payload and call api
                OnlineCustomerDetailsDto customer_payload = new OnlineCustomerDetailsDto
                {
                    CustomerType = _customerType,
                    ResidentType = _residentType,
                    Locality = _localityName!,
                    CustomerCode = customer.CustomerCode!,
                    CustomerName = customer.CompanyName!,
                    Picture = customer.Picture,
                    Gender = string.Empty,
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


                return new CompanyRegistrationResponseDto { IsSuccess = true, SuccessResponse = registeredCustomer };
            }
            catch (Exception ex)
            {
                var err = new CompanyRegistrationErrorResponseDto { StatusCode = 500, StatusMessage = ex.InnerException!.Message };
                return new CompanyRegistrationResponseDto { IsSuccess = false, ErrorResponse = err };
            }
        }

        public async Task<IndividualResidentCustomerResponseDto> CreateCustomer(IndividualResidentCustomerDto values)
        {
            string _imageOne = string.Empty; string _imageTwo = string.Empty;
            string c_imageOne = string.Empty; string c_imageTwo = string.Empty;
            int imageCount;

            imageCount = values.IdentificationImages!.Count();
            switch (imageCount)
            {
                case 1:
                    _imageOne = values.IdentificationImages![0];
                    break;

                case 2:
                    _imageOne = values.IdentificationImages![0];
                    _imageTwo = values.IdentificationImages![1];
                    break;
            }


            imageCount = values.NonResident!.ContactPerson_IdentificationImages!.Count();
            switch (imageCount)
            {
                case 1:
                    c_imageOne = values.IdentificationImages![0];
                    break;

                case 2:
                    c_imageOne = values.IdentificationImages![0];
                    c_imageTwo = values.IdentificationImages![1];
                    break;
            }

            //throw new NotImplementedException();
            CustomerMaster customer = await CustomerMaster.CreateIndividualAsync
                (
                    customerMasterId: values.CustomerMasterId,
                    customerTypeId: values.CustomerTypeId,
                    residentTypeId: values.ResidentTypeId,
                    localityId: values.LocalityId,
                    customerCode: values.CustomerCode!,
                    titleId: values.TitleId,
                    surName: values.SurName,
                    otherNames: values.OtherNames,
                    //companyName  : string.Empty,
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
                    residentPermitNumber: values.Expatriate!.ResidentPermitNumber!,
                    residentPermitDateIssued: values.Expatriate!.ResidentPermitDateIssued!, //Convert.ToDateTime("1900-01-01"),
                    residentPermitExpiryDate: values.Expatriate!.ResidentPermitExpiryDate!, //Convert.ToDateTime("1900-01-01"),
                    socialMediaTypeId: values.SocialMediaTypeId,
                    socialMediaAccount: values.SocialMediaAccount!,
                    identificationTypeId: values.IdentificationTypeId,
                    identificationTypeNumber: values.IdentificationTypeNumber!,
                    identificationTypeImageOne: _imageOne,
                    identificationTypeImageTwo: _imageTwo,
                    comments: values.Comments!,
                    interestExpressed: string.Empty,
                    debtorStatus: 0,
                    parentCode: string.Empty,
                    contactPerson_FullName: values.NonResident.ContactPerson_FullName!,
                    contactPerson_PhoneNumber: values.NonResident.ContactPerson_PhoneNumber!,
                    contactPerson_EmailAddress: values.NonResident.ContactPerson_EmailAddress!,
                    contactPerson_Address: values.NonResident.ContactPerson_Address!,
                    contactPerson_IdentificationTypeId: values.NonResident.ContactPerson_IdentificationTypeId,
                    contactPerson_IdentificationTypeNumber: values.NonResident.ContactPerson_IdentificationTypeNumber!,
                    contactPerson_IdentificationTypeImageOne: c_imageOne,
                    contactPerson_IdentificationTypeImageTwo: c_imageOne,
                    isDeleted: false,
                    _domainService
                ); 

            customer.CreatedBy = values.CreatedBy;
            customer.CreatedOn = DateTime.UtcNow;

            _unitOfWork.CustomerMaster.Insert(customer);
            //await _unitOfWork.Complete();
            
            //update counter
            var _locality = await _unitOfWork.Locality.Get(values.LocalityId);
            var code = customer.CustomerCode!.Substring(Math.Max(0, customer.CustomerCode!.Length - 4));
            _locality!.CustomerCodeCounter = Convert.ToInt32(code);
            _unitOfWork.Locality.Update(_locality);
            await _unitOfWork.Complete();


            string _socialMediaPlatform = string.Empty; string _contactperson_identification = string.Empty;

            //get dynamic variables
            var _customerType = (await _unitOfWork.CustomerType.Get(c => c.CustomerTypeId == customer.CustomerTypeId))!.CustomerTypes;
            var _residentType = (await _unitOfWork.ResidentType.Get(r => r.ResidentTypeId == customer.ResidentTypeId))!.ResidentTypes;
            var _localityName = _locality.LocalityName;
            var _title = (await _unitOfWork.Title.Get(t => t.TitleId == customer.TitleId))!.Titles;
            var _gender = (await _unitOfWork.Gender.Get(g => g.GenderId == customer.GenderId))!.GenderType;
            var _nationality = (await _unitOfWork.Nationality.Get(n => n.NationalityId == customer.NationalityId))!.Nationalities;
            //var _socialMediaPlatform = (await _unitOfWork.SocialMedia.Get(s => s.SocialMediaId == customer.SocialMediaTypeId))!.SocialMediaPlatform;
            var _identificationType = (await _unitOfWork.IdentificationType.Get(i => i.IdentificationTypeId == customer.IdentificationTypeId))!.IdentificationTypes;

            if (values.SocialMediaTypeId > 0)
            {
                _socialMediaPlatform = (await _unitOfWork.SocialMedia.Get(s => s.SocialMediaId == customer.SocialMediaTypeId))!.SocialMediaPlatform;
            }

            if(values.NonResident!.ContactPerson_IdentificationTypeId != 0)
            {
                _contactperson_identification = (await _unitOfWork.IdentificationType.Get(i => i.IdentificationTypeId == customer.ContactPerson_IdentificationTypeId))!.IdentificationTypes!;
            }

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
                IdentificationImages = new string[] { customer.IdentificationTypeImageOne!, customer.IdentificationTypeImageTwo!, },
                IdentificationTypeNumber = customer.IdentificationTypeNumber,
                //IdentificationTypeImageOne = customer.IdentificationTypeImageOne,
                //IdentificationTypeImageTwo = customer.IdentificationTypeImageTwo,
                Comments = customer.Comments,
                DebtorStatus = "Active",
                NonResident = new IndividualNonResidentCustomerResponseDto
                {
                    ContactPerson_FullName = customer.ContactPerson_FullName,
                    ContactPerson_Address = customer.ContactPerson_Address,
                    ContactPerson_EmailAddress = customer.ContactPerson_EmailAddress,
                    ContactPerson_PhoneNumber = customer.ContactPerson_PhoneNumber,
                    ContactPerson_IdentificationTypeNumber = customer.ContactPerson_IdentificationTypeNumber,
                    ContactPerson_IdentificationType = _contactperson_identification,
                    ContactPerson_IdentificationImages = new string[] { customer.ContactPerson_IdentificationTypeImageOne!, customer.ContactPerson_IdentificationTypeImageTwo! }
                },
                Expatriate = new IndividualExpatriateCustomerResponseDto { ResidentPermitNumber = customer.ResidentPermitNumber, ResidentPermitDateIssued = customer.ResidentPermitDateIssued!, ResidentPermitExpiryDate = customer.ResidentPermitExpiryDate}
            };
        }

        //public Task<IndividualNonResidentCustomerResponseDto> CreateCustomer(IndividualNonResidentCustomerDto values)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IndividualExpatriateCustomerResponseDto> CreateCustomer(IndividualExpatriateCustomerDto values)
        //{
        //    throw new NotImplementedException();
        //}

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

