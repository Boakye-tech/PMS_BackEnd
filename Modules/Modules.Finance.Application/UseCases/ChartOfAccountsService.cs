using System;

namespace Modules.Finance.Application.UseCases
{
	public class ChartOfAccountsService : IChartOfAccountsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ChartOfAccountsService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ChartOfAccountsReadDto> AddChartOfAccountsAsync(ChartOfAccountsCreateDto values)
        {
            ChartOfAccounts chartOfAccounts = new(values.AccountCode, values.AccountName!)
            {
                CreatedBy = values.CreatedBy,
                CreatedOn = DateTime.Now
            };

            _unitOfWork.ChartOfAccounts.Insert(chartOfAccounts);
            await _unitOfWork.Complete();

            return new ChartOfAccountsReadDto(chartOfAccounts.AccountCode, chartOfAccounts.AccountName!);
        }

        public async Task<IEnumerable<ChartOfAccountsReadDto>> GetChartOfAccountsAsync()
        {
            var chartOfAccounts = await _unitOfWork.ChartOfAccounts.GetAll();
            return _mapper.Map<IEnumerable<ChartOfAccountsReadDto>>(chartOfAccounts);
        }

        public Task<ChartOfAccountsReadDto> GetChartOfAccountsAsync(int value)
        {
            throw new NotImplementedException();
        }

        public Task<ChartOfAccountsReadDto> GetChartOfAccountsAsync(string value)
        {
            throw new NotImplementedException();
        }

        public Task<ChartOfAccountsReadDto> UpdateChartOfAccountsAsync(ChartOfAccountsUpdateDto values)
        {
            throw new NotImplementedException();
        }
    }
}

