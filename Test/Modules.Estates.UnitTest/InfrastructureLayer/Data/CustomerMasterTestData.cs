using System;
using Modules.Estates.Domain.Entities.Registration;
using Modules.Estates.Domain.Entities.Setup.Customer;
using Modules.Estates.Domain.Entities.Setup.Property;

namespace Modules.Estates.UnitTest.InfrastructureLayer.Data
{
    public static class CustomerMasterTestData
    {

        public static CustomerMaster GetPrimaryMultiOwnerCustomer()
        {
            return new CustomerMaster
            {
                CustomerMasterId = 1,
                CustomerTypeId = 4, // Multi Ownership
                ResidentTypeId = 3, // Resident
                LocalityId = 1,
                CustomerCode = "MCU1001",
                TitleId = 1,
                SurName = "Smith",
                OtherNames = "John William",
                CompanyName = string.Empty,
                DateOfBirth = new DateTime(1980, 5, 15),
                TinNumber = "TIN123456789",
                Picture = "uploads/pictures/smith_john.jpg",
                GenderId = 1,
                NationalityId = 1,
                PostalAddress = "P.O. Box 1234, Accra",
                ResidentialAddress = "15 Independence Avenue, Airport Residential",
                DigitalAddress = "GA-145-2022",
                PrimaryMobileNumber = "0244123456",
                SecondaryMobileNumber = "0201234567",
                OfficeNumber = "0302123456",
                WhatsAppNumber = "0244123456",
                EmailAddress = "john.smith@email.com",
                ResidentPermitNumber = string.Empty,
                ResidentPermitDateIssued = null,
                ResidentPermitExpiryDate = null,
                SocialMediaTypeId = 1,
                SocialMediaAccount = "johnsmith",
                IdentificationTypeId = 1,
                IdentificationTypeNumber = "GHA-123456789-0",
                IdentificationTypeImageOne = "uploads/ids/smith_front.jpg",
                IdentificationTypeImageTwo = "uploads/ids/smith_back.jpg",
                Comments = "Primary owner of the property",
                InterestExpressed = string.Empty,
                DebtorStatus = 0, // Active
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
                IsPrimary = true,
                MaritalStatus = "Single",
                DateOfMarriage = null!,
                CreatedBy = "system",
                CreatedOn = DateTime.Now,
                ModifiedBy = string.Empty,
                ModifiedOn = DateTime.UtcNow
            };
        }

        public static CustomerMaster GetMultiExpatriateCustomer()
        {
            return new CustomerMaster
            {
                CustomerMasterId = 2,
                CustomerTypeId = 4, // Multi Ownership
                ResidentTypeId = 1, // Expatriate
                LocalityId = 1,
                CustomerCode = "MCU1002-01",
                TitleId = 2,
                SurName = "Chen",
                OtherNames = "Wei",
                CompanyName = string.Empty,
                DateOfBirth = new DateTime(1975, 8, 22),
                TinNumber = "TIN987654321",
                Picture = "uploads/pictures/chen_wei.jpg",
                GenderId = 1,
                NationalityId = 2, // Chinese
                PostalAddress = "PMB 45, Cantonments",
                ResidentialAddress = "25 Cantonments Road",
                DigitalAddress = "GA-167-3344",
                PrimaryMobileNumber = "0244987654",
                SecondaryMobileNumber = string.Empty,
                OfficeNumber = "0302987654",
                WhatsAppNumber = "0244987654",
                EmailAddress = "wei.chen@email.com",
                ResidentPermitNumber = "RP2023001",
                ResidentPermitDateIssued = new DateTime(2023, 1, 1),
                ResidentPermitExpiryDate = new DateTime(2025, 12, 31),
                SocialMediaTypeId = 2,
                SocialMediaAccount = "weichen",
                IdentificationTypeId = 2,
                IdentificationTypeNumber = "PP-CHN-G123456",
                IdentificationTypeImageOne = "uploads/ids/chen_passport_front.jpg",
                IdentificationTypeImageTwo = "uploads/ids/chen_passport_back.jpg",
                Comments = "Expatriate co-owner",
                InterestExpressed = string.Empty,
                DebtorStatus = 0, // Active
                ParentCode = "MCU1002",
                ContactPerson_FullName = string.Empty,
                ContactPerson_PhoneNumber = string.Empty,
                ContactPerson_EmailAddress = string.Empty,
                ContactPerson_Address = string.Empty,
                ContactPerson_IdentificationTypeId = 0,
                ContactPerson_IdentificationTypeNumber = string.Empty,
                ContactPerson_IdentificationTypeImageOne = string.Empty,
                ContactPerson_IdentificationTypeImageTwo = string.Empty,
                IsDeleted = false,
                IsPrimary = false,
                MaritalStatus = "Single",
                DateOfMarriage = new DateTime(2000, 12, 31),
                CreatedBy = "system",
                CreatedOn = DateTime.Now,
                ModifiedBy = string.Empty,
                ModifiedOn = DateTime.Now
            };
        }

