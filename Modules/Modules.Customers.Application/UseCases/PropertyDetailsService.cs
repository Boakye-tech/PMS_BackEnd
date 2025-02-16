using System;
using Microsoft.EntityFrameworkCore;

namespace Modules.Customers.Application.UseCases
{
	public class PropertyDetailsService : IPropertyDetailsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;



        public PropertyDetailsService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<GenericResponseDto> AddNewPropertyDetails(PropertyDetailsDto values)
        {
            //throw new NotImplementedException();

            PropertyDetails property = PropertyDetails.AddPropertyDetails(values.PropertyMasterId, values.PropertyNumber, values.PropertyType, values.LandUse, values.LandUseType, values.Locality, values.AllocationType,
                                                                          values.BlockNumber!, values.PlotNumber, values.AcreageOne, values.AcreageTwo, values.PropertyHeight!, values.PlotSize!,values.SellingPrice,values.Currency,
                                                                          values.CustomerCode!, false);

            _unitOfWork.PropertyDetails.Insert(property);
            await _unitOfWork.Complete();

            return new GenericResponseDto { response = "200" };
        }

        public Task<GenericResponseDto> DeletePropertyDetails(string value)
        {
            throw new NotImplementedException();
        }

        public async Task<PropertyDetailsReadDto> GetPropertyDetails(string propertyNumber)
        {
            
            var propertydetails = await _unitOfWork.PropertyDetails.Get(pd => pd.PropertyNumber == propertyNumber);
            return _mapper.Map<PropertyDetailsReadDto>(propertydetails);

        }

        public  async Task<IEnumerable<PropertySummaryMobileViewDto>> GetPropertySummaryMobile(string customerCode)
        {
            //var propertyDetails = await _unitOfWork.PropertyDetails.GetAll(pd => pd.CustomerCode == customerCode);
            //var summary = propertyDetails.Select(pd => new PropertySummaryMobileViewDto
            //{
            //    PropertyNumber = pd.PropertyNumber,
            //    LandUse = pd.LandUse
            //}).ToList();


            //return summary;

            var summary = (await _unitOfWork.CustomerTransaction.GetAll(ct => ct.CustomerCode == customerCode))
                      .Join(await _unitOfWork.PropertyDetails.GetAll(pd => pd.CustomerCode == customerCode),
                                transaction => transaction.PropertyNumber,
                                property => property.PropertyNumber,
                                (transaction, property) => new PropertySummaryMobileViewDto
                                {
                                    PropertyNumber = transaction.PropertyNumber,
                                    LandUse = property.LandUse,
                                    Balance = transaction.Amount
                                })
                            .GroupBy(t => new { t.PropertyNumber, t.LandUse })
                            .Select(g => new PropertySummaryMobileViewDto
                            {
                                PropertyNumber = g.Key.PropertyNumber,
                                LandUse = g.Key.LandUse,
                                Balance = g.Sum(t => t.Balance)
                            })
                            .ToList();

            return summary;

        }

        public async Task<IEnumerable<PropertySummaryWebViewDto>> GetPropertySummaryWeb(string customerCode)
        {
            var propertyDetails = await _unitOfWork.PropertyDetails.GetAll(pd => pd.CustomerCode == customerCode);
            var summary = propertyDetails.Select(pd => new PropertySummaryWebViewDto
            {
                PropertyNumber = pd.PropertyNumber,
                LandUse = pd.LandUse,
                Address = pd.Locality
            }).ToList();

            
            return summary;

        }

        public Task<GenericResponseDto> UpdatePropertyDetails(PropertyDetailsDto values)
        {
            throw new NotImplementedException();
        }
    }
}

