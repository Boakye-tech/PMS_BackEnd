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
	public class NatureOfComplaintService : INatureOfComplaintService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IModuleCommunicationServices _moduleComms;
        private readonly ICustomerDomainService _domainService;

        public NatureOfComplaintService(IUnitOfWork unitOfWork, IMapper mapper, IModuleCommunicationServices moduleComms, ICustomerDomainService domainService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _moduleComms = moduleComms;
            _domainService = domainService;
        }

        public async Task<NatureOfComplaintReadDto> AddNatureOfComplaintAsync(NatureOfComplaintCreateDto values)
        {
            NatureOfComplaint natureOfComplaint = await NatureOfComplaint.Create(values.complaintTypeId, values.natureOfComplaintId, values.natureOfComplaints, _domainService);
            natureOfComplaint.CreatedBy = values.createdBy;
            natureOfComplaint.CreatedOn = DateTime.Now;

            _unitOfWork.NatureOfComplaint.Insert(natureOfComplaint);
            await _unitOfWork.Complete();

            //send to online customer module
            var payload = new NatureOfComplaintDto(natureOfComplaint.ComplaintTypeId, natureOfComplaint.NatureOfComplaintId , natureOfComplaint.NatureOfComplaints);
            await _moduleComms.SendNatureOfComplaintDetailsAsync(payload);

            return new NatureOfComplaintReadDto(natureOfComplaint.ComplaintTypeId, natureOfComplaint.NatureOfComplaintId, natureOfComplaint.NatureOfComplaints);
        }

        public async Task<NatureOfComplaintReadDto> UpdateNatureOfComplaintAsync(NatureOfComplaintUpdateDto values)
        {
            NatureOfComplaint natureOfComplaint = await NatureOfComplaint.Update(values.complaintTypeId, values.natureOfComplaintId, values.natureOfComplaints, _domainService);
            natureOfComplaint.ModifiedBy = values.modifiedBy;
            natureOfComplaint.ModifiedOn = DateTime.Now;

            _unitOfWork.NatureOfComplaint.Update(natureOfComplaint);
            await _unitOfWork.Complete();

            //send to online customer module
            var payload = new NatureOfComplaintDto(natureOfComplaint.ComplaintTypeId, natureOfComplaint.NatureOfComplaintId, natureOfComplaint.NatureOfComplaints);
            await _moduleComms.SendNatureOfComplaintDetailsUpdateAsync(payload);

            return new NatureOfComplaintReadDto(natureOfComplaint.ComplaintTypeId, natureOfComplaint.NatureOfComplaintId, natureOfComplaint.NatureOfComplaints);
        }

        public async Task<string> DeleteNatureOfComplaintAsync(int value)
        {
            var response = await _unitOfWork.NatureOfComplaint.Get(value);

            if (response is null)
            {
                return "BadRequest";
            }

            _unitOfWork.NatureOfComplaint.Delete(response);
            await _unitOfWork.Complete();

            return "success";
        }

        public async Task<IEnumerable<NatureOfComplaintReadDto>> GetNatureOfComplaintAsync()
        {
            var response = await _unitOfWork.NatureOfComplaint.GetAll();
            return _mapper.Map<IEnumerable<NatureOfComplaintReadDto>>(response);
        }

        public async Task<IEnumerable<NatureOfComplaintReadDto>> GetNatureOfComplaintAsync(int complaintTypeId)
        {
            var response = await _unitOfWork.NatureOfComplaint.GetAll(ct => ct.ComplaintTypeId == complaintTypeId);
            return _mapper.Map<IEnumerable<NatureOfComplaintReadDto>>(response);
        }

    }





}

