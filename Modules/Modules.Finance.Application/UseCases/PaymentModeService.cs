using System;

namespace Modules.Finance.Application.UseCases
{
	public class PaymentModeService : IPaymentModeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PaymentModeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<PaymentModeReadDto> AddPaymentModeAsync(PaymentModeCreateDto values)
        {
            PaymentMode mode = new(values.PaymentModeId, values.PaymentModes!)
            {
                CreatedBy = values.CreatedBy,
                CreatedOn = DateTime.Now
            };

            _unitOfWork.PaymentMode.Insert(mode);
            await _unitOfWork.Complete();

            return new PaymentModeReadDto(mode.PaymentModeId, mode.PaymentModes!);
        }

        public async Task<IEnumerable<PaymentModeReadDto>> GetPaymentModeAsync()
        {
            var modes = await _unitOfWork.PaymentMode.GetAll();
            return _mapper.Map<IEnumerable<PaymentModeReadDto>>(modes);
        }

        public Task<PaymentModeReadDto> GetPaymentModeAsync(int value)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentModeReadDto> GetPaymentModeAsync(string value)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentModeReadDto> UpdatePaymentModeAsync(PaymentModeUpdateDto values)
        {
            throw new NotImplementedException();
        }
    }
}

