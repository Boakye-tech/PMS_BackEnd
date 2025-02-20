using System;
namespace Modules.Users.Application.UseCases
{
	public class IdentificationTypeService : IIdentificationTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public IdentificationTypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IdentificationTypeDto> AddIdentificationTypeAsync(IdentificationTypeDto values)
        {
            IdentificationType request = new(values.identificationTypeId, values.identificationTypes!);

            _unitOfWork.IdentificationType.Insert(request);
            await _unitOfWork.Complete();

            return new IdentificationTypeDto(request.IdentificationTypeId, request.IdentificationTypes!);
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

        public async Task<IEnumerable<IdentificationTypeDto>> GetIdentificationTypeAsync()
        {
            var response = await _unitOfWork.IdentificationType.GetAll();
            return _mapper.Map<IEnumerable<IdentificationTypeDto>>(response);
        }


        public async Task<IdentificationTypeDto> UpdateIdentificationTypeAsync(IdentificationTypeDto values)
        {
            IdentificationType request = new(values.identificationTypeId, values.identificationTypes!);

            _unitOfWork.IdentificationType.Update(request);
            await _unitOfWork.Complete();

            return new IdentificationTypeDto(request.IdentificationTypeId, request.IdentificationTypes!);
        }


    }
}

