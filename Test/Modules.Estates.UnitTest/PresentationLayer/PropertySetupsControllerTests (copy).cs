// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/PresentationLayer/PropertySetupsControllerTests.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 14/05/2025 2:30 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Modules.Estates.Application.DTO.Setup;
using Modules.Estates.Application.DTO.Setup.Property;
using Modules.Estates.Application.Interfaces.Entities.Setup.Property;
using Modules.Estates.Application.Interfaces.Management.Property;
using Modules.Estates.Domain.Exceptions; // For SuccessResponseDto, ErrorResponseDto
using Modules.Estates.Presentation.Controllers.v1;
using Xunit;
using Modules.Estates.Application.Interfaces.Entities.Setup;

namespace Modules.Estates.UnitTest.PresentationLayer
{
	public class PropertySetupsControllerTests
	{
		private readonly Mock<IAllocationTypeService> _allocationTypeServiceMock;
		private readonly Mock<IApartmentTypeService> _apartmentTypeServiceMock;
		private readonly Mock<IBlockNumberService> _blockNumberServiceMock;
		private readonly Mock<IBlockSideService> _blockSideServiceMock;
		private readonly Mock<IBlockTypeService> _blockTypeServiceMock;
		private readonly Mock<IBlockUnitService> _blockUnitServiceMock;
		private readonly Mock<IFloorAreaService> _facilitiesServiceMock;
		private readonly Mock<IFloorNumberingService> _floorNumberingServiceMock;
		private readonly Mock<ILandUseService> _landUseServiceMock;
		private readonly Mock<ILandUseTypeService> _landUseTypeServiceMock;
		private readonly Mock<ILocalityService> _localityServiceMock;
		private readonly Mock<IPlotDimensionService> _plotDimensionServiceMock;
		private readonly Mock<IPropertyHeightService> _propertyHeightServiceMock;
		private readonly Mock<IPropertyTypeService> _propertyTypeServiceMock;
		private readonly Mock<IActivityService> _activityServiceMock;
		private readonly Mock<IActivityTypeService> _activityTypeServiceMock;
		private readonly Mock<IPropertyMasterService> _propertyMasterServiceMock;

		private readonly Mock<ILeaseTypeAndPeriodService> _leaseTypeAndPeriodServiceMock;
        private readonly Mock<IPropertyStatusService> _propertyStatusServiceMock;
		private readonly Mock<IShopOfficeTypeAndDescriptionService> _shopOfficeTypeAndDescriptionServiceMock;

        private readonly Mock<IFeaturesService> _featuresService;
        private readonly Mock<IApartmentFeaturesService> _apartmentFeaturesService;
        private readonly Mock<ICurrencyExchangeRateService> _currencyExchangeRateService;



        private readonly PropertyController _controller;

		public PropertySetupsControllerTests()
		{
			_allocationTypeServiceMock = new Mock<IAllocationTypeService>();
			_apartmentTypeServiceMock = new Mock<IApartmentTypeService>();
			_blockNumberServiceMock = new Mock<IBlockNumberService>();
			_blockSideServiceMock = new Mock<IBlockSideService>();
			_blockTypeServiceMock = new Mock<IBlockTypeService>();
			_blockUnitServiceMock = new Mock<IBlockUnitService>();
			_facilitiesServiceMock = new Mock<IFloorAreaService>();
			_floorNumberingServiceMock = new Mock<IFloorNumberingService>();
			_landUseServiceMock = new Mock<ILandUseService>();
			_landUseTypeServiceMock = new Mock<ILandUseTypeService>();
			_localityServiceMock = new Mock<ILocalityService>();
			_plotDimensionServiceMock = new Mock<IPlotDimensionService>();
			_propertyHeightServiceMock = new Mock<IPropertyHeightService>();
			_propertyTypeServiceMock = new Mock<IPropertyTypeService>();
			_activityServiceMock = new Mock<IActivityService>();
			_activityTypeServiceMock = new Mock<IActivityTypeService>();
			_propertyMasterServiceMock = new Mock<IPropertyMasterService>();

			_leaseTypeAndPeriodServiceMock = new Mock<ILeaseTypeAndPeriodService>();
			_propertyStatusServiceMock = new Mock<IPropertyStatusService>();
			_shopOfficeTypeAndDescriptionServiceMock = new Mock<IShopOfficeTypeAndDescriptionService>();

             _featuresService = new Mock<IFeaturesService>();
			_apartmentFeaturesService = new Mock<IApartmentFeaturesService>();
			_currencyExchangeRateService = new Mock<ICurrencyExchangeRateService>();



        _controller = new PropertyController(
				_allocationTypeServiceMock.Object,
				_landUseServiceMock.Object,
				_landUseTypeServiceMock.Object,
				_localityServiceMock.Object,
				_plotDimensionServiceMock.Object,
				_apartmentTypeServiceMock.Object,
				_facilitiesServiceMock.Object,
				_floorNumberingServiceMock.Object,
				_propertyTypeServiceMock.Object,
				_propertyHeightServiceMock.Object,
				_blockNumberServiceMock.Object,
				_blockSideServiceMock.Object,
				_blockTypeServiceMock.Object,
				_blockUnitServiceMock.Object,
                _currencyExchangeRateService.Object,
                _activityServiceMock.Object,
				_activityTypeServiceMock.Object,
				_propertyMasterServiceMock.Object,
                _featuresService.Object,
                _apartmentFeaturesService.Object,
                _leaseTypeAndPeriodServiceMock.Object,
				_propertyStatusServiceMock.Object,
				_shopOfficeTypeAndDescriptionServiceMock.Object
				
			);
		}

