namespace Modules.Estates.Application.Repositories.Setup.Customer;

public class GenderService : IGenderService
{
	public GenderService()
	{
	}

    public Task<GenderReadDto> AddGenderAsync(GenderCreateDto values)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<GenderReadDto>> GetGenderAsync()
    {
        throw new NotImplementedException();
    }

    public Task<GenderReadDto> GetGenderAsync(int value)
    {
        throw new NotImplementedException();
    }

    public Task<GenderReadDto> GetGenderAsync(string value)
    {
        throw new NotImplementedException();
    }

    public Task<GenderReadDto> UpdateGenderAsync(GenderUpdateDto values)
    {
        throw new NotImplementedException();
    }
}

