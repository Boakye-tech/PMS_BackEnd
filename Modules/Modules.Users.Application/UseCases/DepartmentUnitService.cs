using Modules.Users.Domain.Entities;

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

        public async Task<GenericResponseDto> DeleteDepartmentUnit(int unitId)
        {
            //throw new NotImplementedException();
            var unit = await _unitOfWork.DepartmentUnit.Get(unitId);
            if (unit is null)
            {
                return new GenericResponseDto("Not Found");
            }

            _unitOfWork.DepartmentUnit.Delete(unit!);
            await _unitOfWork.Complete();
            return new GenericResponseDto("success");
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

        public async Task<DepartmentUnitReadDto> UpdateDepartmentUnitAsync(DepartmentUnitUpdateDto values)
        {
            DepartmentUnit departmentUnit = new(values.DepartmentId, values.UnitId, values.UnitName!)
            {
                ModifiedBy = values.ModifiedBy,
                ModifiedOn = DateTime.Now
            };

            _unitOfWork.DepartmentUnit.Update(departmentUnit);
            await _unitOfWork.Complete();

            return new DepartmentUnitReadDto(departmentUnit.DepartmentId, departmentUnit.UnitId, departmentUnit.UnitName!);
        }
    }
}

