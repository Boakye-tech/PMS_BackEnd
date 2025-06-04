// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using Modules.Estates.Domain.Entities.Management;
using Modules.Estates.Domain.Enums;

namespace Modules.Estates.UnitTest.DomainLayer
{
    public class ComplaintTests
    {
        #region CreateNewComplaint Tests - Success Cases

        [Fact]
        public void CreateNewComplaint_WithValidData_ShouldCreateInstance()
        {
            // Arrange
            int complaintId = 1;
            string complaintNumber = "C12345";
            int complaintTypeId = 1;
            string natureOfComplaintId = "Billing Issue";
            string propertyNumber = "PROP001";
            string propertyLocation = "123 Main Street, Accra";
            string customerCode = "CUST001";
            string customerName = "John Doe";
            string phoneNumber = "0241234567";
            string emailAddress = "john.doe@example.com";
            string isTheMatterInCourt = "No";
            string detailsOfComplaint = "Detailed description of the complaint";
            DateTime availabilityDate = DateTime.UtcNow.AddDays(2);
            DateTime complaintDate = DateTime.UtcNow;
            string submittedBy = "John Doe";
            string submittedBy_PhoneNumber = "0241234567";
            string[] documentList = { "document1.pdf", "document2.pdf", "document3.pdf" };
            ComplaintStatusEnum complaintStatus = ComplaintStatusEnum.SUBMITTED;
            ComplaintSourceEnum source = ComplaintSourceEnum.STAFF;
            string createdBy = "32ea339b-75f2-4f57-8153-915f127a9612";

            // Act
            var complaint = Complaint.CreateNewComplaint(
                complaintId, complaintNumber, complaintTypeId, natureOfComplaintId,
                propertyNumber, propertyLocation, customerCode, customerName,
                phoneNumber, emailAddress, isTheMatterInCourt, detailsOfComplaint,
                availabilityDate, complaintDate, submittedBy, submittedBy_PhoneNumber,
                documentList, complaintStatus, source, createdBy);

            // Assert
            Assert.NotNull(complaint);
            Assert.Equal(complaintId, complaint.ComplaintId);
            Assert.NotEqual(complaintNumber, complaint.ComplaintNumber);
            Assert.Equal(complaintTypeId, complaint.ComplaintTypeId);
            Assert.Equal(natureOfComplaintId, complaint.NatureOfComplaintId);
            Assert.Equal(propertyNumber, complaint.PropertyNumber);
            Assert.Equal(propertyLocation, complaint.PropertyLocation);
            Assert.Equal(customerCode, complaint.CustomerCode);
            Assert.Equal(customerName, complaint.CustomerName);
            Assert.Equal(phoneNumber, complaint.PhoneNumber);
            Assert.Equal(emailAddress, complaint.EmailAddress);
            Assert.Equal(isTheMatterInCourt, complaint.IsTheMatterInCourt);
            Assert.Equal(detailsOfComplaint, complaint.DetailsOfComplaint);
            Assert.Equal(availabilityDate, complaint.AvailabilityDate);
            Assert.Equal(documentList, complaint.DocumentList);
            Assert.Equal(complaintStatus, complaint.ComplaintStatus);
            Assert.Equal(source, complaint.Source);
            Assert.Equal(0, complaint.DispatachedTo_Department);
            Assert.Equal(0, complaint.DispatachedTo_DepartmentUnit);
            Assert.Equal(string.Empty, complaint.AssignedTo);
            Assert.Equal(string.Empty, complaint.Notes);
        }

