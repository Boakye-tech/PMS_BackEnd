using System;
using Microsoft.Extensions.Logging;
using Modules.Estates.Application.DTO.Management.Complaints;
using Modules.Estates.Application.Enums;
using Modules.Estates.Application.Interfaces.Management.Complaints;
using Modules.Estates.Application.UseCases.Management.Customer;

namespace Modules.Estates.Application.UseCases.Management.Complaints
{
	public class ComplaintMasterService : IComplaintMasterService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomerDomainService _domainService;
        private readonly IModuleCommunicationServices _moduleComms;
        private readonly ILogger<ComplaintMasterService> _logger;
        private readonly IDomainEventDispatcher _domainEventDispatcher;

        public ComplaintMasterService(IUnitOfWork unitOfWork, ICustomerDomainService domainService, IModuleCommunicationServices moduleComms, ILogger<ComplaintMasterService> logger, IDomainEventDispatcher domainEventDispatcher)
        {
            _unitOfWork = unitOfWork;
            _domainService = domainService;
            _moduleComms = moduleComms;
            _logger = logger;
            _domainEventDispatcher = domainEventDispatcher;
        }

        public async Task<BaseResponseDto> AssignComplaint(ComplaintAssignDto values)
        {
            try
            {
                var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

                if (_complaint is null)
                {
                    return new BaseResponseDto { StatusCode = 404, StatusMessage = $"Complaint number {values.ComplaintNumber} doesnot exist." };
                }

                _complaint.AssignedBy = values.AssignedBy;
                _complaint.AssignedTo = values.AssignedTo;
                _complaint.DateAssigned = DateTime.UtcNow;
                _complaint.ComplaintStatus = (int)ComplaintStatusEnum.ASSIGNED;

                _unitOfWork.Complaint.Update(_complaint);
                await _unitOfWork.Complete();

                return new BaseResponseDto { StatusCode = 200, StatusMessage = "Complaint reviewed successfully." };

            }
            catch (Exception ex)
            {
                return new BaseResponseDto { StatusCode = 500, StatusMessage = ex.InnerException!.Message };
            }

        }

        public async Task<BaseResponseDto> CancelComplaint(ComplaintCancellationDto values)
        {
            try
            {
                var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

                if (_complaint is null)
                {
                    return new BaseResponseDto { StatusCode = 404, StatusMessage = $"Complaint number {values.ComplaintNumber} doesnot exist." };
                }

                _complaint.CancelledBy = values.CancelledBy;
                _complaint.CancelledDate = DateTime.UtcNow;
                _complaint.ComplaintStatus = (int)ComplaintStatusEnum.CANCELLED;

                _unitOfWork.Complaint.Update(_complaint);
                await _unitOfWork.Complete();

                return new BaseResponseDto { StatusCode = 200, StatusMessage = "Complaint resolved successfully." };

            }
            catch (Exception ex)
            {
                return new BaseResponseDto { StatusCode = 500, StatusMessage = ex.InnerException!.Message };
            }
        }

        public async Task<BaseResponseDto> CreateNewComplaint(ComplaintCreateDto values)
        {
            try
            {
                Complaint complaint = Complaint.CreateNewComplaint(
                    complaintId: 0,
                    complaintNumber: string.Empty,
                    complaintTypeId: values.ComplaintTypeId,
                    natureOfComplaintId: values.NatureOfComplaintId,
                    propertyNumber: values.PropertyNumber!,
                    propertyLocationId: values.PropertyLocationId,
                    customerCode: values.CustomerCode!,
                    customerName: values.CustomerName!,
                    phoneNumber: values.PhoneNumber!,
                    emailAddress: values.EmailAddress!,
                    isTheMatterInCourt: values.IsTheMatterInCourt,
                    detailsOfComplaint: values.DetailsOfComplaint!,
                    availabilityDate: values.AvailabilityDate,
                    complaintDate: DateTime.UtcNow,
                    submittedBy: values.SubmittedBy!,
                    submittedBy_PhoneNumber: values.SubmittedBy_PhoneNumber!,
                    documentOne: values.DocumentImages![0],
                    documentTwo: values.DocumentImages![1],
                    documentThree: values.DocumentImages![2],
                    complaintStatus: (int)ComplaintStatusEnum.SUBMITTED,
                    createdBy: values.CreatedBy!
                    );

                complaint.CreatedOn = DateTime.UtcNow;

                _unitOfWork.Complaint.Insert(complaint);
                await _unitOfWork.Complete();

                return new BaseResponseDto { StatusCode = 200, StatusMessage = "Complaint submitted successfully." };
            }
            catch (Exception ex)
            {
                return new BaseResponseDto { StatusCode = 500, StatusMessage = ex.InnerException!.Message };
            }
        }