		// --- AllocationType Tests ---

		[Fact]
		public async Task GetAllocationType_ShouldReturnOkResult_WithListOfAllocationTypes()
		{
			// Arrange
			var allocationTypes = new List<AllocationTypeReadDto> { new AllocationTypeReadDto(1, "TC", "Test Council") };
			_allocationTypeServiceMock.Setup(s => s.GetAllocationTypeAsync()).ReturnsAsync(allocationTypes);

			// Act
			var result = await _controller.GetAllocationType();

			// Assert
			var okResult = Assert.IsType<OkObjectResult>(result.Result);
			Assert.Equal(allocationTypes, okResult.Value);
		}

		[Fact]
		public async Task GetAllocationType_ByString_ShouldReturnOkResult_WithAllocationType()
		{
			// Arrange
			var allocationTypeDto = new AllocationTypeReadDto(1, "TC", "Test Council");
			string typeName = "Test Council";
			_allocationTypeServiceMock.Setup(s => s.GetAllocationTypeAsync(typeName)).ReturnsAsync(allocationTypeDto);

			// Act
			var result = await _controller.GetAllocationType(typeName);

			// Assert
			var okResult = Assert.IsType<OkObjectResult>(result.Result);
			Assert.Equal(allocationTypeDto, okResult.Value);
		}

		[Fact]
		public async Task GetAllocationTypeById_ShouldReturnOkResult_WithAllocationType()
		{
			// Arrange
			var allocationTypeDto = new AllocationTypeReadDto(1, "TC", "Test Council");
			int typeId = 1;
			_allocationTypeServiceMock.Setup(s => s.GetAllocationTypeAsync(typeId)).ReturnsAsync(allocationTypeDto);

			// Act
			var result = await _controller.GetAllocationTypeById(typeId);

			// Assert
			var okResult = Assert.IsType<OkObjectResult>(result.Result);
			Assert.Equal(allocationTypeDto, okResult.Value);
		}

		[Fact]
		public async Task CreateAllocationType_WithValidDto_ShouldReturnCreatedAtActionResult()
		{
			// Arrange
			var createDto = new AllocationTypeCreateDto("TC", "Test Council", "user1");
			var readDto = new AllocationTypeReadDto(1, "TC", "Test Council");
			var successResponse = new SuccessResponseDto { Data = readDto, Message = "Created", Code = StatusCodes.Status201Created };
			var serviceResponse = new ReturnResponsesDto { IsSuccess = true, SuccessResponse = successResponse, ErrorResponse = null };
			_allocationTypeServiceMock.Setup(s => s.CreateAllocationTypeAsync(createDto)).ReturnsAsync(serviceResponse);

			// Act
			var result = await _controller.CreateAllocationType(createDto);

			// Assert
			var objectResult = Assert.IsType<ObjectResult>(result);
			Assert.Equal(StatusCodes.Status201Created, objectResult.StatusCode);
			Assert.Equal(successResponse, objectResult.Value);
		}

		[Fact]
		public async Task CreateAllocationType_ServiceReturnsError_ShouldReturnBadRequest()
		{
			// Arrange
			var createDto = new AllocationTypeCreateDto("TC", "Test Council", "user1");
			var errorResponse = new ErrorResponseDto { Message = "Exists", Code = StatusCodes.Status400BadRequest };
			var serviceResponse = new ReturnResponsesDto { IsSuccess = false, ErrorResponse = errorResponse, SuccessResponse = null };
			_allocationTypeServiceMock.Setup(s => s.CreateAllocationTypeAsync(createDto)).ReturnsAsync(serviceResponse);

			// Act
			var result = await _controller.CreateAllocationType(createDto);

			// Assert
			var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
			Assert.Equal(errorResponse, badRequestResult.Value);
		}

