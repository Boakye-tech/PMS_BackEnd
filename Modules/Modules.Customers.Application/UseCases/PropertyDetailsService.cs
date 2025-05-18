// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


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
                                    Address = property.Locality,
                                    LandUse = property.LandUse,
                                    Balance = transaction.Amount,
                                    Image = property.ImageOne
                                })
                            .GroupBy(t => new { t.PropertyNumber, t.LandUse, t.Image, t.Address })
                            .Select(g => new PropertySummaryMobileViewDto
                            {
                                PropertyNumber = g.Key.PropertyNumber,
                                Address = g.Key.Address,
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

        public async Task<List<PropertySearchDto>> GetCustomerPropertySearch(string customerCode_OR_propertyNumber)
        {
            var result = from a in await _unitOfWork.PropertyDetails.GetAll(c => c.CustomerCode!.Contains(customerCode_OR_propertyNumber) || c.PropertyNumber!.Contains(customerCode_OR_propertyNumber))
                         select new PropertySearchDto
                         {
                             CustomerCode = a.CustomerCode,
                             PropertyNumber = a.PropertyNumber
                         };

            return result.ToList();
        }


        public async Task<PaginatedResultDto<PropertySearchDto>> GetCustomerPropertySearch(string customerCode_OR_propertyNumber, int pageNumber, int pageSize)
        {
            var query = from p in await _unitOfWork.PropertyDetails.GetAll()
                        join c in await _unitOfWork.CustomerDetails.GetAll()
                        on p.CustomerCode equals c.CustomerCode into customerGroup
                        from customer in customerGroup.DefaultIfEmpty()
                        where p.CustomerCode!.Contains(customerCode_OR_propertyNumber) || p.PropertyNumber.Contains(customerCode_OR_propertyNumber)
                        select new PropertySearchDto
                        {
                            CustomerCode = p.CustomerCode,
                            CustomerName = customer?.CustomerName ?? string.Empty,
                            PropertyNumber = p.PropertyNumber
                        };

            var totalRecords = query.Count();
            var list = query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return new PaginatedResultDto<PropertySearchDto>
            {
                SearchList = list,
                TotalRecords = totalRecords,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }


        public Task<GenericResponseDto> UpdatePropertyDetails(PropertyDetailsDto values)
        {
            throw new NotImplementedException();
        }
    }
}

