// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


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
            ComplaintType ComplaintType = new(values.complaintTypeId, values.complaintTypes!, values.departmentId, values.departmentUnitId);

            _unitOfWork.ComplaintType.Insert(ComplaintType);
            await _unitOfWork.Complete();

            return new ComplaintTypeDto(ComplaintType.ComplaintTypeId, ComplaintType.ComplaintTypes!, ComplaintType.DepartmentId, ComplaintType.DepartmentUnitId);
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
            ComplaintType ComplaintType = new(values.complaintTypeId, values.complaintTypes!, values.departmentId, values.departmentUnitId);

            _unitOfWork.ComplaintType.Update(ComplaintType);
            await _unitOfWork.Complete();

            return new ComplaintTypeDto(ComplaintType.ComplaintTypeId, ComplaintType.ComplaintTypes!, ComplaintType.DepartmentId, ComplaintType.DepartmentUnitId);
        }
    }
}

