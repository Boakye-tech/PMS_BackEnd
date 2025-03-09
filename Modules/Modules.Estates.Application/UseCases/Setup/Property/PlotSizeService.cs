namespace Modules.Estates.Application.UseCases.Setup.Property;

public class PlotSizeService : IPlotSizeService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public PlotSizeService(IUnitOfWork unitOfWork, IMapper mapper)
	{
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<PlotSizeReadDto> AddPlotSizeAsync(PlotSizeCreateDto values)
    {
        PlotSize plotSize = new(values.PlotSizeId, values.PlotSizes!)
        {
            CreatedBy = values.CreatedBy,
            CreatedOn = DateTime.Now
        };

        _unitOfWork.PlotSize.Insert(plotSize);
        await _unitOfWork.Complete();

        return new PlotSizeReadDto(plotSize.PlotSizeId, plotSize.PlotSizes!);
    }

    public async Task<IEnumerable<PlotSizeReadDto>> GetPlotSizeAsync()
    {
        var plotSize = await _unitOfWork.PlotSize.GetAll();
        return _mapper.Map<IEnumerable<PlotSizeReadDto>>(plotSize);
    }

    public async Task<PlotSizeReadDto> GetPlotSizeAsync(int value)
    {
        var plotSize = await _unitOfWork.PlotSize.Get(value);
        return _mapper.Map<PlotSizeReadDto>(plotSize);
    }

    public async Task<PlotSizeReadDto> GetPlotSizeAsync(string value)
    {
        var plotSize = await _unitOfWork.PlotSize.Get(p => p.PlotSizes == value);
        return _mapper.Map<PlotSizeReadDto>(plotSize);
    }

    public async Task<PlotSizeReadDto> UpdatePlotSizeAsync(PlotSizeUpdateDto values)
    {
        PlotSize plotSize = new(values.PlotSizeId, values.PlotSizes!)
        {
            ModifiedBy = values.ModifiedBy,
            ModifiedOn = DateTime.Now
        };

        _unitOfWork.PlotSize.Update(plotSize);
        await _unitOfWork.Complete();

        return new PlotSizeReadDto(plotSize.PlotSizeId, plotSize.PlotSizes!);
    }
}

