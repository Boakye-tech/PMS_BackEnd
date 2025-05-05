// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Finance.Application.UseCases
{
	public class FormsService : IFormsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public FormsService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<FormsReadDto> AddFormsAsync(FormsCreateDto values)
        {
            Forms form = new(values.FormCode!, values.FormName!, values.Amount, values.AccountCode)
            {
                CreatedBy = values.CreatedBy,
                CreatedOn = DateTime.Now
            };

            _unitOfWork.Forms.Insert(form);
            await _unitOfWork.Complete();

            return new FormsReadDto(form.FormCode!, form.FormName!, form.Amount, form.AccountCode);
        }

        public async Task<IEnumerable<FormsReadDto>> GetFormsAsync()
        {
            var forms = await _unitOfWork.Forms.GetAll();
            return _mapper.Map<IEnumerable<FormsReadDto>>(forms);
        }

        public Task<FormsReadDto> GetFormsAsync(int value)
        {
            throw new NotImplementedException();
        }

        public Task<FormsReadDto> GetFormsAsync(string value)
        {
            throw new NotImplementedException();
        }

        public Task<FormsReadDto> UpdateFormsAsync(FormsUpdateDto values)
        {
            throw new NotImplementedException();
        }
    }
}

