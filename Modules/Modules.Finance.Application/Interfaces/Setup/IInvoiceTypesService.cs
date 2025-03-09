using System;
namespace Modules.Finance.Application.Interfaces.Setup
{
	public interface IInvoiceTypesService
	{
        Task<InvoiceTypesReadDto> AddInvoiceTypesAsync(InvoiceTypesCreateDto values);
        Task<InvoiceTypesReadDto> UpdateInvoiceTypesAsync(InvoiceTypesUpdateDto values);
        Task<IEnumerable<InvoiceTypesReadDto>> GetInvoiceTypesAsync();
        Task<InvoiceTypesReadDto> GetInvoiceTypesAsync(int value);
        //Task<InvoiceTypesReadDto> GetInvoiceTypesAsync(string value);

    }
}

