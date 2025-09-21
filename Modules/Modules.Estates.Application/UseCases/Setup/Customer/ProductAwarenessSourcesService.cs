// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 20/09/2025 5:55 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Modules.Estates.Domain.Entities.Setup.Customer;

namespace Modules.Estates.Application.UseCases.Setup.Customer;

public class ProductAwarenessSourcesService : IProductAwarenessSourcesService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ProductAwarenessSourcesService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<ProductAwarenessSourcesReadDto> AddProductAwarenessSourcesAsync(ProductAwarenessSourcesCreateDto values)
    {
        try
        {

            ProductAwarenessSources productAwarenessSources = new(values.productAwarenessSourcesId, values.productAwarenessSource!)
            {
                CreatedBy = values.createdBy,
                CreatedOn = DateTime.Now
            };

            _unitOfWork.ProductAwarenessSources.Insert(productAwarenessSources);
            await _unitOfWork.Complete();

            return new ProductAwarenessSourcesReadDto(productAwarenessSources.ProductAwarenessSourcesId, productAwarenessSources.ProductAwarenessSource!);
        }
        catch (DbUpdateException ex)
        {
            return new ProductAwarenessSourcesReadDto(ex.HResult, ex.InnerException!.Message);
        }
        catch (Exception ex)
        {
            return new ProductAwarenessSourcesReadDto(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    public async Task<ProductAwarenessSourcesReadDto> DeleteProductAwarenessSourcesAsync(int value)
    {
        try
        {
            var response = await _unitOfWork.ProductAwarenessSources.Get(value);

            if (response is null)
            {
                return new ProductAwarenessSourcesReadDto(StatusCodes.Status404NotFound, $"Product Awareness Source Id {value} supplied was not found.");
            }

            _unitOfWork.ProductAwarenessSources.Delete(response);
            await _unitOfWork.Complete();

            return new ProductAwarenessSourcesReadDto(response.ProductAwarenessSourcesId, response.ProductAwarenessSource!);
        }
        catch (Exception ex)
        {
            return new ProductAwarenessSourcesReadDto(StatusCodes.Status500InternalServerError, ex.Message);
        }

    }

    public async Task<IEnumerable<ProductAwarenessSourcesReadDto>> GetProductAwarenessSourcesAsync()
    {
        var response = await _unitOfWork.ProductAwarenessSources.GetAll();
        return _mapper.Map<IEnumerable<ProductAwarenessSourcesReadDto>>(response);
    }

    public async Task<ProductAwarenessSourcesReadDto> GetProductAwarenessSourcesAsync(int value)
    {
        var response = await _unitOfWork.ProductAwarenessSources.Get(value);
        return _mapper.Map<ProductAwarenessSourcesReadDto>(response);
    }

    public async Task<ProductAwarenessSourcesReadDto> GetProductAwarenessSourcesAsync(string value)
    {
        var response = await _unitOfWork.ProductAwarenessSources.Get(pas => pas.ProductAwarenessSource == value);
        return _mapper.Map<ProductAwarenessSourcesReadDto>(response);
    }

    public async Task<ProductAwarenessSourcesReadDto> UpdateProductAwarenessSourcesAsync(ProductAwarenessSourcesUpdateDto values)
    {
        try
        {
            var result = await _unitOfWork.ProductAwarenessSources.Get(pas => pas.ProductAwarenessSourcesId == values.productAwarenessSourcesId);
            if (result is null)
            {
                return new ProductAwarenessSourcesReadDto(StatusCodes.Status404NotFound, "0 row(s) found.");
            }

            ProductAwarenessSources productAwarenessSources = new(values.productAwarenessSourcesId, values.productAwarenessSource!)
            {
                ModifiedBy = values.modifiedBy,
                ModifiedOn = DateTime.Now
            };

            _unitOfWork.ProductAwarenessSources.Update(productAwarenessSources);
            await _unitOfWork.Complete();

            return new ProductAwarenessSourcesReadDto(productAwarenessSources.ProductAwarenessSourcesId, productAwarenessSources.ProductAwarenessSource!);

        }
        catch (Exception ex)
        {
            return new ProductAwarenessSourcesReadDto(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }


}
