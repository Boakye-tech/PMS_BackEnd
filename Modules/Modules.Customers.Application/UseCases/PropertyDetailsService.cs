using System;
using System.Net;
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
            PropertyDetails property = PropertyDetails.AddPropertyDetails(values.PropertyMasterId, values.PropertyNumber, values.PropertyType, values.LandUse, values.LandUseType, values.Locality, values.AllocationType,
                                                                          values.BlockNumber!, values.PlotNumber, values.AcreageOne, values.AcreageTwo, values.PropertyHeight!, values.PlotSize!,values.SellingPrice,values.Currency,
                                                                          values.CustomerCode!, values.PropertyImages![0].ImageOne!, values.PropertyImages[0].ImageTwo!, values.PropertyImages[0].ImageThree!, values.PropertyImages[0].ImageFour!,
                                                                          values.PropertyImages[0].ImageFive!,false);

            _unitOfWork.PropertyDetails.Insert(property);
            await _unitOfWork.Complete();

            return new GenericResponseDto { response = "200" };
        }

        public async Task<IEnumerable<AvailablePropertySummaryViewDto>> AvailablePropertiesSummary()
        {
            var propertyDetails = await _unitOfWork.PropertyDetails.GetAll(pd => pd.CustomerCode == string.Empty);
            var summary = propertyDetails.Select(pd => new AvailablePropertySummaryViewDto
            {
                PropertyNumber = pd.PropertyNumber,
                LandUse = pd.LandUse,
                Address = $"{pd.Locality} - BLOCK {pd.BlockNumber}, PLOT NUMBER {pd.PlotNumber}",
                Image = pd.ImageOne,
                Currency = pd.Currency,
                SellingPrice = pd.SellingPrice
            }).ToList();


            return summary;
        }

        public Task<GenericResponseDto> DeletePropertyDetails(string value)
        {
            throw new NotImplementedException();
        }

        public async Task<PropertyDetailsReadDto> GetPropertyDetails(string propertyNumber)
        {
            
            var propertydetails = await _unitOfWork.PropertyDetails.Get(pd => pd.PropertyNumber == propertyNumber);
            //PropertyImages[] images = new PropertyImages { ImageOne = propertydetails!.ImageOne!, ImageTwo = propertydetails.ImageTwo!, ImageThree = propertydetails.ImageThree!, ImageFour = propertydetails.ImageFour!, ImageFive = propertydetails.ImageFive! };
            string[] images = new string[] { propertydetails!.ImageOne!, propertydetails.ImageTwo!, propertydetails.ImageThree!, propertydetails.ImageFour!, propertydetails.ImageFive! };
            PropertyDetailsReadDto propertyDetails = _mapper.Map<PropertyDetailsReadDto>(propertydetails);
            propertyDetails.PropertyImages = images;
            propertyDetails.Address = $"{propertyDetails.Locality} - BLOCK {propertyDetails.BlockNumber}, PLOT NUMBER {propertyDetails.PlotNumber}";

            return propertyDetails; 

        }

        public  async Task<IEnumerable<PropertySummaryMobileViewDto>> GetPropertySummaryMobile(string customerCode)
        {
            var summary = (await _unitOfWork.CustomerTransaction.GetAll(ct => ct.CustomerCode == customerCode))
                      .Join(await _unitOfWork.PropertyDetails.GetAll(pd => pd.CustomerCode == customerCode),
                                transaction => transaction.PropertyNumber,
                                property => property.PropertyNumber,
                                (transaction, property) => new PropertySummaryMobileViewDto
                                {
                                    PropertyNumber = transaction.PropertyNumber,
                                    LandUse = property.LandUse,
                                    Balance = transaction.Amount,
                                    Image = property.ImageOne
                                })
                            .GroupBy(t => new { t.PropertyNumber, t.LandUse, t.Image })
                            .Select(g => new PropertySummaryMobileViewDto
                            {
                                PropertyNumber = g.Key.PropertyNumber,
                                LandUse = g.Key.LandUse,
                                Balance = g.Sum(t => t.Balance),
                                Image = g.Key.Image
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
                Address = pd.Locality,
                Image = pd.ImageOne
            }).ToList();

            
            return summary;

        }

        public Task<GenericResponseDto> UpdatePropertyDetails(PropertyDetailsDto values)
        {
            throw new NotImplementedException();
        }
    }
}

