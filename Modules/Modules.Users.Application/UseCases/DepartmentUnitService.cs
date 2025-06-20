// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System.Linq;

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
            DepartmentUnit departmentUnit = DepartmentUnit.Create(values.DepartmentId, values.UnitId ,values.UnitName!);

            departmentUnit.CreatedBy = values.CreatedBy;
            departmentUnit.CreatedOn = DateTime.Now;

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

        public async Task<List<DepartmentsAndUnitsReadDto>> GetDepartmentsAndUnitsAsync()
        {
            // Get all departments and units in a single query using Include
            var departments = await _unitOfWork.Department.GetAll(includes: new List<string> { "DepartmentUnits" });

            // Create a dictionary for quick lookup of units by department id
            var departmentsUnits = departments.Select(departments =>
            {
                var departmentUnits = _mapper.Map<List<DepartmentsUnitsReadDto>>(departments.DepartmentUnits);
                return new DepartmentsAndUnitsReadDto(
                    new DepartmentsReadDto(
                    departments.DepartmentId,
                    departments.DepartmentName,
                    false),
                    departmentUnits
                );
            }).ToList();

            return departmentsUnits;
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
            DepartmentUnit departmentUnit = DepartmentUnit.Update(values.DepartmentId, values.UnitId, values.UnitName!);

            departmentUnit.ModifiedBy = values.ModifiedBy;
            departmentUnit.ModifiedOn = DateTime.Now;

            _unitOfWork.DepartmentUnit.Update(departmentUnit);
            await _unitOfWork.Complete();

            return new DepartmentUnitReadDto(departmentUnit.DepartmentId, departmentUnit.UnitId, departmentUnit.UnitName!);
        }
    }
}

