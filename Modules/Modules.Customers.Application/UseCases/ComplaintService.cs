// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

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
                _logger.LogWarning("Nature of complaint cannot be null or empty");
                return new GenericResponseDto{ responseCode = StatusCodes.Status204NoContent , response = "Nature of complaint cannot be null or empty" };
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

                ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, complaint.ComplaintNumber, ComplaintStatus.SUBMITTED, values.CreatedBy, DateTime.UtcNow);
                _unitOfWork.ComplaintHistory.Insert(complaintHistory);
                await _unitOfWork.Complete();

                _logger.LogInformation($"User comlaint with complaint number {complaint.ComplaintNumber} submitted successfully on {DateTime.UtcNow.ToString()}", complaint.ComplaintNumber);
                _logger.LogInformation($"User comlaint with complaint number {complaint.ComplaintNumber} submission action successful on {DateTime.UtcNow.ToString()}. Complaint submitted by {values.CreatedBy}", complaint.ComplaintNumber, values.CreatedBy);

                if (values.Source == ComplaintSource.CUSTOMER)
                {
                    //send to staff module
                    values.ComplaintNumber = complaint.ComplaintNumber;
                    var response = await _moduleComms.SendSubmittedComplaintDetailsAsync(values);

                    if (!response)
                    {
                        _logger.LogCritical($"User comlaint with complaint number {complaint.ComplaintNumber} modualar communication submitted unsuccessfully on {DateTime.UtcNow.ToString()}", complaint.ComplaintNumber);
                    }
                }

                return new GenericResponseDto{ responseCode = StatusCodes.Status200OK, response = complaint.ComplaintNumber! };
            }
            catch (Exception ex)
            {
                return new GenericResponseDto { responseCode = StatusCodes.Status500InternalServerError, response = ex.Message };
            }
        }

        public async Task<GenericResponseDto> AssignComplaint(ComplaintAssignDto values)
        {
            try
            {
                var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

                if (_complaint is null)
                {
                    _logger.LogWarning($"Complaint number {values.ComplaintNumber} supplied doesnot exist.");
                    return new GenericResponseDto { responseCode = StatusCodes.Status204NoContent, response = $"Complaint number {values.ComplaintNumber} supplied doesnot exist." };
                }

                // Status is neither DISPATCHED nor REVIEWED
                if (!new[] { ComplaintStatus.DISPATCHED, ComplaintStatus.REVIEWED }.Contains(_complaint.ComplaintStatus))
                {
                    _logger.LogWarning($"Complaint number {values.ComplaintNumber} cannot be assigned as it has not been dispatched or reviewed yet.");
                    return new GenericResponseDto { responseCode = StatusCodes.Status403Forbidden, response = $"Complaint number {values.ComplaintNumber} cannot be assigned as it has not been dispatched or reviewed yet." };
                }

                _complaint.AssignedTo = values.AssignedTo;
                _complaint.ComplaintStatus = ComplaintStatus.ASSIGNED;

                _unitOfWork.Complaint.Update(_complaint);

                ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, _complaint.ComplaintNumber, ComplaintStatus.ASSIGNED, values.AssignedBy, DateTime.UtcNow);
                _unitOfWork.ComplaintHistory.Insert(complaintHistory);
                await _unitOfWork.Complete();

                _logger.LogInformation($"Complaint Number: {values.ComplaintNumber} | Status changed from {_complaint.ComplaintStatus} to {ComplaintStatus.ASSIGNED} by {values.AssignedBy} at {DateTime.UtcNow}.");

                return new GenericResponseDto { responseCode = StatusCodes.Status200OK, response = "Complaint assigned successfully." };

            }
            catch (Exception ex)
            {
                return new GenericResponseDto { responseCode = StatusCodes.Status200OK, response = ex.Message };
            }

        }

        public async Task<GenericResponseDto> CancelComplaint(ComplaintCancellationDto values)
        {
            try
            {
                var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

                if (_complaint is null)
                {
                    _logger.LogWarning($"Complaint number {values.ComplaintNumber} supplied doesnot exist.");
                    return new GenericResponseDto { responseCode = StatusCodes.Status204NoContent, response = $"Complaint number {values.ComplaintNumber} supplied doesnot exist." };
                }

                // Status is neither SUBMITTED nor ACKNOWLEDGED
                if (!new[] { ComplaintStatus.SUBMITTED, ComplaintStatus.ACKNOWLEDGED }.Contains(_complaint.ComplaintStatus))
                {
                    _logger.LogWarning($"Complaint number {values.ComplaintNumber} cannot be cancelled at this stage.");
                    return new GenericResponseDto { responseCode = StatusCodes.Status403Forbidden, response = $"Complaint number {values.ComplaintNumber} cannot be cancelled at this stage." };
                }

                _complaint.ComplaintStatus = ComplaintStatus.CANCELLED;
                _unitOfWork.Complaint.Update(_complaint);

                ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, _complaint.ComplaintNumber, ComplaintStatus.CANCELLED, values.CancelledBy, DateTime.UtcNow);
                _unitOfWork.ComplaintHistory.Insert(complaintHistory);
                await _unitOfWork.Complete();

                _logger.LogInformation($"Complaint Number: {values.ComplaintNumber} | Status changed from {_complaint.ComplaintStatus} to {ComplaintStatus.CANCELLED} by {values.CancelledBy} at {DateTime.UtcNow}.");

                //send to staff module
                var response = await _moduleComms.SendComplaintCancelledAsync(values);
                if (!response)
                {
                    _logger.LogCritical($"Complaint number {values.ComplaintNumber} modualar communication cancellation operation unsuccessfully on {DateTime.UtcNow.ToString()}", values.ComplaintNumber);
                }

                return new GenericResponseDto { responseCode = StatusCodes.Status200OK, response = "Complaint cancelled successfully." };

            }
            catch (Exception ex)
            {
                return new GenericResponseDto { responseCode = StatusCodes.Status500InternalServerError, response = ex.Message };
            }
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
                DocumentList = new List<string> { complaint.DocumentOne!, complaint.DocumentTwo!, complaint.DocumentThree! }.Where(d => !string.IsNullOrEmpty(d)).ToList(),
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
            // Initialize a list to store the response, which will be returned at the end.
            List<ComplaintReadDto> response = new List<ComplaintReadDto>();

            // Fetch the list of complaints where the CustomerCode or PropertyNumber matches the provided parameter.
            // The complaints are ordered by ComplaintDate in descending order.
            var complaintList = (await _unitOfWork.Complaint.GetAll(c => c.CustomerCode == customerCode_OR_propertyNumber || c.PropertyNumber == customerCode_OR_propertyNumber))
                                .OrderByDescending(cl => cl.ComplaintDate);

            // Loop through each complaint in the fetched list.
            foreach (var complaint in complaintList)
            {
                // For each complaint, retrieve a summary using its ComplaintNumber.
                // The ComplaintNumber is assumed to be non-null based on the `!` operator.
                var result = await GetComplaintSummary(complaint.ComplaintNumber!);

                // Add the summary result to the response list.
                response.Add(result);
            }

            // Return the list of complaint summaries (ComplaintReadDto).
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
            try
            {
                var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

                if (_complaint is null)
                {
                    _logger.LogWarning($"Complaint number {values.ComplaintNumber} supplied doesnot exist.");
                    return new GenericResponseDto { responseCode = StatusCodes.Status204NoContent, response = $"Complaint number {values.ComplaintNumber} supplied doesnot exist." };
                }

                //Status is neither DISPATCHED nor REVIEWED nor ASSIGNED nor INPROGRESS
                if (!new[] { ComplaintStatus.DISPATCHED, ComplaintStatus.REVIEWED, ComplaintStatus.ASSIGNED, ComplaintStatus.INPROGRESS }.Contains(_complaint.ComplaintStatus))
                {
                    _logger.LogWarning($"Complaint number {values.ComplaintNumber} cannot be resolved at this stage.");
                    return new GenericResponseDto { responseCode = StatusCodes.Status403Forbidden, response = $"Complaint number {values.ComplaintNumber} cannot be resolved at this stage." };
                }

                _complaint.ComplaintStatus = ComplaintStatus.RESOLVED;
                _unitOfWork.Complaint.Update(_complaint);

                ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, _complaint.ComplaintNumber, ComplaintStatus.RESOLVED, values.ResolvedBy, DateTime.UtcNow);
                _unitOfWork.ComplaintHistory.Insert(complaintHistory);
                await _unitOfWork.Complete();

                _logger.LogInformation($"Complaint Number: {values.ComplaintNumber} | Status changed from {_complaint.ComplaintStatus} to {ComplaintStatus.RESOLVED} by {values.ResolvedBy} at {DateTime.UtcNow}.");

                return new GenericResponseDto { responseCode = StatusCodes.Status200OK, response = "Complaint resolved successfully." };

            }
            catch (Exception ex)
            {
                return new GenericResponseDto { responseCode = StatusCodes.Status500InternalServerError, response = ex.Message };
            }
        }

        public async Task<GenericResponseDto> InProgressComplaint(ComplaintInProgressDto values)
        {
            try
            {
                var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

                if (_complaint is null)
                {
                    _logger.LogWarning($"Complaint number {values.ComplaintNumber} supplied doesnot exist.");
                    return new GenericResponseDto { responseCode = StatusCodes.Status204NoContent, response = $"Complaint number {values.ComplaintNumber} supplied doesnot exist." };
                }

                //Status is neither DISPATCHED nor REVIEWED nor ASSIGNED
                if (!new[] { ComplaintStatus.DISPATCHED, ComplaintStatus.REVIEWED, ComplaintStatus.ASSIGNED }.Contains(_complaint.ComplaintStatus))
                {
                    _logger.LogWarning($"Complaint number {values.ComplaintNumber} cannot be moved to the in-progress stage at this time.");
                    return new GenericResponseDto { responseCode = StatusCodes.Status403Forbidden, response = $"Complaint number {values.ComplaintNumber} cannot be moved to the in-progress stage at this time." };
                }

                _complaint.ComplaintStatus = ComplaintStatus.INPROGRESS;
                _unitOfWork.Complaint.Update(_complaint);

                ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, _complaint.ComplaintNumber, ComplaintStatus.INPROGRESS, values.InProgressBy, DateTime.UtcNow);
                _unitOfWork.ComplaintHistory.Insert(complaintHistory);
                await _unitOfWork.Complete();

                _logger.LogInformation($"Complaint Number: {values.ComplaintNumber} | Status changed from {_complaint.ComplaintStatus} to {ComplaintStatus.INPROGRESS} by {values.InProgressBy} at {DateTime.UtcNow}.");

                return new GenericResponseDto { responseCode = StatusCodes.Status200OK, response = $"Complaint status changed from {_complaint.ComplaintStatus} to {ComplaintStatus.INPROGRESS} successfully." };

            }
            catch (Exception ex)
            {
                return new GenericResponseDto { responseCode = StatusCodes.Status500InternalServerError, response = ex.Message };
            }
        }

        public async Task<GenericResponseDto> ReviewComplaint(ComplaintReviewDto values)
        {
            try
            {
                var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

                if (_complaint is null)
                {
                    _logger.LogWarning($"Complaint number {values.ComplaintNumber} supplied doesnot exist.");
                    return new GenericResponseDto { responseCode = StatusCodes.Status204NoContent, response = $"Complaint number {values.ComplaintNumber} supplied doesnot exist." };
                }


                if (!new[] { ComplaintStatus.DISPATCHED, ComplaintStatus.INPROGRESS }.Contains(_complaint.ComplaintStatus))
                {
                    _logger.LogWarning($"Complaint number {values.ComplaintNumber} cannot be reviewed at this stage.");
                    return new GenericResponseDto { responseCode = StatusCodes.Status403Forbidden, response = $"Complaint number {values.ComplaintNumber} cannot be reviewed at this stage." };
                }


                _complaint.ComplaintStatus = ComplaintStatus.REVIEWED;
                _unitOfWork.Complaint.Update(_complaint);

                ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, _complaint.ComplaintNumber, ComplaintStatus.REVIEWED, values.ReviewedBy, DateTime.UtcNow);
                _unitOfWork.ComplaintHistory.Insert(complaintHistory);
                await _unitOfWork.Complete();

                _logger.LogInformation($"Complaint Number: {values.ComplaintNumber} | Status changed from {_complaint.ComplaintStatus} to {ComplaintStatus.REVIEWED} by {values.ReviewedBy} at {DateTime.UtcNow}.");

                return new GenericResponseDto { responseCode = StatusCodes.Status200OK, response = "Complaint reviewed successfully." };

            }
            catch (Exception ex)
            {
                return new GenericResponseDto { responseCode = StatusCodes.Status500InternalServerError, response = ex.Message };
            }
        }

        public async Task<GenericResponseDto> UpdateComplaint(ComplaintUpdateDto values)
        {
            try
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
                //check for existing complaint
                var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

                if (_complaint is null)
                {
                    _logger.LogWarning($"Complaint number {values.ComplaintNumber} supplied doesnot exist.");
                    return new GenericResponseDto { responseCode = StatusCodes.Status204NoContent, response = "Complaint number supplied doesnot exist." };
                }

                //check status of complaint. If status is dispatched, customer cannot modify complaint anymore
                //var _complaintStatus = await _unitOfWork.ComplaintHistory.Get(ch => ch.ComplaintNumber == values.ComplaintNumber && ch.ComplaintStatus == ComplaintStatus.DISPATCHED);
                if (_complaint.ComplaintStatus >= ComplaintStatus.DISPATCHED)
                {
                    _logger.LogWarning($"Complaint number {values.ComplaintNumber} has been dispatched and cannot be modified.");
                    return new GenericResponseDto { responseCode = StatusCodes.Status403Forbidden, response = $"Complaint number {values.ComplaintNumber} has been dispatched and cannot be modified." };
                }

                //check who submitted complaint
                var _submittedBy = await _unitOfWork.ComplaintHistory.Get(ch => ch.ComplaintNumber == values.ComplaintNumber && ch.ActionBy == values.ModifiedBy && ch.ComplaintStatus == ComplaintStatus.SUBMITTED);
                if (_submittedBy is null)
                {
                    _logger.LogWarning($"Sorry you are not the originator of complaint number {values.ComplaintNumber}.");
                    return new GenericResponseDto { responseCode = StatusCodes.Status403Forbidden, response = $"Sorry you are not the originator of complaint number {values.ComplaintNumber}." };
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

                _logger.LogInformation($"Complaint Number: {values.ComplaintNumber} | details modified by {values.ModifiedBy} at {DateTime.UtcNow}.");

                //send to staff module
                await _moduleComms.SendModifiedComplaintDetailsAsync(values);

                return new GenericResponseDto { responseCode = StatusCodes.Status200OK, response = "Complaint modified successfully." };
            }
            catch (Exception ex)
            {
                return new GenericResponseDto { responseCode = StatusCodes.Status500InternalServerError, response = ex.Message };
            }

        }

        public async Task<GenericResponseDto> AcknowledgeComplaint(ComplaintAcknowledgmentDto values)
        {
            try
            {
                var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

                if (_complaint is null)
                {
                    _logger.LogWarning($"Complaint number {values.ComplaintNumber} supplied doesnot exist.");
                    return new GenericResponseDto { responseCode = StatusCodes.Status204NoContent, response = $"Complaint number {values.ComplaintNumber} supplied doesnot exist." };
                }

                if (_complaint.ComplaintStatus != ComplaintStatus.SUBMITTED)
                {
                    _logger.LogWarning($"Complaint number {values.ComplaintNumber} is not in the submitted state and cannot be acknowledged.");
                    return new GenericResponseDto { responseCode = StatusCodes.Status403Forbidden, response = $"Complaint number {values.ComplaintNumber} is not in the submitted state and cannot be acknowledged." };
                }

                _complaint.ComplaintStatus = ComplaintStatus.ACKNOWLEDGED;
                _unitOfWork.Complaint.Update(_complaint);

                ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, _complaint.ComplaintNumber, ComplaintStatus.ACKNOWLEDGED, values.AcknowledgedBy, DateTime.UtcNow);
                _unitOfWork.ComplaintHistory.Insert(complaintHistory);
                await _unitOfWork.Complete();

                _logger.LogInformation($"Complaint Number: {values.ComplaintNumber} | Status changed from {_complaint.ComplaintStatus} to {ComplaintStatus.ACKNOWLEDGED} by {values.AcknowledgedBy} at {DateTime.UtcNow}.");

                return new GenericResponseDto { responseCode = StatusCodes.Status200OK, response = "Complaint acknowledged successfully." };

            }
            catch (Exception ex)
            {
                return new GenericResponseDto { responseCode = StatusCodes.Status500InternalServerError, response = ex.Message };
            }
        }

        public async Task<GenericResponseDto> DispatchComplaint(ComplaintDispatchedDto values)
        {
            try
            {
                var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

                if (_complaint is null)
                {
                    _logger.LogWarning($"Complaint number {values.ComplaintNumber} supplied doesnot exist.");
                    return new GenericResponseDto { responseCode = StatusCodes.Status204NoContent, response = $"Complaint number {values.ComplaintNumber} supplied doesnot exist." };
                }


                if (_complaint.ComplaintStatus != ComplaintStatus.ACKNOWLEDGED)
                {
                    _logger.LogWarning($"Complaint number {values.ComplaintNumber} has not been acknowledged yet and cannot be dispatched.");
                    return new GenericResponseDto { responseCode = StatusCodes.Status403Forbidden, response = $"Complaint number {values.ComplaintNumber} has not been acknowledged yet and cannot be dispatched." };
                }

                _complaint.DispatachedTo_Department = values.DispatchedTo_DepartmentId;
                _complaint.DispatachedTo_DepartmentUnit = values.DispatchedTo_DepartmentUnitId;
                _complaint.ComplaintStatus = ComplaintStatus.DISPATCHED;
                _unitOfWork.Complaint.Update(_complaint);

                ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, _complaint.ComplaintNumber, ComplaintStatus.DISPATCHED, values.DispatchedBy, DateTime.UtcNow);
                _unitOfWork.ComplaintHistory.Insert(complaintHistory);
                await _unitOfWork.Complete();

                _logger.LogInformation($"Complaint Number: {values.ComplaintNumber} | Status changed from {_complaint.ComplaintStatus} to {ComplaintStatus.DISPATCHED} by {values.DispatchedBy} at {DateTime.UtcNow}.");

                return new GenericResponseDto { responseCode = StatusCodes.Status200OK, response = "Complaint dispatched successfully." };

            }
            catch (Exception ex)
            {
                return new GenericResponseDto { responseCode = StatusCodes.Status500InternalServerError, response = ex.Message };
            }
        }

        public async Task<GenericResponseDto> ReopenComplaint(ComplaintReopenedDto values)
        {
            try
            {
                var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

                if (_complaint is null)
                {
                    _logger.LogWarning($"Complaint number {values.ComplaintNumber} supplied doesnot exist.");
                    return new GenericResponseDto { responseCode = StatusCodes.Status204NoContent, response = $"Complaint number {values.ComplaintNumber} supplied doesnot exist." };
                }

                if (_complaint.ComplaintStatus != ComplaintStatus.RESOLVED)
                {
                    _logger.LogWarning($"Complaint number {values.ComplaintNumber} has not been resolved and cannot be re-opened.");
                    return new GenericResponseDto { responseCode = StatusCodes.Status403Forbidden, response = $"Complaint number {values.ComplaintNumber} has not been resolved and cannot be re-opened." };
                }

                _complaint.ComplaintStatus = ComplaintStatus.REOPEN;
                _unitOfWork.Complaint.Update(_complaint);

                ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, _complaint.ComplaintNumber, ComplaintStatus.REOPEN, values.ReopenedBy, DateTime.UtcNow);
                _unitOfWork.ComplaintHistory.Insert(complaintHistory);
                await _unitOfWork.Complete();

                _logger.LogInformation($"Complaint Number: {values.ComplaintNumber} | Status changed from {_complaint.ComplaintStatus} to {ComplaintStatus.REOPEN} by {values.ReopenedBy} at {DateTime.UtcNow}.");

                //send to staff module
                await _moduleComms.SendComplaintReopenAsync(values);

                return new GenericResponseDto { responseCode = StatusCodes.Status200OK, response = "Complaint reopened successfully." };

            }
            catch (Exception ex)
            {
                return new GenericResponseDto { responseCode = StatusCodes.Status500InternalServerError, response = ex.Message };
            }
        }

        public async Task<GenericResponseDto> CloseComplaint(ComplaintClosedDto values)
        {
            try
            {
                var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

                if (_complaint is null)
                {
                    _logger.LogWarning($"Complaint number {values.ComplaintNumber} supplied doesnot exist.");
                    return new GenericResponseDto { responseCode = StatusCodes.Status204NoContent, response = $"Complaint number {values.ComplaintNumber} supplied doesnot exist." };
                }

                if (_complaint.ComplaintStatus != ComplaintStatus.REOPEN)
                {
                    _logger.LogWarning($"Complaint number {values.ComplaintNumber} has not been re-opened and cannot be closed.");
                    return new GenericResponseDto { responseCode = StatusCodes.Status403Forbidden, response = $"Complaint number {values.ComplaintNumber} has not been re-opened and cannot be closed." };
                }

                _complaint.ComplaintStatus = ComplaintStatus.CLOSED;
                _unitOfWork.Complaint.Update(_complaint);

                ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, _complaint.ComplaintNumber, ComplaintStatus.CLOSED, values.ClosedBy, DateTime.UtcNow);
                _unitOfWork.ComplaintHistory.Insert(complaintHistory);
                await _unitOfWork.Complete();

                _logger.LogInformation($"Complaint Number: {values.ComplaintNumber} | Status changed from {_complaint.ComplaintStatus} to {ComplaintStatus.CLOSED} by {values.ClosedBy} at {DateTime.UtcNow}.");

                //send to staff module
                await _moduleComms.SendComplaintClosedAsync(values);

                return new GenericResponseDto { responseCode = StatusCodes.Status200OK, response = "Complaint closed successfully." };

            }
            catch (Exception ex)
            {
                return new GenericResponseDto { responseCode = StatusCodes.Status500InternalServerError, response = ex.Message };

            }
        }


    }
}