        [Fact]
        public void CreateNewComplaint_CustomerSource_ShouldGenerateComplaintNumber()
        {
            // Arrange
            int complaintId = 1;
            string complaintNumber = "ANY"; // This should be overridden
            int complaintTypeId = 1;
            string natureOfComplaintId = "Billing Issue";
            string propertyNumber = "PROP001";
            string propertyLocation = "123 Main Street, Accra";
            string customerCode = "CUST001";
            string customerName = "John Doe";
            string phoneNumber = "0241234567";
            string emailAddress = "john.doe@example.com";
            string isTheMatterInCourt = "No";
            string detailsOfComplaint = "Detailed description of the complaint";
            DateTime availabilityDate = DateTime.UtcNow.AddDays(2);
            DateTime complaintDate = DateTime.UtcNow;
            string submittedBy = "John Doe";
            string submittedBy_PhoneNumber = "0241234567";
            string[] documentList = { "document1.pdf", "document2.pdf", "document3.pdf" };
            ComplaintStatusEnum complaintStatus = ComplaintStatusEnum.SUBMITTED;
            ComplaintSourceEnum source = ComplaintSourceEnum.STAFF;
            string createdBy = "32ea339b-75f2-4f57-8153-915f127a9612";

            // Act
            var complaint = Complaint.CreateNewComplaint(
                complaintId, complaintNumber, complaintTypeId, natureOfComplaintId,
                propertyNumber, propertyLocation, customerCode, customerName,
                phoneNumber, emailAddress, isTheMatterInCourt, detailsOfComplaint,
                availabilityDate, complaintDate, submittedBy, submittedBy_PhoneNumber,
                documentList, complaintStatus, source, createdBy);

            // Assert
            Assert.NotNull(complaint);
            Assert.NotEqual("ANY", complaint.ComplaintNumber);
            Assert.StartsWith("C", complaint.ComplaintNumber);
            Assert.True(complaint.ComplaintNumber!.Length > 1);
        }

        #endregion

        #region CreateNewComplaint Tests - Validation Failures

        [Fact]
        public void CreateNewComplaint_WithInvalidComplaintTypeId_ShouldThrowArgumentException()
        {
            // Arrange
            int complaintId = 1;
            string complaintNumber = "C12345";
            int complaintTypeId = 0; // Invalid: <= 0
            string natureOfComplaintId = "Billing Issue";
            string propertyNumber = "PROP001";
            string propertyLocation = "123 Main Street, Accra";
            string customerCode = "CUST001";
            string customerName = "John Doe";
            string phoneNumber = "0241234567";
            string emailAddress = "john.doe@example.com";
            string isTheMatterInCourt = "No";
            string detailsOfComplaint = "Detailed description of the complaint";
            DateTime availabilityDate = DateTime.UtcNow.AddDays(2);
            DateTime complaintDate = DateTime.UtcNow;
            string submittedBy = "John Doe";
            string submittedBy_PhoneNumber = "0241234567";
            string[] documentList = { "document1.pdf", "document2.pdf", "document3.pdf" };
            ComplaintStatusEnum complaintStatus = ComplaintStatusEnum.SUBMITTED;
            ComplaintSourceEnum source = ComplaintSourceEnum.STAFF;
            string createdBy = "32ea339b-75f2-4f57-8153-915f127a9612";

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => Complaint.CreateNewComplaint(
                complaintId, complaintNumber, complaintTypeId, natureOfComplaintId,
                propertyNumber, propertyLocation, customerCode, customerName,
                phoneNumber, emailAddress, isTheMatterInCourt, detailsOfComplaint,
                availabilityDate, complaintDate, submittedBy, submittedBy_PhoneNumber,
                documentList, complaintStatus, source,createdBy));

