using System;

namespace Modules.Estates.Application.Repositories.Setup.Customer
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

        public async Task<IdentificationTypeReadDto> AddIdentificationTypeAsync(IdentificationTypeCreateDto values)
        {
            IdentificationType request = new(values.identificationTypeId, values.identificationTypes!)
            {
                CreatedBy = values.createdBy,
                CreatedOn = DateTime.Now
            };

            _unitOfWork.IdentificationType.Insert(request);
            await _unitOfWork.Complete();

            return new IdentificationTypeReadDto(request.IdentificationTypeId, request.IdentificationTypes!);
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

