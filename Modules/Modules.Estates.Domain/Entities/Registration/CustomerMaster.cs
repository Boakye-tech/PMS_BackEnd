using System;
using Modules.Estates.Domain.Entities.Setup.Property;
using Modules.Estates.Domain.Enums;
using Modules.Estates.Domain.Interfaces.DomainServices;

namespace Modules.Estates.Domain.Entities.Registration
{
	public class CustomerMaster : BaseEntity
	{
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

        public DateTime ResidentPermitDateIssued { get; set; }

        public DateTime ResidentPermitExpiryDate { get; set; }

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

        [StringLength(12)]
        public string? ContactPerson_Address { get; set; }

        public int ContactPerson_IdentificationTypeId { get; set; }

        [StringLength(20)]
        public string? ContactPerson_IdentificationTypeNumber { get; set; }

        [StringLength(255)]
        public string? ContactPerson_IdentificationTypeImage { get; set; }

        public bool IsDeleted { get; set; }


        public CustomerMaster()
		{
		}

        public CustomerMaster(int customerMasterId, int customerTypeId, int residentTypeId, int localityId, string customerCode, string companyName, string businessRegistrationNumber, string tinNumber, string picture, 
            int nationalityId, string postalAddress, string residentialAddress, string digitalAddress, string primaryMobileNumber, string secondaryMobileNumber, string officeNumber, string whatsAppNumber, string emailAddress, string residentPermitNumber,
            DateTime residentPermitDateIssued, DateTime residentPermitExpiryDate, int socialMediaTypeId, string socialMediaAccount, int identificationTypeId, string identificationTypeNumber, string identificationTypeImageOne, string identificationTypeImageTwo,
            string comments, string interestExpressed, int debtorStatus, string parentCode, string contactPerson_FullName, string contactPerson_PhoneNumber, string contactPerson_EmailAddress, string contactPerson_Address, int contactPerson_IdentificationTypeId,
            string contactPerson_IdentificationTypeNumber, string contactPerson_IdentificationTypeImage, bool isDeleted, ICustomerDomainService customerDomainService)
        {
        }


        public static async Task<CustomerMaster> CreateProspectiveAsync(int customerMasterId, int customerTypeId, int residentTypeId, int localityId, string customerCode, int titleId, string surName, string otherNames, string companyName, string picture, int genderId,
                                                                        int nationalityId, string postalAddress, string residentialAddress, string digitalAddress, string primaryMobileNumber, string secondaryMobileNumber, string officeNumber, string whatsAppNumber, string emailAddress, 
                                                                        int socialMediaTypeId, string socialMediaAccount, string comments, string interestExpressed, string CreatedBy,  ICustomerDomainService customerDomainService)
        {
            if (customerTypeId <= 0 || residentTypeId <= 0 || localityId <= 0 || string.IsNullOrWhiteSpace(surName) && string.IsNullOrWhiteSpace(otherNames) && string.IsNullOrWhiteSpace(companyName) || string.IsNullOrWhiteSpace(primaryMobileNumber)|| string.IsNullOrWhiteSpace(emailAddress) || string.IsNullOrWhiteSpace(interestExpressed))
            {
                throw new ArgumentException("Invalid prospective customer registration data.");
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
           


            //if (customerTypeId <= 0)
            //{
            //    throw new ArgumentException("Customer type id must be greater than zero.");
            //}

            //if (residentTypeId <= 0)
            //{
            //    throw new ArgumentException("Resident type id must be greater than zero.");
            //}

            //if (localityId <= 0)
            //{
            //    throw new ArgumentException("Locality id must be greater than zero.");
            //}

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

            if(string.IsNullOrWhiteSpace(interestExpressed))
            {
                throw new ArgumentException("Interest expressed must not be null or empty");
            }

            if (string.IsNullOrWhiteSpace(comments))
            {
                throw new ArgumentException("Comments must not be null or empty");
            }

            var customer_locality = await customerDomainService.GetLocalityDetails(localityId);

            if (customer_locality is null)
            {
                throw new ArgumentException("Customer locality provided does not exist");
            }


            //int counter = customer_locality.CustomerCodeCounter;
            //counter++;

            //string incrementedNumber = counter.ToString("D4");

            int code = new Random().Next(1000, 10000000);


            string locality_customerCode = customer_locality.LocalityInitial!;
            string _customercode = $"{locality_customerCode}{code}";


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
                ContactPerson_IdentificationTypeImage = string.Empty,
                IsDeleted = false
            };




        }


