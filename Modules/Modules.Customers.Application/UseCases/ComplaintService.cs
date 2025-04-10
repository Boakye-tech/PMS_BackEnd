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
        //private readonly IModuleCommunicationServices _moduleComms;
        private readonly ILogger<ComplaintService> _logger;
        //private readonly IDomainEventDispatcher _domainEventDispatcher;

        public ComplaintService(IUnitOfWork unitOfWork, IMapper mapper,  ILogger<ComplaintService> logger) //ICustomerDomainService domainService, IModuleCommunicationServices moduleComms,, IDomainEventDispatcher domainEventDispatcher
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            //_domainService = domainService;
            //_moduleComms = moduleComms;
            _logger = logger;
            //_domainEventDispatcher = domainEventDispatcher;
        }

        public async Task<string> AddNewComplaint(ComplaintCreateDto values)
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
                    complaintStatus: (int)ComplaintStatus.SUBMITTED,
                    createdBy: values.CreatedBy!
                    );
                complaint.CreatedOn = DateTime.UtcNow;

                _unitOfWork.Complaint.Insert(complaint);
                await _unitOfWork.Complete();

                return complaint.ComplaintNumber!;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public async Task<GenericResponseDto> AssignComplaint(ComplaintAssignDto values)
        {
            //throw new NotImplementedException();
            var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

            if (_complaint is null)
            {
                return new GenericResponseDto { response = "Complaint number supplied doesnot exist." };
            }

            _complaint.AssignedBy = values.AssignedBy;
            _complaint.AssignedTo = values.AssignedTo;
            _complaint.DateAssigned = DateTime.UtcNow;
            _complaint.ComplaintStatus = (int)ComplaintStatus.ASSIGNED;

            _unitOfWork.Complaint.Update(_complaint);
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

            _complaint.CancelledBy = values.CancelledBy;
            _complaint.CancelledDate = DateTime.UtcNow;
            _complaint.ComplaintStatus = (int)ComplaintStatus.CANCELLED;

            _unitOfWork.Complaint.Update(_complaint);
            await _unitOfWork.Complete();

            return new GenericResponseDto { response = "Complaint resolved successfully." };
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

        public async Task<ComplaintReadDto> GetComplaintDetails(string complaintNumber)
        {
            var complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == complaintNumber);

            if (complaint == null)
            {
                return new ComplaintReadDto(null, null, null,DateTime.Now,null);
            }

            var response = new ComplaintReadDto
            (
                ComplaintNumber : complaint.ComplaintNumber,
                NatureOfComplaint : (await _unitOfWork.NatureOfComplaint.Get(n => n.NatureOfComplaintId == complaint.NatureOfComplaintId))!.NatureOfComplaints,
                //complaint.NatureOfComplaintId.ToString(),
                PropertyNumber : complaint.PropertyNumber,
                ComplaintDate : complaint.ComplaintDate,
                ComplaintStatus : complaint.ComplaintStatus.ToString()
            );

            return response;

        }

        public Task<IEnumerable<ComplaintReadDto>> GetComplaintsList()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ComplaintReadDto>> GetComplaintsList(string customerCode_OR_propertyNumber)
        {
            //throw new NotImplementedException();
            var response = (
                from c in await _unitOfWork.Complaint.GetAll(c => c.CustomerCode == customerCode_OR_propertyNumber || c.PropertyNumber == customerCode_OR_propertyNumber)
                join n in await _unitOfWork.NatureOfComplaint.GetAll()
                    on c.NatureOfComplaintId equals n.NatureOfComplaintId into gj
                from nature in gj.DefaultIfEmpty() // this ensures it's a LEFT JOIN
                orderby c.ComplaintDate descending
                select new ComplaintReadDto ( 
                    ComplaintNumber : c.ComplaintNumber,
                    NatureOfComplaint :  nature?.NatureOfComplaints, // safe access in case there's no match
                    PropertyNumber : c.PropertyNumber,
                    ComplaintDate : c.ComplaintDate,
                    ComplaintStatus : c.ComplaintStatus.ToString()
                )).ToList();

            return response;
        }

        public async Task<GenericResponseDto> ResolveComplaint(ComplaintResolutionDto values)
        {
            //throw new NotImplementedException();
            var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

            if (_complaint is null)
            {
                return new GenericResponseDto { response = "Complaint number supplied doesnot exist." };
            }

            _complaint.ResolvedBy = values.ResolvedBy;
            _complaint.ResolutionDate = DateTime.UtcNow;
            _complaint.ComplaintStatus = (int)ComplaintStatus.RESOLVED;

            _unitOfWork.Complaint.Update(_complaint);
            await _unitOfWork.Complete();

            return new GenericResponseDto { response = "Complaint resolved successfully." };

        }

        public async Task<GenericResponseDto> ReviewComplaint(ComplaintReviewDto values)
        {
            //throw new NotImplementedException();
            var _complaint = await _unitOfWork.Complaint.Get(c => c.ComplaintNumber == values.ComplaintNumber);

            if (_complaint is null)
            {
                return new GenericResponseDto { response = "Complaint number supplied doesnot exist." };
            }

            _complaint.ReviewedBy = values.ReviewedBy;
            _complaint.DateReviewed = DateTime.UtcNow;
            _complaint.ComplaintStatus = (int)ComplaintStatus.REVIEWED;

            _unitOfWork.Complaint.Update(_complaint);
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
            _complaint.ModifiedBy = values.ModifiedBy;
            _complaint.ModifiedOn = DateTime.UtcNow;

            _unitOfWork.Complaint.Update(_complaint);
            await _unitOfWork.Complete();

            return new GenericResponseDto { response = "Complaint updated successfully." };

        }





    }
}

