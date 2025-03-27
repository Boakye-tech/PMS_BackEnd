using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using Modules.Estates.Application.DTO;
using Modules.Estates.Application.DTO.Management;
using Modules.Estates.Application.Enums;
using Modules.Estates.Domain.Entities.Management;
using Modules.Estates.Domain.Entities.Setup.Customer;
using Modules.Estates.Domain.Entities.Setup.Property;
using Modules.Estates.Domain.Events;

namespace Modules.Estates.Application.UseCases.Management.Customer
{
    public partial class CustomerMasterService : ICustomerMasterService
    {

        public async Task<CustomerRegistrationResponseDto> UpdateCustomer(UpdateProspectiveCustomerDto values)
        {
            string _residentType = string.Empty;
            string _title = string.Empty;
            string _socialMediaPlatform = string.Empty;
            string _identificationType = string.Empty;

            try
            {
                CustomerMaster customer = await CustomerMaster.UpdateProspectiveAsync
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
                        modifiedBy: values.ModifiedBy!,
                        _domainService
                    );

                customer.ModifiedOn = DateTime.UtcNow;
                //customer.DebtorStatus = (int)DebtorStatusEnum.APPROVED;

                _unitOfWork.CustomerMaster.Update(customer);
                await _unitOfWork.Complete();

                foreach (var domainEvent in customer.DomainEvents)
                {
                    await _domainEventDispatcher.DispatchAsync(domainEvent);
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

        public async Task<int> StopCustomerDebitAsync(StopDebitRequestDto values)
        {
            if(values is null)
            {
                return 400;
            }

            //check if customer exist
            var customer = await _unitOfWork.CustomerMaster.Get(c => c.CustomerCode == values!.CustomerCode);
            if(customer is null)
            {
                return 404;
            }

            var debitDetails = new StopDebit
            {
                StopDebitId = 0,
                CustomerCode = values!.CustomerCode,
                PropertyNumber = values.PropertyNumber,
                DebtorStatus = values.DebtorStatus,
                ActionBy = values.ActionBy,
                ActionOn = DateTime.UtcNow
            };

            //update customer master
            customer!.DebtorStatus = values.DebtorStatus;
            customer.ModifiedBy = values.ActionBy;
            customer.ModifiedOn = DateTime.UtcNow;

            _unitOfWork.CustomerMaster.Update(customer);
            _unitOfWork.StopDebit.Insert(debitDetails);

            await _unitOfWork.Complete();

            return 200;

        }





    }
}

