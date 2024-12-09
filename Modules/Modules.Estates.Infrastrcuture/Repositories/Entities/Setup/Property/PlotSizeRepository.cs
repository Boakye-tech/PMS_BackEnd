using System;
namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Property
{
	public class PlotSizeRepository : Repository<PlotSize>, IPlotSizeRepository
	{
		public PlotSizeRepository(ApplicationDbContext dbContext): base(dbContext)
		{
		}
	}
}

