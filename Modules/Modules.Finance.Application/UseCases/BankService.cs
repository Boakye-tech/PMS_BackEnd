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
	public class BankService : IBankService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BankService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BankReadDto> AddBankAsync(BankCreateDto values)
        {
            Bank bank = new(values.BankId, values.BankName!)
            {
                CreatedBy = values.CreatedBy,
                CreatedOn = DateTime.Now
            };

            _unitOfWork.Bank.Insert(bank);
            await _unitOfWork.Complete();

            return new BankReadDto(bank.BankId, bank.BankName!);
        }

        public async Task<IEnumerable<BankReadDto>> GetBankAsync()
        {
            var banks = await _unitOfWork.Bank.GetAll();
            return _mapper.Map<IEnumerable<BankReadDto>>(banks);
        }

        public async Task<BankReadDto> GetBankAsync(int value)
        {
            var bank = await _unitOfWork.Bank.Get(value);
            return _mapper.Map<BankReadDto>(bank);
        }

        public Task<BankReadDto> GetBankAsync(string value)
        {
            throw new NotImplementedException();
        }

        public async Task<BankReadDto> UpdateBankAsync(BankUpdateDto values)
        {
            //throw new NotImplementedException();
            Bank bank = new(values.BankId, values.BankName!)
            {
                ModifiedBy = values.ModifiedBy,
                ModifiedOn = DateTime.Now
            };

            _unitOfWork.Bank.Update(bank);
            await _unitOfWork.Complete();

            return new BankReadDto(bank.BankId, bank.BankName!);
        }
    }
}

