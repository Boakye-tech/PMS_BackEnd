using Modules.Users.Domain.Entities;

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
            Department department = new(values.DepartmentId, values.DepartmentName!)
            {
                CreatedBy = values.CreatedBy,
                CreatedOn = DateTime.Now
            };

            _unitOfWork.Department.Insert(department);
            await _unitOfWork.Complete();

            return new DepartmentReadDto(department.DepartmentId, department.DepartmentName!);
        }

        public async Task<GenericResponseDto> DeleteDepartment(int departmentId)
        {
            //throw new NotImplementedException();
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
            //throw new NotImplementedException();
            Department department = new(values.DepartmentId, values.DepartmentName!)
            {
                ModifiedBy = values.ModifiedBy,
                ModifiedOn = DateTime.UtcNow
            };

            _unitOfWork.Department.Update(department);
            await _unitOfWork.Complete();

            return new DepartmentReadDto(department.DepartmentId, department.DepartmentName!);
        }
    }
}