		[Fact]
		public async Task CreateAllocationType_ServiceThrowsException_ShouldReturnInternalServerError()
		{
			// Arrange
			var createDto = new AllocationTypeCreateDto("TC", "Test Council", "user1");
			_allocationTypeServiceMock.Setup(s => s.CreateAllocationTypeAsync(createDto)).ThrowsAsync(new Exception("Database error"));

			// Act
			var result = await _controller.CreateAllocationType(createDto);

			// Assert
			var objectResult = Assert.IsType<ObjectResult>(result);
			Assert.Equal(StatusCodes.Status500InternalServerError, objectResult.StatusCode);
			Assert.Equal("Database error", objectResult.Value); // Controller catches ex.InnerException.Message, direct throw here for simplicity
		}


		[Fact]
		public async Task UpdateAllocationType_WithValidDto_ShouldReturnOkResult()
		{
			// Arrange
			var updateDto = new AllocationTypeUpdateDto(1, "TC_U", "Test Council Updated", "user2");
			var readDto = new AllocationTypeReadDto(1, "TC_U", "Test Council Updated");
			var successResponse = new SuccessResponseDto { Data = readDto, Message = "Updated", Code = StatusCodes.Status200OK };
			var serviceResponse = new ReturnResponsesDto { IsSuccess = true, SuccessResponse = successResponse, ErrorResponse = null };
			_allocationTypeServiceMock.Setup(s => s.UpdateAllocationTypeAsync(updateDto)).ReturnsAsync(serviceResponse);

			// Act
			var result = await _controller.UpdateAllocationType(updateDto);

			// Assert
			var okResult = Assert.IsType<OkObjectResult>(result.Result);
			Assert.Equal(successResponse, okResult.Value);
		}

		[Fact]
		public async Task UpdateAllocationType_ServiceReturnsNotFound_ShouldReturnNotFoundResult()
		{
			// Arrange
			var updateDto = new AllocationTypeUpdateDto(99, "NTC", "Non Existent Council", "user2");
			var errorResponse = new ErrorResponseDto { Message = "Not Found", Code = StatusCodes.Status404NotFound };
			var serviceResponse = new ReturnResponsesDto { IsSuccess = false, ErrorResponse = errorResponse, SuccessResponse = null };
			_allocationTypeServiceMock.Setup(s => s.UpdateAllocationTypeAsync(updateDto)).ReturnsAsync(serviceResponse);

			// Act
			var result = await _controller.UpdateAllocationType(updateDto);

			// Assert
			var notFoundResult = Assert.IsType<NotFoundObjectResult>(result.Result);
			Assert.Equal(errorResponse, notFoundResult.Value);
		}

		[Fact]
		public async Task DeleteAllocationType_WithValidId_ShouldReturnOkResult()
		{
			// Arrange
			int typeId = 1;
			var successResponse = new SuccessResponseDto { Message = "Deleted successfully", Code = StatusCodes.Status200OK }; // Data might be null or a specific message string for delete
			var serviceResponse = new ReturnResponsesDto { IsSuccess = true, SuccessResponse = successResponse, ErrorResponse = null };
			_allocationTypeServiceMock.Setup(s => s.DeleteAllocationType(typeId)).ReturnsAsync(serviceResponse);

			// Act
			var result = await _controller.DeleteAllocationType(typeId);

			// Assert
			var okResult = Assert.IsType<OkObjectResult>(result);
			Assert.Equal(successResponse, okResult.Value);
		}

		[Fact]
		public async Task DeleteAllocationType_ServiceReturnsNotFound_ShouldReturnNotFoundResult()
		{
			// Arrange
			int typeId = 99;
			var errorResponse = new ErrorResponseDto { Message = "Not Found", Code = StatusCodes.Status404NotFound };
			var serviceResponse = new ReturnResponsesDto { IsSuccess = false, ErrorResponse = errorResponse, SuccessResponse = null };
			_allocationTypeServiceMock.Setup(s => s.DeleteAllocationType(typeId)).ReturnsAsync(serviceResponse);

			// Act
			var result = await _controller.DeleteAllocationType(typeId);

			// Assert
			var notFoundResult = Assert.IsType<NotFoundObjectResult>(result);
			Assert.Equal(errorResponse, notFoundResult.Value);
		}

		[Fact]
		public async Task DeleteAllocationType_ServiceThrowsException_ShouldReturnInternalServerError()
		{
			// Arrange
			int typeId = 1;
			_allocationTypeServiceMock.Setup(s => s.DeleteAllocationType(typeId)).ThrowsAsync(new Exception("Database error"));

			// Act
			var result = await _controller.DeleteAllocationType(typeId);

			// Assert
			var objectResult = Assert.IsType<ObjectResult>(result);
			Assert.Equal(StatusCodes.Status500InternalServerError, objectResult.StatusCode);
			Assert.Equal("Database error", objectResult.Value);
		}

		// --- Locality Tests ---

