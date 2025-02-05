namespace Modules.Users.Application.UseCases
{
	public class DepartmentUnitService : IDepartmentUnitService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DepartmentUnitService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<DepartmentUnitReadDto> AddDepartmentUnitAsync(DepartmentUnitCreateDto values)
        {
            DepartmentUnit departmentUnit = new(values.DepartmentId, values.UnitId ,values.UnitName!)
            {
                CreatedBy = values.CreatedBy,
                CreatedOn = DateTime.Now
            };

            _unitOfWork.DepartmentUnit.Insert(departmentUnit);
            await _unitOfWork.Complete();

            return new DepartmentUnitReadDto(departmentUnit.DepartmentId, departmentUnit.UnitId, departmentUnit.UnitName!);
        }

        public async Task<IEnumerable<DepartmentUnitReadDto>> GetDepartmentUnitAsync()
        {
            var response = await _unitOfWork.DepartmentUnit.GetAll();
            return _mapper.Map<IEnumerable<DepartmentUnitReadDto>>(response);
        }

        public async Task<IEnumerable<DepartmentUnitReadDto>> GetDepartmentUnitAsync(int value)
        {
            //throw new NotImplementedException();
            var response = await _unitOfWork.DepartmentUnit.GetAll(u => u.DepartmentId == value);
            return _mapper.Map<IEnumerable<DepartmentUnitReadDto>>(response);

        }

        public Task<DepartmentUnitReadDto> GetDepartmentUnitAsync(string value)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UnitReadDto>> GetUnitAsync(int value)
        {
            var response = await _unitOfWork.DepartmentUnit.GetAll(u => u.DepartmentId == value);
            return _mapper.Map<IEnumerable<UnitReadDto>>(response);

        }

        public Task<DepartmentUnitReadDto> UpdateDepartmentUnitAsync(DepartmentUnitUpdateDto values)
        {
            throw new NotImplementedException();
        }
    }
}

