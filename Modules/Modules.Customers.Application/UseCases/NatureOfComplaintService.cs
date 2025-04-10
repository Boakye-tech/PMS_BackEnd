using System;

namespace Modules.Customers.Application.UseCases
{
	public class NatureOfComplaintService: INatureOfComplaintService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public NatureOfComplaintService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<NatureOfComplaintDto> AddNewNatureOfComplaint(NatureOfComplaintDto values)
        {
            NatureOfComplaint natureOfComplaint = new(values.complaintTypeId, values.natureOfComplaintId, values.natureOfComplaints);

            _unitOfWork.NatureOfComplaint.Insert(natureOfComplaint);
            await _unitOfWork.Complete();

            return new NatureOfComplaintDto(natureOfComplaint.ComplaintTypeId, natureOfComplaint.NatureOfComplaintId, natureOfComplaint.NatureOfComplaints!);
        }

        public Task<GenericResponseDto> DeleteNatureOfComplaint(int natureOfComplaintId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<NatureOfComplaintDto>> GetNatureOfComplaints()
        {
            var response = await _unitOfWork.NatureOfComplaint.GetAll();
            return _mapper.Map<IEnumerable<NatureOfComplaintDto>>(response);

        }

        public async Task<IEnumerable<NatureOfComplaintDto>> GetNatureOfComplaints(int complaintTypeId)
        {
            var response = await _unitOfWork.NatureOfComplaint.GetAll(n => n.ComplaintTypeId == complaintTypeId);
            return _mapper.Map<IEnumerable<NatureOfComplaintDto>>(response);
        }

        public async Task<NatureOfComplaintDto> UpdateNatureOfComplaint(NatureOfComplaintDto values)
        {
            NatureOfComplaint natureOfComplaint = new(values.complaintTypeId, values.natureOfComplaintId, values.natureOfComplaints);

            _unitOfWork.NatureOfComplaint.Update(natureOfComplaint);
            await _unitOfWork.Complete();

            return new NatureOfComplaintDto(natureOfComplaint.ComplaintTypeId, natureOfComplaint.NatureOfComplaintId, natureOfComplaint.NatureOfComplaints!);
        }
    }
}