        public static CustomerMaster GetMultiNonResidentCustomer()
        {
            return new CustomerMaster
            {
                CustomerMasterId = 3,
                CustomerTypeId = 4, // Multi Ownership
                ResidentTypeId = 2, // Non-Resident
                LocalityId = 1,
                CustomerCode = "MCU1003-02",
                TitleId = 1,
                SurName = "Johnson",
                OtherNames = "Robert",
                CompanyName = string.Empty,
                DateOfBirth = new DateTime(1982, 3, 10),
                TinNumber = "TIN456789123",
                Picture = "uploads/pictures/johnson_robert.jpg",
                GenderId = 1,
                NationalityId = 3, // British
                PostalAddress = "123 Oxford Street, London, UK",
                ResidentialAddress = "123 Oxford Street, London, UK",
                DigitalAddress = string.Empty,
                PrimaryMobileNumber = "+447123456789",
                SecondaryMobileNumber = string.Empty,
                OfficeNumber = string.Empty,
                WhatsAppNumber = "+447123456789",
                EmailAddress = "robert.johnson@email.com",
                ResidentPermitNumber = string.Empty,
                ResidentPermitDateIssued = null,
                ResidentPermitExpiryDate = null,
                SocialMediaTypeId = 1,
                SocialMediaAccount = "robertjohnson",
                IdentificationTypeId = 2,
                IdentificationTypeNumber = "PP-GBR-789123",
                IdentificationTypeImageOne = "uploads/ids/johnson_passport_front.jpg",
                IdentificationTypeImageTwo = "uploads/ids/johnson_passport_back.jpg",
                Comments = "Non-resident co-owner",
                InterestExpressed = string.Empty,
                DebtorStatus = 0, // Active
                ParentCode = "MCU1003",
                ContactPerson_FullName = "James Wilson",
                ContactPerson_PhoneNumber = "0244555666",
                ContactPerson_EmailAddress = "james.wilson@email.com",
                ContactPerson_Address = "10 High Street, East Legon",
                ContactPerson_IdentificationTypeId = 1,
                ContactPerson_IdentificationTypeNumber = "GHA-987654321-0",
                ContactPerson_IdentificationTypeImageOne = "uploads/ids/wilson_id_front.jpg",
                ContactPerson_IdentificationTypeImageTwo = "uploads/ids/wilson_id_back.jpg",
                IsDeleted = false,
                IsPrimary = false,
                MaritalStatus = "Married",
                DateOfMarriage = new DateTime(2015, 9, 15),
                CreatedBy = "system",
                CreatedOn = DateTime.Now,
                ModifiedBy = string.Empty,
                ModifiedOn = DateTime.Now
            };
        }


