using System;

namespace Modules.Finance.Application.UseCases
{
	public class BankSortCodesService : IBankSortCodesService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BankSortCodesService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BankSortCodesReadDto> AddBankSortCodesAsync(BankSortCodesCreateDto values)
        {
            BankSortCodes sortCodes = new(values.Id,values.SortCode, values.BankName!,values.BranchName!)
            {
                CreatedBy = values.CreatedBy,
                CreatedOn = DateTime.Now
            };

            _unitOfWork.BankSortCodes.Insert(sortCodes);
            await _unitOfWork.Complete();

            return new BankSortCodesReadDto(sortCodes.Id, sortCodes.SortCode!, sortCodes.BankName!, sortCodes.BranchName!);
        }

        public async Task<IEnumerable<BankSortCodesReadDto>> GetBankSortCodesAsync()
        {
            var sortcodes = await _unitOfWork.BankSortCodes.GetAll();
            return _mapper.Map<IEnumerable<BankSortCodesReadDto>>(sortcodes);
        }

        public Task<BankSortCodesReadDto> GetBankSortCodesAsync(int value)
        {
            throw new NotImplementedException();
        }

        public Task<BankSortCodesReadDto> GetBankSortCodesAsync(string value)
        {
            throw new NotImplementedException();
        }

        public Task<BankSortCodesReadDto> UpdateBankSortCodesAsync(BankSortCodesUpdateDto values)
        {
            throw new NotImplementedException();
        }
    }
}