		[Fact]
		public async Task GetLocality_ShouldReturnOkResult_WithListOfLocalities()
		{
			// Arrange
			var localities = new List<LocalityReadDto> { new LocalityReadDto(1, "ACC", "Airport Residential", "CUS001", 1) };
			_localityServiceMock.Setup(s => s.GetLocalityAsync()).ReturnsAsync(localities);

			// Act
			var result = await _controller.GeLocality(); // Assuming GeLocality is a typo for GetLocality

			// Assert
			var okResult = Assert.IsType<OkObjectResult>(result.Result);
			Assert.Equal(localities, okResult.Value);
		}

		[Fact]
		public async Task GetLocality_ByString_ShouldReturnOkResult_WithLocality()
		{
			// Arrange
			var localityDto = new LocalityReadDto(1, "ACC", "Airport Residential", "CUS001", 1);
			string localityName = "Airport Residential";
			_localityServiceMock.Setup(s => s.GetLocalityAsync(localityName)).ReturnsAsync(localityDto);

			// Act
			var result = await _controller.GetLocality(localityName);

			// Assert
			var okResult = Assert.IsType<OkObjectResult>(result.Result);
			Assert.Equal(localityDto, okResult.Value);
		}

		[Fact]
		public async Task GetLocalityById_ShouldReturnOkResult_WithLocality()
		{
			// Arrange
			var localityDto = new LocalityReadDto(1, "ACC", "Airport Residential", "CUS001", 1);
			int localityId = 1;
			_localityServiceMock.Setup(s => s.GetLocalityAsync(localityId)).ReturnsAsync(localityDto);

			// Act
			var result = await _controller.GetLocalityById(localityId);

			// Assert
			var okResult = Assert.IsType<OkObjectResult>(result.Result);
			Assert.Equal(localityDto, okResult.Value);
		}

		[Fact]
		public async Task CreateLocality_WithValidDto_ShouldReturnCreatedAtActionResult()
		{
			// Arrange
			var createDto = new LocalityCreateDto("CAN", "Cantonments", "CUS002", 1, "user1");
			var readDto = new LocalityReadDto(2, "CAN", "Cantonments", "CUS002", 1);
			var successResponse = new SuccessResponseDto { Data = readDto, Message = "Locality created successfully.", Code = StatusCodes.Status201Created };
			var serviceResponse = new ReturnResponsesDto { IsSuccess = true, SuccessResponse = successResponse, ErrorResponse = null };
			_localityServiceMock.Setup(s => s.CreateLocalityAsync(createDto)).ReturnsAsync(serviceResponse);

			// Act
			var result = await _controller.CreateLocality(createDto);

			// Assert
			var objectResult = Assert.IsType<ObjectResult>(result);
			Assert.Equal(StatusCodes.Status201Created, objectResult.StatusCode);
			Assert.Equal(successResponse, objectResult.Value);
		}

		[Fact]
		public async Task CreateLocality_ServiceReturnsError_ShouldReturnBadRequest()
		{
			// Arrange
			var createDto = new LocalityCreateDto("ACC", "Airport Residential", "CUS001", 1, "user1");
			var errorResponse = new ErrorResponseDto { Message = "Locality already exists.", Code = StatusCodes.Status400BadRequest };
			var serviceResponse = new ReturnResponsesDto { IsSuccess = false, ErrorResponse = errorResponse, SuccessResponse = null };
			_localityServiceMock.Setup(s => s.CreateLocalityAsync(createDto)).ReturnsAsync(serviceResponse);

			// Act
			var result = await _controller.CreateLocality(createDto);

			// Assert
			var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
			Assert.Equal(errorResponse, badRequestResult.Value);
		}

		[Fact]
		public async Task CreateLocality_ServiceThrowsException_ShouldReturnInternalServerError()
		{
			// Arrange
			var createDto = new LocalityCreateDto("LAB", "Labone", "CUS003", 1, "user1");
			_localityServiceMock.Setup(s => s.CreateLocalityAsync(createDto)).ThrowsAsync(new Exception("Database error"));

			// Act
			var result = await _controller.CreateLocality(createDto);

			// Assert
			var objectResult = Assert.IsType<ObjectResult>(result);
			Assert.Equal(StatusCodes.Status500InternalServerError, objectResult.StatusCode);
			Assert.Equal("Database error", objectResult.Value);
		}

		[Fact]
		public async Task UpdateLocality_WithValidDto_ShouldReturnOkResult()
		{
			// Arrange
			var updateDto = new LocalityUpdateDto(1, "ARU", "Airport Residential Updated", "CUS001U", 2, "user2");
			var readDto = new LocalityReadDto(1, "ARU", "Airport Residential Updated", "CUS001U", 2);
			var successResponse = new SuccessResponseDto { Data = readDto, Message = "Locality details modified successfully.", Code = StatusCodes.Status200OK };
			var serviceResponse = new ReturnResponsesDto { IsSuccess = true, SuccessResponse = successResponse, ErrorResponse = null };
			_localityServiceMock.Setup(s => s.UpdateLocalityAsync(updateDto)).ReturnsAsync(serviceResponse);

			// Act
			var result = await _controller.UpdateLocality(updateDto);

			// Assert
			var okResult = Assert.IsType<OkObjectResult>(result.Result);
			Assert.Equal(successResponse, okResult.Value);
		}

