﻿// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System.ComponentModel.DataAnnotations.Schema;

namespace Modules.Estates.Domain.Entities.Registration
{
    public partial class CustomerMaster : BaseEntity
    {
        private readonly List<DomainEvent> _domainEvents = new();

        [NotMapped]
        public IReadOnlyCollection<DomainEvent> DomainEvents => _domainEvents.AsReadOnly();

        [Key]
        public int CustomerMasterId { get; set; }

        [Required]
        public int CustomerTypeId { get; set; }

        [Required]
        public int ResidentTypeId { get; set; }

        [Required]
        public int LocalityId { get; set; }

        [Required]
        [StringLength(10)]
        public string? CustomerCode { get; set; }

        public int TitleId { get; set; }

        [StringLength(150)]
        public string? SurName { get; set; }

        [StringLength(75)]
        public string? OtherNames { get; set; }

        [StringLength(100)]
        public string? CompanyName { get; set; }

        public DateTime DateOfBirth { get; set; }

        [StringLength(20)]
        public string? TinNumber { get; set; }

        [StringLength(255)]
        public string? Picture { get; set; }

        public int GenderId { get; set; }

        public int NationalityId { get; set; }

        [StringLength(255)]
        public string? PostalAddress { get; set; }

        [StringLength(255)]
        public string? ResidentialAddress { get; set; }

        [StringLength(50)]
        public string? DigitalAddress { get; set; }

        [Required]
        [StringLength(12)]
        public string? PrimaryMobileNumber { get; set; }

        [StringLength(12)]
        public string? SecondaryMobileNumber { get; set; }

        [StringLength(12)]
        public string? OfficeNumber { get; set; }

        [StringLength(12)]
        public string? WhatsAppNumber { get; set; }

        [EmailAddress]
        [StringLength(255)]
        public string? EmailAddress { get; set; }

        [StringLength(30)]
        public string? ResidentPermitNumber { get; set; }

        public DateTime? ResidentPermitDateIssued { get; set; }

        public DateTime? ResidentPermitExpiryDate { get; set; }

        public int SocialMediaTypeId { get; set; }

        [StringLength(50)]
        public string? SocialMediaAccount { get; set; }

        public int IdentificationTypeId { get; set; }

        [StringLength(20)]
        public string? IdentificationTypeNumber { get; set; }

        [StringLength(255)]
        public string? IdentificationTypeImageOne { get; set; }

        [StringLength(255)]
        public string? IdentificationTypeImageTwo { get; set; }

        [StringLength(255)]
        public string? IdentificationTypeImageThree { get; set; }

        [StringLength(255)]
        public string? IdentificationTypeImageFour { get; set; }

        [StringLength(255)]
        public string? IdentificationTypeImageFive { get; set; }

        [StringLength(255)]
        public string? Comments { get; set; }

        [StringLength(255)]
        public string? InterestExpressed { get; set; }

        public int DebtorStatus { get; set; }

        [StringLength(10)]
        public string? ParentCode { get; set; }

        [StringLength(255)]
        public string? ContactPerson_FullName { get; set; }

        [StringLength(12)]
        public string? ContactPerson_PhoneNumber { get; set; }

        [StringLength(255)]
        [EmailAddress]
        public string? ContactPerson_EmailAddress { get; set; }

        [StringLength(255)]
        public string? ContactPerson_Address { get; set; }

        public int ContactPerson_IdentificationTypeId { get; set; }

        [StringLength(20)]
        public string? ContactPerson_IdentificationTypeNumber { get; set; }

        [StringLength(255)]
        public string? ContactPerson_IdentificationTypeImageOne { get; set; }

