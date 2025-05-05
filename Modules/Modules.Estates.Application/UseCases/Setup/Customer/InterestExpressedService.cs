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
	public class InterestExpressedService : IInterestExpressedService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public InterestExpressedService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<InterestExpressedReadDto> CreateInterestExpressedAsync(InterestExpressedCreateDto values)
        {
            InterestExpressed interestExpressed = new(values.interestExpressedId, values.customerInterestExpressed)
            {
                CreatedBy = values.createdBy,
                CreatedOn = DateTime.UtcNow
            };

            _unitOfWork.InterestExpressed.Insert(interestExpressed);
            await _unitOfWork.Complete();

            return new InterestExpressedReadDto(interestExpressed.InterestExpressedId, interestExpressed.CustomerInterestExpressed);
        }

        public async Task<string> DeleteInterestExpressedAsync(int value)
        {
            var response = await _unitOfWork.InterestExpressed.Get(value);

            if (response is null)
            {
                return "400 - BadRequest";
            }

            _unitOfWork.InterestExpressed.Delete(response);
            await _unitOfWork.Complete();

            return "success";
        }

        public async Task<IEnumerable<InterestExpressedReadDto>> GetInterestExpressedAsync()
        {
            var response = await _unitOfWork.InterestExpressed.GetAll();
            return _mapper.Map<IEnumerable<InterestExpressedReadDto>>(response);
        }

        public async Task<InterestExpressedReadDto> UpdateInterestExpressedAsync(InterestExpressedUpdateDto values)
        {
            InterestExpressed interestExpressed = new(values.interestExpressedId, values.customerInterestExpressed)
            {
                CreatedBy = values.modifiedBy,
                CreatedOn = DateTime.UtcNow
            };

            _unitOfWork.InterestExpressed.Update(interestExpressed);
            await _unitOfWork.Complete();

            return new InterestExpressedReadDto(interestExpressed.InterestExpressedId, interestExpressed.CustomerInterestExpressed);
        }
    }
}