		[Fact]
		public async Task UpdateLocality_ServiceReturnsNotFound_ShouldReturnNotFoundResult()
		{
			// Arrange
			var updateDto = new LocalityUpdateDto(99, "NEX", "NonExistent", "CUS999", 1, "user2");
			var errorResponse = new ErrorResponseDto { Message = "Locality not found.", Code = StatusCodes.Status404NotFound };
			var serviceResponse = new ReturnResponsesDto { IsSuccess = false, ErrorResponse = errorResponse, SuccessResponse = null };
			_localityServiceMock.Setup(s => s.UpdateLocalityAsync(updateDto)).ReturnsAsync(serviceResponse);

			// Act
			var result = await _controller.UpdateLocality(updateDto);

			// Assert
			var notFoundResult = Assert.IsType<NotFoundObjectResult>(result.Result);
			Assert.Equal(errorResponse, notFoundResult.Value);
		}

		[Fact]
		public async Task DeleteLocality_WithValidId_ShouldReturnOkResult()
		{
			// Arrange
			int localityId = 1;
			var successResponse = new SuccessResponseDto { Message = "Locality deleted successfully.", Code = StatusCodes.Status200OK };
			var serviceResponse = new ReturnResponsesDto { IsSuccess = true, SuccessResponse = successResponse, ErrorResponse = null };
			_localityServiceMock.Setup(s => s.DeleteLocality(localityId)).ReturnsAsync(serviceResponse);

			// Act
			var result = await _controller.DeleteLocality(localityId);

			// Assert
			var okResult = Assert.IsType<OkObjectResult>(result);
			Assert.Equal(successResponse, okResult.Value);
		}

		[Fact]
		public async Task DeleteLocality_ServiceReturnsNotFound_ShouldReturnNotFoundResult()
		{
			// Arrange
			int localityId = 99;
			var errorResponse = new ErrorResponseDto { Message = "Locality not found.", Code = StatusCodes.Status404NotFound };
			var serviceResponse = new ReturnResponsesDto { IsSuccess = false, ErrorResponse = errorResponse, SuccessResponse = null };
			_localityServiceMock.Setup(s => s.DeleteLocality(localityId)).ReturnsAsync(serviceResponse);

			// Act
			var result = await _controller.DeleteLocality(localityId);

			// Assert
			var notFoundResult = Assert.IsType<NotFoundObjectResult>(result);
			Assert.Equal(errorResponse, notFoundResult.Value);
		}

		[Fact]
		public async Task DeleteLocality_ServiceThrowsException_ShouldReturnInternalServerError()
		{
			// Arrange
			int localityId = 1;
			_localityServiceMock.Setup(s => s.DeleteLocality(localityId)).ThrowsAsync(new Exception("Database error"));

			// Act
			var result = await _controller.DeleteLocality(localityId);

			// Assert
			var objectResult = Assert.IsType<ObjectResult>(result);
			Assert.Equal(StatusCodes.Status500InternalServerError, objectResult.StatusCode);
			Assert.Equal("Database error", objectResult.Value);
		}

		// --- PlotDimension Tests ---

		[Fact]
		public async Task GetPlotDimension_ShouldReturnOkResult_WithListOfPlotDimensions()
		{
			// Arrange
			var plotDimensions = new List<PlotDimensionReadDto> { new PlotDimensionReadDto(1, "50x100") };
			_plotDimensionServiceMock.Setup(s => s.GetPlotDimensionAsync()).ReturnsAsync(plotDimensions);

			// Act
			var result = await _controller.GetPlotDimension();

			// Assert
			var okResult = Assert.IsType<OkObjectResult>(result.Result);
			Assert.Equal(plotDimensions, okResult.Value);
		}

		[Fact]
		public async Task GetPlotDimension_ByString_ShouldReturnOkResult_WithPlotDimension()
		{
			// Arrange
			var plotDimensionDto = new PlotDimensionReadDto(1, "50x100");
			string plotDimensionValue = "50x100";
			_plotDimensionServiceMock.Setup(s => s.GetPlotDimensionAsync(plotDimensionValue)).ReturnsAsync(plotDimensionDto);

			// Act
			var result = await _controller.GetPlotDimension(plotDimensionValue);

			// Assert
			var okResult = Assert.IsType<OkObjectResult>(result.Result);
			Assert.Equal(plotDimensionDto, okResult.Value);
		}

