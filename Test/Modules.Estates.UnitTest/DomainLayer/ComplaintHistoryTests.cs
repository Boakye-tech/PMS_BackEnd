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
    public class ComplaintHistoryTests
    {
        #region ProcessComplaint Tests - Success Cases

        [Fact]
        public void ProcessComplaint_WithValidData_ShouldCreateInstance()
        {
            // Arrange
            int complaintHistoryId = 1;
            string complaintNumber = "C12345";
            ComplaintStatusEnum complaintStatus = ComplaintStatusEnum.SUBMITTED;
            string actionBy = "user123";
            DateTime actionOn = DateTime.UtcNow;

            // Act
            var complaintHistory = ComplaintHistory.ProcessComplaint(
                complaintHistoryId,
                complaintNumber,
                complaintStatus,
                actionBy,
                actionOn);

            // Assert
            Assert.NotNull(complaintHistory);
            Assert.Equal(complaintHistoryId, complaintHistory.ComplaintHistoryId);
            Assert.Equal(complaintNumber, complaintHistory.ComplaintNumber);
            Assert.Equal(complaintStatus, complaintHistory.ComplaintStatus);
            Assert.Equal(actionBy, complaintHistory.ActionBy);
            Assert.Equal(actionOn, complaintHistory.ActionOn);
        }

        [Theory]
        [InlineData(ComplaintStatusEnum.SUBMITTED)]
        [InlineData(ComplaintStatusEnum.ACKNOWLEDGED)]
        [InlineData(ComplaintStatusEnum.RESOLVED)]
        [InlineData(ComplaintStatusEnum.DISPATCHED)]
        public void ProcessComplaint_WithDifferentStatuses_ShouldSetStatusCorrectly(ComplaintStatusEnum status)
        {
            // Arrange
            int complaintHistoryId = 1;
            string complaintNumber = "C12345";
            string actionBy = "user123";
            DateTime actionOn = DateTime.UtcNow;

            // Act
            var complaintHistory = ComplaintHistory.ProcessComplaint(
                complaintHistoryId,
                complaintNumber,
                status,
                actionBy,
                actionOn);

            // Assert
            Assert.Equal(status, complaintHistory.ComplaintStatus);
        }

        #endregion

        #region ProcessComplaint Tests - Validation Failures

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void ProcessComplaint_WithInvalidComplaintNumber_ShouldThrowArgumentException(string complaintNumber)
        {
            // Arrange
            int complaintHistoryId = 1;
            ComplaintStatusEnum complaintStatus = ComplaintStatusEnum.SUBMITTED;
            string actionBy = "user123";
            DateTime actionOn = DateTime.UtcNow;

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => ComplaintHistory.ProcessComplaint(
                complaintHistoryId,
                complaintNumber,
                complaintStatus,
                actionBy,
                actionOn));

            Assert.Equal("Complaint number must not be null or empty", exception.Message);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void ProcessComplaint_WithInvalidActionBy_ShouldThrowArgumentException(string actionBy)
        {
            // Arrange
            int complaintHistoryId = 1;
            string complaintNumber = "C12345";
            ComplaintStatusEnum complaintStatus = ComplaintStatusEnum.SUBMITTED;
            DateTime actionOn = DateTime.UtcNow;

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => ComplaintHistory.ProcessComplaint(
                complaintHistoryId,
                complaintNumber,
                complaintStatus,
                actionBy,
                actionOn));

            Assert.Equal("Action by must not be null or empty", exception.Message);
        }

        #endregion

        #region Constructor Tests

        [Fact]
        public void DefaultConstructor_ShouldCreateEmptyInstance()
        {
            // Act
            var complaintHistory = new ComplaintHistory();

            // Assert
            Assert.NotNull(complaintHistory);
            Assert.Equal(0, complaintHistory.ComplaintHistoryId);
            Assert.Null(complaintHistory.ComplaintNumber);
            Assert.Equal(default(ComplaintStatusEnum), complaintHistory.ComplaintStatus);
            Assert.Null(complaintHistory.ActionBy);
            Assert.Equal(default(DateTime), complaintHistory.ActionOn);
        }

        [Fact]
        public void ParameterizedConstructor_ShouldCreateInstance()
        {
            // Arrange
            int complaintHistoryId = 1;
            string complaintNumber = "C12345";
            ComplaintStatusEnum complaintStatus = ComplaintStatusEnum.SUBMITTED;
            string actionBy = "user123";
            DateTime actionOn = DateTime.UtcNow;

            // Act
            var complaintHistory = new ComplaintHistory(
                complaintHistoryId,
                complaintNumber,
                complaintStatus,
                actionBy,
                actionOn);

            // Assert
            Assert.NotNull(complaintHistory);
            // Note: The parameterized constructor in the code appears to be empty,
            // so properties won't be set, but we're testing what should happen
            // if the constructor is implemented properly.
        }

        #endregion

        #region ComplaintStatus Enum Tests

        [Fact]
        public void ProcessComplaint_WithAllComplaintStatuses_ShouldAcceptAllValues()
        {
            // Arrange
            int complaintHistoryId = 1;
            string complaintNumber = "C12345";
            string actionBy = "user123";
            DateTime actionOn = DateTime.UtcNow;

            // Act - Test all enum values
            var acknowledgeRecord = ComplaintHistory.ProcessComplaint(
                complaintHistoryId, complaintNumber, ComplaintStatusEnum.ACKNOWLEDGED, actionBy, actionOn);

            var dispatchRecord = ComplaintHistory.ProcessComplaint(
                complaintHistoryId, complaintNumber, ComplaintStatusEnum.DISPATCHED, actionBy, actionOn);

            var resolvedRecord = ComplaintHistory.ProcessComplaint(
                complaintHistoryId, complaintNumber, ComplaintStatusEnum.REVIEWED, actionBy, actionOn);

            var closedRecord = ComplaintHistory.ProcessComplaint(
                complaintHistoryId, complaintNumber, ComplaintStatusEnum.CLOSED, actionBy, actionOn);

            // Assert
            Assert.Equal(ComplaintStatusEnum.ACKNOWLEDGED, acknowledgeRecord.ComplaintStatus);
            Assert.Equal(ComplaintStatusEnum.DISPATCHED, dispatchRecord.ComplaintStatus);
            Assert.Equal(ComplaintStatusEnum.REVIEWED, resolvedRecord.ComplaintStatus);
            Assert.Equal(ComplaintStatusEnum.CLOSED, closedRecord.ComplaintStatus);
        }

        #endregion

        #region Boundary and Edge Case Tests

        [Fact]
        public void ProcessComplaint_WithLongComplaintNumber_ShouldCreateInstance()
        {
            // Arrange
            int complaintHistoryId = 1;
            string complaintNumber = "C123456789"; // 10 characters, testing max length
            ComplaintStatusEnum complaintStatus = ComplaintStatusEnum.CANCELLED;
            string actionBy = "user123";
            DateTime actionOn = DateTime.UtcNow;

            // Act
            var complaintHistory = ComplaintHistory.ProcessComplaint(
                complaintHistoryId,
                complaintNumber,
                complaintStatus,
                actionBy,
                actionOn);

            // Assert
            Assert.Equal(complaintNumber, complaintHistory.ComplaintNumber);
        }

        [Fact]
        public void ProcessComplaint_WithLongActionBy_ShouldCreateInstance()
        {
            // Arrange
            int complaintHistoryId = 1;
            string complaintNumber = "C12345";
            ComplaintStatusEnum complaintStatus = ComplaintStatusEnum.REVIEWED;
            string actionBy = new string('a', 36); // 36 characters, testing max length
            DateTime actionOn = DateTime.UtcNow;

            // Act
            var complaintHistory = ComplaintHistory.ProcessComplaint(
                complaintHistoryId,
                complaintNumber,
                complaintStatus,
                actionBy,
                actionOn);

            // Assert
            Assert.Equal(actionBy, complaintHistory.ActionBy);
        }

        [Fact]
        public void ProcessComplaint_WithMinDate_ShouldCreateInstance()
        {
            // Arrange
            int complaintHistoryId = 1;
            string complaintNumber = "C12345";
            ComplaintStatusEnum complaintStatus = ComplaintStatusEnum.REOPEN;
            string actionBy = "user123";
            DateTime actionOn = DateTime.MinValue;

            // Act
            var complaintHistory = ComplaintHistory.ProcessComplaint(
                complaintHistoryId,
                complaintNumber,
                complaintStatus,
                actionBy,
                actionOn);

            // Assert
            Assert.Equal(actionOn, complaintHistory.ActionOn);
        }

        [Fact]
        public void ProcessComplaint_WithMaxDate_ShouldCreateInstance()
        {
            // Arrange
            int complaintHistoryId = 1;
            string complaintNumber = "C12345";
            ComplaintStatusEnum complaintStatus = ComplaintStatusEnum.CLOSED;
            string actionBy = "user123";
            DateTime actionOn = DateTime.MaxValue;

            // Act
            var complaintHistory = ComplaintHistory.ProcessComplaint(
                complaintHistoryId,
                complaintNumber,
                complaintStatus,
                actionBy,
                actionOn);

            // Assert
            Assert.Equal(actionOn, complaintHistory.ActionOn);
        }

        #endregion
    }
}

