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
	public class ComplaintTypeService : IComplaintTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IModuleCommunicationServices _moduleComms;
        private readonly ICustomerDomainService _domainService;

        public ComplaintTypeService(IUnitOfWork unitOfWork, IMapper mapper, IModuleCommunicationServices moduleComms, ICustomerDomainService domainService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _moduleComms = moduleComms;
            _domainService = domainService;
        }

        public async Task<ComplaintTypeReadDto> AddComplaintTypeAsync(ComplaintTypeCreateDto values)
        {
            ComplaintType _complaintType = await ComplaintType.Create(values.complaintTypeId, values.complaintTypes!, values.departmentId, values.departmentUnitId, _domainService);
            _complaintType.CreatedBy = values.createdBy;
            _complaintType.CreatedOn = DateTime.Now;

            _unitOfWork.ComplaintType.Insert(_complaintType);
            await _unitOfWork.Complete();

            //send to online customer module
            var payload = new ComplaintTypeDto(_complaintType.ComplaintTypeId, _complaintType.ComplaintTypes!, _complaintType.DepartmentId, _complaintType.DepartmentUnitId);
            await _moduleComms.SendComplaintTypeDetailsAsync(payload);
             
            return new ComplaintTypeReadDto(_complaintType.ComplaintTypeId, _complaintType.ComplaintTypes!, _complaintType.DepartmentId, _complaintType.DepartmentUnitId);
        }

        public async Task<string> DeleteComplaintTypeAsync(int value)
        {
            var response = await _unitOfWork.ComplaintType.Get(value);

            if (response is null)
            {
                return "BadRequest";
            }

            _unitOfWork.ComplaintType.Delete(response);
            await _unitOfWork.Complete();

            return "success";
        }

        public async Task<IEnumerable<ComplaintTypeReadDto>> GetComplaintTypeAsync()
        {
            var response = await _unitOfWork.ComplaintType.GetAll();
            return _mapper.Map<IEnumerable<ComplaintTypeReadDto>>(response);
        }

        //public async Task<ComplaintTypeReadDto> GetComplaintTypeAsync(int value)
        //{
        //    var response = await _unitOfWork.ComplaintType.Get(value);
        //    return _mapper.Map<ComplaintTypeReadDto>(response);
        //}

        //public async Task<ComplaintTypeReadDto> GetComplaintTypeAsync(string value)
        //{
        //    var response = await _unitOfWork.ComplaintType.Get(ct => ct.ComplaintTypes == value);
        //    return _mapper.Map<ComplaintTypeReadDto>(response);
        //}

        public async Task<ComplaintTypeReadDto> UpdateComplaintTypeAsync(ComplaintTypeUpdateDto values)
        {
            ComplaintType _complaintType = await ComplaintType.Update(values.complaintTypeId, values.complaintTypes!, values.departmentId, values.departmentUnitId, _domainService);
            _complaintType.ModifiedBy = values.modifiedBy;
            _complaintType.ModifiedOn = DateTime.Now;

            _unitOfWork.ComplaintType.Update(_complaintType);
            await _unitOfWork.Complete();

            //send to online customer module
            var payload = new ComplaintTypeDto(_complaintType.ComplaintTypeId, _complaintType.ComplaintTypes!, _complaintType.DepartmentId, _complaintType.DepartmentUnitId);
            await _moduleComms.SendComplaintTypeDetailsUpdateAsync(payload);

            return new ComplaintTypeReadDto(_complaintType.ComplaintTypeId, _complaintType.ComplaintTypes!, _complaintType.DepartmentId, _complaintType.DepartmentUnitId);
        }

    }






}