		[Fact]
		public async Task GetPlotDimensionById_ShouldReturnOkResult_WithPlotDimension()
		{
			// Arrange
			var plotDimensionDto = new PlotDimensionReadDto(1, "50x100");
			int plotDimensionId = 1;
			_plotDimensionServiceMock.Setup(s => s.GetPlotDimensionAsync(plotDimensionId)).ReturnsAsync(plotDimensionDto);

			// Act
			var result = await _controller.GetPlotDimensionById(plotDimensionId);

			// Assert
			var okResult = Assert.IsType<OkObjectResult>(result.Result);
			Assert.Equal(plotDimensionDto, okResult.Value);
		}

		[Fact]
		public async Task CreatePlotDimension_WithValidDto_ShouldReturnCreatedAtActionResult()
		{
			// Arrange
			var createDto = new PlotDimensionCreateDto("70x100", "user1");
			var readDto = new PlotDimensionReadDto(2, "70x100");
			var successResponse = new SuccessResponseDto { Data = readDto, Message = "PlotDimension created successfully.", Code = StatusCodes.Status201Created };
			var serviceResponse = new ReturnResponsesDto { IsSuccess = true, SuccessResponse = successResponse, ErrorResponse = null };
			_plotDimensionServiceMock.Setup(s => s.CreatePlotDimensionAsync(createDto)).ReturnsAsync(serviceResponse);

			// Act
			var result = await _controller.CreatePlotDimension(createDto);

			// Assert
			var objectResult = Assert.IsType<ObjectResult>(result);
			Assert.Equal(StatusCodes.Status201Created, objectResult.StatusCode);
			Assert.Equal(successResponse, objectResult.Value);
		}

		[Fact]
		public async Task CreatePlotDimension_ServiceReturnsError_ShouldReturnBadRequest()
		{
			// Arrange
			var createDto = new PlotDimensionCreateDto("50x100", "user1"); // Assuming "50x100" already exists
			var errorResponse = new ErrorResponseDto { Message = "PlotDimension already exists.", Code = StatusCodes.Status400BadRequest };
			var serviceResponse = new ReturnResponsesDto { IsSuccess = false, ErrorResponse = errorResponse, SuccessResponse = null };
			_plotDimensionServiceMock.Setup(s => s.CreatePlotDimensionAsync(createDto)).ReturnsAsync(serviceResponse);

			// Act
			var result = await _controller.CreatePlotDimension(createDto);

			// Assert
			var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
			Assert.Equal(errorResponse, badRequestResult.Value);
		}

		[Fact]
		public async Task CreatePlotDimension_ServiceThrowsException_ShouldReturnInternalServerError()
		{
			// Arrange
			var createDto = new PlotDimensionCreateDto("100x100", "user1");
			_plotDimensionServiceMock.Setup(s => s.CreatePlotDimensionAsync(createDto)).ThrowsAsync(new Exception("Database error"));

			// Act
			var result = await _controller.CreatePlotDimension(createDto);

			// Assert
			var objectResult = Assert.IsType<ObjectResult>(result);
			Assert.Equal(StatusCodes.Status500InternalServerError, objectResult.StatusCode);
			Assert.Equal("Database error", objectResult.Value);
		}

		[Fact]
		public async Task UpdatePlotDimension_WithValidDto_ShouldReturnOkResult()
		{
			// Arrange
			var updateDto = new PlotDimensionUpdateDto(1, "50x120", "user2");
			var readDto = new PlotDimensionReadDto(1, "50x120");
			var successResponse = new SuccessResponseDto { Data = readDto, Message = "PlotDimension details modified successfully.", Code = StatusCodes.Status200OK };
			var serviceResponse = new ReturnResponsesDto { IsSuccess = true, SuccessResponse = successResponse, ErrorResponse = null };
			_plotDimensionServiceMock.Setup(s => s.UpdatePlotDimensionAsync(updateDto)).ReturnsAsync(serviceResponse);

			// Act
			var result = await _controller.UpdatePlotDimension(updateDto);

			// Assert
			var okResult = Assert.IsType<OkObjectResult>(result.Result);
			Assert.Equal(successResponse, okResult.Value);
		}

		[Fact]
		public async Task UpdatePlotDimension_ServiceReturnsNotFound_ShouldReturnNotFoundResult()
		{
			// Arrange
			var updateDto = new PlotDimensionUpdateDto(99, "NonExistent", "user2");
			var errorResponse = new ErrorResponseDto { Message = "PlotDimension not found.", Code = StatusCodes.Status404NotFound };
			var serviceResponse = new ReturnResponsesDto { IsSuccess = false, ErrorResponse = errorResponse, SuccessResponse = null };
			_plotDimensionServiceMock.Setup(s => s.UpdatePlotDimensionAsync(updateDto)).ReturnsAsync(serviceResponse);

			// Act
			var result = await _controller.UpdatePlotDimension(updateDto);

			// Assert
			var notFoundResult = Assert.IsType<NotFoundObjectResult>(result.Result);
			Assert.Equal(errorResponse, notFoundResult.Value);
		}