        public static async Task<CustomerMaster> CreateCompanyAsync(int customerMasterId, int customerTypeId, int residentTypeId, int localityId, string customerCode, string companyName, int nationalityId, string companyAddress, string digitalAddress, string primaryMobileNumber,
                                                                    string secondaryMobileNumber,string officeNumber, string whatsAppNumber, string emailAddress, string businessRegistrationNumber, string tinNumber,int socialMediaTypeId, string socialMediaAccount,
                                                                    string contactPerson_FullName, string contactPerson_PhoneNumber, string contactPerson_EmailAddress, string contactPerson_Address, int contactPerson_IdentificationTypeId,string contactPerson_IdentificationTypeNumber,
                                                                    string contactPerson_IdentificationTypeImage, string comments, bool isDeleted, ICustomerDomainService customerDomainService)
        {
            if (customerTypeId <= 0 || residentTypeId <= 0 || localityId <= 0 || nationalityId <= 0 || string.IsNullOrWhiteSpace(companyName) || string.IsNullOrWhiteSpace(companyAddress) || string.IsNullOrWhiteSpace(primaryMobileNumber) || string.IsNullOrWhiteSpace(emailAddress))
            {
                throw new ArgumentException("Invalid company customer registration data.");
            }

            if (!await customerDomainService.CustomerTypeExists(customerTypeId))
                throw new ArgumentException("Invalid customer type id.");

            if (!await customerDomainService.ResidentTypeExists(residentTypeId))
                throw new ArgumentException("Invalid resident type id.");

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

            if (customerTypeId <= 0)
            {
                throw new ArgumentException("Customer type id must be greater than zero.");
            }

            if (residentTypeId <= 0)
            {
                throw new ArgumentException("Resident type id must be greater than zero.");
            }

            if (localityId <= 0)
            {
                throw new ArgumentException("Locality id must be greater than zero.");
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
                ResidentPermitNumber = companyAddress,
                ResidentPermitDateIssued = Convert.ToDateTime("1900-01-01"),
                ResidentPermitExpiryDate = Convert.ToDateTime("1900-01-01"),
                SocialMediaTypeId = socialMediaTypeId,
                SocialMediaAccount = socialMediaAccount,
                IdentificationTypeId = 0,
                IdentificationTypeNumber = businessRegistrationNumber,
                IdentificationTypeImageOne = string.Empty,
                IdentificationTypeImageTwo = string.Empty,
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
                ContactPerson_IdentificationTypeImage = contactPerson_IdentificationTypeImage,
                IsDeleted = false

            };




        }



        public static async Task<CustomerMaster> CreateIndividualAsync(int customerMasterId, int customerTypeId, int residentTypeId, int localityId, string customerCode, int titleId, string surName, string otherNames, DateTime dateOfBirth, string tinNumber, string picture, int genderId,
                                                                       int nationalityId, string postalAddress, string residentialAddress, string digitalAddress, string primaryMobileNumber, string secondaryMobileNumber, string officeNumber, string whatsAppNumber, string emailAddress,
                                                                       string residentPermitNumber,DateTime residentPermitDateIssued, DateTime residentPermitExpiryDate, int socialMediaTypeId, string socialMediaAccount, int identificationTypeId, string identificationTypeNumber,
                                                                       string identificationTypeImageOne, string identificationTypeImageTwo,string comments, string interestExpressed, int debtorStatus, string parentCode, string contactPerson_FullName, string contactPerson_PhoneNumber,
                                                                       string contactPerson_EmailAddress, string contactPerson_Address, int contactPerson_IdentificationTypeId,string contactPerson_IdentificationTypeNumber, string contactPerson_IdentificationTypeImage, ICustomerDomainService customerDomainService)
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
                    throw new ArgumentException("Contact person phone number cannot be null or empty");
                }

                if (string.IsNullOrWhiteSpace(contactPerson_EmailAddress))
                {
                    throw new ArgumentException("Company name cannot be null or empty");
                }

                if (string.IsNullOrWhiteSpace(contactPerson_Address))
                {
                    throw new ArgumentException("Company name cannot be null or empty");
                }

                if (contactPerson_IdentificationTypeId <= 0)
                {
                    throw new ArgumentException("Identification Type id must be greater than zero.");
                }

                if (string.IsNullOrWhiteSpace(contactPerson_IdentificationTypeNumber))
                {
                    throw new ArgumentException("Company name cannot be null or empty");
                }


