// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Users.Application.UseCases
{
	public class DepartmentService : IDepartmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DepartmentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<DepartmentReadDto> AddDepartmentAsync(DepartmentCreateDto values)
        {
            Department department = Department.Create(values.DepartmentId, values.DepartmentName!);

            department.CreatedBy = values.CreatedBy;
            department.CreatedOn = DateTime.Now;

            _unitOfWork.Department.Insert(department);
            await _unitOfWork.Complete();

            return new DepartmentReadDto(department.DepartmentId, department.DepartmentName!);
        }

        public async Task<GenericResponseDto> DeleteDepartment(int departmentId)
        {
            var department = await _unitOfWork.Department.Get(departmentId);
            if(department is null)
            {
                return new GenericResponseDto("Not Found");
            }

            _unitOfWork.Department.Delete(department!);
            await _unitOfWork.Complete();
            return new GenericResponseDto("success");
        }

        public async Task<IEnumerable<DepartmentReadDto>> GetDepartmentAsync()
        {
            var response = await _unitOfWork.Department.GetAll();
            return _mapper.Map<IEnumerable<DepartmentReadDto>>(response);
        }

        public async Task<DepartmentReadDto> GetDepartmentAsync(int value)
        {
            //throw new NotImplementedException();
            var response = await _unitOfWork.Department.Get(value);
            return _mapper.Map<DepartmentReadDto>(response);
        }

        public async Task<DepartmentReadDto> GetDepartmentAsync(string value)
        {
            var response = await _unitOfWork.Department.Get(d => d.DepartmentName == value);
            return _mapper.Map<DepartmentReadDto>(response);
        }

        public async Task<DepartmentReadDto> UpdateDepartmentAsync(DepartmentUpdateDto values)
        {
            Department department = Department.Update(values.DepartmentId, values.DepartmentName!);
            department.ModifiedBy = values.ModifiedBy;
            department.ModifiedOn = DateTime.UtcNow;

            _unitOfWork.Department.Update(department);
            await _unitOfWork.Complete();

            return new DepartmentReadDto(department.DepartmentId, department.DepartmentName!);
        }
    }
}

