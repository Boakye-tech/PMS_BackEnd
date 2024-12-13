

namespace Modules.Finance.Application.UseCases
{
	public class BankBranchService : IBankBranchService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BankBranchService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BankBranchReadDto> AddBankBranchAsync(BankBranchCreateDto values)
        {
            BankBranch branch = new(values.BankId, values.BranchId, values.BranchName!)
            {
                CreatedBy = values.CreatedBy,
                CreatedOn = DateTime.Now
            };

            _unitOfWork.BankBranch.Insert(branch);
            await _unitOfWork.Complete();

            return new BankBranchReadDto(branch.BankId, branch.BranchId, branch.BranchName!);
        }

        public async Task<IEnumerable<BankBranchReadDto>> GetBankBranchAsync()
        {
            
            var bankbranches = await _unitOfWork.BankBranch.GetAll();
            return _mapper.Map<IEnumerable<BankBranchReadDto>>(bankbranches);
        }

        public Task<BankBranchReadDto> GetBankBranchAsync(int value)
        {
            throw new NotImplementedException();
        }

        public Task<BankBranchReadDto> GetBankBranchAsync(string value)
        {
            throw new NotImplementedException();
        }

        public Task<BankBranchReadDto> UpdateBankBranchAsync(BankBranchUpdateDto values)
        {
            throw new NotImplementedException();
        }
    }
}

