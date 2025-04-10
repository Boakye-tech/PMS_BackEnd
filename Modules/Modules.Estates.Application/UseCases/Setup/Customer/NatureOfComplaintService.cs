using System;
using Modules.Estates.Domain.Entities.Setup.Customer;

namespace Modules.Estates.Application.UseCases.Setup.Customer
{
	public class NatureOfComplaintService : INatureOfComplaintService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IModuleCommunicationServices _moduleComms;

        public NatureOfComplaintService(IUnitOfWork unitOfWork, IMapper mapper, IModuleCommunicationServices moduleComms)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _moduleComms = moduleComms;
        }

        public async Task<NatureOfComplaintReadDto> AddNatureOfComplaintAsync(NatureOfComplaintCreateDto values)
        {
            NatureOfComplaint natureOfComplaint = new(values.complaintTypeId, values.natureOfComplaintId, values.natureOfComplaints)
            {
                CreatedBy = values.createdBy,
                CreatedOn = DateTime.Now
            };

            _unitOfWork.NatureOfComplaint.Insert(natureOfComplaint);
            await _unitOfWork.Complete();

            //send to online customer module
            var payload = new NatureOfComplaintDto(natureOfComplaint.ComplaintTypeId, natureOfComplaint.NatureOfComplaintId , natureOfComplaint.NatureOfComplaints);
            await _moduleComms.SendNatureOfComplaintDetailsAsync(payload);

            return new NatureOfComplaintReadDto(natureOfComplaint.ComplaintTypeId, natureOfComplaint.NatureOfComplaintId, natureOfComplaint.NatureOfComplaints);
        }

        public async Task<NatureOfComplaintReadDto> UpdateNatureOfComplaintAsync(NatureOfComplaintUpdateDto values)
        {
            NatureOfComplaint natureOfComplaint = new(values.complaintTypeId, values.natureOfComplaintId, values.natureOfComplaints)
            {
                ModifiedBy = values.modifiedBy,
                ModifiedOn = DateTime.Now
            };

            _unitOfWork.NatureOfComplaint.Update(natureOfComplaint);
            await _unitOfWork.Complete();
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



    }





}

