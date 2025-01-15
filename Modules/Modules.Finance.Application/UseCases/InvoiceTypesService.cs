using System;

namespace Modules.Finance.Application.UseCases
{
	public class InvoiceTypesService : IInvoiceTypesService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public InvoiceTypesService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<InvoiceTypesReadDto> AddInvoiceTypesAsync(InvoiceTypesCreateDto values)
        {
            InvoiceTypes invoiceTypes = new InvoiceTypes(values.InvoiceTypesId, values.InvoiceInitials, values.InvoiceDescriptions, values.InvoiceAmount)
            {
                CreatedBy = values.CreatedBy,
                CreatedOn = DateTime.UtcNow
            };

            _unitOfWork.InvoiceTypes.Insert(invoiceTypes);
            await _unitOfWork.Complete();

            return new InvoiceTypesReadDto(invoiceTypes.InvoiceTypesId, invoiceTypes.InvoiceInitials!, invoiceTypes.InvoiceDescriptions!, invoiceTypes.InvoiceAmount);
        }

        public async Task<IEnumerable<InvoiceTypesReadDto>> GetInvoiceTypesAsync()
        {
            //throw new NotImplementedException();
            var inv_types = await _unitOfWork.InvoiceTypes.GetAll();
            return _mapper.Map<IEnumerable<InvoiceTypesReadDto>>(inv_types);

        }

        public Task<InvoiceTypesReadDto> GetInvoiceTypesAsync(int value)
        {
            throw new NotImplementedException();
        }

        public Task<InvoiceTypesReadDto> UpdateInvoiceTypesAsync(InvoiceTypesUpdateDto values)
        {
            throw new NotImplementedException();
        }
    }
}

