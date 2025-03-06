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
        CustomerType customerType = new(values.customerTypeId, values.customerTypes!)
        {
            CreatedBy = values.createdBy,
            CreatedOn = DateTime.Now
        };

        _unitOfWork.CustomerType.Insert(customerType);
        await _unitOfWork.Complete();

        return new CustomerTypeReadDto(customerType.CustomerTypeId, customerType.CustomerTypes!);
    }

    public async Task<string> DeleteCustomerTyeAsync(int value)
    {
        var response = await _unitOfWork.CustomerType.Get(value);

        if (response is null)
        {
            return "BadRequest";
        }

        _unitOfWork.CustomerType.Delete(response);
        await _unitOfWork.Complete();

        return "success";
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
        CustomerType customerType = new(values.customerTypeId, values.customerTypes!)
        {
            ModifiedBy = values.modifiedBy,
            ModifiedOn = DateTime.Now
        };

        _unitOfWork.CustomerType.Update(customerType);
        await _unitOfWork.Complete();

        return new CustomerTypeReadDto(customerType.CustomerTypeId, customerType.CustomerTypes!);
    }
}

