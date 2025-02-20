using System;
using System.Text;
using System.Text.Json;

namespace Modules.Estates.Application.Repositories.Setup.Customer
{
	public class IdentificationTypeService : IIdentificationTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly HttpClient _httpClient;

        public IdentificationTypeService(IUnitOfWork unitOfWork, IMapper mapper, HttpClient httpClient)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _httpClient = httpClient;
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

            string json_payload = JsonSerializer.Serialize(payload);
            var _httpContent = new StringContent(json_payload, Encoding.UTF8, "application/json");
            HttpResponseMessage _response = await _httpClient.PostAsync("https://mindsprings-002-site1.ltempurl.com/api/v1/Administration/AddIdentificationType", _httpContent);
            var result_sms = _response.IsSuccessStatusCode;


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

