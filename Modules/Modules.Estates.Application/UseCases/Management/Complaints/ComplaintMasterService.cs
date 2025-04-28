// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using Microsoft.Extensions.Logging;


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

                _complaint.AssignedTo = values.AssignedTo;
                _complaint.ComplaintStatus = ComplaintStatusEnum.ASSIGNED;

                _unitOfWork.Complaint.Update(_complaint);

                ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, _complaint.ComplaintNumber, ComplaintStatusEnum.ASSIGNED, values.AssignedBy, DateTime.UtcNow);
                _unitOfWork.ComplaintHistory.Insert(complaintHistory);
                await _unitOfWork.Complete();

                //send to online customer
                await _moduleComms.SendComplaintAssignedAsync(values);

                return new BaseResponseDto { StatusCode = 200, StatusMessage = "Complaint assigned successfully." };
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

                _complaint.ComplaintStatus = ComplaintStatusEnum.CANCELLED;

                _unitOfWork.Complaint.Update(_complaint);

                ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, _complaint.ComplaintNumber, ComplaintStatusEnum.CANCELLED, values.CancelledBy, DateTime.UtcNow);
                _unitOfWork.ComplaintHistory.Insert(complaintHistory);
                await _unitOfWork.Complete();

                //send to online customer
                await _moduleComms.SendComplaintCancelledAsync(values);

                return new BaseResponseDto { StatusCode = 200, StatusMessage = "Complaint cancelled successfully." };
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
                    complaintNumber: values.ComplaintNumber!,
                    complaintTypeId: values.ComplaintTypeId,
                    natureOfComplaintId: natureofComplaint,
                    propertyNumber: values.PropertyNumber!,
                    propertyLocation: values.PropertyLocation!,
                    customerCode: values.CustomerCode!,
                    customerName: values.CustomerName!,
                    phoneNumber: values.PhoneNumber!,
                    emailAddress: values.EmailAddress!,
                    isTheMatterInCourt: values.IsTheMatterInCourt!,
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

                _unitOfWork.Complaint.Insert(complaint);

                ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, complaint.ComplaintNumber, ComplaintStatusEnum.SUBMITTED, values.CreatedBy, DateTime.UtcNow);
                _unitOfWork.ComplaintHistory.Insert(complaintHistory);
                await _unitOfWork.Complete();

                if (values.Source == ComplaintSourceEnum.STAFF)
                {
                    //send to online customer
                    values.ComplaintNumber = complaint.ComplaintNumber;
                    await _moduleComms.SendSubmittedComplaintDetailsAsync(values);
                }

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

        public async Task<ComplaintDto> GetComplaintDetails(string complaintNumber)
        {
            var complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == complaintNumber);

            if (complaint == null)
            {
                return null!;
            }

            string[] natureofComplaints = complaint.NatureOfComplaintId!.Split(',');
            List<NatureOfComplaints> natureofComplaints_list = new List<NatureOfComplaints>();

            foreach (var item in natureofComplaints)
            {
                var result = await _unitOfWork.NatureOfComplaint.Get(n => n.NatureOfComplaintId == Convert.ToInt32(item));
                natureofComplaints_list.Add(new NatureOfComplaints(result!.NatureOfComplaintId, result.NatureOfComplaints!));
            }

            var response = new ComplaintDto
            {
                ComplaintId = complaint.ComplaintId,
                ComplaintNumber = complaint.ComplaintNumber,
                ComplaintTypeId = complaint.ComplaintTypeId,
                ComplaintType = (await _unitOfWork.ComplaintType.Get(c => c.ComplaintTypeId == complaint.ComplaintTypeId))!.ComplaintTypes,
                NatureOfComplaint = natureofComplaints_list,
                PropertyNumber = complaint.PropertyNumber,
                PropertyLocation = complaint.PropertyLocation,
                CustomerCode = complaint.CustomerCode,
                CustomerName = complaint.CustomerName,
                PhoneNumber = complaint.PhoneNumber,
                EmailAddress = complaint.EmailAddress,
                IsTheMatterInCourt = complaint.IsTheMatterInCourt,
                DetailsOfComplaint = complaint.DetailsOfComplaint!.Trim(),
                ComplaintDate = complaint.ComplaintDate,
                SubmittedBy = complaint.SubmittedBy,
                SubmittedBy_PhoneNumber = complaint.SubmittedBy_PhoneNumber,
                DocumentList = new List<string> { complaint.DocumentOne!, complaint.DocumentTwo!, complaint.DocumentThree! }.Where(d => !string.IsNullOrWhiteSpace(d)).ToList(),
                ComplaintStatus = await GetComplaintStatus(complaintNumber)
            };

            return response;
        }

        private async Task<List<ComplaintHistoryReadDto>> GetComplaintStatus(string complaintNumber)
        {

            var result = (from a in await _unitOfWork.ComplaintHistory.GetAll(ch => ch.ComplaintNumber == complaintNumber)
                          join b in await _unitOfWork.ComplaintStatuses.GetAll()
                          on (int)a.ComplaintStatus equals b.ComplaintStatusId
                          orderby a.ActionOn descending
                          select new ComplaintHistoryReadDto
                          {
                              ComplaintStatus = b.ComplaintStatus!,
                              ComplaintDescription =  b.Description!,
                              ActionOn = a.ActionOn
                          }).ToList();

            return result;

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
                    ComplaintStatus: ComplaintStatusEnumDescription.GetEnumDescription(complaint.ComplaintStatus),
                    CustomerName: complaint.CustomerName
                );

                _allComplaints.Add(response);
            }

            return _allComplaints;
        }

        public async Task<ComplaintStaffReadDto> GetComplaintSummary(string complaintNumber)
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
                ComplaintStatus: ComplaintStatusEnumDescription.GetEnumDescription(complaint.ComplaintStatus),
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
                    ComplaintStatus: ComplaintStatusEnumDescription.GetEnumDescription(complaint.ComplaintStatus),
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

                _complaint.ComplaintStatus = ComplaintStatusEnum.RESOLVED;

                _unitOfWork.Complaint.Update(_complaint);

                ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, _complaint.ComplaintNumber, ComplaintStatusEnum.RESOLVED, values.ResolvedBy, DateTime.UtcNow);
                _unitOfWork.ComplaintHistory.Insert(complaintHistory);
                await _unitOfWork.Complete();

                //send to online customer
                await _moduleComms.SendComplaintResolvedAsync(values);


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

                _complaint.ComplaintStatus = ComplaintStatusEnum.REVIEWED;

                _unitOfWork.Complaint.Update(_complaint);

                ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, _complaint.ComplaintNumber, ComplaintStatusEnum.REVIEWED, values.ReviewedBy, DateTime.UtcNow);
                _unitOfWork.ComplaintHistory.Insert(complaintHistory);
                await _unitOfWork.Complete();

                //send to online customer
                await _moduleComms.SendComplaintReviewAsync(values);

                return new BaseResponseDto { StatusCode = 200, StatusMessage = "Complaint reviewed successfully." };

            }
            catch (Exception ex)
            {
                return new BaseResponseDto { StatusCode = 500, StatusMessage = ex.InnerException!.Message };
            }
        }

        public async Task<BaseResponseDto> UpdateComplaint(ComplaintUpdateDto values)
        {
            string _imageOne = string.Empty; string _imageTwo = string.Empty; string _imageThree = string.Empty;
            int imageCount;

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
                _complaint.DocumentOne = _imageOne;
                _complaint.DocumentTwo = _imageTwo;
                _complaint.DocumentThree = _imageThree;

                _unitOfWork.Complaint.Update(_complaint);
                await _unitOfWork.Complete();

                //send to online customer
                await _moduleComms.SendModifiedComplaintDetailsAsync(values);

                return new BaseResponseDto { StatusCode = 200, StatusMessage = "Complaint updated successfully." };

            }
            catch (Exception ex)
            {
                return new BaseResponseDto { StatusCode = 500, StatusMessage = ex.InnerException!.Message };
            }
        }

        public async Task<BaseResponseDto> AcknowledgeComplaint(ComplaintAcknowledgmentDto values)
        {
            try
            {
                var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

                if (_complaint is null)
                {
                    return new BaseResponseDto { StatusCode = 404, StatusMessage = $"Complaint number {values.ComplaintNumber} doesnot exist." };
                }

                _complaint.ComplaintStatus = ComplaintStatusEnum.ACKNOWLEDGED;
                _unitOfWork.Complaint.Update(_complaint);

                ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, _complaint.ComplaintNumber, ComplaintStatusEnum.ACKNOWLEDGED, values.AcknowledgedBy, DateTime.UtcNow);
                _unitOfWork.ComplaintHistory.Insert(complaintHistory);
                await _unitOfWork.Complete();

                //send to online customer
                await _moduleComms.SendComplaintAcknowledgmentAsync(values);

                return new BaseResponseDto { StatusCode = 200, StatusMessage = "Complaint acknowledged successfully." };

            }
            catch (Exception ex)
            {
                return new BaseResponseDto { StatusCode = 500, StatusMessage = ex.InnerException!.Message };
            }

        }

        public async Task<BaseResponseDto> DispatchComplaint(ComplaintDispatchedDto values)
        {
            try
            {
                var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

                if (_complaint is null)
                {
                    return new BaseResponseDto { StatusCode = 404, StatusMessage = $"Complaint number {values.ComplaintNumber} doesnot exist." };
                }

                _complaint.DispatachedTo_Department = values.DispatchedTo_DepartmentId;
                _complaint.DispatachedTo_DepartmentUnit = values.DispatchedTo_DepartmentUnitId;
                _complaint.ComplaintStatus = ComplaintStatusEnum.DISPATCHED;
                _unitOfWork.Complaint.Update(_complaint);

                ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, _complaint.ComplaintNumber, ComplaintStatusEnum.DISPATCHED, values.DispatchedBy, DateTime.UtcNow);
                _unitOfWork.ComplaintHistory.Insert(complaintHistory);
                await _unitOfWork.Complete();

                //send to online customer
                await _moduleComms.SendComplaintDispatchAsync(values);

                return new BaseResponseDto { StatusCode = 200, StatusMessage = "Complaint dispatched successfully." };

            }
            catch (Exception ex)
            {
                return new BaseResponseDto { StatusCode = 500, StatusMessage = ex.InnerException!.Message };
            }

        }

        public async Task<BaseResponseDto> ReopenComplaint(ComplaintReopenedDto values)
        {
            try
            {
                var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

                if (_complaint is null)
                {
                    return new BaseResponseDto { StatusCode = 404, StatusMessage = $"Complaint number {values.ComplaintNumber} doesnot exist." };
                }

                _complaint.ComplaintStatus = ComplaintStatusEnum.REOPEN;
                _unitOfWork.Complaint.Update(_complaint);

                ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, _complaint.ComplaintNumber, ComplaintStatusEnum.REOPEN, values.ReopenedBy, DateTime.UtcNow);
                _unitOfWork.ComplaintHistory.Insert(complaintHistory);
                await _unitOfWork.Complete();

                //send to online customer
                await _moduleComms.SendComplaintReopenAsync(values);

                return new BaseResponseDto { StatusCode = 200, StatusMessage = "Complaint reopened successfully." };

            }
            catch (Exception ex)
            {
                return new BaseResponseDto { StatusCode = 500, StatusMessage = ex.InnerException!.Message };
            }

        }

        public async Task<BaseResponseDto> CloseComplaint(ComplaintClosedDto values)
        {
            try
            {
                var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

                if (_complaint is null)
                {
                    return new BaseResponseDto { StatusCode = 404, StatusMessage = $"Complaint number {values.ComplaintNumber} doesnot exist." };
                }

                _complaint.ComplaintStatus = ComplaintStatusEnum.CLOSED;
                _unitOfWork.Complaint.Update(_complaint);

                ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, _complaint.ComplaintNumber, ComplaintStatusEnum.CLOSED, values.ClosedBy, DateTime.UtcNow);
                _unitOfWork.ComplaintHistory.Insert(complaintHistory);

                await _unitOfWork.Complete();

                //send to online customer
                await _moduleComms.SendComplaintClosedAsync(values);


                return new BaseResponseDto { StatusCode = 200, StatusMessage = "Complaint closed successfully." };

            }
            catch (Exception ex)
            {
                return new BaseResponseDto { StatusCode = 500, StatusMessage = ex.InnerException!.Message };
            }

        }



    }
}

