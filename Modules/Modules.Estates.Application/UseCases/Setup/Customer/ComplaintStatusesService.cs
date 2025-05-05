// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/



namespace Modules.Estates.Application.UseCases.Setup.Customer
{
	public class ComplaintStatusesService : IComplaintStatusesService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ComplaintStatusesService(IUnitOfWork unitOfWork, IMapper mapper)
		{
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ComplaintStatusesReadDto> CreateComplaintStatusAsync(ComplaintStatusesCreateDto values)
        {
            ComplaintStatuses complaintStatus = ComplaintStatuses.CreateUpdate(values.complaintStatusId, values.complaintStatus!, values.description!);
            complaintStatus.CreatedBy = values.createdBy;
            complaintStatus.CreatedOn = DateTime.UtcNow;

            _unitOfWork.ComplaintStatuses.Insert(complaintStatus);
            await _unitOfWork.Complete();

            return new ComplaintStatusesReadDto(complaintStatus.ComplaintStatusId, complaintStatus.ComplaintStatus!, complaintStatus.Description!);
        }

        public async Task<string> DeleteComplaintStatusAsync(int value)
        {
            var response = await _unitOfWork.ComplaintStatuses.Get(value);

            if (response is null)
            {
                return "400 - BadRequest";
            }

            _unitOfWork.ComplaintStatuses.Delete(response);
            await _unitOfWork.Complete();

            return "success";
        }

        public async Task<IEnumerable<ComplaintStatusesReadDto>> GetComplaintStatusAsync()
        {
            var response = await _unitOfWork.ComplaintStatuses.GetAll();
            return _mapper.Map<IEnumerable<ComplaintStatusesReadDto>>(response);
        }

        public async Task<ComplaintStatusesReadDto> UpdateComplaintStatusAsync(ComplaintStatusesUpdateDto values)
        {
            var complaintStatus = await _unitOfWork.ComplaintStatuses.Get(cs => cs.ComplaintStatusId == values.complaintStatusId);
            if(complaintStatus is null)
            {
                return null!;
            }
            //ComplaintStatuses complaintStatus = ComplaintStatuses.CreateUpdate(values.complaintStatusId, values.complaintStatus!, values.description!);

            complaintStatus.ComplaintStatus = values.complaintStatus;
            complaintStatus.Description = values.description;
            complaintStatus.ModifiedBy = values.modifiedBy;
            complaintStatus.ModifiedOn = DateTime.UtcNow;

            _unitOfWork.ComplaintStatuses.Update(complaintStatus);
            await _unitOfWork.Complete();

            return new ComplaintStatusesReadDto(complaintStatus.ComplaintStatusId, complaintStatus.ComplaintStatus!, complaintStatus.Description!);
        }
    }
}

