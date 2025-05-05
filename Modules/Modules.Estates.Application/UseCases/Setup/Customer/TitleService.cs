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
	public class TitleService: ITitleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TitleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<TitleReadDto> AddTitleAsync(TitleCreateDto values)
        {
            Title title = new(values.titleId, values.titles!)
            {
                CreatedBy = values.createdby,
                CreatedOn = DateTime.Now
            };

            _unitOfWork.Title.Insert(title);
            await _unitOfWork.Complete();

            return new TitleReadDto(title.TitleId, title.Titles!);
        }

        public async Task<string> DeleteTitleAsync(int value)
        {
            var response = await _unitOfWork.Title.Get(value);

            if (response is null)
            {
                return "400 - BadRequest";
            }

            _unitOfWork.Title.Delete(response);
            await _unitOfWork.Complete();

            return "success";
        }

        public async Task<IEnumerable<TitleReadDto>> GetTitleAsync()
        {
            var response = await _unitOfWork.Title.GetAll();
            return _mapper.Map<IEnumerable<TitleReadDto>>(response);
        }

        public async Task<TitleReadDto> GetTitleAsync(int value)
        {
            var response = await _unitOfWork.Title.Get(value);
            return _mapper.Map<TitleReadDto>(response);
        }

        public async Task<TitleReadDto> GetTitleAsync(string value)
        {
            var response = await _unitOfWork.Title.Get(t => t.Titles == value);
            return _mapper.Map<TitleReadDto>(response);
        }

        public async Task<TitleReadDto> UpdateTitleAsync(TitleUpdateDto values)
        {
            Title title = new(values.titleId, values.titles!)
            {
                ModifiedBy = values.modifiedby,
                ModifiedOn = DateTime.Now
            };

            _unitOfWork.Title.Update(title);
            await _unitOfWork.Complete();

            return new TitleReadDto(title.TitleId, title.Titles!);
        }


    }
}