        public Task<BaseResponseDto> DeleteComplaint(string ComplaintNumber)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ComplaintStaffReadDto>> GetComplaintsList()
        {
            // Perform a left outer join in-memory using LINQ
            var response = (
                from c in await _unitOfWork.Complaint.GetAll()
                join n in await _unitOfWork.NatureOfComplaint.GetAll()
                    on c.NatureOfComplaintId equals n.NatureOfComplaintId into gj
                from nature in gj.DefaultIfEmpty() // this ensures it's a LEFT JOIN
                orderby c.ComplaintDate descending
                select new ComplaintStaffReadDto(
                    c.ComplaintNumber,
                    nature?.NatureOfComplaints, // safe access in case there's no match
                    c.PropertyNumber,
                    c.ComplaintDate,
                    c.ComplaintStatus.ToString(),
                    c.CustomerName
                )
            ).ToList();

            return response;
        }

        public Task<IEnumerable<ComplaintReadDto>> GetCustomerComplaintsList(string customerCode_OR_propertyNumber)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponseDto> ResolveComplaint(ComplaintResolutionDto values)
        {
            try
            {
                var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

                if (_complaint is null)
                {
                    return new BaseResponseDto { StatusCode = 404, StatusMessage = $"Complaint number {values.ComplaintNumber} doesnot exist." };
                }

                _complaint.ResolvedBy = values.ResolvedBy;
                _complaint.ResolutionDate = DateTime.UtcNow;
                _complaint.ComplaintStatus = (int)ComplaintStatusEnum.RESOLVED;

                _unitOfWork.Complaint.Update(_complaint);
                await _unitOfWork.Complete();

                return new BaseResponseDto { StatusCode = 200, StatusMessage = "Complaint resolved successfully." };

            }
            catch (Exception ex)
            {
                return new BaseResponseDto { StatusCode = 500, StatusMessage = ex.InnerException!.Message };
            }

        }

        public async Task<BaseResponseDto> ReviewComplaint(ComplaintReviewDto values)
        {
            try
            {
                var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

                if (_complaint is null)
                {
                    return new BaseResponseDto { StatusCode = 404, StatusMessage = $"Complaint number {values.ComplaintNumber} doesnot exist." };
                }

                _complaint.ReviewedBy = values.ReviewedBy;
                _complaint.DateReviewed = DateTime.UtcNow;
                _complaint.ComplaintStatus = (int)ComplaintStatusEnum.REVIEWED;

                _unitOfWork.Complaint.Update(_complaint);
                await _unitOfWork.Complete();

                return new BaseResponseDto { StatusCode = 200, StatusMessage = "Complaint reviewed successfully." };

            }
            catch (Exception ex)
            {
                return new BaseResponseDto { StatusCode = 500, StatusMessage = ex.InnerException!.Message };
            }
        }

        public async Task<BaseResponseDto> UpdateComplaint(ComplaintUpdateDto values)
        {
            try
            {
                var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

                if (_complaint is null)
                {
                    return new BaseResponseDto { StatusCode = 404, StatusMessage = $"Complaint number {values.ComplaintNumber} doesnot exist." };
                }

                _complaint.PhoneNumber = values.PhoneNumber;
                _complaint.EmailAddress = values.EmailAddress;
                _complaint.IsTheMatterInCourt = values.IsTheMatterInCourt;
                _complaint.DetailsOfComplaint = values.DetailsOfComplaint;
                _complaint.AvailabilityDate = values.AvailabilityDate;
                _complaint.DocumentOne = values.DocumentImages![0];
                _complaint.DocumentTwo = values.DocumentImages![1];
                _complaint.DocumentThree = values.DocumentImages![2];
                _complaint.ModifiedBy = values.ModifiedBy;
                _complaint.ModifiedOn = DateTime.UtcNow;

                _unitOfWork.Complaint.Update(_complaint);
                await _unitOfWork.Complete();

                return new BaseResponseDto { StatusCode = 200, StatusMessage = "Complaint updated successfully." };

            }
            catch (Exception ex)
            {
                return new BaseResponseDto { StatusCode = 500, StatusMessage = ex.InnerException!.Message };
            }
        }



    }
}

