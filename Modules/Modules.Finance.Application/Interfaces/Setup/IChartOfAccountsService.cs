using System;
namespace Modules.Finance.Application.Interfaces.Setup
{
	public interface IChartOfAccountsService
	{
        Task<ChartOfAccountsReadDto> AddChartOfAccountsAsync(ChartOfAccountsCreateDto values);
        Task<ChartOfAccountsReadDto> UpdateChartOfAccountsAsync(ChartOfAccountsUpdateDto values);
        Task<IEnumerable<ChartOfAccountsReadDto>> GetChartOfAccountsAsync();
        Task<ChartOfAccountsReadDto> GetChartOfAccountsAsync(int value);
        Task<ChartOfAccountsReadDto> GetChartOfAccountsAsync(string value);
    }
}

