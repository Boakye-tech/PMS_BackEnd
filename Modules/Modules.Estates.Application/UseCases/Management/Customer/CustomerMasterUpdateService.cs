using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using Modules.Estates.Application.DTO;
using Modules.Estates.Application.DTO.Management;
using Modules.Estates.Domain.Entities.Setup.Customer;
using Modules.Estates.Domain.Entities.Setup.Property;
using Modules.Estates.Domain.Events;

namespace Modules.Estates.Application.UseCases.Management.Customer
{
    public partial class CustomerMasterService : ICustomerMasterService
    {

        public async Task<CustomerRegistrationResponseDto> UpdateCustomer(UpdateCompanyCustomerDto values)
        {
            //string _socialMediaPlatform = string.Empty; string _residentType = string.Empty;
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
                CustomerMaster customer = await CustomerMaster.UpdateCompanyAsync
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
                        _domainService
                    );
                customer.PostalAddress = values.CompanyAddress;
                customer.ResidentialAddress = values.CompanyAddress;
                customer.ModifiedBy = values.ModifiedBy;
                customer.ModifiedOn = DateTime.UtcNow;
                //customer.DebtorStatus = 1;

                _unitOfWork.CustomerMaster.Update(customer);
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
                var err = new BaseResponseDto { StatusCode = 500, StatusMessage = ex.InnerException!.Message };
                return new CustomerRegistrationResponseDto { IsSuccess = false, ErrorResponse = err };
            }
        }

        public async Task<CustomerRegistrationResponseDto> UpdateCustomer(UpdateIndividualResidentCustomerDto values)
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
                CustomerMaster customer = await CustomerMaster.UpdateIndividualAsync
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
                        _domainService
                    );

                customer.CreatedBy = values.ModifiedBy;
                customer.CreatedOn = DateTime.UtcNow;

                _unitOfWork.CustomerMaster.Update(customer);
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

        public async Task<CustomerRegistrationResponseDto> UpdateCustomer(UpdateJointOwnershipCustomerDto values)
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

            //throw new NotImplementedException();
            CustomerMaster customer = await CustomerMaster.UpdateJointAsync
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
                    contactPerson_IdentificationTypeImageTwo: c_imageTwo,
                    maritalStatus: values.MaritalStatus!,
                    dateOfMarriage: values.DateOfMarriage!,
                    _domainService
                );

            customer.ModifiedBy = values.ModifiedBy;
            customer.ModifiedOn = DateTime.UtcNow;

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
                //throw new NotImplementedException();
                CustomerMaster co_customer = await CustomerMaster.UpdateJointAsync
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
                        debtorStatus: 0,
                        parentCode: customer.CustomerCode!,
                        contactPerson_FullName: value.NonResident.ContactPerson_FullName!,
                        contactPerson_PhoneNumber: value.NonResident.ContactPerson_PhoneNumber!,
                        contactPerson_EmailAddress: value.NonResident.ContactPerson_EmailAddress!,
                        contactPerson_Address: value.NonResident.ContactPerson_Address!,
                        contactPerson_IdentificationTypeId: value.NonResident.ContactPerson_IdentificationTypeId,
                        contactPerson_IdentificationTypeNumber: value.NonResident.ContactPerson_IdentificationTypeNumber!,
                        contactPerson_IdentificationTypeImageOne: col_imageOne,
                        contactPerson_IdentificationTypeImageTwo: col_imageTwo,
                        maritalStatus: values.MaritalStatus!,
                        dateOfMarriage: values.DateOfMarriage!,
                        _domainService
                    );

                //co_customer.CustomerCode = $"{customer.CustomerCode!}-{count.ToString("D2")}";
                co_customer.ModifiedBy = values.ModifiedBy;
                co_customer.ModifiedOn = DateTime.UtcNow;

                jointCustomers.Add(co_customer);
            }

            _unitOfWork.CustomerMaster.UpdateRange(jointCustomers);
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

        public async Task<CustomerRegistrationResponseDto> UpdateCustomer(UpdateMultiOwnershipCustomerDto values)
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
                    debtorStatus: 0,
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

            customer.ModifiedBy = values.ModifiedBy;
            customer.ModifiedOn = DateTime.UtcNow;
            //customer.DebtorStatus = 1;

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
                        debtorStatus: 0,
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

                //co_customer.CustomerCode = $"{customer.CustomerCode!}-{count.ToString("D2")}";
                co_customer. ModifiedBy = values.ModifiedBy;
                co_customer.ModifiedOn = DateTime.UtcNow;
                //co_customer.DebtorStatus = 1;

                jointCustomers.Add(co_customer);
            }

            _unitOfWork.CustomerMaster.UpdateRange(jointCustomers);
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



        

        


    }
}