        public static CustomerMaster GetProspectiveCustomer()
        {
            return new CustomerMaster
            {
                CustomerMasterId = 1,
                CustomerTypeId = 5, // Prospective
                ResidentTypeId = 0,
                LocalityId = 1,
                CustomerCode = "PROS001",
                TitleId = 1,
                SurName = "Brown",
                OtherNames = "Sarah",
                CompanyName = string.Empty,
                DateOfBirth = DateTime.MinValue,
                TinNumber = string.Empty,
                Picture = string.Empty,
                GenderId = 2, // Female
                NationalityId = 1,
                PostalAddress = string.Empty,
                ResidentialAddress = string.Empty,
                DigitalAddress = string.Empty,
                PrimaryMobileNumber = "0244111222",
                SecondaryMobileNumber = string.Empty,
                OfficeNumber = string.Empty,
                WhatsAppNumber = "0244111222",
                EmailAddress = "sarah.brown@email.com",
                SocialMediaTypeId = 1,
                SocialMediaAccount = "sarahbrown",
                IdentificationTypeId = 0,
                IdentificationTypeNumber = string.Empty,
                Comments = "Interested in purchasing a property",
                InterestExpressed = "Looking for a 3-bedroom apartment",
                DebtorStatus = 1, // Pending
                IsDeleted = false,
                IsPrimary = false,
                CreatedBy = "system",
                CreatedOn = DateTime.Now
            };
        }


        public static CustomerMaster GetCompanyCustomer()
        {
            return new CustomerMaster
            {
                CustomerMasterId = 2,
                CustomerTypeId = 2, // Company
                ResidentTypeId = 1,
                LocalityId = 1,
                CustomerCode = "COMP001",
                TitleId = 0,
                SurName = string.Empty,
                OtherNames = string.Empty,
                CompanyName = "Global Tech Solutions Ltd",
                DateOfBirth = DateTime.MinValue,
                TinNumber = "COMP123456789",
                Picture = "uploads/logos/globaltech.jpg",
                GenderId = 0,
                NationalityId = 1,
                PostalAddress = "P.O. Box CT 5678, Cantonments",
                ResidentialAddress = "Plot 45, Spintex Road",
                DigitalAddress = "GA-543-2109",
                PrimaryMobileNumber = "0302555666",
                SecondaryMobileNumber = "0244333444",
                OfficeNumber = "0302555666",
                WhatsAppNumber = "0244333444",
                EmailAddress = "info@globaltech.com",
                SocialMediaTypeId = 1,
                SocialMediaAccount = "globaltechgh",
                IdentificationTypeId = 3, // Business Registration
                IdentificationTypeNumber = "BUS-2023-987654",
                IdentificationTypeImageOne = "uploads/docs/cert_incorporation.pdf",
                IdentificationTypeImageTwo = "uploads/docs/cert_commence.pdf",
                Comments = "Technology company",
                DebtorStatus = 0, // Active
                ContactPerson_FullName = "Michael Adams",
                ContactPerson_PhoneNumber = "0244777888",
                ContactPerson_EmailAddress = "m.adams@globaltech.com",
                ContactPerson_Address = "Plot 45, Spintex Road",
                ContactPerson_IdentificationTypeId = 1,
                ContactPerson_IdentificationTypeNumber = "GHA-456789123-0",
                ContactPerson_IdentificationTypeImageOne = "uploads/ids/adams_id_front.jpg",
                ContactPerson_IdentificationTypeImageTwo = "uploads/ids/adams_id_back.jpg",
                IsDeleted = false,
                IsPrimary = true,
                CreatedBy = "system",
                CreatedOn = DateTime.Now
            };
        }


        public static CustomerMaster GetIndividualCustomer()
        {
            return new CustomerMaster
            {
                CustomerMasterId = 3,
                CustomerTypeId = 2, // Individual
                ResidentTypeId = 3, // Resident
                LocalityId = 1,
                CustomerCode = "IND001",
                TitleId = 5, // Col.
                SurName = "Mensah",
                OtherNames = "Kwame",
                CompanyName = string.Empty,
                DateOfBirth = new DateTime(1978, 12, 15),
                TinNumber = "TIN789123456",
                Picture = "uploads/pictures/mensah_kwame.jpg",
                GenderId = 1,
                NationalityId = 1,
                PostalAddress = "PMB 15, Legon",
                ResidentialAddress = "24 University Avenue, East Legon",
                DigitalAddress = "GA-987-6543",
                PrimaryMobileNumber = "0244999888",
                SecondaryMobileNumber = "0201234567",
                OfficeNumber = "0302444555",
                WhatsAppNumber = "0244999888",
                EmailAddress = "dr.mensah@email.com",
                SocialMediaTypeId = 1,
                SocialMediaAccount = "drmensah",
                IdentificationTypeId = 1,
                IdentificationTypeNumber = "GHA-741852963-0",
                IdentificationTypeImageOne = "uploads/ids/mensah_id_front.jpg",
                IdentificationTypeImageTwo = "uploads/ids/mensah_id_back.jpg",
                Comments = "Medical professional",
                DebtorStatus = 0, // Active
                IsDeleted = false,
                IsPrimary = true,
                MaritalStatus = "Single",
                CreatedBy = "system",
                CreatedOn = DateTime.Now
            };
        }

