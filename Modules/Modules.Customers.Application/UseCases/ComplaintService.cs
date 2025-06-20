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
using Modules.Customers.Application.Services;
using Modules.Customers.Domain.Events;
using Modules.Customers.Application.EventHandlers;

namespace Modules.Customers.Application.UseCases
{
    public class ComplaintService : IComplaintService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        //private readonly ICustomerDomainService _domainService;
        private readonly ICustomerModuleCommunicationServices _moduleComms;
        private readonly INotificationModuleService _notification;
        private readonly ILogger<ComplaintService> _logger;
        private readonly IComplaintCreationService _complaintCreationService;
        private readonly IComplaintNotificationService _complaintNotificationService;
        private readonly IDomainEventDispatcher _domainEventDispatcher;
        private readonly ComplaintSubmittedEventHandler _complaintSubmittedHandler;
        private readonly ComplaintStatusChangedEventHandler _statusChangedHandler;

        public ComplaintService(
            IUnitOfWork unitOfWork,
            ICustomerModuleCommunicationServices moduleComms,
            IMapper mapper,
            ILogger<ComplaintService> logger,
            INotificationModuleService notification,
            IComplaintCreationService complaintCreationService,
            IComplaintNotificationService complaintNotificationService,
            IDomainEventDispatcher domainEventDispatcher,
            ComplaintSubmittedEventHandler complaintSubmittedHandler,
            ComplaintStatusChangedEventHandler statusChangedHandler)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            //_domainService = domainService;
            _moduleComms = moduleComms;
            _notification = notification;
            _logger = logger;
            _complaintCreationService = complaintCreationService;
            _complaintNotificationService = complaintNotificationService;
            _domainEventDispatcher = domainEventDispatcher;
            _complaintSubmittedHandler = complaintSubmittedHandler;
            _statusChangedHandler = statusChangedHandler;
        }

        public async Task<GenericResponseDto> AddNewComplaint(ComplaintCreateDto values)
        {
            try
            {
                //check of complaint type exist
                var complaintType = await _unitOfWork.ComplaintType.Get(values.ComplaintTypeId);
                if(complaintType is null)
                {
                    _logger.LogWarning($"Complaint Type Id {values.ComplaintTypeId} provided does not exist.");
                    return new GenericResponseDto
                    {
                        responseCode = StatusCodes.Status404NotFound,
                        response = $"Complaint Type Id {values.ComplaintTypeId} provided does not exist."
                    };

                }

                //check of the nature of complaint is empty
                if (values.NatureOfComplaintId!.Count() == 0)
                {
                    _logger.LogWarning("Nature of complaint cannot be null or empty");
                    return new GenericResponseDto
                    {
                        responseCode = StatusCodes.Status204NoContent,
                        response = "Nature of complaint cannot be null or empty"
                    };
                }

                //check of nature of complaint exist
                foreach (var item in values.NatureOfComplaintId!)
                {
                    var nature = await _unitOfWork.NatureOfComplaint.Get(item);
                    if (nature is null)
                    {
                        _logger.LogWarning($"Nature Of Complaint Id {item} provided does not exist.");
                        return new GenericResponseDto
                        {
                            responseCode = StatusCodes.Status404NotFound,
                            response = $"Nature Of Complaint Id {item} provided does not exist."
                        };
                    }
                }


                string natureofComplaint = string.Join(',', values.NatureOfComplaintId!);

                var complaint = Complaint.CreateNewComplaint(
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
                    documentList: values.DocumentImages!,
                    complaintStatus: ComplaintStatus.SUBMITTED,
                    source: values.Source
                );

                _unitOfWork.Complaint.Insert(complaint);

                var complaintHistory = ComplaintHistory.ProcessComplaint(
                    0,
                    complaint.ComplaintNumber,
                    ComplaintStatus.SUBMITTED,
                    values.SubmittedBy!,
                    DateTime.UtcNow
                );

                _unitOfWork.ComplaintHistory.Insert(complaintHistory);
                await _unitOfWork.Complete();

                // Dispatch domain events
                await _domainEventDispatcher.DispatchEventsAsync(complaint.DomainEvents);
                complaint.ClearDomainEvents();

                // Handle customer-specific notifications
                if (values.Source == ComplaintSource.CUSTOMER)
                {
                    await _complaintNotificationService.NotifyStaffAboutNewComplaint(values, complaint.ComplaintNumber!);
                }

                return new GenericResponseDto
                {
                    responseCode = StatusCodes.Status201Created,
                    response = $"Complaint submitted successfully with complaint number - {complaint.ComplaintNumber}."
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating new complaint");
                return new GenericResponseDto
                {
                    responseCode = StatusCodes.Status500InternalServerError,
                    response = ex.Message
                };
            }
        }

        public async Task<GenericResponseDto> AssignComplaint(ComplaintAssignDto values)
        {
            try
            {
                var complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

                if (complaint is null)
                {
                    _logger.LogWarning($"Complaint number {values.ComplaintNumber} supplied doesnot exist.");
                    return new GenericResponseDto
                    {
                        responseCode = StatusCodes.Status204NoContent,
                        response = $"Complaint number {values.ComplaintNumber} supplied doesnot exist."
                    };
                }

                if (!new[] { ComplaintStatus.DISPATCHED, ComplaintStatus.REVIEWED }.Contains(complaint.ComplaintStatus))
                {
                    _logger.LogWarning($"Complaint number {values.ComplaintNumber} cannot be assigned as it has not been dispatched or reviewed yet.");
                    return new GenericResponseDto
                    {
                        responseCode = StatusCodes.Status403Forbidden,
                        response = $"Complaint number {values.ComplaintNumber} cannot be assigned as it has not been dispatched or reviewed yet."
                    };
                }

                complaint.Assign(values.AssignedTo!, values.AssignedBy!);
                complaint.ChangeStatus(ComplaintStatus.ASSIGNED, values.AssignedBy!);

                _unitOfWork.Complaint.Update(complaint);

                var complaintHistory = ComplaintHistory.ProcessComplaint(
                    0,
                    complaint.ComplaintNumber,
                    ComplaintStatus.ASSIGNED,
                    values.AssignedBy,
                    DateTime.UtcNow
                );

                _unitOfWork.ComplaintHistory.Insert(complaintHistory);
                await _unitOfWork.Complete();

                // Dispatch domain events
                await _domainEventDispatcher.DispatchEventsAsync(complaint.DomainEvents);
                complaint.ClearDomainEvents();

                return new GenericResponseDto
                {
                    responseCode = StatusCodes.Status200OK,
                    response = "Complaint assigned successfully."
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error assigning complaint {ComplaintNumber}", values.ComplaintNumber);
                return new GenericResponseDto
                {
                    responseCode = StatusCodes.Status500InternalServerError,
                    response = ex.Message
                };
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

                _complaint.CancelNotes = values.CancelNotes;
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
                AvailableDate = complaint.AvailabilityDate,
                ComplaintDate = complaint.ComplaintDate,
                SubmittedBy = complaint.SubmittedBy,
                SubmittedBy_PhoneNumber = complaint.SubmittedBy_PhoneNumber,
                DocumentList = complaint.DocumentList!.ToList(),
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

                _complaint.Notes = values.Notes;
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

                if (values.IsReviewed!.ToUpper() == "NO")
                {
                    _logger.LogWarning($"Complaint number {values.ComplaintNumber} has not been reviewed at this stage.");
                    return new GenericResponseDto { responseCode = StatusCodes.Status400BadRequest, response = $"Complaint number {values.ComplaintNumber} has not been reviewed at this stage." };
                }

                _complaint.ReviewNotes = values.ReviewNotes;
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
                //string _imageOne = string.Empty; string _imageTwo = string.Empty; string _imageThree = string.Empty;
                //int imageCount;

                //imageCount = values.DocumentImages!.Count();
                //switch (imageCount)
                //{
                //    case 1:
                //        _imageOne = values.DocumentImages![0];
                //        break;

                //    case 2:
                //        _imageOne = values.DocumentImages![0];
                //        _imageTwo = values.DocumentImages![1];
                //        break;

                //    case 3:
                //        _imageOne = values.DocumentImages![0];
                //        _imageTwo = values.DocumentImages![1];
                //        _imageThree = values.DocumentImages![2];
                //        break;
                //}

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
                _complaint.DocumentList = values.DocumentImages;

                _unitOfWork.Complaint.Update(_complaint);
                await _unitOfWork.Complete();

                _logger.LogInformation($"Complaint Number: {values.ComplaintNumber} | details modified by {values.ModifiedBy} at {DateTime.UtcNow}.");

                //send to staff module
                await _moduleComms.SendModifiedComplaintDetailsAsync(values);

                return new GenericResponseDto { responseCode = StatusCodes.Status200OK, response = $"Complaint has been successfully modified. - {values.ComplaintNumber}" };
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
                if (values.ComplaintNumber!.Count == 0)
                {
                    _logger.LogWarning("The complaint number list cannot be empty or null, it must contain at least one valid complaint number.");
                    return new GenericResponseDto { responseCode = StatusCodes.Status204NoContent, response = "The complaint number list cannot be empty or null, it must contain at least one valid complaint number." };
                }

                foreach (var _complaintNumber in values.ComplaintNumber)
                {
                    var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == _complaintNumber);

                    if (_complaint is null)
                    {
                        _logger.LogWarning($"Complaint number {_complaintNumber} supplied doesnot exist.");
                        return new GenericResponseDto { responseCode = StatusCodes.Status204NoContent, response = $"Complaint number {_complaintNumber} supplied doesnot exist." };
                    }

                    if (_complaint.ComplaintStatus != ComplaintStatus.SUBMITTED)
                    {
                        _logger.LogWarning($"Complaint number {values.ComplaintNumber} is not in the submitted state and cannot be acknowledged.");
                        return new GenericResponseDto { responseCode = StatusCodes.Status403Forbidden, response = $"Complaint number {_complaintNumber} is not in the submitted state and cannot be acknowledged." };
                    }

                    _complaint.ComplaintStatus = ComplaintStatus.ACKNOWLEDGED;
                    _unitOfWork.Complaint.Update(_complaint);

                    ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, _complaint.ComplaintNumber, ComplaintStatus.ACKNOWLEDGED, values.AcknowledgedBy, DateTime.UtcNow);
                    _unitOfWork.ComplaintHistory.Insert(complaintHistory);

                    _logger.LogInformation(
                        "Complaint Number: {ComplaintNumber} | Status changed from {PreviousStatus} to {NewStatus} by {AcknowledgedBy} at {TimeStamp}.",
                        _complaintNumber ?? "N/A",
                        ComplaintStatus.SUBMITTED,
                        ComplaintStatus.ACKNOWLEDGED,
                        values.AcknowledgedBy ?? "Unknown",
                        DateTime.UtcNow
                    );
                }

                await _unitOfWork.Complete();

                return new GenericResponseDto { responseCode = StatusCodes.Status200OK, response = $"Complaint(s) acknowledged successfully." };

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
                if (values.ComplaintNumber!.Count == 0)
                {
                    _logger.LogWarning("The complaint number list cannot be empty or null, it must contain at least one valid complaint number.");
                    return new GenericResponseDto { responseCode = StatusCodes.Status204NoContent, response = "The complaint number list cannot be empty or null, it must contain at least one valid complaint number." };
                }

                foreach (var _complaintNumber in values.ComplaintNumber)
                {
                    var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == _complaintNumber);

                    if (_complaint is null)
                    {
                        _logger.LogWarning($"Complaint number {_complaintNumber} supplied doesnot exist.");
                        return new GenericResponseDto { responseCode = StatusCodes.Status204NoContent, response = $"Complaint number {_complaintNumber} supplied doesnot exist." };
                    }

                    if (_complaint.ComplaintStatus != ComplaintStatus.ACKNOWLEDGED)
                    {
                        _logger.LogWarning($"Complaint number {_complaintNumber} has not been acknowledged yet and cannot be dispatched.");
                        return new GenericResponseDto { responseCode = StatusCodes.Status403Forbidden, response = $"Complaint number {_complaintNumber} has not been acknowledged yet and cannot be dispatched." };
                    }

                    var _deptInfo = await _unitOfWork.ComplaintType.Get(ct => ct.ComplaintTypeId == _complaint.ComplaintTypeId);
                    if (_deptInfo is null)
                    {
                        _logger.LogWarning($"Complaint type id {_complaint.ComplaintTypeId} supplied doesnot exist.");
                        return new GenericResponseDto { responseCode = StatusCodes.Status404NotFound, response = $"Complaint type id {_complaint.ComplaintTypeId} supplied doesnot exist." };
                    }

                    _complaint.DispatachedTo_Department = _deptInfo!.DepartmentId;
                    _complaint.DispatachedTo_DepartmentUnit = _deptInfo.DepartmentUnitId;
                    _complaint.ComplaintStatus = ComplaintStatus.DISPATCHED;
                    _unitOfWork.Complaint.Update(_complaint);

                    ComplaintHistory complaintHistory = ComplaintHistory.ProcessComplaint(0, _complaint.ComplaintNumber, ComplaintStatus.DISPATCHED, values.DispatchedBy, DateTime.UtcNow);
                    _unitOfWork.ComplaintHistory.Insert(complaintHistory);

                    _logger.LogInformation(
                        "Complaint Number: {ComplaintNumber} | Status changed from {PreviousStatus} to {NewStatus} by {AcknowledgedBy} at {TimeStamp}.",
                        _complaintNumber ?? "N/A",
                        ComplaintStatus.ACKNOWLEDGED,
                        ComplaintStatus.DISPATCHED,
                        values.DispatchedBy ?? "Unknown",
                        DateTime.UtcNow
                    );
                }

                await _unitOfWork.Complete();

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

                _complaint.ReopenNotes = values.ReopenNotes;
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

                _complaint.ClosedNotes = values.CloseNotes;
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

