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
        private readonly IModulesService _moduleCommunication;

        public DepartmentService(IUnitOfWork unitOfWork, IMapper mapper, IModulesService moduleCommunication)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _moduleCommunication = moduleCommunication;
        }

        public async Task<DepartmentReadDto> AddDepartmentAsync(DepartmentCreateDto values)
        {
            Department department = Department.Create(values.DepartmentId, values.DepartmentInitial, values.DepartmentName!);

            department.CreatedBy = values.CreatedBy;
            department.CreatedOn = DateTime.Now;

            _unitOfWork.Department.Insert(department);
            await _unitOfWork.Complete();

            //send to finance module
            var response = await _moduleCommunication.SendDepartmentDetailsAsync(values);
            if (!response)
            {
                //_logger.LogWarning($"Failed to send department details to finance module {values.DepartmentName}", values.DepartmentName);
            }

            return new DepartmentReadDto(department.DepartmentId, values.DepartmentInitial, department.DepartmentName!);
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
            Department department = Department.Update(values.DepartmentId, values.DepartmentInitial, values.DepartmentName!);
            department.ModifiedBy = values.ModifiedBy;
            department.ModifiedOn = DateTime.UtcNow;

            _unitOfWork.Department.Update(department);
            await _unitOfWork.Complete();

            //send to finance module
            var response = await _moduleCommunication.SendModifiedDepartmentDetailsAsync(values);
            if (!response)
            {
                //_logger.LogWarning($"Failed to send department details to finance module {values.DepartmentName}", values.DepartmentName);
            }


            return new DepartmentReadDto(department.DepartmentId, values.DepartmentInitial, department.DepartmentName!);
        }
    }
}