        public static CustomerMaster GetIndividualNonResidentCustomer()
        {
            return new CustomerMaster
            {
                CustomerMasterId = 5,
                CustomerTypeId = 2, // Individual
                ResidentTypeId = 2, // Non-Resident
                LocalityId = 1,
                CustomerCode = "IEXP002",
                TitleId = 3, // Mrs.
                SurName = "Zhang",
                OtherNames = "Wei",
                CompanyName = string.Empty,
                DateOfBirth = new DateTime(1982, 5, 18),
                TinNumber = "NRTIN123456",
                Picture = "uploads/pictures/zhang_wei.jpg",
                GenderId = 2, // Female
                NationalityId = 2, // Chinese
                PostalAddress = "123 Huangpu Road, Shanghai",
                ResidentialAddress = "Unit 45, Tower B, Century Plaza, Shanghai",
                DigitalAddress = string.Empty,
                PrimaryMobileNumber = "+8613912345678",
                SecondaryMobileNumber = string.Empty,
                OfficeNumber = "+862161234567",
                WhatsAppNumber = "+8613912345678",
                EmailAddress = "wei.zhang@email.com",
                SocialMediaTypeId = 2, // WeChat
                SocialMediaAccount = "weizhang888",
                IdentificationTypeId = 2, // Passport
                IdentificationTypeNumber = "E12345678",
                IdentificationTypeImageOne = "uploads/ids/zhang_passport_front.jpg",
                IdentificationTypeImageTwo = "uploads/ids/zhang_passport_back.jpg",
                Comments = "International investor",
                DebtorStatus = 0, // Active
                IsDeleted = false,
                IsPrimary = true,
                MaritalStatus = "Married",

                // Non-Resident specific fields
                ContactPerson_FullName = "John Owusu",
                ContactPerson_PhoneNumber = "0244123456",
                ContactPerson_EmailAddress = "j.owusu@email.com",
                ContactPerson_Address = "15 Airport Road, Accra",
                ContactPerson_IdentificationTypeId = 1,
                ContactPerson_IdentificationTypeNumber = "GHA-123456789-0",
                ContactPerson_IdentificationTypeImageOne = "uploads/ids/owusu_id_front.jpg",
                ContactPerson_IdentificationTypeImageTwo = "uploads/ids/owusu_id_back.jpg",

                CreatedBy = "system",
                CreatedOn = DateTime.Now
            };
        }

