using System;

namespace Modules.Estates.Application.Repositories.Setup.Customer
{
	public class NationalityService: INationalityService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public NationalityService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<NationalityReadDto> AddNationalityAsync(NationalityCreateDto values)
        {
            Nationality request = new(values.nationalityId, values.nationalities!)
            {
                CreatedBy = values.createdby,
                CreatedOn = DateTime.Now
            };

            _unitOfWork.Nationality.Insert(request);
            await _unitOfWork.Complete();

            return new NationalityReadDto(request.NationalityId, request.Nationalities!);
        }

        public async Task<string> DeleteNationalityAsync(int value)
        {
            var response = await _unitOfWork.Nationality.Get(value);

            if (response is null)
            {
                return "400 - BadRequest";
            }

            _unitOfWork.Nationality.Delete(response);
            await _unitOfWork.Complete();

            return "success";
        }

        public async Task<IEnumerable<NationalityReadDto>> GetNationalityAsync()
        {
            var response = await _unitOfWork.Nationality.GetAll();
            return _mapper.Map<IEnumerable<NationalityReadDto>>(response);
        }

        public async Task<NationalityReadDto> GetNationalityAsync(int value)
        {
            var response = await _unitOfWork.Nationality.Get(value);
            return _mapper.Map<NationalityReadDto>(response);
        }

        public async Task<NationalityReadDto> GetNationalityAsync(string value)
        {
            var response = await _unitOfWork.Nationality.Get(n => n.Nationalities == value);
            return _mapper.Map<NationalityReadDto>(response);
        }

        public async Task<NationalityReadDto> UpdateNationalityAsync(NationalityUpdateDto values)
        {
            Nationality request = new(values.nationalityId, values.nationalities!)
            {
                ModifiedBy = values.modifiedby,
                ModifiedOn = DateTime.Now
            };

            _unitOfWork.Nationality.Update(request);
            await _unitOfWork.Complete();

            return new NationalityReadDto(request.NationalityId, request.Nationalities!);
        }
    }
}