            Assert.Equal("Complaint type id must be greater than zero.", exception.Message);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void CreateNewComplaint_WithInvalidNatureOfComplaintId_ShouldThrowArgumentException(string natureOfComplaintId)
        {
            // Arrange
            int complaintId = 1;
            string complaintNumber = "C12345";
            int complaintTypeId = 1;
            string propertyNumber = "PROP001";
            string propertyLocation = "123 Main Street, Accra";
            string customerCode = "CUST001";
            string customerName = "John Doe";
            string phoneNumber = "0241234567";
            string emailAddress = "john.doe@example.com";
            string isTheMatterInCourt = "No";
            string detailsOfComplaint = "Detailed description of the complaint";
            DateTime availabilityDate = DateTime.UtcNow.AddDays(2);
            DateTime complaintDate = DateTime.UtcNow;
            string submittedBy = "John Doe";
            string submittedBy_PhoneNumber = "0241234567";
            string[] documentList = { "document1.pdf", "document2.pdf", "document3.pdf" };
            ComplaintStatusEnum complaintStatus = ComplaintStatusEnum.SUBMITTED;
            ComplaintSourceEnum source = ComplaintSourceEnum.STAFF;
            string createdBy = "32ea339b-75f2-4f57-8153-915f127a9612";

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => Complaint.CreateNewComplaint(
                complaintId, complaintNumber, complaintTypeId, natureOfComplaintId,
                propertyNumber, propertyLocation, customerCode, customerName,
                phoneNumber, emailAddress, isTheMatterInCourt, detailsOfComplaint,
                availabilityDate, complaintDate, submittedBy, submittedBy_PhoneNumber,
                documentList, complaintStatus, source,createdBy));

            Assert.Equal("Nature of complaint must not be null or empty", exception.Message);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void CreateNewComplaint_WithInvalidPropertyNumber_ShouldThrowArgumentException(string propertyNumber)
        {
            // Arrange
            int complaintId = 1;
            string complaintNumber = "C12345";
            int complaintTypeId = 1;
            string natureOfComplaintId = "Billing Issue";
            string propertyLocation = "123 Main Street, Accra";
            string customerCode = "CUST001";
            string customerName = "John Doe";
            string phoneNumber = "0241234567";
            string emailAddress = "john.doe@example.com";
            string isTheMatterInCourt = "No";
            string detailsOfComplaint = "Detailed description of the complaint";
            DateTime availabilityDate = DateTime.UtcNow.AddDays(2);
            DateTime complaintDate = DateTime.UtcNow;
            string submittedBy = "John Doe";
            string submittedBy_PhoneNumber = "0241234567";
            string[] documentList = { "document1.pdf", "document2.pdf", "document3.pdf" };
            ComplaintStatusEnum complaintStatus = ComplaintStatusEnum.SUBMITTED;
            ComplaintSourceEnum source = ComplaintSourceEnum.STAFF;
            string createdBy = "32ea339b-75f2-4f57-8153-915f127a9612";

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => Complaint.CreateNewComplaint(
                complaintId, complaintNumber, complaintTypeId, natureOfComplaintId,
                propertyNumber, propertyLocation, customerCode, customerName,
                phoneNumber, emailAddress, isTheMatterInCourt, detailsOfComplaint,
                availabilityDate, complaintDate, submittedBy, submittedBy_PhoneNumber,
                documentList, complaintStatus, source,createdBy));

            Assert.Equal("Property number must not be null or empty", exception.Message);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void CreateNewComplaint_WithInvalidPropertyLocation_ShouldThrowArgumentException(string propertyLocation)
        {
            // Arrange
            int complaintId = 1;
            string complaintNumber = "C12345";
            int complaintTypeId = 1;
            string natureOfComplaintId = "Billing Issue";
            string propertyNumber = "PROP001";
            string customerCode = "CUST001";
            string customerName = "John Doe";
            string phoneNumber = "0241234567";
            string emailAddress = "john.doe@example.com";
            string isTheMatterInCourt = "No";
            string detailsOfComplaint = "Detailed description of the complaint";
            DateTime availabilityDate = DateTime.UtcNow.AddDays(2);
            DateTime complaintDate = DateTime.UtcNow;
            string submittedBy = "John Doe";
            string submittedBy_PhoneNumber = "0241234567";
            string[] documentList = { "document1.pdf", "document2.pdf", "document3.pdf" };
            ComplaintStatusEnum complaintStatus = ComplaintStatusEnum.SUBMITTED;
            ComplaintSourceEnum source = ComplaintSourceEnum.STAFF;
            string createdBy = "32ea339b-75f2-4f57-8153-915f127a9612";

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => Complaint.CreateNewComplaint(
                complaintId, complaintNumber, complaintTypeId, natureOfComplaintId,
                propertyNumber, propertyLocation, customerCode, customerName,
                phoneNumber, emailAddress, isTheMatterInCourt, detailsOfComplaint,
                availabilityDate, complaintDate, submittedBy, submittedBy_PhoneNumber,
                documentList, complaintStatus, source,createdBy));