        [StringLength(255)]
        public string? ContactPerson_IdentificationTypeImageTwo { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsPrimary { get; set; }

        public string? MaritalStatus { get; set; }

        public DateTime? DateOfMarriage { get; set; }


        public CustomerMaster()
        {
        }

        public CustomerMaster(int customerMasterId, int customerTypeId, int residentTypeId, int localityId, string customerCode, string companyName, string businessRegistrationNumber, string tinNumber, string picture,
            int nationalityId, string postalAddress, string residentialAddress, string digitalAddress, string primaryMobileNumber, string secondaryMobileNumber, string officeNumber, string whatsAppNumber, string emailAddress, string residentPermitNumber,
            DateTime residentPermitDateIssued, DateTime residentPermitExpiryDate, int socialMediaTypeId, string socialMediaAccount, int identificationTypeId, string identificationTypeNumber, string identificationTypeImageOne, string identificationTypeImageTwo,
            string comments, string interestExpressed, int debtorStatus, string parentCode, string contactPerson_FullName, string contactPerson_PhoneNumber, string contactPerson_EmailAddress, string contactPerson_Address, int contactPerson_IdentificationTypeId,
            string contactPerson_IdentificationTypeNumber, string contactPerson_IdentificationTypeImage, bool isDeleted, bool isParent, string maritalStatus, DateTime dateOfMarriage, ICustomerDomainService customerDomainService)
        {
        }

        public static async Task<CustomerMaster> CreateProspectiveAsync(
            int customerMasterId,
            int customerTypeId,
            int residentTypeId,
            int localityId,
            string customerCode,
            int titleId,
            string surName,
            string otherNames,
            string companyName,
            string picture,
            int genderId,
            int nationalityId,
            string postalAddress,
            string residentialAddress,
            string digitalAddress,
            string primaryMobileNumber,
            string secondaryMobileNumber,
            string officeNumber,
            string whatsAppNumber,
            string emailAddress,
            int socialMediaTypeId,
            string socialMediaAccount,
            string comments,
            string interestExpressed,
            string createdBy,
            ICustomerDomainService customerDomainService)
        {

            if (customerTypeId <= 0 || localityId <= 0 || string.IsNullOrWhiteSpace(surName) && string.IsNullOrWhiteSpace(otherNames) && string.IsNullOrWhiteSpace(companyName) || string.IsNullOrWhiteSpace(primaryMobileNumber) || string.IsNullOrWhiteSpace(emailAddress) || string.IsNullOrWhiteSpace(interestExpressed))
            {
                throw new ArgumentException("Invalid prospective customer registration data.");
            }

            if (!await customerDomainService.CustomerTypeExists(customerTypeId))
                throw new ArgumentException(ErrorMessages.InvalidCustomerTypeId);

            if (residentTypeId > 0)
            {
                if (!await customerDomainService.ResidentTypeExists(residentTypeId))
                    throw new ArgumentException(ErrorMessages.InvalidResidentTypeId);
            }

            if (!await customerDomainService.LocalityExists(localityId))
                throw new ArgumentException(ErrorMessages.InvalidLocalityId);

            if (!await customerDomainService.GenderExists(genderId))
                throw new ArgumentException(ErrorMessages.InvalidGenderId);

            if (!await customerDomainService.NationalityExists(nationalityId))
                throw new ArgumentException(ErrorMessages.InvalidNationalityId);

            if (titleId > 0)
            {
                if (!await customerDomainService.TitleExists(titleId))
                    throw new ArgumentException(ErrorMessages.InvalidTitleId);
            }

            if (genderId <= 0)
            {
                throw new ArgumentException("Gender id must be greater than zero.");
            }

            if (nationalityId <= 0)
            {
                throw new ArgumentException("Nationality id must be greater than zero.");
            }

            if (socialMediaTypeId > 0)
            {
                if (!await customerDomainService.SocialMediaExists(socialMediaTypeId))
                    throw new ArgumentException(ErrorMessages.InvalidSocialMediaTypeId);
            }

            if (string.IsNullOrWhiteSpace(surName) && string.IsNullOrWhiteSpace(otherNames) && string.IsNullOrWhiteSpace(companyName))
            {
                throw new ArgumentException("Surname, othernames and company name cannot be null or empty");
            }

            if (string.IsNullOrWhiteSpace(primaryMobileNumber))
            {
                throw new ArgumentException("Primary mobile number must not be null or empty");
            }

            if (string.IsNullOrWhiteSpace(emailAddress))
            {
                throw new ArgumentException("Email address must not be null or empty");
            }

            if (string.IsNullOrWhiteSpace(interestExpressed))
            {
                throw new ArgumentException("Interest expressed must not be null or empty");
            }

            if (string.IsNullOrWhiteSpace(comments))
            {
                throw new ArgumentException("Comments must not be null or empty");
            }
            var customer_locality = await customerDomainService.GetLocalityDetails(localityId);
            var locality = await customerDomainService.LocalityExists(localityId);
            if (locality is false)
            {
                throw new ArgumentException("Customer locality provided does not exist");
            }

            string code = new Random().Next(0, 10000).ToString();

            string locality_customerCode = customer_locality.LocalityInitial!;
            string _customercode = $"{locality_customerCode}{code}";

            var customer = new CustomerMaster
            {
                CustomerMasterId = customerMasterId,
                CustomerTypeId = customerTypeId,
                ResidentTypeId = residentTypeId,
                LocalityId = localityId,
                CustomerCode = _customercode,
                TitleId = titleId,
                SurName = surName,
                OtherNames = otherNames,
                CompanyName = companyName,
                DateOfBirth = Convert.ToDateTime("1900-01-01"),
                TinNumber = string.Empty,
                Picture = picture,
                GenderId = genderId,
                NationalityId = nationalityId,
                PostalAddress = postalAddress,
                ResidentialAddress = residentialAddress,
                DigitalAddress = digitalAddress,
                PrimaryMobileNumber = primaryMobileNumber,
                SecondaryMobileNumber = secondaryMobileNumber,
                OfficeNumber = officeNumber,
                WhatsAppNumber = whatsAppNumber,
                EmailAddress = emailAddress,
                ResidentPermitNumber = string.Empty,
                ResidentPermitDateIssued = Convert.ToDateTime("1900-01-01"),
                ResidentPermitExpiryDate = Convert.ToDateTime("1900-01-01"),
                SocialMediaTypeId = socialMediaTypeId,
                SocialMediaAccount = socialMediaAccount,
                IdentificationTypeId = 0,
                IdentificationTypeNumber = string.Empty,
                IdentificationTypeImageOne = string.Empty,
                IdentificationTypeImageTwo = string.Empty,
                IdentificationTypeImageThree = string.Empty,
                IdentificationTypeImageFour = string.Empty,
                IdentificationTypeImageFive = string.Empty,
                Comments = comments,
                InterestExpressed = interestExpressed,
                DebtorStatus = 0,
                ParentCode = string.Empty,
                ContactPerson_FullName = string.Empty,
                ContactPerson_PhoneNumber = string.Empty,
                ContactPerson_EmailAddress = string.Empty,
                ContactPerson_Address = string.Empty,
                ContactPerson_IdentificationTypeId = 0,
                ContactPerson_IdentificationTypeNumber = string.Empty,
                ContactPerson_IdentificationTypeImageOne = string.Empty,
                ContactPerson_IdentificationTypeImageTwo = string.Empty,
                IsDeleted = false,
                CreatedBy = createdBy
            };

            customer._domainEvents.Add(new CustomerCreatedEvent(
                customerMasterId,
                _customercode,
                "Prospective",
                createdBy));

            return customer;

        }

        public static async Task<CustomerMaster> CreateCompanyAsync(int customerMasterId, int customerTypeId, int residentTypeId, int localityId, string customerCode, string companyName, int nationalityId, string companyAddress, string digitalAddress, string primaryMobileNumber,
                                                                    string secondaryMobileNumber, string officeNumber, string whatsAppNumber, string emailAddress, string businessRegistrationNumber, string tinNumber, int socialMediaTypeId, string socialMediaAccount,
                                                                    string identificationTypeImageOne, string identificationTypeImageTwo, string identificationTypeImageThree, string identificationTypeImageFour, string identificationTypeImageFive,
                                                                    string contactPerson_FullName, string contactPerson_PhoneNumber, string contactPerson_EmailAddress, string contactPerson_Address, int contactPerson_IdentificationTypeId, string contactPerson_IdentificationTypeNumber,
                                                                    string contactPerson_IdentificationTypeImageOne, string contactPerson_IdentificationTypeImageTwo, string comments, bool isDeleted, bool isPrimary, ICustomerDomainService customerDomainService)
        {
            if (customerTypeId <= 0 || localityId <= 0 || nationalityId <= 0 || string.IsNullOrWhiteSpace(companyName) || string.IsNullOrWhiteSpace(companyAddress) || string.IsNullOrWhiteSpace(primaryMobileNumber) || string.IsNullOrWhiteSpace(emailAddress))
            {
                throw new ArgumentException("Invalid company customer registration data.");
            }

            if (!await customerDomainService.CustomerTypeExists(customerTypeId))
                throw new ArgumentException("Invalid customer type id.");

            if (residentTypeId > 0)
            {
                if (!await customerDomainService.ResidentTypeExists(residentTypeId))
                    throw new ArgumentException("Invalid resident type id.");

            }

            if (!await customerDomainService.LocalityExists(localityId))
                throw new ArgumentException("Invalid locality id.");


            if (!await customerDomainService.NationalityExists(nationalityId))
                throw new ArgumentException("Invalid nationality id.");


            if (string.IsNullOrWhiteSpace(companyName))
            {
                throw new ArgumentException("Company name cannot be null or empty");
            }

            if (string.IsNullOrWhiteSpace(companyAddress))
            {
                throw new ArgumentException("Company address cannot be null or empty");
            }

            if (string.IsNullOrWhiteSpace(businessRegistrationNumber))
            {
                throw new ArgumentException("Business registration number cannot be null or empty");
            }

            if (string.IsNullOrWhiteSpace(tinNumber))
            {
                throw new ArgumentException("Tin number cannot be null or empty");
            }

            if (socialMediaTypeId > 0)
            {
                if (!await customerDomainService.SocialMediaExists(socialMediaTypeId))
                    throw new ArgumentException("Invalid social media type id.");
            }

            if (string.IsNullOrWhiteSpace(companyAddress))
            {
                throw new ArgumentException("Company address must not be null or empty");
            }

            if (string.IsNullOrWhiteSpace(primaryMobileNumber))
            {
                throw new ArgumentException("Primary mobile number must not be null or empty");
            }

            if (string.IsNullOrWhiteSpace(emailAddress))
            {
                throw new ArgumentException("Email address must not be null or empty");
            }

            var customer_locality = await customerDomainService.GetLocalityDetails(localityId);

            if (customer_locality is null)
            {
                throw new ArgumentException("Customer locality provided does not exist");
            }


            int counter = customer_locality.CustomerCodeCounter;
            counter++;

            string incrementedNumber = counter.ToString("D4");
            string locality_customerCode = customer_locality.CustomerCode!;
            string _customercode = $"{locality_customerCode}{incrementedNumber}";


            return new CustomerMaster
            {
                CustomerMasterId = customerMasterId,
                CustomerTypeId = customerTypeId,
                ResidentTypeId = residentTypeId,
                LocalityId = localityId,
                CustomerCode = _customercode,
                TitleId = 0,
                SurName = string.Empty,
                OtherNames = string.Empty,
                CompanyName = companyName,
                DateOfBirth = Convert.ToDateTime("1900-01-01"),
                TinNumber = tinNumber,
                Picture = string.Empty,
                GenderId = 0,
                NationalityId = nationalityId,
                PostalAddress = companyAddress,
                ResidentialAddress = companyAddress,
                DigitalAddress = digitalAddress,
                PrimaryMobileNumber = primaryMobileNumber,
                SecondaryMobileNumber = secondaryMobileNumber,
                OfficeNumber = officeNumber,
                WhatsAppNumber = whatsAppNumber,
                EmailAddress = emailAddress,
                ResidentPermitNumber = string.Empty,
                ResidentPermitDateIssued = Convert.ToDateTime("1900-01-01"),
                ResidentPermitExpiryDate = Convert.ToDateTime("1900-01-01"),
                SocialMediaTypeId = socialMediaTypeId,
                SocialMediaAccount = socialMediaAccount,
                IdentificationTypeId = 0,
                IdentificationTypeNumber = businessRegistrationNumber,
                IdentificationTypeImageOne = identificationTypeImageOne,
                IdentificationTypeImageTwo = identificationTypeImageTwo,
                IdentificationTypeImageThree = identificationTypeImageThree,
                IdentificationTypeImageFour = identificationTypeImageFour,
                IdentificationTypeImageFive = identificationTypeImageFive,
                Comments = comments,
                InterestExpressed = string.Empty,
                DebtorStatus = 0,
                ParentCode = string.Empty,
                ContactPerson_FullName = contactPerson_FullName,
                ContactPerson_PhoneNumber = contactPerson_PhoneNumber,
                ContactPerson_EmailAddress = contactPerson_EmailAddress,
                ContactPerson_Address = contactPerson_Address,
                ContactPerson_IdentificationTypeId = contactPerson_IdentificationTypeId,
                ContactPerson_IdentificationTypeNumber = contactPerson_IdentificationTypeNumber,
                ContactPerson_IdentificationTypeImageOne = contactPerson_IdentificationTypeImageOne,
                ContactPerson_IdentificationTypeImageTwo = contactPerson_IdentificationTypeImageTwo,
                IsDeleted = false,
                IsPrimary = true,
                MaritalStatus = string.Empty,
                DateOfMarriage = Convert.ToDateTime("1900-01-01")
            };


        }



        public static async Task<CustomerMaster> CreateIndividualAsync(int customerMasterId, int customerTypeId, int residentTypeId, int localityId, string customerCode, int titleId, string surName, string otherNames, DateTime dateOfBirth, string tinNumber, string picture, int genderId,
                                                                       int nationalityId, string postalAddress, string residentialAddress, string digitalAddress, string primaryMobileNumber, string secondaryMobileNumber, string officeNumber, string whatsAppNumber, string emailAddress,
                                                                       string residentPermitNumber, DateTime? residentPermitDateIssued, DateTime? residentPermitExpiryDate, int socialMediaTypeId, string socialMediaAccount, int identificationTypeId, string identificationTypeNumber,
                                                                       string identificationTypeImageOne, string identificationTypeImageTwo, string identificationTypeImageThree, string identificationTypeImageFour, string identificationTypeImageFive, string comments, string interestExpressed, int debtorStatus, string parentCode, string contactPerson_FullName, string contactPerson_PhoneNumber,
                                                                       string contactPerson_EmailAddress, string contactPerson_Address, int contactPerson_IdentificationTypeId, string contactPerson_IdentificationTypeNumber, string contactPerson_IdentificationTypeImageOne, string contactPerson_IdentificationTypeImageTwo, bool isDeleted, bool isPrimary, ICustomerDomainService customerDomainService)
        {
            if (customerTypeId <= 0 || residentTypeId <= 0 || localityId <= 0 || nationalityId <= 0 || identificationTypeId <= 0 || string.IsNullOrWhiteSpace(surName) || string.IsNullOrWhiteSpace(otherNames) || string.IsNullOrWhiteSpace(identificationTypeNumber) || string.IsNullOrWhiteSpace(primaryMobileNumber) || string.IsNullOrWhiteSpace(emailAddress))
            {
                throw new ArgumentException("Invalid individual customer registration data.");
            }

            if (!await customerDomainService.CustomerTypeExists(customerTypeId))
                throw new ArgumentException("Invalid customer type id.");

            if (!await customerDomainService.ResidentTypeExists(residentTypeId))
                throw new ArgumentException("Invalid resident type id.");

            if (!await customerDomainService.LocalityExists(localityId))
                throw new ArgumentException("Invalid locality id.");

            if (!await customerDomainService.GenderExists(genderId))
                throw new ArgumentException("Invalid gender id.");

            if (!await customerDomainService.NationalityExists(nationalityId))
                throw new ArgumentException("Invalid nationality id.");

            if (!await customerDomainService.IdentificationTypeExists(identificationTypeId))
                throw new ArgumentException("Invalid identification type id.");


            if ((int)ResidentTypeEnum.NON_RESIDENT == residentTypeId)
            {
                if (string.IsNullOrWhiteSpace(contactPerson_FullName))
                {
                    throw new ArgumentException("Contact person's fullName cannot be null or empty");
                }

                if (string.IsNullOrWhiteSpace(contactPerson_PhoneNumber))
                {
                    throw new ArgumentException("Contact person's phone number cannot be null or empty");
                }

                if (string.IsNullOrWhiteSpace(contactPerson_EmailAddress))
                {
                    throw new ArgumentException("Contact person's email address cannot be null or empty");
                }

                if (string.IsNullOrWhiteSpace(contactPerson_Address))
                {
                    throw new ArgumentException("Contact person's address cannot be null or empty");
                }

                if (contactPerson_IdentificationTypeId <= 0)
                {
                    throw new ArgumentException("Contact person identification type id must be greater than zero.");
                }

                if (string.IsNullOrWhiteSpace(contactPerson_IdentificationTypeNumber))
                {
                    throw new ArgumentException("Contact person identification type number cannot be null or empty");
                }

                if (string.IsNullOrWhiteSpace(contactPerson_IdentificationTypeImageOne))
                {
                    throw new ArgumentException("Contact person identification type image cannot be null or empty");
                }

            }


            if ((int)ResidentTypeEnum.EXPATRIATE == residentTypeId)
            {
                if (string.IsNullOrWhiteSpace(residentPermitNumber))
                {
                    throw new ArgumentException("Resident permit number cannot be null or empty");
                }

                if (residentPermitDateIssued == DateTime.MinValue)
                {
                    throw new ArgumentException("Date of birth must not be an invalid date.");
                }

                if (residentPermitExpiryDate == DateTime.MinValue)
                {
                    throw new ArgumentException("Date of birth must not be an invalid date.");
                }

            }

            if (titleId > 0)
            {
                if (!await customerDomainService.TitleExists(titleId))
                    throw new ArgumentException("Invalid title id.");
            }

            if (genderId <= 0)
            {
                throw new ArgumentException("Gender id must be greater than zero.");
            }

            if (nationalityId <= 0)
            {
                throw new ArgumentException("Nationality id must be greater than zero.");
            }

            if (socialMediaTypeId > 0)
            {
                if (!await customerDomainService.SocialMediaExists(socialMediaTypeId))
                    throw new ArgumentException("Invalid social media type id.");
            }

            if (identificationTypeId <= 0)
            {
                throw new ArgumentException("Identification Type id must be greater than zero.");
            }

            if (string.IsNullOrWhiteSpace(surName) || string.IsNullOrWhiteSpace(otherNames))
            {
                throw new ArgumentException("Surname and othernames cannot be null or empty");
            }

            if (dateOfBirth == DateTime.MinValue)
            {
                throw new ArgumentException("Date of birth must not be an invalid date.");
            }

            if (string.IsNullOrWhiteSpace(postalAddress))
            {
                throw new ArgumentException("Postal address must not be null or empty");
            }

            if (string.IsNullOrWhiteSpace(residentialAddress))
            {
                throw new ArgumentException("Residential address must not be null or empty");
            }

            if (string.IsNullOrWhiteSpace(primaryMobileNumber))
            {
                throw new ArgumentException("Primary mobile number must not be null or empty");
            }

            if (string.IsNullOrWhiteSpace(emailAddress))
            {
                throw new ArgumentException("Email address must not be null or empty");
            }


            var customer_locality = await customerDomainService.GetLocalityDetails(localityId);

            if (customer_locality is null)
            {
                throw new ArgumentException("Customer locality provided does not exist");
            }


            int counter = customer_locality.CustomerCodeCounter;
            counter++;

            string incrementedNumber = counter.ToString("D4");
            string locality_customerCode = customer_locality.CustomerCode!;
            string _customercode = $"{locality_customerCode}{incrementedNumber}";


            return new CustomerMaster
            {
                CustomerMasterId = customerMasterId,
                CustomerTypeId = customerTypeId,
                ResidentTypeId = residentTypeId,
                LocalityId = localityId,
                CustomerCode = _customercode,
                TitleId = titleId,
                SurName = surName,
                OtherNames = otherNames,
                CompanyName = string.Empty,
                DateOfBirth = dateOfBirth,
                TinNumber = tinNumber,
                Picture = picture,
                GenderId = genderId,
                NationalityId = nationalityId,
                PostalAddress = postalAddress,
                ResidentialAddress = residentialAddress,
                DigitalAddress = digitalAddress,
                PrimaryMobileNumber = primaryMobileNumber,
                SecondaryMobileNumber = secondaryMobileNumber,
                OfficeNumber = officeNumber,
                WhatsAppNumber = whatsAppNumber,
                EmailAddress = emailAddress,
                ResidentPermitNumber = residentPermitNumber,
                ResidentPermitDateIssued = residentPermitDateIssued,
                ResidentPermitExpiryDate = residentPermitExpiryDate,
                SocialMediaTypeId = socialMediaTypeId,
                SocialMediaAccount = socialMediaAccount,
                IdentificationTypeId = identificationTypeId,
                IdentificationTypeNumber = identificationTypeNumber,
                IdentificationTypeImageOne = identificationTypeImageOne,
                IdentificationTypeImageTwo = identificationTypeImageTwo,
                IdentificationTypeImageThree = identificationTypeImageThree,
                IdentificationTypeImageFour = identificationTypeImageFour,
                IdentificationTypeImageFive = identificationTypeImageFive,
                Comments = comments,
                InterestExpressed = interestExpressed,
                DebtorStatus = debtorStatus,
                ParentCode = parentCode,
                ContactPerson_FullName = contactPerson_FullName,
                ContactPerson_PhoneNumber = contactPerson_PhoneNumber,
                ContactPerson_EmailAddress = contactPerson_EmailAddress,
                ContactPerson_Address = contactPerson_Address,
                ContactPerson_IdentificationTypeId = contactPerson_IdentificationTypeId,
                ContactPerson_IdentificationTypeNumber = contactPerson_IdentificationTypeNumber,
                ContactPerson_IdentificationTypeImageOne = contactPerson_IdentificationTypeImageOne,
                ContactPerson_IdentificationTypeImageTwo = contactPerson_IdentificationTypeImageTwo,
                IsDeleted = false,
                IsPrimary = true,
                MaritalStatus = string.Empty,
                DateOfMarriage = Convert.ToDateTime("1900-01-01")
            };
        }




        public static async Task<CustomerMaster> CreateJointAsync(int customerMasterId, int customerTypeId, int residentTypeId, int localityId, string customerCode, int titleId, string surName, string otherNames, DateTime dateOfBirth, string tinNumber, string picture, int genderId,
                                                               int nationalityId, string postalAddress, string residentialAddress, string digitalAddress, string primaryMobileNumber, string secondaryMobileNumber, string officeNumber, string whatsAppNumber, string emailAddress,
                                                               string residentPermitNumber, DateTime? residentPermitDateIssued, DateTime? residentPermitExpiryDate, int socialMediaTypeId, string socialMediaAccount, int identificationTypeId, string identificationTypeNumber,
                                                               string identificationTypeImageOne, string identificationTypeImageTwo, string identificationTypeImageThree, string identificationTypeImageFour, string identificationTypeImageFive, string comments, string interestExpressed, string parentCode, string contactPerson_FullName, string contactPerson_PhoneNumber,
                                                               string contactPerson_EmailAddress, string contactPerson_Address, int contactPerson_IdentificationTypeId, string contactPerson_IdentificationTypeNumber, string contactPerson_IdentificationTypeImageOne,
                                                               string contactPerson_IdentificationTypeImageTwo, bool isDeleted, bool isPrimary, string maritalStatus, DateTime? dateOfMarriage, ICustomerDomainService customerDomainService)
        {
            if (customerTypeId <= 0 || residentTypeId <= 0 || localityId <= 0 || nationalityId <= 0 || identificationTypeId <= 0 || string.IsNullOrWhiteSpace(surName) || string.IsNullOrWhiteSpace(otherNames) || string.IsNullOrWhiteSpace(identificationTypeNumber) || string.IsNullOrWhiteSpace(primaryMobileNumber) || string.IsNullOrWhiteSpace(emailAddress))
            {
                throw new ArgumentException("Invalid customer registration data.");
            }

            if (!await customerDomainService.CustomerTypeExists(customerTypeId))
                throw new ArgumentException("Invalid customer type id.");

            if (!await customerDomainService.ResidentTypeExists(residentTypeId))
                throw new ArgumentException("Invalid resident type id.");

            if (!await customerDomainService.LocalityExists(localityId))
                throw new ArgumentException("Invalid locality id.");

            if (!await customerDomainService.GenderExists(genderId))
                throw new ArgumentException("Invalid gender id.");

            if (!await customerDomainService.NationalityExists(nationalityId))
                throw new ArgumentException("Invalid nationality id.");

            if (!await customerDomainService.IdentificationTypeExists(identificationTypeId))
                throw new ArgumentException("Invalid identification type id.");


            if ((int)ResidentTypeEnum.NON_RESIDENT == residentTypeId)
            {
                if (string.IsNullOrWhiteSpace(contactPerson_FullName))
                {
                    throw new ArgumentException("Contact person's fullName cannot be null or empty");
                }

                if (string.IsNullOrWhiteSpace(contactPerson_PhoneNumber))
                {
                    throw new ArgumentException("Contact person phone number cannot be null or empty");
                }

                if (string.IsNullOrWhiteSpace(contactPerson_EmailAddress))
                {
                    throw new ArgumentException("Contact person email address cannot be null or empty");
                }

                if (string.IsNullOrWhiteSpace(contactPerson_Address))
                {
                    throw new ArgumentException("Contact person address cannot be null or empty");
                }

                if (contactPerson_IdentificationTypeId <= 0)
                {
                    throw new ArgumentException("Contact person identification type id must be greater than zero.");
                }

                if (string.IsNullOrWhiteSpace(contactPerson_IdentificationTypeNumber))
                {
                    throw new ArgumentException("contact person identification type number cannot be null or empty");
                }


                if (string.IsNullOrWhiteSpace(contactPerson_IdentificationTypeImageOne))
                {
                    throw new ArgumentException("Contact person identification type image cannot be null or empty");
                }

            }


            if ((int)ResidentTypeEnum.EXPATRIATE == residentTypeId)
            {
                if (string.IsNullOrWhiteSpace(residentPermitNumber))
                {
                    throw new ArgumentException("Resident permit number cannot be null or empty");
                }

                if (residentPermitDateIssued == DateTime.MinValue)
                {
                    throw new ArgumentException("Date of birth must not be an invalid date.");
                }

                if (residentPermitExpiryDate == DateTime.MinValue)
                {
                    throw new ArgumentException("Date of birth must not be an invalid date.");
                }

            }

            if (titleId > 0)
            {
                if (!await customerDomainService.TitleExists(titleId))
                    throw new ArgumentException("Invalid title id.");
            }

            if (genderId <= 0)
            {
                throw new ArgumentException("Gender id must be greater than zero.");
            }

            if (nationalityId <= 0)
            {
                throw new ArgumentException("Nationality id must be greater than zero.");
            }

            if (socialMediaTypeId > 0)
            {
                if (!await customerDomainService.SocialMediaExists(socialMediaTypeId))
                    throw new ArgumentException("Invalid social media type id.");
            }

            if (identificationTypeId <= 0)
            {
                throw new ArgumentException("Identification Type id must be greater than zero.");
            }

            if (string.IsNullOrWhiteSpace(surName) || string.IsNullOrWhiteSpace(otherNames))
            {
                throw new ArgumentException("Surname and othernames cannot be null or empty");
            }

            if (dateOfBirth == DateTime.MinValue)
            {
                throw new ArgumentException("Date of birth must not be an invalid date.");
            }

            if (string.IsNullOrWhiteSpace(postalAddress))
            {
                throw new ArgumentException("Postal address must not be null or empty");
            }

            if (string.IsNullOrWhiteSpace(residentialAddress))
            {
                throw new ArgumentException("Residential address must not be null or empty");
            }

            if (string.IsNullOrWhiteSpace(primaryMobileNumber))
            {
                throw new ArgumentException("Primary mobile number must not be null or empty");
            }

            if (string.IsNullOrWhiteSpace(emailAddress))
            {
                throw new ArgumentException("Email address must not be null or empty");
            }


            var customer_locality = await customerDomainService.GetLocalityDetails(localityId);

            if (customer_locality is null)
            {
                throw new ArgumentException("Customer locality provided does not exist");
            }


            int counter = customer_locality.CustomerCodeCounter;
            counter++;

            string incrementedNumber = counter.ToString("D4");
            string locality_customerCode = customer_locality.CustomerCode!;
            string _customercode = $"{locality_customerCode}{incrementedNumber}";


            return new CustomerMaster
            {
                CustomerMasterId = customerMasterId,
                CustomerTypeId = customerTypeId,
                ResidentTypeId = residentTypeId,
                LocalityId = localityId,
                CustomerCode = _customercode,
                TitleId = titleId,
                SurName = surName,
                OtherNames = otherNames,
                CompanyName = string.Empty,
                DateOfBirth = dateOfBirth,
                TinNumber = tinNumber,
                Picture = picture,
                GenderId = genderId,
                NationalityId = nationalityId,
                PostalAddress = postalAddress,
                ResidentialAddress = residentialAddress,
                DigitalAddress = digitalAddress,
                PrimaryMobileNumber = primaryMobileNumber,
                SecondaryMobileNumber = secondaryMobileNumber,
                OfficeNumber = officeNumber,
                WhatsAppNumber = whatsAppNumber,
                EmailAddress = emailAddress,
                ResidentPermitNumber = residentPermitNumber,
                ResidentPermitDateIssued = residentPermitDateIssued,
                ResidentPermitExpiryDate = residentPermitExpiryDate,
                SocialMediaTypeId = socialMediaTypeId,
                SocialMediaAccount = socialMediaAccount,
                IdentificationTypeId = identificationTypeId,
                IdentificationTypeNumber = identificationTypeNumber,
                IdentificationTypeImageOne = identificationTypeImageOne,
                IdentificationTypeImageTwo = identificationTypeImageTwo,
                IdentificationTypeImageThree = identificationTypeImageThree,
                IdentificationTypeImageFour = identificationTypeImageFour,
                IdentificationTypeImageFive = identificationTypeImageFive,
                Comments = comments,
                InterestExpressed = interestExpressed,
                DebtorStatus = 1,
                ParentCode = parentCode,
                ContactPerson_FullName = contactPerson_FullName,
                ContactPerson_PhoneNumber = contactPerson_PhoneNumber,
                ContactPerson_EmailAddress = contactPerson_EmailAddress,
                ContactPerson_Address = contactPerson_Address,
                ContactPerson_IdentificationTypeId = contactPerson_IdentificationTypeId,
                ContactPerson_IdentificationTypeNumber = contactPerson_IdentificationTypeNumber,
                ContactPerson_IdentificationTypeImageOne = contactPerson_IdentificationTypeImageOne,
                ContactPerson_IdentificationTypeImageTwo = contactPerson_IdentificationTypeImageTwo,
                IsDeleted = false,
                IsPrimary = isPrimary,
                MaritalStatus = maritalStatus,
                DateOfMarriage = dateOfMarriage
            };
        }

        //public void UpdateContactInformation(
        //    string postalAddress,
        //    string residentialAddress,
        //    string digitalAddress,
        //    string primaryMobileNumber,
        //    string secondaryMobileNumber,
        //    string officeNumber,
        //    string whatsAppNumber,
        //    string emailAddress,
        //    string updatedBy)
        //{
        //    PostalAddress = postalAddress;
        //    ResidentialAddress = residentialAddress;
        //    DigitalAddress = digitalAddress;
        //    PrimaryMobileNumber = primaryMobileNumber;
        //    SecondaryMobileNumber = secondaryMobileNumber;
        //    OfficeNumber = officeNumber;
        //    WhatsAppNumber = whatsAppNumber;
        //    EmailAddress = emailAddress;
        //    ModifiedOn = DateTime.UtcNow;

        //    _domainEvents.Add(new CustomerUpdatedEvent(
        //        CustomerMasterId,
        //        CustomerCode,
        //        updatedBy,
        //        "ContactInformation"));
        //}

        //public void UpdateStatus(int newStatus, string changedBy)
        //{
        //    var oldStatus = DebtorStatus;
        //    DebtorStatus = newStatus;
        //    ModifiedOn = DateTime.UtcNow;

        //    _domainEvents.Add(new CustomerStatusChangedEvent(
        //        CustomerMasterId,
        //        CustomerCode,
        //        oldStatus.ToString(),
        //        newStatus.ToString(),
        //        changedBy));
        //}

        public void Delete(string deletedBy, string reason)
        {
            IsDeleted = true;
            ModifiedOn = DateTime.UtcNow;

            _domainEvents.Add(new CustomerDeletedEvent(
                CustomerMasterId,
                CustomerCode!,
                deletedBy,
                reason));
        }

        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }
    }
}

