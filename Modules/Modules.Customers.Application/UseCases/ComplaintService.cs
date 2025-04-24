using System;
using Microsoft.Extensions.Logging;
using Modules.Customers.Domain.Enums;

namespace Modules.Customers.Application.UseCases
{
	public class ComplaintService: IComplaintService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        //private readonly ICustomerDomainService _domainService;
        private readonly ICustomerModuleCommunicationServices _moduleComms;
        private readonly ILogger<ComplaintService> _logger;
        //private readonly IDomainEventDispatcher _domainEventDispatcher;

        public ComplaintService(IUnitOfWork unitOfWork, ICustomerModuleCommunicationServices moduleComms, IMapper mapper,  ILogger<ComplaintService> logger) //ICustomerDomainService domainService, , IDomainEventDispatcher domainEventDispatcher
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            //_domainService = domainService;
            _moduleComms = moduleComms;
            _logger = logger;
            //_domainEventDispatcher = domainEventDispatcher;
        }

        public async Task<GenericResponseDto> AddNewComplaint(ComplaintCreateDto values)
        {
            string _imageOne = string.Empty; string _imageTwo = string.Empty; string _imageThree = string.Empty;
            int imageCount;
            string natureofComplaint = string.Empty;

            if (values.NatureOfComplaintId!.Count() == 0)
            {
                return new GenericResponseDto{ response = "204 - Nature of complaint cannot be null or empty" };
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
                    complaintStatus: ComplaintStatus.SUBMITTED,
                    source: values.Source
                    );

                _unitOfWork.Complaint.Insert(complaint);
                //await _unitOfWork.Complete();

                ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, complaint.ComplaintNumber, ComplaintStatus.SUBMITTED, values.CreatedBy, DateTime.UtcNow);
                _unitOfWork.ComplaintHistory.Insert(complaintHistory);
                await _unitOfWork.Complete();


                if (values.Source == ComplaintSource.CUSTOMER)
                {
                    //send to staff module
                    values.ComplaintNumber = complaint.ComplaintNumber;
                    await _moduleComms.SendSubmittedComplaintDetailsAsync(values);
                }

                return new GenericResponseDto{ response = complaint.ComplaintNumber! };
            }
            catch (Exception ex)
            {
                return new GenericResponseDto { response = ex.ToString() };
            }
        }

        public async Task<GenericResponseDto> AssignComplaint(ComplaintAssignDto values)
        {
            var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

            if (_complaint is null)
            {
                return new GenericResponseDto { response = "Complaint number supplied doesnot exist." };
            }

            _complaint.AssignedTo = values.AssignedTo;
            _complaint.ComplaintStatus = ComplaintStatus.ASSIGNED;

            _unitOfWork.Complaint.Update(_complaint);
            //await _unitOfWork.Complete();

            ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, _complaint.ComplaintNumber, ComplaintStatus.ASSIGNED, values.AssignedBy, DateTime.UtcNow);
            _unitOfWork.ComplaintHistory.Insert(complaintHistory);
            await _unitOfWork.Complete();


            return new GenericResponseDto { response = "Complaint reviewed successfully." };

        }

        public async Task<GenericResponseDto> CancelComplaint(ComplaintCancellationDto values)
        {
            var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

            if (_complaint is null)
            {
                return new GenericResponseDto { response = "Complaint number supplied doesnot exist." };
            }

            _complaint.ComplaintStatus = ComplaintStatus.CANCELLED;
            _unitOfWork.Complaint.Update(_complaint);

            ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, _complaint.ComplaintNumber, ComplaintStatus.CANCELLED, values.CancelledBy, DateTime.UtcNow);
            _unitOfWork.ComplaintHistory.Insert(complaintHistory);
            await _unitOfWork.Complete();


            return new GenericResponseDto { response = "Complaint cancelled successfully." };
        }

        public Task<GenericResponseDto> DeleteComplaint(string complaintNumber)
        {
            throw new NotImplementedException();
            //var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

            //if (_complaint is null)
            //{
            //    return new GenericResponseDto { response = "Complaint number supplied doesnot exist." };
            //}

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
                var result =  await _unitOfWork.NatureOfComplaint.Get(n => n.NatureOfComplaintId == Convert.ToInt32(item));
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
                DocumentList = new List<string> { complaint.DocumentOne!, complaint.DocumentTwo!, complaint.DocumentThree! },
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
                              ComplaintDescription = b.Description!,
                              ActionOn = a.ActionOn
                          }).ToList();

            return result;

        }

        public Task<IEnumerable<ComplaintReadDto>> GetComplaintsList()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ComplaintReadDto>> GetComplaintsList(string customerCode_OR_propertyNumber)
        {
            List<ComplaintReadDto> response = new List<ComplaintReadDto>();
            var complaintList = await _unitOfWork.Complaint.GetAll(c => c.CustomerCode == customerCode_OR_propertyNumber || c.PropertyNumber == customerCode_OR_propertyNumber);

            foreach (var complaint in complaintList)
            {
                var result = await GetComplaintSummary(complaint.ComplaintNumber!);
                response.Add(result);
            }

            return response;
        }

        public async Task<ComplaintReadDto> GetComplaintSummary(string complaintNumber)
        {
            var complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == complaintNumber);

            if (complaint == null)
            {
                return new ComplaintReadDto(null, null, null, DateTime.Now, null);
            }

            string[] natureofComplaints = complaint.NatureOfComplaintId!.Split(',');
            List<string> natureofComplaints_list = new List<string>();

            foreach (var item in natureofComplaints)
            {
                var result = (await _unitOfWork.NatureOfComplaint.Get(n => n.NatureOfComplaintId == Convert.ToInt32(item)))!.NatureOfComplaints;
                natureofComplaints_list.Add(result!);
            }

            var response = new ComplaintReadDto
            (
                ComplaintNumber: complaint.ComplaintNumber,
                NatureOfComplaint: natureofComplaints_list,
                PropertyNumber: complaint.PropertyNumber,
                ComplaintDate: complaint.ComplaintDate,
                ComplaintStatus: ComplaintStatusDescription.GetEnumDescription(complaint.ComplaintStatus)
            );

            return response;

        }

        public async Task<GenericResponseDto> ResolveComplaint(ComplaintResolutionDto values)
        {
            var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

            if (_complaint is null)
            {
                return new GenericResponseDto { response = "Complaint number supplied doesnot exist." };
            }

            _complaint.ComplaintStatus = ComplaintStatus.RESOLVED;
            _unitOfWork.Complaint.Update(_complaint);

            ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, _complaint.ComplaintNumber, ComplaintStatus.RESOLVED, values.ResolvedBy, DateTime.UtcNow);
            _unitOfWork.ComplaintHistory.Insert(complaintHistory);
            await _unitOfWork.Complete();

            return new GenericResponseDto { response = "Complaint resolved successfully." };
        }

        public async Task<GenericResponseDto> ReviewComplaint(ComplaintReviewDto values)
        {
            var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

            if (_complaint is null)
            {
                return new GenericResponseDto { response = "Complaint number supplied doesnot exist." };
            }

            _complaint.ComplaintStatus = ComplaintStatus.REVIEWED;
            _unitOfWork.Complaint.Update(_complaint);

            ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, _complaint.ComplaintNumber, ComplaintStatus.REVIEWED, values.ReviewedBy, DateTime.UtcNow);
            _unitOfWork.ComplaintHistory.Insert(complaintHistory);
            await _unitOfWork.Complete();


            return new GenericResponseDto { response = "Complaint reviewed successfully." };
        }

        public async Task<GenericResponseDto> UpdateComplaint(ComplaintUpdateDto values)
        {
            //check for existing complaint
            var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

            if(_complaint is null)
            {
                return new GenericResponseDto { response = "Complaint number supplied doesnot exist." };
            }

            _complaint.PhoneNumber = values.PhoneNumber;
            _complaint.EmailAddress = values.EmailAddress;
            _complaint.IsTheMatterInCourt = values.IsTheMatterInCourt;
            _complaint.DetailsOfComplaint = values.DetailsOfComplaint;
            _complaint.AvailabilityDate = values.AvailabilityDate;
            _complaint.DocumentOne = values.DocumentImages![0];
            _complaint.DocumentTwo = values.DocumentImages![1];
            _complaint.DocumentThree = values.DocumentImages![2];
           
            _unitOfWork.Complaint.Update(_complaint);
            await _unitOfWork.Complete();

            return new GenericResponseDto { response = "Complaint updated successfully." };

        }

        public async Task<GenericResponseDto> AcknowledgeComplaint(ComplaintAcknowledgmentDto values)
        {
            var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

            if (_complaint is null)
            {
                return new GenericResponseDto { response = "Complaint number supplied doesnot exist." };
            }

            _complaint.ComplaintStatus = ComplaintStatus.ACKNOWLEDGED;
            _unitOfWork.Complaint.Update(_complaint);

            ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, _complaint.ComplaintNumber, ComplaintStatus.ACKNOWLEDGED, values.AcknowledgedBy, DateTime.UtcNow);
            _unitOfWork.ComplaintHistory.Insert(complaintHistory);
            await _unitOfWork.Complete();

            return new GenericResponseDto { response = "Complaint acknowledged successfully." };

        }

        public async Task<GenericResponseDto> DispatchComplaint(ComplaintDispatchedDto values)
        {
            var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

            if (_complaint is null)
            {
                return new GenericResponseDto { response = "Complaint number supplied doesnot exist." };
            }

            _complaint.DispatachedTo_Department = values.DispatchedTo_DepartmentId;
            _complaint.DispatachedTo_DepartmentUnit = values.DispatchedTo_DepartmentUnitId;
            _complaint.ComplaintStatus = ComplaintStatus.DISPATCHED;
            _unitOfWork.Complaint.Update(_complaint);

            ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, _complaint.ComplaintNumber, ComplaintStatus.DISPATCHED, values.DispatchedBy, DateTime.UtcNow);
            _unitOfWork.ComplaintHistory.Insert(complaintHistory);
            await _unitOfWork.Complete();

            return new GenericResponseDto { response = "Complaint dispatched successfully." };

        }

        public async Task<GenericResponseDto> ReopenComplaint(ComplaintReopenedDto values)
        {
            var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

            if (_complaint is null)
            {
                return new GenericResponseDto { response = "Complaint number supplied doesnot exist." };
            }

            _complaint.ComplaintStatus = ComplaintStatus.REOPEN;
            _unitOfWork.Complaint.Update(_complaint);

            ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, _complaint.ComplaintNumber, ComplaintStatus.REOPEN, values.ReopenedBy, DateTime.UtcNow);
            _unitOfWork.ComplaintHistory.Insert(complaintHistory);
            await _unitOfWork.Complete();

            return new GenericResponseDto { response = "Complaint reopened successfully." };

        }

        public async Task<GenericResponseDto> CloseComplaint(ComplaintClosedDto values)
        {
            var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

            if (_complaint is null)
            {
                return new GenericResponseDto { response = "Complaint number supplied doesnot exist." };
            }

            _complaint.ComplaintStatus = ComplaintStatus.CLOSED;
            _unitOfWork.Complaint.Update(_complaint);

            ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, _complaint.ComplaintNumber, ComplaintStatus.CLOSED, values.ClosedBy, DateTime.UtcNow);
            _unitOfWork.ComplaintHistory.Insert(complaintHistory);
            await _unitOfWork.Complete();

            return new GenericResponseDto { response = "Complaint closed successfully." };

        }


    }
}