            Assert.Equal("Property location must not be null or empty", exception.Message);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void CreateNewComplaint_WithInvalidCustomerCode_ShouldThrowArgumentException(string customerCode)
        {
            // Arrange
            int complaintId = 1;
            string complaintNumber = "C12345";
            int complaintTypeId = 1;
            string natureOfComplaintId = "Billing Issue";
            string propertyNumber = "PROP001";
            string propertyLocation = "123 Main Street, Accra";
            string customerName = "John Doe";
            string phoneNumber = "0241234567";
            string emailAddress = "john.doe@example.com";
            string isTheMatterInCourt = "No";
            string detailsOfComplaint = "Detailed description of the complaint";
            DateTime availabilityDate = DateTime.UtcNow.AddDays(2);
            DateTime complaintDate = DateTime.UtcNow;
            string submittedBy = "John Doe";
            string submittedBy_PhoneNumber = "0241234567";
            string[] documentList = { "document1.pdf", "document2.pdf", "document3.pdf" };
            ComplaintStatusEnum complaintStatus = ComplaintStatusEnum.SUBMITTED;
            ComplaintSourceEnum source = ComplaintSourceEnum.STAFF;
            string createdBy = "32ea339b-75f2-4f57-8153-915f127a9612";

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => Complaint.CreateNewComplaint(
                complaintId, complaintNumber, complaintTypeId, natureOfComplaintId,
                propertyNumber, propertyLocation, customerCode, customerName,
                phoneNumber, emailAddress, isTheMatterInCourt, detailsOfComplaint,
                availabilityDate, complaintDate, submittedBy, submittedBy_PhoneNumber,
                documentList, complaintStatus, source,createdBy));

            Assert.Equal("Customer code must not be null or empty", exception.Message);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void CreateNewComplaint_WithInvalidCustomerName_ShouldThrowArgumentException(string customerName)
        {
            // Arrange
            int complaintId = 1;
            string complaintNumber = "C12345";
            int complaintTypeId = 1;
            string natureOfComplaintId = "Billing Issue";
            string propertyNumber = "PROP001";
            string propertyLocation = "123 Main Street, Accra";
            string customerCode = "CUST001";
            string phoneNumber = "0241234567";
            string emailAddress = "john.doe@example.com";
            string isTheMatterInCourt = "No";
            string detailsOfComplaint = "Detailed description of the complaint";
            DateTime availabilityDate = DateTime.UtcNow.AddDays(2);
            DateTime complaintDate = DateTime.UtcNow;
            string submittedBy = "John Doe";
            string submittedBy_PhoneNumber = "0241234567";
            string[] documentList = { "document1.pdf", "document2.pdf", "document3.pdf" };
            ComplaintStatusEnum complaintStatus = ComplaintStatusEnum.SUBMITTED;
            ComplaintSourceEnum source = ComplaintSourceEnum.STAFF;
            string createdBy = "32ea339b-75f2-4f57-8153-915f127a9612";

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => Complaint.CreateNewComplaint(
                complaintId, complaintNumber, complaintTypeId, natureOfComplaintId,
                propertyNumber, propertyLocation, customerCode, customerName,
                phoneNumber, emailAddress, isTheMatterInCourt, detailsOfComplaint,
                availabilityDate, complaintDate, submittedBy, submittedBy_PhoneNumber,
                documentList, complaintStatus, source,createdBy));

