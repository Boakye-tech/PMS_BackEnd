// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Application/UseCases/Setup/StockService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 10:45 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Application.UseCases.Setup
{
    public class StockService : IStockService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public StockService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ReturnResponsesDto> CreateStockAsync(StockCreateDto values)
        {
            try
            {
                var existing = await _unitOfWork.Stock.Get(c => c.ItemCode == values.itemCode);
                if (existing != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status400BadRequest, StatusMessage = "Stock for this item already exists." },
                        SuccessResponse = null
                    };
                }
                var stock = Stock.Create(
                    0,
                    values.stockNumber,
                    values.itemCode,
                    values.quantity,
                    values.unitPrice,
                    values.supplierId,
                    values.transactionDate,
                    values.transactionType,
                    values.receiptNoteNumber,
                    values.quantityReceived,
                    values.issueNoteNumber,
                    values.quantityIssues,
                    values.remarks,
                    values.lowStockThreshold,
                    values.lastRestockedDate
                );
                stock.CreatedBy = values.createdBy;
                stock.CreatedOn = DateTime.Now;
                _unitOfWork.Stock.Insert(stock);
                await _unitOfWork.Complete();
                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new BaseResponseDto { StatusCode = StatusCodes.Status201Created, StatusMessage = "Stock created successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status500InternalServerError, StatusMessage = ex.Message },
                    SuccessResponse = null
                };
            }
        }

        public async Task<ReturnResponsesDto> UpdateStockAsync(StockUpdateDto values)
        {
            try
            {
                var stock = await _unitOfWork.Stock.Get(values.stockId);
                if (stock is null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status404NotFound, StatusMessage = $"Stock with ID {values.stockId} not found." },
                        SuccessResponse = null
                    };
                }
                stock.Update(
                    values.stockId,
                    values.stockNumber,
                    values.itemCode,
                    values.quantity,
                    values.unitPrice,
                    values.supplierId,
                    values.transactionDate,
                    values.transactionType,
                    values.receiptNoteNumber,
                    values.quantityReceived,
                    values.issueNoteNumber,
                    values.quantityIssues,
                    values.remarks,
                    values.lowStockThreshold,
                    values.lastRestockedDate
                );
                stock.ModifiedBy = values.modifiedBy;
                stock.ModifiedOn = DateTime.Now;
                _unitOfWork.Stock.Update(stock);
                await _unitOfWork.Complete();
                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new BaseResponseDto { StatusCode = StatusCodes.Status200OK, StatusMessage = "Stock updated successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status500InternalServerError, StatusMessage = ex.Message },
                    SuccessResponse = null
                };
            }
        }

        public async Task<IEnumerable<StockReadDto>> GetStockAsync()
        {
            var stocks = await _unitOfWork.Stock.GetAll();
            return _mapper.Map<IEnumerable<StockReadDto>>(stocks);
        }

        public async Task<ReturnResponsesDto> DeleteStockAsync(int stockId)
        {
            try
            {
                var stock = await _unitOfWork.Stock.Get(stockId);
                if (stock == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status404NotFound, StatusMessage = $"Stock with ID {stockId} not found." },
                        SuccessResponse = null
                    };
                }
                _unitOfWork.Stock.Delete(stock);
                await _unitOfWork.Complete();
                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new BaseResponseDto { StatusCode = StatusCodes.Status200OK, StatusMessage = $"Stock with ID {stockId} deleted successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status500InternalServerError, StatusMessage = ex.Message },
                    SuccessResponse = null
                };
            }
        }
    }
}