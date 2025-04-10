using System;

namespace Modules.Customers.Application.UseCases
{
	public class ComplaintTypeService : IComplaintTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ComplaintTypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ComplaintTypeDto> AddNewComplaintType(ComplaintTypeDto values)
        {
            ComplaintType ComplaintType = new(values.complaintTypeId, values.complaintTypes!);

            _unitOfWork.ComplaintType.Insert(ComplaintType);
            await _unitOfWork.Complete();

            return new ComplaintTypeDto(ComplaintType.ComplaintTypeId, ComplaintType.ComplaintTypes!);
        }

        public async Task<GenericResponseDto> DeleteComplaintType(int complaintTypeid)
        {
            var response = await _unitOfWork.ComplaintType.Get(complaintTypeid);

            if (response is null)
            {
                return new GenericResponseDto{ response = "BadRequest" };
            }

            _unitOfWork.ComplaintType.Delete(response);
            await _unitOfWork.Complete();

            return new GenericResponseDto{ response = "success" };
        }

        public async Task<IEnumerable<ComplaintTypeDto>> GetComplaintTypes()
        {
            var response = await _unitOfWork.ComplaintType.GetAll();
            return _mapper.Map<IEnumerable<ComplaintTypeDto>>(response);

        }

        public async Task<ComplaintTypeDto> UpdateComplaintType(ComplaintTypeDto values)
        {
            ComplaintType ComplaintType = new(values.complaintTypeId, values.complaintTypes!);

            _unitOfWork.ComplaintType.Update(ComplaintType);
            await _unitOfWork.Complete();

            return new ComplaintTypeDto(ComplaintType.ComplaintTypeId, ComplaintType.ComplaintTypes!);
        }
    }
}