                if (string.IsNullOrWhiteSpace(contactPerson_IdentificationTypeImage))
                {
                    throw new ArgumentException("Company name cannot be null or empty");
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

            //if (customerTypeId <= 0)
            //{
            //    throw new ArgumentException("Customer type id must be greater than zero.");
            //}

            //if (residentTypeId <= 0)
            //{
            //    throw new ArgumentException("Resident type id must be greater than zero.");
            //}

            //if (localityId <= 0)
            //{
            //    throw new ArgumentException("Locality id must be greater than zero.");
            //}

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
                ContactPerson_IdentificationTypeImage = contactPerson_IdentificationTypeImage,
                IsDeleted = false

            };




        }


        public static async Task<CustomerMaster> CreateUpdateAsync(int customerMasterId, int customerTypeId, int residentTypeId, int localityId, string customerCode, int titleId, string surName, string otherNames, string companyName, DateTime dateOfBirth, string tinNumber, string picture, int genderId,
            int nationalityId, string postalAddress, string residentialAddress, string digitalAddress, string primaryMobileNumber, string secondaryMobileNumber, string officeNumber, string whatsAppNumber, string emailAddress, string residentPermitNumber,
            DateTime residentPermitDateIssued, DateTime residentPermitExpiryDate, int socialMediaTypeId, string socialMediaAccount, int identificationTypeId, string identificationTypeNumber, string identificationTypeImageOne, string identificationTypeImageTwo,
            string comments, string interestExpressed, int debtorStatus, string parentCode, string contactPerson_FullName, string contactPerson_PhoneNumber, string contactPerson_EmailAddress, string contactPerson_Address, int contactPerson_IdentificationTypeId,
            string contactPerson_IdentificationTypeNumber, string contactPerson_IdentificationTypeImage, bool isDeleted, ICustomerDomainService customerDomainService)
        {
            if (customerTypeId <= 0 || residentTypeId <= 0 || localityId <= 0 || nationalityId <= 0 || identificationTypeId <= 0 || string.IsNullOrWhiteSpace(surName) || string.IsNullOrWhiteSpace(otherNames) || string.IsNullOrWhiteSpace(identificationTypeNumber) || string.IsNullOrWhiteSpace(primaryMobileNumber) || string.IsNullOrWhiteSpace(emailAddress))
            {
                throw new ArgumentException("Invalid customer registration data.");
            }


            if((int)CustomerTypeEnum.PROSPECTIVE == customerTypeId)
            {
                if (string.IsNullOrWhiteSpace(interestExpressed))
                {
                    throw new ArgumentException("Interest expressed must not be null or empty");
                }

                if (string.IsNullOrWhiteSpace(comments))
                {
                    throw new ArgumentException("Comments must not be null or empty");
                }
            }

            if((int)CustomerTypeEnum.COMPANY == customerTypeId)
            {
                if (string.IsNullOrWhiteSpace(companyName))
                {
                    throw new ArgumentException("Company name cannot be null or empty");
                }

                //if (string.IsNullOrWhiteSpace())
                //{
                //    throw new ArgumentException("Company name cannot be null or empty");
                //}

                if (string.IsNullOrWhiteSpace(tinNumber))
                {
                    throw new ArgumentException("Company name cannot be null or empty");
                }
            }


            if ((int)CustomerTypeEnum.INDIVIDUAL == customerTypeId && (int)ResidentTypeEnum.NON_RESIDENT == residentTypeId)
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
                    throw new ArgumentException("Company name cannot be null or empty");
                }

                if (string.IsNullOrWhiteSpace(contactPerson_Address))
                {
                    throw new ArgumentException("Company name cannot be null or empty");
                }

                if (contactPerson_IdentificationTypeId <= 0)
                {
                    throw new ArgumentException("Identification Type id must be greater than zero.");
                }

                if (string.IsNullOrWhiteSpace(contactPerson_IdentificationTypeNumber))
                {
                    throw new ArgumentException("Company name cannot be null or empty");
                }


                if (string.IsNullOrWhiteSpace(contactPerson_IdentificationTypeImage))
                {
                    throw new ArgumentException("Company name cannot be null or empty");
                }

               
            }


            if ((int)CustomerTypeEnum.INDIVIDUAL == customerTypeId && (int)ResidentTypeEnum.EXPATRIATE == residentTypeId)
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


            if (customerTypeId <= 0)
            {
                throw new ArgumentException("Customer type id must be greater than zero.");
            }

            if (residentTypeId <= 0)
            {
                throw new ArgumentException("Resident type id must be greater than zero.");
            }

            if (localityId <= 0)
            {
                throw new ArgumentException("Locality id must be greater than zero.");
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

            if (string.IsNullOrWhiteSpace(surName) && string.IsNullOrWhiteSpace(otherNames) && string.IsNullOrWhiteSpace(companyName))
            {
                throw new ArgumentException("Surname, othernames and company name cannot be null or empty");
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

            if(customer_locality is null)
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
                CompanyName = companyName,
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
                IdentificationTypeId =  identificationTypeId,
                IdentificationTypeNumber =  identificationTypeNumber,
                IdentificationTypeImageOne = identificationTypeImageOne,
                IdentificationTypeImageTwo = identificationTypeImageTwo,
                Comments =  comments,
                InterestExpressed = interestExpressed,
                DebtorStatus = debtorStatus,
                ParentCode = parentCode,
                ContactPerson_FullName =  contactPerson_FullName,
                ContactPerson_PhoneNumber =  contactPerson_PhoneNumber,
                ContactPerson_EmailAddress = contactPerson_EmailAddress,
                ContactPerson_Address = contactPerson_Address,
                ContactPerson_IdentificationTypeId = contactPerson_IdentificationTypeId,
                ContactPerson_IdentificationTypeNumber  =  contactPerson_IdentificationTypeNumber,
                ContactPerson_IdentificationTypeImage = contactPerson_IdentificationTypeImage,
                IsDeleted = isDeleted

            };




        }






    }
}

