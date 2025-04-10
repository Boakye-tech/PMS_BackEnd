using System;
namespace Modules.Estates.Application.UseCases.Setup.Customer
{
	public class ComplaintTypeService : IComplaintTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IModuleCommunicationServices _moduleComms;

        public ComplaintTypeService(IUnitOfWork unitOfWork, IMapper mapper, IModuleCommunicationServices moduleComms)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _moduleComms = moduleComms;
        }

        public async Task<ComplaintTypeReadDto> AddComplaintTypeAsync(ComplaintTypeCreateDto values)
        {
            ComplaintType ComplaintType = new(values.complaintTypeId, values.complaintTypes!)
            {
                CreatedBy = values.createdBy,
                CreatedOn = DateTime.Now
            };

            _unitOfWork.ComplaintType.Insert(ComplaintType);
            await _unitOfWork.Complete();

            //send to online customer module
            var payload = new ComplaintTypeDto(ComplaintType.ComplaintTypeId, ComplaintType.ComplaintTypes!);
            await _moduleComms.SendComplaintTypeDetailsAsync(payload);
             
            return new ComplaintTypeReadDto(ComplaintType.ComplaintTypeId, ComplaintType.ComplaintTypes!);
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
            ComplaintType ComplaintType = new(values.complaintTypeId, values.complaintTypes!)
            {
                ModifiedBy = values.modifiedBy,
                ModifiedOn = DateTime.Now
            };

            _unitOfWork.ComplaintType.Update(ComplaintType);
            await _unitOfWork.Complete();

            return new ComplaintTypeReadDto(ComplaintType.ComplaintTypeId, ComplaintType.ComplaintTypes!);
        }

    }






}