            Assert.Equal("Customer name must not be null or empty", exception.Message);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void CreateNewComplaint_WithInvalidPhoneNumber_ShouldThrowArgumentException(string phoneNumber)
        {
            // Arrange
            int complaintId = 1;
            string complaintNumber = "C12345";
            int complaintTypeId = 1;
            string natureOfComplaintId = "Billing Issue";
            string propertyNumber = "PROP001";
            string propertyLocation = "123 Main Street, Accra";
            string customerCode = "CUST001";
            string customerName = "John Doe";
            string emailAddress = "john.doe@example.com";
            string isTheMatterInCourt = "No";
            string detailsOfComplaint = "Detailed description of the complaint";
            DateTime availabilityDate = DateTime.UtcNow.AddDays(2);
            DateTime complaintDate = DateTime.UtcNow;
            string submittedBy = "John Doe";
            string submittedBy_PhoneNumber = "0241234567";
            string[] documentList = { "document1.pdf", "document2.pdf", "document3.pdf" };
            ComplaintStatusEnum complaintStatus = ComplaintStatusEnum.SUBMITTED;
            ComplaintSourceEnum source = ComplaintSourceEnum.STAFF;
            string createdBy = "32ea339b-75f2-4f57-8153-915f127a9612";

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => Complaint.CreateNewComplaint(
                complaintId, complaintNumber, complaintTypeId, natureOfComplaintId,
                propertyNumber, propertyLocation, customerCode, customerName,
                phoneNumber, emailAddress, isTheMatterInCourt, detailsOfComplaint,
                availabilityDate, complaintDate, submittedBy, submittedBy_PhoneNumber,
                documentList, complaintStatus, source,createdBy));

            Assert.Equal("Phone number must not be null or empty", exception.Message);
        }

        [Theory]
        [InlineData(default)]
        [InlineData("")]
        [InlineData("   ")]
        public void CreateNewComplaint_WithInvalidDetailsOfComplaint_ShouldThrowArgumentException(string detailsOfComplaint)
        {
            // Arrange
            int complaintId = 1;
            string complaintNumber = "C12345";
            int complaintTypeId = 1;
            string natureOfComplaintId = "Billing Issue";
            string propertyNumber = "PROP001";
            string propertyLocation = "123 Main Street, Accra";
            string customerCode = "CUST001";
            string customerName = "John Doe";
            string phoneNumber = "0241234567";
            string emailAddress = "john.doe@example.com";
            string isTheMatterInCourt = "No";
            DateTime availabilityDate = DateTime.UtcNow.AddDays(2);
            DateTime complaintDate = DateTime.UtcNow;
            string submittedBy = "John Doe";
            string submittedBy_PhoneNumber = "0241234567";
            string[] documentList = { "document1.pdf", "document2.pdf", "document3.pdf" };
            ComplaintStatusEnum complaintStatus = ComplaintStatusEnum.SUBMITTED;
            ComplaintSourceEnum source = ComplaintSourceEnum.STAFF;
            string createdBy = "32ea339b-75f2-4f57-8153-915f127a9612";

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => Complaint.CreateNewComplaint(
                complaintId, complaintNumber, complaintTypeId, natureOfComplaintId,
                propertyNumber, propertyLocation, customerCode, customerName,
                phoneNumber, emailAddress, isTheMatterInCourt, detailsOfComplaint,
                availabilityDate, complaintDate, submittedBy, submittedBy_PhoneNumber,
                documentList, complaintStatus, source,createdBy));

