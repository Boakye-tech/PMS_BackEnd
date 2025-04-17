using System;
using Microsoft.Extensions.Logging;
using Modules.Estates.Domain.Enums;

namespace Modules.Estates.Application.UseCases.Management.Complaints
{
	public class ComplaintMasterService : IComplaintMasterService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomerDomainService _domainService;
        private readonly IModuleCommunicationServices _moduleComms;
        private readonly ILogger<ComplaintMasterService> _logger;
        private readonly IDomainEventDispatcher _domainEventDispatcher;
        private readonly IMapper _mapper;

        public ComplaintMasterService(IUnitOfWork unitOfWork, ICustomerDomainService domainService, IModuleCommunicationServices moduleComms, ILogger<ComplaintMasterService> logger, IDomainEventDispatcher domainEventDispatcher, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _domainService = domainService;
            _moduleComms = moduleComms;
            _logger = logger;
            _domainEventDispatcher = domainEventDispatcher;
            _mapper = mapper;
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
                _complaint.ComplaintStatus = ComplaintStatusEnum.ASSIGNED;

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
                _complaint.ComplaintStatus = ComplaintStatusEnum.CANCELLED;

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
            string _imageOne = string.Empty; string _imageTwo = string.Empty; string _imageThree = string.Empty; 
            int imageCount;
            string natureofComplaint = string.Empty;

            if(values.NatureOfComplaintId!.Count() == 0)
            {
                return new BaseResponseDto { StatusCode = 204 , StatusMessage = "Nature of complaint cannot be null or empty" };
            }

            natureofComplaint = string.Join(',', values.NatureOfComplaintId!);

            imageCount = values.DocumentImages!.Count();
            switch (imageCount)
            {
                case 1:
                    _imageOne = values.DocumentImages![0];
                    break;

                case 2:
                    _imageOne = values.DocumentImages![0];
                    _imageTwo = values.DocumentImages![1];
                    break;

                case 3:
                    _imageOne = values.DocumentImages![0];
                    _imageTwo = values.DocumentImages![1];
                    _imageThree = values.DocumentImages![2];
                    break;
            }

            try
            {
                Complaint complaint = Complaint.CreateNewComplaint(
                    complaintId: 0,
                    complaintNumber: string.Empty,
                    complaintTypeId: values.ComplaintTypeId,
                    natureOfComplaintId: natureofComplaint,
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
                    documentOne: _imageOne,
                    documentTwo: _imageTwo,
                    documentThree: _imageThree,
                    complaintStatus: ComplaintStatusEnum.SUBMITTED,
                    source: values.Source,
                    createdBy: values.CreatedBy!
                    );

                complaint.CreatedOn = DateTime.UtcNow;

                _unitOfWork.Complaint.Insert(complaint);
                await _unitOfWork.Complete();

                //send to online customer
                values.ComplaintNumber = complaint.ComplaintNumber;
                await _moduleComms.SendSubmittedComplaintDetailsAsync(values);

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
            List<ComplaintStaffReadDto> _allComplaints = new List<ComplaintStaffReadDto>();

            var allComplaint_Result = await _unitOfWork.Complaint.GetAll();

            if (allComplaint_Result == null)
            {
                return _allComplaints;
            }


            foreach (var complaint in allComplaint_Result!)
            {
                string[] natureofComplaints = complaint.NatureOfComplaintId!.Split(',');
                List<string> natureofComplaints_list = new List<string>();

                foreach (var item in natureofComplaints)
                {
                    var result = (await _unitOfWork.NatureOfComplaint.Get(n => n.NatureOfComplaintId == Convert.ToInt32(item)))!.NatureOfComplaints;
                    natureofComplaints_list.Add(result!);
                }

                var response = new ComplaintStaffReadDto
                (
                    ComplaintNumber: complaint.ComplaintNumber,
                    NatureOfComplaint: natureofComplaints_list,
                    PropertyNumber: complaint.PropertyNumber,
                    ComplaintDate: complaint.ComplaintDate,
                    ComplaintStatus: complaint.ComplaintStatus.ToString(),
                    CustomerName: complaint.CustomerName
                );

                _allComplaints.Add(response);
            }

            return _allComplaints;
        }

        public async Task<ComplaintStaffReadDto> GetComplaint(string complaintNumber)
        {
            var complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == complaintNumber);

            if (complaint == null)
            {
                return new ComplaintStaffReadDto(null, null, null, DateTime.Now, null, null);
            }

            string[] natureofComplaints = complaint.NatureOfComplaintId!.Split(',');
            List<string> natureofComplaints_list = new List<string>();

            foreach (var item in natureofComplaints)
            {
                var result = (await _unitOfWork.NatureOfComplaint.Get(n => n.NatureOfComplaintId == Convert.ToInt32(item)))!.NatureOfComplaints;
                natureofComplaints_list.Add(result!);
            }

            var response = new ComplaintStaffReadDto
            (
                ComplaintNumber: complaint.ComplaintNumber,
                NatureOfComplaint: natureofComplaints_list,
                PropertyNumber: complaint.PropertyNumber,
                ComplaintDate: complaint.ComplaintDate,
                ComplaintStatus: complaint.ComplaintStatus.ToString(),
                CustomerName: complaint.CustomerName
            );

            return response;
        }

        public async Task<IEnumerable<ComplaintStaffReadDto>> GetCustomerComplaintsList(string customerCode_OR_propertyNumber)
        {
            List<ComplaintStaffReadDto> _allComplaints = new List<ComplaintStaffReadDto>();

            var allComplaint_Result = await _unitOfWork.Complaint.GetAll(c => c.CustomerCode == customerCode_OR_propertyNumber || c.PropertyNumber == customerCode_OR_propertyNumber);

            if (allComplaint_Result == null)
            {
                return _allComplaints;
            }


            foreach (var complaint in allComplaint_Result!)
            {
                string[] natureofComplaints = complaint.NatureOfComplaintId!.Split(',');
                List<string> natureofComplaints_list = new List<string>();

                foreach (var item in natureofComplaints)
                {
                    var result = (await _unitOfWork.NatureOfComplaint.Get(n => n.NatureOfComplaintId == Convert.ToInt32(item)))!.NatureOfComplaints;
                    natureofComplaints_list.Add(result!);
                }

                var response = new ComplaintStaffReadDto
                (
                    ComplaintNumber: complaint.ComplaintNumber,
                    NatureOfComplaint: natureofComplaints_list,
                    PropertyNumber: complaint.PropertyNumber,
                    ComplaintDate: complaint.ComplaintDate,
                    ComplaintStatus: complaint.ComplaintStatus.ToString(),
                    CustomerName: complaint.CustomerName
                );

                _allComplaints.Add(response);
            }

            return _allComplaints;

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
                _complaint.ComplaintStatus = ComplaintStatusEnum.RESOLVED;

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
                _complaint.ComplaintStatus = ComplaintStatusEnum.REVIEWED;

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