		[Fact]
		public async Task DeletePlotDimension_WithValidId_ShouldReturnOkResult()
		{
			// Arrange
			int plotDimensionId = 1;
			var successResponse = new SuccessResponseDto { Message = "PlotDimension deleted successfully.", Code = StatusCodes.Status200OK };
			var serviceResponse = new ReturnResponsesDto { IsSuccess = true, SuccessResponse = successResponse, ErrorResponse = null };
			_plotDimensionServiceMock.Setup(s => s.DeletePlotDimension(plotDimensionId)).ReturnsAsync(serviceResponse);

			// Act
			var result = await _controller.DeletePlotDimension(plotDimensionId);

			// Assert
			var okResult = Assert.IsType<OkObjectResult>(result);
			Assert.Equal(successResponse, okResult.Value);
		}

		[Fact]
		public async Task DeletePlotDimension_ServiceReturnsNotFound_ShouldReturnNotFoundResult()
		{
			// Arrange
			int plotDimensionId = 99;
			var errorResponse = new ErrorResponseDto { Message = "PlotDimension not found.", Code = StatusCodes.Status404NotFound };
			var serviceResponse = new ReturnResponsesDto { IsSuccess = false, ErrorResponse = errorResponse, SuccessResponse = null };
			_plotDimensionServiceMock.Setup(s => s.DeletePlotDimension(plotDimensionId)).ReturnsAsync(serviceResponse);

			// Act
			var result = await _controller.DeletePlotDimension(plotDimensionId);

			// Assert
			var notFoundResult = Assert.IsType<NotFoundObjectResult>(result);
			Assert.Equal(errorResponse, notFoundResult.Value);
		}

		[Fact]
		public async Task DeletePlotDimension_ServiceThrowsException_ShouldReturnInternalServerError()
		{
			// Arrange
			int plotDimensionId = 1;
			_plotDimensionServiceMock.Setup(s => s.DeletePlotDimension(plotDimensionId)).ThrowsAsync(new Exception("Database error"));

			// Act
			var result = await _controller.DeletePlotDimension(plotDimensionId);

			// Assert
			var objectResult = Assert.IsType<ObjectResult>(result);
			Assert.Equal(StatusCodes.Status500InternalServerError, objectResult.StatusCode);
			Assert.Equal("Database error", objectResult.Value);
		}

		// --- PropertyHeight Tests ---

		[Fact]
		public async Task GetPropertyHeight_ShouldReturnOkResult_WithListOfPropertyHeights()
		{
			// Arrange
			var propertyHeights = new List<PropertyHeightReadDto> { new PropertyHeightReadDto(1, "High-rise") };
			_propertyHeightServiceMock.Setup(s => s.GetPropertyHeightAsync()).ReturnsAsync(propertyHeights);

			// Act
			var result = await _controller.GetPropertyHeight();

			// Assert
			var okResult = Assert.IsType<OkObjectResult>(result.Result);
			Assert.Equal(propertyHeights, okResult.Value);
		}

		[Fact]
		public async Task CreatePropertyHeight_WithValidDto_ShouldReturnCreatedAtActionResult()
		{
			// Arrange
			var createDto = new PropertyHeightCreateDto("Mid-rise", "user1");
			var readDto = new PropertyHeightReadDto(2, "Mid-rise");
			var successResponse = new SuccessResponseDto { Data = readDto, Message = "PropertyHeight created successfully.", Code = StatusCodes.Status201Created };
			var serviceResponse = new ReturnResponsesDto { IsSuccess = true, SuccessResponse = successResponse, ErrorResponse = null };
			_propertyHeightServiceMock.Setup(s => s.CreatePropertyHeightAsync(createDto)).ReturnsAsync(serviceResponse);

			// Act
			var result = await _controller.CreatePropertyHeight(createDto);

			// Assert
			var objectResult = Assert.IsType<ObjectResult>(result);
			Assert.Equal(StatusCodes.Status201Created, objectResult.StatusCode);
			Assert.Equal(successResponse, objectResult.Value);
		}

		[Fact]
		public async Task CreatePropertyHeight_ServiceReturnsError_ShouldReturnBadRequest()
		{
			// Arrange
			var createDto = new PropertyHeightCreateDto("High-rise", "user1"); // Assuming "High-rise" already exists
			var errorResponse = new ErrorResponseDto { Message = "PropertyHeight already exists.", Code = StatusCodes.Status400BadRequest };
			var serviceResponse = new ReturnResponsesDto { IsSuccess = false, ErrorResponse = errorResponse, SuccessResponse = null };
			_propertyHeightServiceMock.Setup(s => s.CreatePropertyHeightAsync(createDto)).ReturnsAsync(serviceResponse);

			// Act
			var result = await _controller.CreatePropertyHeight(createDto);

			// Assert
			var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
			Assert.Equal(errorResponse, badRequestResult.Value);
		}