            Assert.Equal("Complaint details must not be null or empty", exception.Message);
        }

        #endregion

        #region Optional Parameters Tests

        [Fact]
        public void CreateNewComplaint_WithOptionalFieldsEmpty_ShouldCreateInstance()
        {
            // Arrange
            int complaintId = 1;
            string complaintNumber = "C12345";
            int complaintTypeId = 1;
            string natureOfComplaintId = "Billing Issue";
            string propertyNumber = "PROP001";
            string propertyLocation = "123 Main Street, Accra";
            string customerCode = "CUST001";
            string customerName = "John Doe";
            string phoneNumber = "0241234567";
            string emailAddress = default!; // Optional
            string isTheMatterInCourt = default!; // Optional
            string detailsOfComplaint = "Detailed description of the complaint";
            DateTime availabilityDate = DateTime.UtcNow.AddDays(2);
            DateTime complaintDate = DateTime.UtcNow;
            string submittedBy = default!; // Optional
            string submittedBy_PhoneNumber = default!; // Optional
            string[] documentList = default!;// Optional
            ComplaintStatusEnum complaintStatus = ComplaintStatusEnum.SUBMITTED;
            ComplaintSourceEnum source = ComplaintSourceEnum.STAFF;
            string createdBy = "32ea339b-75f2-4f57-8153-915f127a9612";

            // Act
            var complaint = Complaint.CreateNewComplaint(
                complaintId, complaintNumber, complaintTypeId, natureOfComplaintId,
                propertyNumber, propertyLocation, customerCode, customerName,
                phoneNumber, emailAddress, isTheMatterInCourt, detailsOfComplaint,
                availabilityDate, complaintDate, submittedBy, submittedBy_PhoneNumber,
                documentList, complaintStatus, source,createdBy);

            // Assert
            Assert.NotNull(complaint);
            Assert.Equal(complaintId, complaint.ComplaintId);
            Assert.NotEqual(complaintNumber, complaint.ComplaintNumber);
            Assert.Equal(complaintTypeId, complaint.ComplaintTypeId);
            Assert.Equal(natureOfComplaintId, complaint.NatureOfComplaintId);
            Assert.Equal(propertyNumber, complaint.PropertyNumber);
            Assert.Equal(propertyLocation, complaint.PropertyLocation);
            Assert.Equal(customerCode, complaint.CustomerCode);
            Assert.Equal(customerName, complaint.CustomerName);
            Assert.Equal(phoneNumber, complaint.PhoneNumber);
            Assert.Null(complaint.EmailAddress);
            Assert.Null(complaint.IsTheMatterInCourt);
            Assert.Equal(detailsOfComplaint, complaint.DetailsOfComplaint);
            Assert.Equal(availabilityDate, complaint.AvailabilityDate);
            Assert.Null(complaint.DocumentList);
            Assert.Equal(complaintStatus, complaint.ComplaintStatus);
        }

        #endregion

        #region Default Constructor Tests

        [Fact]
        public void DefaultConstructor_ShouldCreateEmptyInstance()
        {
            // Act
            var complaint = new Complaint();

            // Assert
            Assert.NotNull(complaint);
            Assert.Equal(0, complaint.ComplaintId);
            Assert.Null(complaint.ComplaintNumber);
            Assert.Equal(0, complaint.ComplaintTypeId);
            Assert.Null(complaint.NatureOfComplaintId);
            Assert.Null(complaint.PropertyNumber);
            Assert.Null(complaint.PropertyLocation);
            Assert.Null(complaint.CustomerCode);
            Assert.Null(complaint.CustomerName);
            Assert.Null(complaint.PhoneNumber);
            Assert.Null(complaint.EmailAddress);
            Assert.Null(complaint.IsTheMatterInCourt);
            Assert.Null(complaint.DetailsOfComplaint);
            Assert.Equal(default(DateTime), complaint.AvailabilityDate);
            Assert.Equal(default(DateTime), complaint.ComplaintDate);
            Assert.Null(complaint.SubmittedBy);
            Assert.Null(complaint.SubmittedBy_PhoneNumber);
            Assert.Null(complaint.DocumentList);
            Assert.Equal(default(ComplaintStatusEnum), complaint.ComplaintStatus);
            Assert.Equal(0, complaint.DispatachedTo_Department);
            Assert.Equal(0, complaint.DispatachedTo_DepartmentUnit);
            Assert.Null(complaint.AssignedTo);
            Assert.Null(complaint.Notes);
            Assert.Equal(default(ComplaintSourceEnum), complaint.Source);
        }

        #endregion

        
    }
}

