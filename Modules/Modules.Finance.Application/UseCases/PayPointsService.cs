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
	public class PayPointsService : IPayPointsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PayPointsService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<PaypointsReadDto> AddPaypointsAsync(PaypointsCreateDto values)
        {
            Paypoints paypoint = new(values.PaypointId, values.Paypoint!)
            {
                CreatedBy = values.CreatedBy,
                CreatedOn = DateTime.Now
            };

            _unitOfWork.Paypoints.Insert(paypoint);
            await _unitOfWork.Complete();

            return new PaypointsReadDto(paypoint.PaypointId, paypoint.Paypoint!);
        }

        public async Task<IEnumerable<PaypointsReadDto>> GetPaypointsAsync()
        {
            var paypoints = await _unitOfWork.Paypoints.GetAll();
            return _mapper.Map<IEnumerable<PaypointsReadDto>>(paypoints);
        }

        public Task<PaypointsReadDto> GetPaypointsAsync(int value)
        {
            throw new NotImplementedException();
        }

        public Task<PaypointsReadDto> GetPaypointsAsync(string value)
        {
            throw new NotImplementedException();
        }

        public Task<PaypointsReadDto> UpdatePaypointsAsync(PaypointsUpdateDto values)
        {
            throw new NotImplementedException();
        }
    }
}