        public static CustomerMaster GetIndividualExpatriateCustomer()
        {
            return new CustomerMaster
            {
                CustomerMasterId = 6,
                CustomerTypeId = 2, // Individual
                ResidentTypeId = 1, // Expatriate
                LocalityId = 1,
                CustomerCode = "IEXP003",
                TitleId = 1, // Mr.
                SurName = "Smith",
                OtherNames = "David James",
                CompanyName = string.Empty,
                DateOfBirth = new DateTime(1975, 8, 25),
                TinNumber = "EXPTIN789012",
                Picture = "uploads/pictures/smith_david.jpg",
                GenderId = 1, // Male
                NationalityId = 3, // British
                PostalAddress = "PMB KA 123, Airport",
                ResidentialAddress = "Villa 7, Cantonments",
                DigitalAddress = "GA-145-7890",
                PrimaryMobileNumber = "0244555666",
                SecondaryMobileNumber = "0201234567",
                OfficeNumber = "0302789012",
                WhatsAppNumber = "0244555666",
                EmailAddress = "d.smith@email.com",
                SocialMediaTypeId = 1, // LinkedIn
                SocialMediaAccount = "davidjsmith",
                IdentificationTypeId = 2, // Passport
                IdentificationTypeNumber = "GBR123456",
                IdentificationTypeImageOne = "uploads/ids/smith_passport_front.jpg",
                IdentificationTypeImageTwo = "uploads/ids/smith_passport_back.jpg",
                Comments = "Technical Director at Global Mining Corp",
                DebtorStatus = 0, // Active
                IsDeleted = false,
                IsPrimary = true,
                MaritalStatus = "Married",

                // Expatriate specific fields
                ResidentPermitNumber = "GHA-RP-2023-123456",
                ResidentPermitDateIssued = new DateTime(2023, 1, 15),
                ResidentPermitExpiryDate = new DateTime(2025, 1, 14),
                //ResidentPermitImageOne = "uploads/permits/smith_permit_front.jpg",
                //ResidentPermitImageTwo = "uploads/permits/smith_permit_back.jpg",
                //WorkPermitNumber = "GHA-WP-2023-789012",
                //WorkPermitIssueDate = new DateTime(2023, 1, 15),
                //WorkPermitExpiryDate = new DateTime(2025, 1, 14),
                //WorkPermitImageOne = "uploads/permits/smith_work_permit_front.jpg",
                //WorkPermitImageTwo = "uploads/permits/smith_work_permit_back.jpg",

                CreatedBy = "system",
                CreatedOn = DateTime.Now
            };
        }


        public static CustomerMaster GetJointCustomer()
        {
            return new CustomerMaster
            {
                CustomerMasterId = 4,
                CustomerTypeId = 3, // Joint Ownership
                ResidentTypeId = 1,
                LocalityId = 1,
                CustomerCode = "JNT001",
                TitleId = 4, // Mr. & Mrs.
                SurName = "Addo",
                OtherNames = "Samuel & Mary",
                CompanyName = string.Empty,
                DateOfBirth = new DateTime(1985, 3, 20),
                TinNumber = "TIN456123789",
                Picture = "uploads/pictures/addo_family.jpg",
                GenderId = 1,
                NationalityId = 1,
                PostalAddress = "P.O. Box AN 7890, Accra North",
                ResidentialAddress = "15 Palm Street, Dzorwulu",
                DigitalAddress = "GA-234-5678",
                PrimaryMobileNumber = "0244777666",
                SecondaryMobileNumber = "0244888999",
                OfficeNumber = string.Empty,
                WhatsAppNumber = "0244777666",
                EmailAddress = "addo.family@email.com",
                SocialMediaTypeId = 1,
                SocialMediaAccount = "addofamily",
                IdentificationTypeId = 1,
                IdentificationTypeNumber = "GHA-369258147-0",
                IdentificationTypeImageOne = "uploads/ids/addo_samuel_id_front.jpg",
                IdentificationTypeImageTwo = "uploads/ids/addo_samuel_id_back.jpg",
                IdentificationTypeImageThree = "uploads/ids/addo_mary_id_front.jpg",
                IdentificationTypeImageFour = "uploads/ids/addo_mary_id_back.jpg",
                Comments = "Joint ownership by married couple",
                DebtorStatus = 0, // Active
                IsDeleted = false,
                IsPrimary = true,
                MaritalStatus = "Married",
                DateOfMarriage = new DateTime(2010, 8, 15),
                CreatedBy = "system",
                CreatedOn = DateTime.Now
            };
        }

