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

        public async Task<IEnumerable<DepartmentReadDto>> GetDepartmentAsync()
        {
            var response = await _unitOfWork.Department.GetAll();
            return _mapper.Map<IEnumerable<DepartmentReadDto>>(response);
        }

        public Task<DepartmentReadDto> GetDepartmentAsync(int value)
        {
            throw new NotImplementedException();
        }

        public Task<DepartmentReadDto> GetDepartmentAsync(string value)
        {
            throw new NotImplementedException();
        }

        public Task<DepartmentReadDto> UpdateDepartmentAsync(DepartmentUpdateDto values)
        {
            throw new NotImplementedException();
        }
    }
}

