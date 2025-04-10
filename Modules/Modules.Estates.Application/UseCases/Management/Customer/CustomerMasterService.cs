using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using Modules.Estates.Application.Enums;
using Modules.Estates.Domain.Entities.Setup.Customer;

namespace Modules.Estates.Application.UseCases.Management.Customer
{
    public partial class CustomerMasterService : ICustomerMasterService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ICustomerDomainService _domainService;
        private readonly IModuleCommunicationServices _moduleComms;
        private readonly ILogger<CustomerMasterService> _logger;
        private readonly IDomainEventDispatcher _domainEventDispatcher;


        public CustomerMasterService(IUnitOfWork unitOfWork, IMapper mapper, ICustomerDomainService domainService, IModuleCommunicationServices moduleComms, ILogger<CustomerMasterService> logger, IDomainEventDispatcher domainEventDispatcher)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _domainService = domainService;
            _moduleComms = moduleComms;
            _logger = logger;
            _domainEventDispatcher = domainEventDispatcher;
        }

        public async Task<CustomerRegistrationResponseDto> CreateCustomer(ProspectiveCustomerCreateDto values)
        {
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
                        createdBy: values.CreatedBy!,
                        _domainService
                    );

                customer.CreatedOn = DateTime.UtcNow;
                customer.DebtorStatus = (int)DebtorStatusEnum.APPROVED;

                _unitOfWork.CustomerMaster.Insert(customer);
                await _unitOfWork.Complete();

                foreach (var domainEvent in customer.DomainEvents)
                {
                    await _domainEventDispatcher.Dispatch(domainEvent);
                }

                if (values.TitleId != 0)
                {
                    _title = (await _unitOfWork.Title.Get(t => t.TitleId == customer.TitleId))!.Titles;
                }

                if (values.SocialMediaTypeId != 0)
                {
                    _socialMediaPlatform = (await _unitOfWork.SocialMedia.Get(s => s.SocialMediaId == customer.SocialMediaTypeId))!.SocialMediaPlatform;
                }

                var registeredCustomer = new CustomerRegistrationSuccessResponseDto
                {
                    CustomerCode = customer.CustomerCode,
                    FullName = string.Concat(_title, " ", customer.OtherNames!, " ", customer.SurName!, " ", customer.CompanyName!).Trim(),
                    PhoneNumber = customer.PrimaryMobileNumber,
                };

                return new CustomerRegistrationResponseDto { IsSuccess = true, SuccessResponse = registeredCustomer };

            }
            catch (Exception ex)
            {
                var err = new BaseResponseDto { StatusCode = 500, StatusMessage = ex.InnerException!.Message };
                return new CustomerRegistrationResponseDto { IsSuccess = false, ErrorResponse = err };

            }
        }

        public async Task<CustomerRegistrationResponseDto> CreateCustomer(CreateCompanyCustomerDto values)
        {
            string _socialMediaPlatform = string.Empty; string _residentType = string.Empty;
            string _imageOne = string.Empty; string _imageTwo = string.Empty; string _imageThree = string.Empty; string _imageFour = string.Empty; string _imageFive = string.Empty;
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

                case 3:
                    _imageOne = values.IdentificationImages![0];
                    _imageTwo = values.IdentificationImages![1];
                    _imageThree = values.IdentificationImages![2];
                    break;

                case 4:
                    _imageOne = values.IdentificationImages![0];
                    _imageTwo = values.IdentificationImages![1];
                    _imageThree = values.IdentificationImages![2];
                    _imageFour = values.IdentificationImages![3];
                    break;

                case 5:
                    _imageOne = values.IdentificationImages![0];
                    _imageTwo = values.IdentificationImages![1];
                    _imageThree = values.IdentificationImages![2];
                    _imageFour = values.IdentificationImages![3];
                    _imageFive = values.IdentificationImages![4];
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
                        identificationTypeImageThree: _imageThree,
                        identificationTypeImageFour: _imageFour,
                        identificationTypeImageFive: _imageFive,
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
                        isPrimary: true,
                        _domainService
                    );
                customer.PostalAddress = values.CompanyAddress;
                customer.ResidentialAddress = values.CompanyAddress;
                customer.CreatedBy = values.CreatedBy;
                customer.CreatedOn = DateTime.UtcNow;
                customer.DebtorStatus = (int)DebtorStatusEnum.PENDING;

                _unitOfWork.CustomerMaster.Insert(customer);

                //update counter
                var _locality = await _unitOfWork.Locality.Get(values.LocalityId);
                var code = customer.CustomerCode!.Substring(Math.Max(0, customer.CustomerCode!.Length - 4));
                _locality!.CustomerCodeCounter = Convert.ToInt32(code);
                _unitOfWork.Locality.Update(_locality);
                await _unitOfWork.Complete();

                var registeredCustomer = new CustomerRegistrationSuccessResponseDto
                {
                    CustomerCode = customer.CustomerCode,
                    FullName = customer.CompanyName!.Trim(),
                    PhoneNumber = customer.PrimaryMobileNumber,
                };

                return new CustomerRegistrationResponseDto { IsSuccess = true, SuccessResponse = registeredCustomer };
            }
            catch (Exception ex)
            {
                var err = new BaseResponseDto { StatusCode = 500, StatusMessage = ex.Message };
                return new CustomerRegistrationResponseDto { IsSuccess = false, ErrorResponse = err };
            }
        }

        public async Task<CustomerRegistrationResponseDto> CreateCustomer(IndividualResidentCustomerDto values)
        {
            string _imageOne = string.Empty; string _imageTwo = string.Empty; string _imageThree = string.Empty; string _imageFour = string.Empty; string _imageFive = string.Empty;
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

                case 3:
                    _imageOne = values.IdentificationImages![0];
                    _imageTwo = values.IdentificationImages![1];
                    _imageThree = values.IdentificationImages![2];
                    break;

                case 4:
                    _imageOne = values.IdentificationImages![0];
                    _imageTwo = values.IdentificationImages![1];
                    _imageThree = values.IdentificationImages![2];
                    _imageFour = values.IdentificationImages![3];
                    break;

                case 5:
                    _imageOne = values.IdentificationImages![0];
                    _imageTwo = values.IdentificationImages![1];
                    _imageThree = values.IdentificationImages![2];
                    _imageFour = values.IdentificationImages![3];
                    _imageFive = values.IdentificationImages![4];
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

            try
            {
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
                        identificationTypeImageThree: _imageThree,
                        identificationTypeImageFour: _imageFour,
                        identificationTypeImageFive: _imageFive,
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
                        isPrimary: true,
                        _domainService
                    );

                customer.CreatedBy = values.CreatedBy;
                customer.CreatedOn = DateTime.UtcNow;
                customer.DebtorStatus = (int)DebtorStatusEnum.PENDING;

                _unitOfWork.CustomerMaster.Insert(customer);

                //update counter
                var _locality = await _unitOfWork.Locality.Get(values.LocalityId);
                var code = customer.CustomerCode!.Substring(Math.Max(0, customer.CustomerCode!.Length - 4));
                _locality!.CustomerCodeCounter = Convert.ToInt32(code);
                _unitOfWork.Locality.Update(_locality);
                await _unitOfWork.Complete();


                //get dynamic variables
                var _title = (await _unitOfWork.Title.Get(t => t.TitleId == customer.TitleId))!.Titles;
                var customername = string.Concat(_title, " ", customer.OtherNames, " ", customer.SurName).Trim();

                var registeredCustomer = new CustomerRegistrationSuccessResponseDto
                {
                    CustomerCode = customer.CustomerCode,
                    FullName = customername,
                    PhoneNumber = customer.PrimaryMobileNumber,
                };

                return new CustomerRegistrationResponseDto { IsSuccess = true, SuccessResponse = registeredCustomer };
            }
            catch (Exception ex)
            {
                var err = new BaseResponseDto { StatusCode = 500, StatusMessage = ex.InnerException!.Message };
                return new CustomerRegistrationResponseDto { IsSuccess = false, ErrorResponse = err };

            }
        }

        public async Task<CustomerRegistrationResponseDto> CreateCustomer(JointOwnershipCustomerDto values)
        {
            //throw new NotImplementedException();
            string _imageOne = string.Empty; string _imageTwo = string.Empty; string _imageThree = string.Empty; string _imageFour = string.Empty; string _imageFive = string.Empty;
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

                case 3:
                    _imageOne = values.IdentificationImages![0];
                    _imageTwo = values.IdentificationImages![1];
                    _imageThree = values.IdentificationImages![2];
                    break;

                case 4:
                    _imageOne = values.IdentificationImages![0];
                    _imageTwo = values.IdentificationImages![1];
                    _imageThree = values.IdentificationImages![2];
                    _imageFour = values.IdentificationImages![3];
                    break;

                case 5:
                    _imageOne = values.IdentificationImages![0];
                    _imageTwo = values.IdentificationImages![1];
                    _imageThree = values.IdentificationImages![2];
                    _imageFour = values.IdentificationImages![3];
                    _imageFive = values.IdentificationImages![4];
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
            CustomerMaster customer = await CustomerMaster.CreateJointAsync
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
                    identificationTypeImageThree: _imageThree,
                    identificationTypeImageFour: _imageFour,
                    identificationTypeImageFive: _imageFive,
                    comments: values.Comments!,
                    interestExpressed: string.Empty,
                    parentCode: string.Empty,
                    contactPerson_FullName: values.NonResident.ContactPerson_FullName!,
                    contactPerson_PhoneNumber: values.NonResident.ContactPerson_PhoneNumber!,
                    contactPerson_EmailAddress: values.NonResident.ContactPerson_EmailAddress!,
                    contactPerson_Address: values.NonResident.ContactPerson_Address!,
                    contactPerson_IdentificationTypeId: values.NonResident.ContactPerson_IdentificationTypeId,
                    contactPerson_IdentificationTypeNumber: values.NonResident.ContactPerson_IdentificationTypeNumber!,
                    contactPerson_IdentificationTypeImageOne: c_imageOne,
                    contactPerson_IdentificationTypeImageTwo: c_imageTwo,
                    isDeleted: false,
                    isPrimary: true,
                    maritalStatus: values.MaritalStatus!,
                    dateOfMarriage: values.DateOfMarriage!,
                    _domainService
                );

            customer.CreatedBy = values.CreatedBy;
            customer.CreatedOn = DateTime.UtcNow;
            customer.DebtorStatus = (int)DebtorStatusEnum.PENDING;

            List<CustomerMaster> jointCustomers = new List<CustomerMaster>
            {
                customer
            };

            string co_imageOne = string.Empty; string co_imageTwo = string.Empty;
            string col_imageOne = string.Empty; string col_imageTwo = string.Empty;
            int co_imageCount;


            //colesses and or dependent
            int count = 0;
            foreach (var value in values.CoLesse!)
            {
                co_imageCount = value.IdentificationImages!.Count();
                switch (co_imageCount)
                {
                    case 1:
                        co_imageOne = value.IdentificationImages![0];
                        break;

                    case 2:
                        co_imageOne = value.IdentificationImages![0];
                        co_imageTwo = value.IdentificationImages![1];
                        break;
                }


                co_imageCount = value.NonResident!.ContactPerson_IdentificationImages!.Count();
                switch (co_imageCount)
                {
                    case 1:
                        col_imageOne = value.IdentificationImages![0];
                        break;

                    case 2:
                        col_imageOne = value.IdentificationImages![0];
                        col_imageTwo = value.IdentificationImages![1];
                        break;
                }
                count++;

                CustomerMaster co_customer = await CustomerMaster.CreateJointAsync
                    (
                        customerMasterId: values.CustomerMasterId,
                        customerTypeId: values.CustomerTypeId,
                        residentTypeId: values.ResidentTypeId,
                        localityId: values.LocalityId,
                        customerCode: string.Empty,
                        titleId: value.TitleId,
                        surName: value.SurName,
                        otherNames: value.OtherNames,
                        dateOfBirth: value.DateOfBirth,
                        tinNumber: value.TinNumber!,
                        picture: value.Picture!,
                        genderId: value.GenderId,
                        nationalityId: value.NationalityId,
                        postalAddress: value.PostalAddress!,
                        residentialAddress: value.ResidentialAddress!,
                        digitalAddress: value.DigitalAddress!,
                        primaryMobileNumber: value.PrimaryMobileNumber!,
                        secondaryMobileNumber: value.SecondaryMobileNumber!,
                        officeNumber: value.OfficeNumber!,
                        whatsAppNumber: value.WhatsAppNumber!,
                        emailAddress: value.EmailAddress,
                        residentPermitNumber: value.Expatriate!.ResidentPermitNumber!,
                        residentPermitDateIssued: value.Expatriate!.ResidentPermitDateIssued!, //Convert.ToDateTime("1900-01-01"),
                        residentPermitExpiryDate: value.Expatriate!.ResidentPermitExpiryDate!, //Convert.ToDateTime("1900-01-01"),
                        socialMediaTypeId: value.SocialMediaTypeId,
                        socialMediaAccount: value.SocialMediaAccount!,
                        identificationTypeId: value.IdentificationTypeId,
                        identificationTypeNumber: value.IdentificationTypeNumber!,
                        identificationTypeImageOne: co_imageOne,
                        identificationTypeImageTwo: co_imageTwo,
                        identificationTypeImageThree: _imageThree,
                        identificationTypeImageFour: _imageFour,
                        identificationTypeImageFive: _imageFive,
                        comments: values.Comments!,
                        interestExpressed: string.Empty,
                        parentCode: customer.CustomerCode!,
                        contactPerson_FullName: value.NonResident.ContactPerson_FullName!,
                        contactPerson_PhoneNumber: value.NonResident.ContactPerson_PhoneNumber!,
                        contactPerson_EmailAddress: value.NonResident.ContactPerson_EmailAddress!,
                        contactPerson_Address: value.NonResident.ContactPerson_Address!,
                        contactPerson_IdentificationTypeId: value.NonResident.ContactPerson_IdentificationTypeId,
                        contactPerson_IdentificationTypeNumber: value.NonResident.ContactPerson_IdentificationTypeNumber!,
                        contactPerson_IdentificationTypeImageOne: col_imageOne,
                        contactPerson_IdentificationTypeImageTwo: col_imageTwo,
                        isDeleted: false,
                        isPrimary: false,
                        maritalStatus: values.MaritalStatus!,
                        dateOfMarriage: values.DateOfMarriage!,
                        _domainService
                    );

                co_customer.CustomerCode = $"{customer.CustomerCode!}-{count.ToString("D2")}";
                co_customer.CreatedBy = values.CreatedBy;
                co_customer.CreatedOn = DateTime.UtcNow;
                co_customer.DebtorStatus = (int)DebtorStatusEnum.PENDING;

                jointCustomers.Add(co_customer);
            }

            _unitOfWork.CustomerMaster.InsertRange(jointCustomers);

            //update counter
            var _locality = await _unitOfWork.Locality.Get(values.LocalityId);
            var code = customer.CustomerCode!.Substring(Math.Max(0, customer.CustomerCode!.Length - 4));
            _locality!.CustomerCodeCounter = Convert.ToInt32(code);
            _unitOfWork.Locality.Update(_locality);
            await _unitOfWork.Complete();

            //get dynamic variables
            var _title = (await _unitOfWork.Title.Get(t => t.TitleId == customer.TitleId))!.Titles;
            var customername = string.Concat(_title, " ", customer.OtherNames, " ", customer.SurName).Trim();

            var registeredCustomer = new CustomerRegistrationSuccessResponseDto
            {
                CustomerCode = customer.CustomerCode,
                FullName = customername,
                PhoneNumber = customer.PrimaryMobileNumber,
            };

            return new CustomerRegistrationResponseDto { IsSuccess = true, SuccessResponse = registeredCustomer };
        }

        public async Task<CustomerRegistrationResponseDto> CreateCustomer(MultiOwnershipCustomerDto values)
        {
            string _imageOne = string.Empty; string _imageTwo = string.Empty; string _imageThree = string.Empty; string _imageFour = string.Empty; string _imageFive = string.Empty;
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

                case 3:
                    _imageOne = values.IdentificationImages![0];
                    _imageTwo = values.IdentificationImages![1];
                    _imageThree = values.IdentificationImages![2];
                    break;

                case 4:
                    _imageOne = values.IdentificationImages![0];
                    _imageTwo = values.IdentificationImages![1];
                    _imageThree = values.IdentificationImages![2];
                    _imageFour = values.IdentificationImages![3];
                    break;

                case 5:
                    _imageOne = values.IdentificationImages![0];
                    _imageTwo = values.IdentificationImages![1];
                    _imageThree = values.IdentificationImages![2];
                    _imageFour = values.IdentificationImages![3];
                    _imageFive = values.IdentificationImages![4];
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

            CustomerMaster customer = await CustomerMaster.CreateJointAsync
                (
                    customerMasterId: values.CustomerMasterId,
                    customerTypeId: values.CustomerTypeId,
                    residentTypeId: values.ResidentTypeId,
                    localityId: values.LocalityId,
                    customerCode: values.CustomerCode!,
                    titleId: values.TitleId,
                    surName: values.SurName,
                    otherNames: values.OtherNames,
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
                    residentPermitDateIssued: values.Expatriate!.ResidentPermitDateIssued!,
                    residentPermitExpiryDate: values.Expatriate!.ResidentPermitExpiryDate!,
                    socialMediaTypeId: values.SocialMediaTypeId,
                    socialMediaAccount: values.SocialMediaAccount!,
                    identificationTypeId: values.IdentificationTypeId,
                    identificationTypeNumber: values.IdentificationTypeNumber!,
                    identificationTypeImageOne: _imageOne,
                    identificationTypeImageTwo: _imageTwo,
                    identificationTypeImageThree: _imageThree,
                    identificationTypeImageFour: _imageFour,
                    identificationTypeImageFive: _imageFive,
                    comments: values.Comments!,
                    interestExpressed: string.Empty,
                    parentCode: string.Empty,
                    contactPerson_FullName: values.NonResident.ContactPerson_FullName!,
                    contactPerson_PhoneNumber: values.NonResident.ContactPerson_PhoneNumber!,
                    contactPerson_EmailAddress: values.NonResident.ContactPerson_EmailAddress!,
                    contactPerson_Address: values.NonResident.ContactPerson_Address!,
                    contactPerson_IdentificationTypeId: values.NonResident.ContactPerson_IdentificationTypeId,
                    contactPerson_IdentificationTypeNumber: values.NonResident.ContactPerson_IdentificationTypeNumber!,
                    contactPerson_IdentificationTypeImageOne: c_imageOne,
                    contactPerson_IdentificationTypeImageTwo: c_imageTwo,
                    isDeleted: false,
                    isPrimary: true,
                    maritalStatus: values.MaritalStatus!,
                    dateOfMarriage: values.DateOfMarriage!,
                    _domainService
                );

            customer.CreatedBy = values.CreatedBy;
            customer.CreatedOn = DateTime.UtcNow;
            customer.DebtorStatus = (int)DebtorStatusEnum.PENDING;

            List<CustomerMaster> jointCustomers = new List<CustomerMaster>
            {
                customer
            };

            string co_imageOne = string.Empty; string co_imageTwo = string.Empty;
            int co_imageCount;


            //colesses and or dependent
            int count = 0;
            foreach (var value in values.Dependent!)
            {
                co_imageCount = value.IdentificationImages!.Count();
                switch (co_imageCount)
                {
                    case 1:
                        co_imageOne = value.IdentificationImages![0];
                        break;

                    case 2:
                        co_imageOne = value.IdentificationImages![0];
                        co_imageTwo = value.IdentificationImages![1];
                        break;
                }

                count++;

                CustomerMaster co_customer = await CustomerMaster.CreateJointAsync
                    (
                        customerMasterId: values.CustomerMasterId,
                        customerTypeId: values.CustomerTypeId,
                        residentTypeId: values.ResidentTypeId,
                        localityId: values.LocalityId,
                        customerCode: string.Empty,
                        titleId: value.TitleId,
                        surName: value.SurName,
                        otherNames: value.OtherNames,
                        dateOfBirth: value.DateOfBirth,
                        tinNumber: value.TinNumber!,
                        picture: value.Picture!,
                        genderId: value.GenderId,
                        nationalityId: value.NationalityId,
                        postalAddress: value.PostalAddress!,
                        residentialAddress: value.ResidentialAddress!,
                        digitalAddress: value.DigitalAddress!,
                        primaryMobileNumber: value.PrimaryMobileNumber!,
                        secondaryMobileNumber: value.SecondaryMobileNumber!,
                        officeNumber: value.OfficeNumber!,
                        whatsAppNumber: value.WhatsAppNumber!,
                        emailAddress: value.EmailAddress,
                        residentPermitNumber: values.Expatriate!.ResidentPermitNumber!,
                        residentPermitDateIssued: values.Expatriate!.ResidentPermitDateIssued!,
                        residentPermitExpiryDate: values.Expatriate!.ResidentPermitExpiryDate!,
                        socialMediaTypeId: value.SocialMediaTypeId,
                        socialMediaAccount: value.SocialMediaAccount!,
                        identificationTypeId: value.IdentificationTypeId,
                        identificationTypeNumber: value.IdentificationTypeNumber!,
                        identificationTypeImageOne: co_imageOne,
                        identificationTypeImageTwo: co_imageTwo,
                        identificationTypeImageThree: _imageThree,
                        identificationTypeImageFour: _imageFour,
                        identificationTypeImageFive: _imageFive,
                        comments: values.Comments!,
                        interestExpressed: string.Empty,
                        parentCode: customer.CustomerCode!,
                        contactPerson_FullName: values.NonResident.ContactPerson_FullName!,
                        contactPerson_PhoneNumber: values.NonResident.ContactPerson_PhoneNumber!,
                        contactPerson_EmailAddress: values.NonResident.ContactPerson_EmailAddress!,
                        contactPerson_Address: values.NonResident.ContactPerson_Address!,
                        contactPerson_IdentificationTypeId: values.NonResident.ContactPerson_IdentificationTypeId,
                        contactPerson_IdentificationTypeNumber: values.NonResident.ContactPerson_IdentificationTypeNumber!,
                        contactPerson_IdentificationTypeImageOne: c_imageOne,
                        contactPerson_IdentificationTypeImageTwo: c_imageTwo,
                        isDeleted: false,
                        isPrimary: false,
                        maritalStatus: values.MaritalStatus!,
                        dateOfMarriage: values.DateOfMarriage!,
                        _domainService
                    );

                co_customer.CustomerCode = $"{customer.CustomerCode!}-{count.ToString("D2")}";
                co_customer.CreatedBy = values.CreatedBy;
                co_customer.CreatedOn = DateTime.UtcNow;
                co_customer.DebtorStatus = (int)DebtorStatusEnum.PENDING;

                jointCustomers.Add(co_customer);
            }

            _unitOfWork.CustomerMaster.InsertRange(jointCustomers);

            //update counter
            var _locality = await _unitOfWork.Locality.Get(values.LocalityId);
            var code = customer.CustomerCode!.Substring(Math.Max(0, customer.CustomerCode!.Length - 4));
            _locality!.CustomerCodeCounter = Convert.ToInt32(code);
            _unitOfWork.Locality.Update(_locality);
            await _unitOfWork.Complete();

            //get dynamic variables
            var _title = (await _unitOfWork.Title.Get(t => t.TitleId == customer.TitleId))!.Titles;
            var customername = string.Concat(_title, " ", customer.OtherNames, " ", customer.SurName).Trim();

            var registeredCustomer = new CustomerRegistrationSuccessResponseDto
            {
                CustomerCode = customer.CustomerCode,
                FullName = customername,
                PhoneNumber = customer.PrimaryMobileNumber,
            };

            return new CustomerRegistrationResponseDto { IsSuccess = true, SuccessResponse = registeredCustomer };
        }

        public async Task<int> DeleteCustomerAsync(DeleteCustomerRequestDto values)
        {
            var customer = await _unitOfWork.CustomerMaster.Get(c => c.CustomerCode == values.customerCode);
            if(customer is null)
            {
                return 404;
            }

            customer!.IsDeleted = true;
            customer.DeletedBy = values.deletedBy;
            customer.DeletedOn = DateTime.UtcNow;

            _unitOfWork.CustomerMaster.Update(customer);

            var co_customers = await _unitOfWork.CustomerMaster.GetAll(c => c.ParentCode == values.customerCode);
            if(co_customers is not null)
            {
                foreach (var co_customer in co_customers)
                {
                    co_customer!.IsDeleted = true;
                    co_customer.DeletedBy = values.deletedBy;
                    co_customer.DeletedOn = DateTime.UtcNow;

                    _unitOfWork.CustomerMaster.Update(co_customer);
                }
            }

            await _unitOfWork.Complete();

            return 200;
        }

        public async Task<int> ApproveCustomerAsync(ApproveCustomerDto values)
        {
            //throw new NotImplementedException();
            var customer = await _unitOfWork.CustomerMaster.Get(c => c.CustomerCode == values.customerCode);
            if (customer is null)
            {
                return 404;
            }

            customer!.DebtorStatus = (int)DebtorStatusEnum.APPROVED;
            customer.ApprovedBy = values.approvedBy;
            customer.ApprovedOn = DateTime.UtcNow;

            _unitOfWork.CustomerMaster.Update(customer);
            await _unitOfWork.Complete();

            
            //get dynamic variables
            var _customerType = (await _unitOfWork.CustomerType.Get(c => c.CustomerTypeId == customer.CustomerTypeId))!.CustomerTypes;
            var _residentType = (await _unitOfWork.ResidentType.Get(r => r.ResidentTypeId == customer.ResidentTypeId))!.ResidentTypes;
            var _locality = (await _unitOfWork.Locality.Get(l => l.LocalityId == customer.LocalityId))!.LocalityName;
            var _title = (await _unitOfWork.Title.Get(t => t.TitleId == customer.TitleId))!.Titles;
            var _gender = (await _unitOfWork.Gender.Get(g => g.GenderId == customer.GenderId))!.GenderType;
            var _nationality = (await _unitOfWork.Nationality.Get(n => n.NationalityId == customer.NationalityId))!.Nationalities;
            var _socialMediaPlatform = (await _unitOfWork.SocialMedia.Get(s => s.SocialMediaId == customer.SocialMediaTypeId))!.SocialMediaPlatform;


            //prepare payload and call api
            if (customer.CustomerTypeId == (int)CustomerTypeEnum.COMPANY)
            {
                OnlineCustomerDetailsDto customer_payload = new OnlineCustomerDetailsDto
                {
                    CustomerType = _customerType,
                    ResidentType = _residentType,
                    Locality = _locality!,
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
            }
            else
            {
                var customername = string.Concat(_title, " ", customer.OtherNames, " ", customer.SurName);

                OnlineCustomerDetailsDto customer_payload = new OnlineCustomerDetailsDto
                {
                    CustomerType = _customerType,
                    ResidentType = _residentType,
                    Locality = _locality!,
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
            }

            return 200;

        }


    }
}

