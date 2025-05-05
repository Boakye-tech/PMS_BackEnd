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
	public class PaymentTypeService : IPaymentTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PaymentTypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<PaymentTypeReadDto> AddPaymentTypeAsync(PaymentTypeCreateDto values)
        {
            PaymentType types = new(values.PaymentTypeId, values.PaymentTypes!)
            {
                CreatedBy = values.CreatedBy,
                CreatedOn = DateTime.Now
            };

            _unitOfWork.PaymentType.Insert(types);
            await _unitOfWork.Complete();

            return new PaymentTypeReadDto(types.PaymentTypeId, types.PaymentTypes!);
        }

        public async Task<IEnumerable<PaymentTypeReadDto>> GetPaymentTypeAsync()
        {
            var types = await _unitOfWork.PaymentType.GetAll();
            return _mapper.Map<IEnumerable<PaymentTypeReadDto>>(types);
        }

        public Task<PaymentTypeReadDto> GetPaymentTypeAsync(int value)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentTypeReadDto> GetPaymentTypeAsync(string value)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentTypeReadDto> UpdatePaymentTypeAsync(PaymentTypeUpdateDto values)
        {
            throw new NotImplementedException();
        }
    }
}

