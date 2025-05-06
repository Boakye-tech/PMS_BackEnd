// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Modules.Estates.Domain.Entities.Setup.Customer;

namespace Modules.Estates.Application.UseCases.Setup.Customer;

public class CustomerTypeService : ICustomerTypeService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CustomerTypeService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<CustomerTypeReadDto> AddCustomerTypeAsync(CustomerTypeCreateDto values)
    {
        try
        {
            values.customerTypeId = 0;
            CustomerType customerType = new(values.customerTypeId, values.customerTypes!)
            {
                CreatedBy = values.createdBy,
                CreatedOn = DateTime.Now
            };

            _unitOfWork.CustomerType.Insert(customerType);
            await _unitOfWork.Complete();

            return new CustomerTypeReadDto(customerType.CustomerTypeId, customerType.CustomerTypes!);
        }
        catch (DbUpdateException ex)
        {
            return new CustomerTypeReadDto(ex.HResult, ex.InnerException!.Message);
        }
        catch (Exception ex)
        {
            return new CustomerTypeReadDto(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    public async Task<CustomerTypeReadDto> DeleteCustomerTyeAsync(int value)
    {
        try
        {
            var response = await _unitOfWork.CustomerType.Get(value);

            if (response is null)
            {
                return new CustomerTypeReadDto(StatusCodes.Status404NotFound, $"Customer Type Id {value} supplied was not found.");
            }

            _unitOfWork.CustomerType.Delete(response);
            await _unitOfWork.Complete();

            return new CustomerTypeReadDto(response.CustomerTypeId, response.CustomerTypes!);
        }
        catch (Exception ex)
        {
            return new CustomerTypeReadDto(StatusCodes.Status500InternalServerError, ex.Message);
        }
        
    }

    public async Task<IEnumerable<CustomerTypeReadDto>> GetCustomerTypeAsync()
    {
        var response = await _unitOfWork.CustomerType.GetAll();
        return _mapper.Map<IEnumerable<CustomerTypeReadDto>>(response);
    }

    public async Task<CustomerTypeReadDto> GetCustomerTypeAsync(int value)
    {
        var response = await _unitOfWork.CustomerType.Get(value);
        return _mapper.Map<CustomerTypeReadDto>(response);
    }

    public async Task<CustomerTypeReadDto> GetCustomerTypeAsync(string value)
    {
        var response = await _unitOfWork.CustomerType.Get(ct => ct.CustomerTypes == value);
        return _mapper.Map<CustomerTypeReadDto>(response);
    }

    public async Task<CustomerTypeReadDto> UpdateCustomerTypeAsync(CustomerTypeUpdateDto values)
    {
        try
        {
            var result = await _unitOfWork.CustomerType.Get(ct => ct.CustomerTypeId == values.customerTypeId);
            if (result is null)
            {
                return new CustomerTypeReadDto(StatusCodes.Status404NotFound, "0 row(s) found.");
            }

            CustomerType customerType = new(values.customerTypeId, values.customerTypes!)
            {
                ModifiedBy = values.modifiedBy,
                ModifiedOn = DateTime.Now
            };

            _unitOfWork.CustomerType.Update(customerType);
            await _unitOfWork.Complete();

            return new CustomerTypeReadDto(customerType.CustomerTypeId, customerType.CustomerTypes!);

        }
        catch (Exception ex)
        {
            return new CustomerTypeReadDto(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }


}

