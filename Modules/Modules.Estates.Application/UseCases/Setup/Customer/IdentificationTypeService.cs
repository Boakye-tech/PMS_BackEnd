using System;
using System.Text;
using System.Text.Json;

namespace Modules.Estates.Application.UseCases.Setup.Customer
{
	public class IdentificationTypeService : IIdentificationTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IModuleCommunicationServices _moduleComms;

        public IdentificationTypeService(IUnitOfWork unitOfWork, IMapper mapper, IModuleCommunicationServices moduleComms) 
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _moduleComms = moduleComms;
        }

        public async Task<IdentificationTypeReadDto> AddIdentificationTypeAsync(IdentificationTypeCreateDto values)
        {
            IdentificationType request = new(values.identificationTypeId, values.identificationTypes!)
            {
                CreatedBy = values.createdBy,
                CreatedOn = DateTime.Now
            };

            _unitOfWork.IdentificationType.Insert(request);
            await _unitOfWork.Complete();

            //send to user module
            var payload = new IdentificationTypeDto(request.IdentificationTypeId, request.IdentificationTypes!);
            var response = await _moduleComms.SendIdentificationTypeAsync(payload);
            if (!response) { } //remember to log failure response

            return new IdentificationTypeReadDto(request.IdentificationTypeId, request.IdentificationTypes!);
        }

        public async Task<string> DeleteIdentificationTypeAsync(int value)
        {
            var response = await _unitOfWork.IdentificationType.Get(value);

            if (response is null)
            {
                return "400 - BadRequest";
            }

            _unitOfWork.IdentificationType.Delete(response);
            await _unitOfWork.Complete();

            return "success";
        }

        public async Task<IEnumerable<IdentificationTypeReadDto>> GetIdentificationTypeAsync()
        {
            var response = await _unitOfWork.IdentificationType.GetAll();
            return _mapper.Map<IEnumerable<IdentificationTypeReadDto>>(response);
        }

        public async Task<IdentificationTypeReadDto> GetIdentificationTypeAsync(int value)
        {
            var response = await _unitOfWork.IdentificationType.Get(value);
            return _mapper.Map<IdentificationTypeReadDto>(response);
        }

        public async Task<IdentificationTypeReadDto> GetIdentificationTypeAsync(string value)
        {
            var response = await _unitOfWork.IdentificationType.Get(i => i.IdentificationTypes == value);
            return _mapper.Map<IdentificationTypeReadDto>(response);
        }

        public async Task<IdentificationTypeReadDto> UpdateIdentificationTypeAsync(IdentificationTypeUpdateDto values)
        {
            IdentificationType request = new(values.identificationTypeId, values.identificationTypes!)
            {
                ModifiedBy = values.modifiedBy,
                ModifiedOn = DateTime.Now
            };

            _unitOfWork.IdentificationType.Update(request);
            await _unitOfWork.Complete();

            return new IdentificationTypeReadDto(request.IdentificationTypeId, request.IdentificationTypes!);
        }

    }


}