        public static CustomerMaster GetJointNonResidentCustomer()
        {
            return new CustomerMaster
            {
                CustomerMasterId = 7,
                CustomerTypeId = 3, // Joint Ownership
                ResidentTypeId = 2, // Non-Resident
                LocalityId = 1,
                CustomerCode = "JNTR001",
                TitleId = 4, // Mr. & Mrs.
                SurName = "Kumar",
                OtherNames = "Raj & Priya",
                CompanyName = string.Empty,
                DateOfBirth = new DateTime(1980, 3, 15), // Primary holder's birth date
                TinNumber = "NRTIN456789",
                Picture = "uploads/pictures/kumar_family.jpg",
                GenderId = 1, // Primary holder's gender
                NationalityId = 4, // Indian
                PostalAddress = "45 MG Road, Mumbai 400001",
                ResidentialAddress = "Palm Grove Heights, Flat 2301, Mumbai",
                DigitalAddress = string.Empty,
                PrimaryMobileNumber = "+919876543210",
                SecondaryMobileNumber = "+919876543211",
                OfficeNumber = "+912222443355",
                WhatsAppNumber = "+919876543210",
                EmailAddress = "raj.kumar@email.com",
                SocialMediaTypeId = 2,
                SocialMediaAccount = "rajkumar_family",
                IdentificationTypeId = 2, // Passport
                IdentificationTypeNumber = "Z12345678", // Primary holder's passport
                IdentificationTypeImageOne = "uploads/ids/raj_passport_front.jpg",
                IdentificationTypeImageTwo = "uploads/ids/raj_passport_back.jpg",
                IdentificationTypeImageThree = "uploads/ids/priya_passport_front.jpg",
                IdentificationTypeImageFour = "uploads/ids/priya_passport_back.jpg",
                Comments = "Non-resident investment couple",
                DebtorStatus = 0, // Active
                IsDeleted = false,
                IsPrimary = true,
                MaritalStatus = "Married",
                DateOfMarriage = new DateTime(2005, 11, 23),

                // Non-Resident specific fields
                ContactPerson_FullName = "Kwame Mensah",
                ContactPerson_PhoneNumber = "0244789012",
                ContactPerson_EmailAddress = "k.mensah@email.com",
                ContactPerson_Address = "25 Independence Avenue, Accra",
                ContactPerson_IdentificationTypeId = 1,
                ContactPerson_IdentificationTypeNumber = "GHA-987654321-0",
                ContactPerson_IdentificationTypeImageOne = "uploads/ids/mensah_id_front.jpg",
                ContactPerson_IdentificationTypeImageTwo = "uploads/ids/mensah_id_back.jpg",

                // Spouse Passport Details
                //SpouseIdentificationTypeNumber = "Z98765432",

                CreatedBy = "system",
                CreatedOn = DateTime.Now
            };
        }