		[Fact]
		public async Task CreatePropertyHeight_ServiceThrowsException_ShouldReturnInternalServerError()
		{
			// Arrange
			var createDto = new PropertyHeightCreateDto("Low-rise", "user1");
			_propertyHeightServiceMock.Setup(s => s.CreatePropertyHeightAsync(createDto)).ThrowsAsync(new Exception("Database error"));

			// Act
			var result = await _controller.CreatePropertyHeight(createDto);

			// Assert
			var objectResult = Assert.IsType<ObjectResult>(result);
			Assert.Equal(StatusCodes.Status500InternalServerError, objectResult.StatusCode);
			Assert.Equal("Database error", objectResult.Value);
		}

		[Fact]
		public async Task UpdatePropertyHeight_WithValidDto_ShouldReturnOkResult()
		{
			// Arrange
			var updateDto = new PropertyHeightUpdateDto(1, "High-rise Updated", "user2");
			var readDto = new PropertyHeightReadDto(1, "High-rise Updated");
			var successResponse = new SuccessResponseDto { Data = readDto, Message = "PropertyHeight details modified successfully.", Code = StatusCodes.Status200OK };
			var serviceResponse = new ReturnResponsesDto { IsSuccess = true, SuccessResponse = successResponse, ErrorResponse = null };
			_propertyHeightServiceMock.Setup(s => s.UpdatePropertyHeightAsync(updateDto)).ReturnsAsync(serviceResponse);

			// Act
			var result = await _controller.UpdatePropertyHeight(updateDto);

			// Assert
			var okResult = Assert.IsType<OkObjectResult>(result.Result);
			Assert.Equal(successResponse, okResult.Value);
		}

		[Fact]
		public async Task UpdatePropertyHeight_ServiceReturnsNotFound_ShouldReturnNotFoundResult()
		{
			// Arrange
			var updateDto = new PropertyHeightUpdateDto(99, "NonExistent", "user2");
			var errorResponse = new ErrorResponseDto { Message = "PropertyHeight not found.", Code = StatusCodes.Status404NotFound };
			var serviceResponse = new ReturnResponsesDto { IsSuccess = false, ErrorResponse = errorResponse, SuccessResponse = null };
			_propertyHeightServiceMock.Setup(s => s.UpdatePropertyHeightAsync(updateDto)).ReturnsAsync(serviceResponse);

			// Act
			var result = await _controller.UpdatePropertyHeight(updateDto);

			// Assert
			var notFoundResult = Assert.IsType<NotFoundObjectResult>(result.Result);
			Assert.Equal(errorResponse, notFoundResult.Value);
		}

		[Fact]
		public async Task DeletePropertyHeight_WithValidId_ShouldReturnOkResult()
		{
			// Arrange
			int propertyHeightId = 1;
			var successResponse = new SuccessResponseDto { Message = "PropertyHeight deleted successfully.", Code = StatusCodes.Status200OK };
			var serviceResponse = new ReturnResponsesDto { IsSuccess = true, SuccessResponse = successResponse, ErrorResponse = null };
			_propertyHeightServiceMock.Setup(s => s.DeletePropertyHeight(propertyHeightId)).ReturnsAsync(serviceResponse);

			// Act
			var result = await _controller.DeletePropertyHeight(propertyHeightId);

			// Assert
			var okResult = Assert.IsType<OkObjectResult>(result);
			Assert.Equal(successResponse, okResult.Value);
		}

		[Fact]
		public async Task DeletePropertyHeight_ServiceReturnsNotFound_ShouldReturnNotFoundResult()
		{
			// Arrange
			int propertyHeightId = 99;
			var errorResponse = new ErrorResponseDto { Message = "PropertyHeight not found.", Code = StatusCodes.Status404NotFound };
			var serviceResponse = new ReturnResponsesDto { IsSuccess = false, ErrorResponse = errorResponse, SuccessResponse = null };
			_propertyHeightServiceMock.Setup(s => s.DeletePropertyHeight(propertyHeightId)).ReturnsAsync(serviceResponse);

			// Act
			var result = await _controller.DeletePropertyHeight(propertyHeightId);

			// Assert
			var notFoundResult = Assert.IsType<NotFoundObjectResult>(result);
			Assert.Equal(errorResponse, notFoundResult.Value);
		}

		[Fact]
		public async Task DeletePropertyHeight_ServiceThrowsException_ShouldReturnInternalServerError()
		{
			// Arrange
			int propertyHeightId = 1;
			_propertyHeightServiceMock.Setup(s => s.DeletePropertyHeight(propertyHeightId)).ThrowsAsync(new Exception("Database error"));

			// Act
			var result = await _controller.DeletePropertyHeight(propertyHeightId);

			// Assert
			var objectResult = Assert.IsType<ObjectResult>(result);
			Assert.Equal(StatusCodes.Status500InternalServerError, objectResult.StatusCode);
			Assert.Equal("Database error", objectResult.Value);
		}
	}
}

*/