        public static CustomerMaster GetJointExpatriateCustomer()
        {
            return new CustomerMaster
            {
                CustomerMasterId = 8,
                CustomerTypeId = 3, // Joint Ownership
                ResidentTypeId = 1, // Expatriate
                LocalityId = 2,
                CustomerCode = "JNTE001",
                TitleId = 4, // Mr. & Mrs.
                SurName = "Anderson",
                OtherNames = "Michael & Sarah",
                CompanyName = string.Empty,
                DateOfBirth = new DateTime(1978, 7, 12), // Primary holder's birth date
                TinNumber = "EXPTIN234567",
                Picture = "uploads/pictures/anderson_family.jpg",
                GenderId = 1, // Primary holder's gender
                NationalityId = 5, // American
                PostalAddress = "PMB CT 456, Cantonments",
                ResidentialAddress = "No. 8 Second Circular Road, Cantonments",
                DigitalAddress = "GA-567-8901",
                PrimaryMobileNumber = "0244111222",
                SecondaryMobileNumber = "0244333444",
                OfficeNumber = "0302456789",
                WhatsAppNumber = "0244111222",
                EmailAddress = "m.anderson@email.com",
                SocialMediaTypeId = 1,
                SocialMediaAccount = "andersonfamily",
                IdentificationTypeId = 2, // Passport
                IdentificationTypeNumber = "USA123456789", // Primary holder's passport
                IdentificationTypeImageOne = "uploads/ids/michael_passport_front.jpg",
                IdentificationTypeImageTwo = "uploads/ids/michael_passport_back.jpg",
                IdentificationTypeImageThree = "uploads/ids/sarah_passport_front.jpg",
                IdentificationTypeImageFour = "uploads/ids/sarah_passport_back.jpg",
                Comments = "Expatriate couple working in diplomatic mission",
                DebtorStatus = 0, // Active
                IsDeleted = false,
                IsPrimary = true,
                MaritalStatus = "Married",
                DateOfMarriage = new DateTime(2008, 6, 14),

                // Expatriate specific fields - Primary Holder
                ResidentPermitNumber = "GHA-RP-2023-789012",
                ResidentPermitDateIssued = new DateTime(2023, 3, 1),
                ResidentPermitExpiryDate = new DateTime(2025, 2, 28),
                //ResidentPermitImageOne = "uploads/permits/michael_permit_front.jpg",
                //ResidentPermitImageTwo = "uploads/permits/michael_permit_back.jpg",
                //WorkPermitNumber = "GHA-WP-2023-345678",
                //WorkPermitIssueDate = new DateTime(2023, 3, 1),
                //WorkPermitExpiryDate = new DateTime(2025, 2, 28),
                //WorkPermitImageOne = "uploads/permits/michael_work_permit_front.jpg",
                //WorkPermitImageTwo = "uploads/permits/michael_work_permit_back.jpg",

                //// Spouse Details
                //SpouseIdentificationTypeNumber = "USA987654321",
                //SpouseResidentPermitNumber = "GHA-RP-2023-789013",
                //SpouseResidentPermitIssueDate = new DateTime(2023, 3, 1),
                //SpouseResidentPermitExpiryDate = new DateTime(2025, 2, 28),
                //SpouseResidentPermitImageOne = "uploads/permits/sarah_permit_front.jpg",
                //SpouseResidentPermitImageTwo = "uploads/permits/sarah_permit_back.jpg",

                CreatedBy = "system",
                CreatedOn = DateTime.Now
            };
        }




        public static List<Title> GetSampleTitleData()
        {
            return new List<Title>
            {
                new Title(1, "Mr."),
                new Title(2, "Dr."),
                new Title(3, "Mrs."),
                new Title(4, "Mr. & Mrs."),
                new Title(5, "Col."),
            };
        }


        public static List<CustomerType> GetSampleCustomerTypeData()
        {
            return new List<CustomerType>
            {
                new CustomerType(1, "Company"),
                new CustomerType(2, "Individual"),
                new CustomerType(3, "Joint Ownership"),
                new CustomerType(4, "Multi Ownership"),
                new CustomerType(5, "Prospective"),
            };
        }

        public static List<ResidentType> GetSampleResidentTypeData()
        {
            return new List<ResidentType>
            {
                new ResidentType(1, "Expatriate"),
                new ResidentType(2, "Non-Resident"),
                new ResidentType(3, "Resident"),
            };
        }

        public static List<Nationality> GetSampleNationalityData()
        {
            return new List<Nationality>
            {
                new Nationality(1, "Ghanaian"),
                new Nationality(2, "Chinese"),
                new Nationality(3, "British"),
                new Nationality(4, "Indian"),
                new Nationality(5, "American"),
            };
        }

        public static List<Gender> GetSampleGenderData()
        {
            return new List<Gender>
            {
                new Gender(1, "Male"),
                new Gender(2, "Female"),
                new Gender(3, "N/A")
            };
        }

        public static List<SocialMedia> GetSampleSocialMediaData()
        {
            return new List<SocialMedia>
            {
                new SocialMedia(1, "LinkedIn"),
                new SocialMedia(2, "Facebook"),
            };
        }

        public static List<IdentificationType> GetSampleIdentificationTypeData()
        {
            return new List<IdentificationType>
            {
                new IdentificationType(1, "National ID"),
                new IdentificationType(2, "Passport"),
                new IdentificationType(3, "Voters ID")
            };
        }


        public static List<Locality> GetSampleLocalityData()
        {
            return new List<Locality>
            {
                new Locality(1, "TLT", "Test Locality", "9XX", 101),
                new Locality(2, "TLA", "Test Locality One", "8XX", 201),
                new Locality(3, "TLB", "Test Locality Two", "7XX", 301)
            };
        }

    }

}

