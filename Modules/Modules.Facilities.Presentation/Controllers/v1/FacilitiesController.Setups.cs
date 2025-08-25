// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Presentation/Controllers/v1/FacilitiesController.Setups.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 12:00 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Facilities.Presentation.Controllers.v1
{
    /// <summary>
    /// Controller for managing facilities setup operations
    /// </summary>
    public partial class FacilitiesController
    {
        // CATEGORY ENDPOINTS
        /// <summary>
        /// Gets all categories
        /// </summary>
        /// <remarks>
        /// **Sample Response 200:**
        ///
        ///     [
        ///         {
        ///             "categoryId": 1,
        ///             "categoryName": "Cleaning Supplies"
        ///         }
        ///     ]
        ///
        /// </remarks>
        [HttpGet("GetCategories")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CategoryReadDto>))]
        public async Task<ActionResult<IEnumerable<CategoryReadDto>>> GetCategories([FromServices] ICategoryService _categoryService)
        {
            return Ok(await _categoryService.GetCategoryAsync());
        }

        /// <summary>
        /// Creates a new category
        /// </summary>
        /// <remarks>
        /// **Sample Request:**
        ///
        ///     POST /CreateCategory
        ///
        /// **Sample Request Body:**
        ///
        ///     {
        ///         "categoryName": "Cleaning Supplies",
        ///         "createdBy": "user-guid"
        ///     }
        ///
        /// **Sample Response 201:**
        ///
        ///     {
        ///         "statusCode": 201,
        ///         "statusMessage": "Category created successfully."
        ///     }
        /// </remarks>
        [HttpPost("CreateCategory")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateCategory([FromBody] CategoryCreateDto values, [FromServices] ICategoryService _categoryService)
        {
            var result = await _categoryService.CreateCategoryAsync(values);
            if (result.IsSuccess)
                return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
            return BadRequest(result.ErrorResponse);
        }

        /// <summary>
        /// Updates a category
        /// </summary>
        /// <remarks>
        /// **Sample Request:**
        ///
        ///     PUT /UpdateCategory
        ///
        /// **Sample Request Body:**
        ///
        ///     {
        ///         "categoryId": 1,
        ///         "categoryName": "Updated Name",
        ///         "modifiedBy": "user-guid"
        ///     }
        ///
        /// **Sample Response 200:**
        ///
        ///     {
        ///         "statusCode": 200,
        ///         "statusMessage": "Category updated successfully."
        ///     }
        /// </remarks>
        [HttpPut("UpdateCategory")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> UpdateCategory([FromBody] CategoryUpdateDto values, [FromServices] ICategoryService _categoryService)
        {
            var result = await _categoryService.UpdateCategoryAsync(values);
            if (result.IsSuccess)
                return Ok(result.SuccessResponse);
            return NotFound(result.ErrorResponse);
        }

        /// <summary>
        /// Deletes a category by ID
        /// </summary>
        /// <param name="categoryId">The ID of the category to delete</param>
        /// <returns>Success or error response</returns>
        /// <remarks>
        /// **Sample Response 200:**
        ///
        ///     {
        ///         "statusCode": 200,
        ///         "statusMessage": "Category with ID 1 deleted successfully."
        ///     }
        /// </remarks>
        [HttpDelete("DeleteCategory/{categoryId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> DeleteCategory(int categoryId, [FromServices] ICategoryService _categoryService)
        {
            var result = await _categoryService.DeleteCategoryAsync(categoryId);
            if (result.IsSuccess)
                return Ok(result.SuccessResponse);
            return NotFound(result.ErrorResponse);
        }

        // CLEANERS ENDPOINTS
        /// <summary>
        /// Gets all cleaners
        /// </summary>
        /// <remarks>
        /// **Sample Response 200:**
        ///
        ///     [
        ///         {
        ///             "staffID": 1,
        ///             "name": "John Doe",
        ///             "phone": "1234567890"
        ///         }
        ///     ]
        ///
        /// </remarks>
        [HttpGet("GetCleaners")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CleanersReadDto>))]
        public async Task<ActionResult<IEnumerable<CleanersReadDto>>> GetCleaners([FromServices] ICleanersService _cleanersService)
        {
            return Ok(await _cleanersService.GetCleanersAsync());
        }

        /// <summary>
        /// Creates a new cleaner
        /// </summary>
        /// <remarks>
        /// **Sample Request:**
        ///
        ///     POST /CreateCleaner
        ///
        /// **Sample Request Body:**
        ///
        ///     {
        ///         "staffID": "CLN001",
        ///         "profilePhoto": "base64string",
        ///         "firstName": "John",
        ///         "middleName": "A.",
        ///         "lastName": "Doe",
        ///         "phoneNumber": "1234567890",
        ///         "emailAddress": "john.doe@example.com",
        ///         "jobTitle": "Janitor",
        ///         "employmentStatus": "Active",
        ///         "hireDate": "2024-01-01T00:00:00Z",
        ///         "assignedProperties": "Property1,Property2",
        ///         "images": "base64string",
        ///         "createdBy": "user-guid"
        ///     }
        ///
        /// **Sample Response 201:**
        ///
        ///     {
        ///         "statusCode": 201,
        ///         "statusMessage": "Cleaner created successfully."
        ///     }
        /// </remarks>
        [HttpPost("CreateCleaner")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateCleaner([FromBody] CleanersCreateDto values, [FromServices] ICleanersService _cleanersService)
        {
            var result = await _cleanersService.CreateCleanersAsync(values);
            if (result.IsSuccess)
                return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
            return BadRequest(result.ErrorResponse);
        }

        /// <summary>
        /// Updates a cleaner
        /// </summary>
        /// <remarks>
        /// **Sample Request:**
        ///
        ///     PUT /UpdateCleaner
        ///
        /// **Sample Request Body:**
        ///
        ///     {
        ///         "staffID": "CLN001",
        ///         "profilePhoto": "base64string",
        ///         "firstName": "Jane",
        ///         "middleName": "B.",
        ///         "lastName": "Smith",
        ///         "phoneNumber": "0987654321",
        ///         "emailAddress": "jane.smith@example.com",
        ///         "jobTitle": "Supervisor",
        ///         "employmentStatus": "Inactive",
        ///         "hireDate": "2024-02-01T00:00:00Z",
        ///         "assignedProperties": "Property3",
        ///         "images": "base64string",
        ///         "modifiedBy": "user-guid"
        ///     }
        ///
        /// **Sample Response 200:**
        ///
        ///     {
        ///         "statusCode": 200,
        ///         "statusMessage": "Cleaner updated successfully."
        ///     }
        /// </remarks>
        [HttpPut("UpdateCleaner")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> UpdateCleaner([FromBody] CleanersUpdateDto values, [FromServices] ICleanersService _cleanersService)
        {
            var result = await _cleanersService.UpdateCleanersAsync(values);
            if (result.IsSuccess)
                return Ok(result.SuccessResponse);
            return NotFound(result.ErrorResponse);
        }

        /// <summary>
        /// Deletes a cleaner by staff ID
        /// </summary>
        /// <param name="staffID">The ID of the cleaner to delete</param>
        /// <returns>Success or error response</returns>
        /// <remarks>
        /// **Sample Response 200:**
        ///
        ///     {
        ///         "statusCode": 200,
        ///         "statusMessage": "Cleaner with ID 1 deleted successfully."
        ///     }
        /// </remarks>
        [HttpDelete("DeleteCleaner/{staffID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> DeleteCleaner(int staffID, [FromServices] ICleanersService _cleanersService)
        {
            var result = await _cleanersService.DeleteCleanersAsync(staffID);
            if (result.IsSuccess)
                return Ok(result.SuccessResponse);
            return NotFound(result.ErrorResponse);
        }

        // ITEMS ENDPOINTS
        /// <summary>
        /// Gets all items
        /// </summary>
        /// <remarks>
        /// **Sample Response 200:**
        ///
        ///     [
        ///         {
        ///             "itemCode": "ITM001",
        ///             "itemName": "Mop",
        ///             "itemCategoryId": 1
        ///         }
        ///     ]
        ///
        /// </remarks>
        [HttpGet("GetItems")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ItemsReadDto>))]
        public async Task<ActionResult> GetItems([FromServices] IItemsService _itemsService)
        {
            return Ok(await _itemsService.GetItemsAsync());
        }

        /// <summary>
        /// Creates a new item
        /// </summary>
        /// <remarks>
        /// **Sample Request:**
        ///
        ///     POST /CreateItem
        ///
        /// **Sample Request Body:**
        ///
        ///     {
        ///         "itemCode": "ITM001",
        ///         "itemName": "Mop",
        ///         "itemCategoryId": 1,
        ///         "createdBy": "user-guid"
        ///     }
        ///
        /// **Sample Response 201:**
        ///
        ///     {
        ///         "statusCode": 201,
        ///         "statusMessage": "Item created successfully."
        ///     }
        /// </remarks>
        [HttpPost("CreateItem")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateItem([FromBody] ItemsCreateDto values, [FromServices] IItemsService _itemsService)
        {
            var result = await _itemsService.CreateItemsAsync(values);
            if (result.IsSuccess)
                return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
            return BadRequest(result.ErrorResponse);
        }

        /// <summary>
        /// Updates an item
        /// </summary>
        /// <remarks>
        /// **Sample Request:**
        ///
        ///     PUT /UpdateItem
        ///
        /// **Sample Request Body:**
        ///
        ///     {
        ///         "itemCode": "ITM001",
        ///         "itemName": "Updated Mop",
        ///         "itemCategoryId": 1,
        ///         "modifiedBy": "user-guid"
        ///     }
        ///
        /// **Sample Response 200:**
        ///
        ///     {
        ///         "statusCode": 200,
        ///         "statusMessage": "Item updated successfully."
        ///     }
        /// </remarks>
        [HttpPut("UpdateItem")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> UpdateItem([FromBody] ItemsUpdateDto values, [FromServices] IItemsService _itemsService)
        {
            var result = await _itemsService.UpdateItemsAsync(values);
            if (result.IsSuccess)
                return Ok(result.SuccessResponse);
            return NotFound(result.ErrorResponse);
        }

        /// <summary>
        /// Deletes an item by item code
        /// </summary>
        /// <param name="itemCode">The code of the item to delete</param>
        /// <returns>Success or error response</returns>
        /// <remarks>
        /// **Sample Response 200:**
        ///
        ///     {
        ///         "statusCode": 200,
        ///         "statusMessage": "Item with code ITM001 deleted successfully."
        ///     }
        /// </remarks>
        [HttpDelete("DeleteItem/{itemCode}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> DeleteItem(string itemCode, [FromServices] IItemsService _itemsService)
        {
            var result = await _itemsService.DeleteItemsAsync(itemCode);
            if (result.IsSuccess)
                return Ok(result.SuccessResponse);
            return NotFound(result.ErrorResponse);
        }

        // ITEMS CATEGORY ENDPOINTS
        /// <summary>
        /// Gets all item categories
        /// </summary>
        /// <remarks>
        /// **Sample Response 200:**
        ///
        ///     [
        ///         {
        ///             "itemCategoryId": 1,
        ///             "itemCategoryName": "Cleaning Tools"
        ///         }
        ///     ]
        ///
        /// </remarks>
        [HttpGet("GetItemsCategories")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ItemsCategoryReadDto>))]
        public async Task<ActionResult<IEnumerable<ItemsCategoryReadDto>>> GetItemsCategories([FromServices] IItemsCategoryService _itemsCategoryService)
        {
            return Ok(await _itemsCategoryService.GetItemsCategoryAsync());
        }

        [HttpGet("GetItemCategoryAndItems")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ItemCategoryAndItemsReadDto>))]
        public async Task<ActionResult<IEnumerable<ItemCategoryAndItemsReadDto>>> GetItemCategoryAndItems([FromServices] IItemsCategoryService _itemsCategoryService)
        {
            return Ok(await _itemsCategoryService.GetItemCategoryAndItemsAsync());
        }

        /// <summary>
        /// Creates a new item category
        /// </summary>
        /// <remarks>
        /// **Sample Request:**
        ///
        ///     POST /CreateItemsCategory
        ///
        /// **Sample Request Body:**
        ///
        ///     {
        ///         "itemCategoryName": "Cleaning Tools",
        ///         "createdBy": "user-guid"
        ///     }
        ///
        /// **Sample Response 201:**
        ///
        ///     {
        ///         "statusCode": 201,
        ///         "statusMessage": "Item category created successfully."
        ///     }
        /// </remarks>
        [HttpPost("CreateItemsCategory")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateItemsCategory([FromBody] ItemsCategoryCreateDto values, [FromServices] IItemsCategoryService _itemsCategoryService)
        {
            var result = await _itemsCategoryService.CreateItemsCategoryAsync(values);
            if (result.IsSuccess)
                return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
            return BadRequest(result.ErrorResponse);
        }

        /// <summary>
        /// Updates an item category
        /// </summary>
        /// <remarks>
        /// **Sample Request:**
        ///
        ///     PUT /UpdateItemsCategory
        ///
        /// **Sample Request Body:**
        ///
        ///     {
        ///         "itemCategoryId": 1,
        ///         "itemCategoryName": "Updated Tools",
        ///         "modifiedBy": "user-guid"
        ///     }
        ///
        /// **Sample Response 200:**
        ///
        ///     {
        ///         "statusCode": 200,
        ///         "statusMessage": "Item category updated successfully."
        ///     }
        /// </remarks>
        [HttpPut("UpdateItemsCategory")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> UpdateItemsCategory([FromBody] ItemsCategoryUpdateDto values, [FromServices] IItemsCategoryService _itemsCategoryService)
        {
            var result = await _itemsCategoryService.UpdateItemsCategoryAsync(values);
            if (result.IsSuccess)
                return Ok(result.SuccessResponse);
            return NotFound(result.ErrorResponse);
        }

        /// <summary>
        /// Deletes an item category by ID
        /// </summary>
        /// <param name="itemCategoryId">The ID of the item category to delete</param>
        /// <returns>Success or error response</returns>
        /// <remarks>
        /// **Sample Response 200:**
        ///
        ///     {
        ///         "statusCode": 200,
        ///         "statusMessage": "Item category with ID 1 deleted successfully."
        ///     }
        /// </remarks>
        [HttpDelete("DeleteItemsCategory/{itemCategoryId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> DeleteItemsCategory(int itemCategoryId, [FromServices] IItemsCategoryService _itemsCategoryService)
        {
            var result = await _itemsCategoryService.DeleteItemsCategoryAsync(itemCategoryId);
            if (result.IsSuccess)
                return Ok(result.SuccessResponse);
            return NotFound(result.ErrorResponse);
        }

        // SERVICE CATEGORY ENDPOINTS
        /// <summary>
        /// Gets all service categories
        /// </summary>
        /// <remarks>
        /// **Sample Response 200:**
        ///
        ///     [
        ///         {
        ///             "serviceCategoryId": 1,
        ///             "serviceCategoryName": "Repairs"
        ///         }
        ///     ]
        ///
        /// </remarks>
        [HttpGet("GetServiceCategories")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ServiceCategoryReadDto>))]
        public async Task<ActionResult<IEnumerable<ServiceCategoryReadDto>>> GetServiceCategories([FromServices] IServiceCategoryService _serviceCategoryService)
        {
            return Ok(await _serviceCategoryService.GetServiceCategoryAsync());
        }

        /// <summary>
        /// Creates a new service category
        /// </summary>
        /// <remarks>
        /// **Sample Request:**
        ///
        ///     POST /CreateServiceCategory
        ///
        /// **Sample Request Body:**
        ///
        ///     {
        ///         "serviceCategoryName": "Repairs",
        ///         "createdBy": "user-guid"
        ///     }
        ///
        /// **Sample Response 201:**
        ///
        ///     {
        ///         "statusCode": 201,
        ///         "statusMessage": "Service category created successfully."
        ///     }
        /// </remarks>
        [HttpPost("CreateServiceCategory")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateServiceCategory([FromBody] ServiceCategoryCreateDto values, [FromServices] IServiceCategoryService _serviceCategoryService)
        {
            var result = await _serviceCategoryService.CreateServiceCategoryAsync(values);
            if (result.IsSuccess)
                return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
            return BadRequest(result.ErrorResponse);
        }

        /// <summary>
        /// Updates a service category
        /// </summary>
        /// <remarks>
        /// **Sample Request:**
        ///
        ///     PUT /UpdateServiceCategory
        ///
        /// **Sample Request Body:**
        ///
        ///     {
        ///         "serviceCategoryId": 1,
        ///         "serviceCategoryName": "Updated Repairs",
        ///         "modifiedBy": "user-guid"
        ///     }
        ///
        /// **Sample Response 200:**
        ///
        ///     {
        ///         "statusCode": 200,
        ///         "statusMessage": "Service category updated successfully."
        ///     }
        /// </remarks>
        [HttpPut("UpdateServiceCategory")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> UpdateServiceCategory([FromBody] ServiceCategoryUpdateDto values, [FromServices] IServiceCategoryService _serviceCategoryService)
        {
            var result = await _serviceCategoryService.UpdateServiceCategoryAsync(values);
            if (result.IsSuccess)
                return Ok(result.SuccessResponse);
            return NotFound(result.ErrorResponse);
        }

        /// <summary>
        /// Deletes a service category by ID
        /// </summary>
        /// <param name="serviceCategoryId">The ID of the service category to delete</param>
        /// <returns>Success or error response</returns>
        /// <remarks>
        /// **Sample Response 200:**
        ///
        ///     {
        ///         "statusCode": 200,
        ///         "statusMessage": "Service category with ID 1 deleted successfully."
        ///     }
        /// </remarks>
        [HttpDelete("DeleteServiceCategory/{serviceCategoryId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> DeleteServiceCategory(int serviceCategoryId, [FromServices] IServiceCategoryService _serviceCategoryService)
        {
            var result = await _serviceCategoryService.DeleteServiceCategoryAsync(serviceCategoryId);
            if (result.IsSuccess)
                return Ok(result.SuccessResponse);
            return NotFound(result.ErrorResponse);
        }

        // SERVICES ENDPOINTS
        /// <summary>
        /// Gets all services
        /// </summary>
        /// <remarks>
        /// **Sample Response 200:**
        ///
        ///     [
        ///         {
        ///             "serviceId": 1,
        ///             "serviceName": "Plumbing"
        ///         }
        ///     ]
        ///
        /// </remarks>
        [HttpGet("GetServices")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ServicesReadDto>))]
        public async Task<ActionResult<IEnumerable<ServicesReadDto>>> GetServices([FromServices] IServicesService _servicesService)
        {
            return Ok(await _servicesService.GetServicesAsync());
        }

        /// <summary>
        /// Creates a new service
        /// </summary>
        /// <remarks>
        /// **Sample Request:**
        ///
        ///     POST /CreateService
        ///
        /// **Sample Request Body:**
        ///
        ///     {
        ///         "serviceName": "Plumbing",
        ///         "createdBy": "user-guid"
        ///     }
        ///
        /// **Sample Response 201:**
        ///
        ///     {
        ///         "statusCode": 201,
        ///         "statusMessage": "Service created successfully."
        ///     }
        /// </remarks>
        [HttpPost("CreateService")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateService([FromBody] ServicesCreateDto values, [FromServices] IServicesService _servicesService)
        {
            var result = await _servicesService.CreateServicesAsync(values);
            if (result.IsSuccess)
                return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
            return BadRequest(result.ErrorResponse);
        }

        /// <summary>
        /// Updates a service
        /// </summary>
        /// <remarks>
        /// **Sample Request:**
        ///
        ///     PUT /UpdateService
        ///
        /// **Sample Request Body:**
        ///
        ///     {
        ///         "serviceId": 1,
        ///         "serviceName": "Updated Plumbing",
        ///         "modifiedBy": "user-guid"
        ///     }
        ///
        /// **Sample Response 200:**
        ///
        ///     {
        ///         "statusCode": 200,
        ///         "statusMessage": "Service updated successfully."
        ///     }
        /// </remarks>
        [HttpPut("UpdateService")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> UpdateService([FromBody] ServicesUpdateDto values, [FromServices] IServicesService _servicesService)
        {
            var result = await _servicesService.UpdateServicesAsync(values);
            if (result.IsSuccess)
                return Ok(result.SuccessResponse);
            return NotFound(result.ErrorResponse);
        }

        /// <summary>
        /// Deletes a service by ID
        /// </summary>
        /// <param name="serviceId">The ID of the service to delete</param>
        /// <returns>Success or error response</returns>
        /// <remarks>
        /// **Sample Response 200:**
        ///
        ///     {
        ///         "statusCode": 200,
        ///         "statusMessage": "Service with ID 1 deleted successfully."
        ///     }
        /// </remarks>
        [HttpDelete("DeleteService/{serviceId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> DeleteService(int serviceId, [FromServices] IServicesService _servicesService)
        {
            var result = await _servicesService.DeleteServicesAsync(serviceId);
            if (result.IsSuccess)
                return Ok(result.SuccessResponse);
            return NotFound(result.ErrorResponse);
        }

        // SERVICE PROVIDERS ENDPOINTS
        /// <summary>
        /// Gets all service providers
        /// </summary>
        /// <remarks>
        /// **Sample Response 200:**
        ///
        ///     [
        ///         {
        ///             "companyID": 1,
        ///             "companyName": "CleanCo",
        ///             "phoneNumber": "1234567890",
        ///             "emailAddress": "info@cleanco.com",
        ///             "companyRegistrationNumber": "REG123",
        ///             "tinNumber": "TIN456",
        ///             "companyAddress": "123 Main St",
        ///             "digitalAddress": "GA-123-4567",
        ///             "images": "base64string",
        ///             "listOfServices": "Cleaning,Maintenance",
        ///             "contactPerson_FirstName": "Alice",
        ///             "contactPerson_MiddleName": "B.",
        ///             "contactPerson_LastName": "Smith",
        ///             "contactPerson_JobTitle": "Manager",
        ///             "contactPerson_PhoneNumber": "0987654321",
        ///             "contactPerson_EmailAddress": "alice.smith@cleanco.com"
        ///         }
        ///     ]
        ///
        /// </remarks>
        [HttpGet("GetServiceProviders")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ServiceProvidersReadDto>))]
        public async Task<ActionResult<IEnumerable<ServiceProvidersReadDto>>> GetServiceProviders([FromServices] IServiceProvidersService _serviceProvidersService)
        {
            return Ok(await _serviceProvidersService.GetServiceProvidersAsync());
        }

        /// <summary>
        /// Creates a new service provider
        /// </summary>
        /// <remarks>
        /// **Sample Request:**
        ///
        ///     POST /CreateServiceProvider
        ///
        /// **Sample Request Body:**
        ///
        ///     {
        ///         "companyName": "CleanCo",
        ///         "phoneNumber": "1234567890",
        ///         "emailAddress": "info@cleanco.com",
        ///         "companyRegistrationNumber": "REG123",
        ///         "tinNumber": "TIN456",
        ///         "companyAddress": "123 Main St",
        ///         "digitalAddress": "GA-123-4567",
        ///         "images": "base64string",
        ///         "listOfServices": "Cleaning,Maintenance",
        ///         "contactPerson_FirstName": "Alice",
        ///         "contactPerson_MiddleName": "B.",
        ///         "contactPerson_LastName": "Smith",
        ///         "contactPerson_JobTitle": "Manager",
        ///         "contactPerson_PhoneNumber": "0987654321",
        ///         "contactPerson_EmailAddress": "alice.smith@cleanco.com",
        ///         "createdBy": "user-guid"
        ///     }
        ///
        /// **Sample Response 201:**
        ///
        ///     {
        ///         "statusCode": 201,
        ///         "statusMessage": "Service provider created successfully."
        ///     }
        /// </remarks>
        [HttpPost("CreateServiceProvider")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateServiceProvider([FromBody] ServiceProvidersCreateDto values, [FromServices] IServiceProvidersService _serviceProvidersService)
        {
            var result = await _serviceProvidersService.CreateServiceProvidersAsync(values);
            if (result.IsSuccess)
                return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
            return BadRequest(result.ErrorResponse);
        }

        /// <summary>
        /// Updates a service provider
        /// </summary>
        /// <remarks>
        /// **Sample Request:**
        ///
        ///     PUT /UpdateServiceProvider
        ///
        /// **Sample Request Body:**
        ///
        ///     {
        ///         "companyID": 1,
        ///         "companyName": "CleanCo",
        ///         "phoneNumber": "1234567890",
        ///         "emailAddress": "info@cleanco.com",
        ///         "companyRegistrationNumber": "REG123",
        ///         "tinNumber": "TIN456",
        ///         "companyAddress": "123 Main St",
        ///         "digitalAddress": "GA-123-4567",
        ///         "images": "base64string",
        ///         "listOfServices": "Cleaning,Maintenance",
        ///         "contactPerson_FirstName": "Alice",
        ///         "contactPerson_MiddleName": "B.",
        ///         "contactPerson_LastName": "Smith",
        ///         "contactPerson_JobTitle": "Manager",
        ///         "contactPerson_PhoneNumber": "0987654321",
        ///         "contactPerson_EmailAddress": "alice.smith@cleanco.com",
        ///         "modifiedBy": "user-guid"
        ///     }
        ///
        /// **Sample Response 200:**
        ///
        ///     {
        ///         "statusCode": 200,
        ///         "statusMessage": "Service provider updated successfully."
        ///     }
        /// </remarks>
        [HttpPut("UpdateServiceProvider")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> UpdateServiceProvider([FromBody] ServiceProvidersUpdateDto values, [FromServices] IServiceProvidersService _serviceProvidersService)
        {
            var result = await _serviceProvidersService.UpdateServiceProvidersAsync(values);
            if (result.IsSuccess)
                return Ok(result.SuccessResponse);
            return NotFound(result.ErrorResponse);
        }

        /// <summary>
        /// Deletes a service provider by company ID
        /// </summary>
        /// <param name="companyID">The ID of the service provider to delete</param>
        /// <returns>Success or error response</returns>
        /// <remarks>
        /// **Sample Response 200:**
        ///
        ///     {
        ///         "statusCode": 200,
        ///         "statusMessage": "Service provider with ID 1 deleted successfully."
        ///     }
        /// </remarks>
        [HttpDelete("DeleteServiceProvider/{companyID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> DeleteServiceProvider(int companyID, [FromServices] IServiceProvidersService _serviceProvidersService)
        {
            var result = await _serviceProvidersService.DeleteServiceProvidersAsync(companyID);
            if (result.IsSuccess)
                return Ok(result.SuccessResponse);
            return NotFound(result.ErrorResponse);
        }

        // SUPPLIERS ENDPOINTS
        /// <summary>
        /// Gets all suppliers
        /// </summary>
        /// <remarks>
        /// **Sample Response 200:**
        ///
        ///     [
        ///         {
        ///             "supplierID": 1,
        ///             "supplierName": "SupplyCo"
        ///         }
        ///     ]
        ///
        /// </remarks>
        [HttpGet("GetSuppliers")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<SuppliersReadDto>))]
        public async Task<ActionResult<IEnumerable<SuppliersReadDto>>> GetSuppliers([FromServices] ISuppliersService _suppliersService)
        {
            return Ok(await _suppliersService.GetSuppliersAsync());
        }

        /// <summary>
        /// Creates a new supplier
        /// </summary>
        /// <remarks>
        /// **Sample Request:**
        ///
        ///     POST /CreateSupplier
        ///
        /// **Sample Request Body:**
        ///
        ///     {
        ///         "supplierName": "SupplyCo",
        ///         "createdBy": "user-guid"
        ///     }
        ///
        /// **Sample Response 201:**
        ///
        ///     {
        ///         "statusCode": 201,
        ///         "statusMessage": "Supplier created successfully."
        ///     }
        /// </remarks>
        [HttpPost("CreateSupplier")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateSupplier([FromBody] SuppliersCreateDto values, [FromServices] ISuppliersService _suppliersService)
        {
            var result = await _suppliersService.CreateSuppliersAsync(values);
            if (result.IsSuccess)
                return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
            return BadRequest(result.ErrorResponse);
        }

        /// <summary>
        /// Updates a supplier
        /// </summary>
        /// <remarks>
        /// **Sample Request:**
        ///
        ///     PUT /UpdateSupplier
        ///
        /// **Sample Request Body:**
        ///
        ///     {
        ///         "supplierID": 1,
        ///         "supplierName": "Updated SupplyCo",
        ///         "modifiedBy": "user-guid"
        ///     }
        ///
        /// **Sample Response 200:**
        ///
        ///     {
        ///         "statusCode": 200,
        ///         "statusMessage": "Supplier updated successfully."
        ///     }
        /// </remarks>
        [HttpPut("UpdateSupplier")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> UpdateSupplier([FromBody] SuppliersUpdateDto values, [FromServices] ISuppliersService _suppliersService)
        {
            var result = await _suppliersService.UpdateSuppliersAsync(values);
            if (result.IsSuccess)
                return Ok(result.SuccessResponse);
            return NotFound(result.ErrorResponse);
        }

        /// <summary>
        /// Deletes a supplier by ID
        /// </summary>
        /// <param name="supplierID">The ID of the supplier to delete</param>
        /// <returns>Success or error response</returns>
        /// <remarks>
        /// **Sample Response 200:**
        ///
        ///     {
        ///         "statusCode": 200,
        ///         "statusMessage": "Supplier with ID 1 deleted successfully."
        ///     }
        /// </remarks>
        [HttpDelete("DeleteSupplier/{supplierID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> DeleteSupplier(int supplierID, [FromServices] ISuppliersService _suppliersService)
        {
            var result = await _suppliersService.DeleteSuppliersAsync(supplierID);
            if (result.IsSuccess)
                return Ok(result.SuccessResponse);
            return NotFound(result.ErrorResponse);
        }

        // STOCK ENDPOINTS
        /// <summary>
        /// Gets all stock
        /// </summary>
        /// <remarks>
        /// **Sample Response 200:**
        ///
        ///     [
        ///         {
        ///             "stockId": 1,
        ///             "itemCode": "ITM001",
        ///             "quantity": 100
        ///         }
        ///     ]
        ///
        /// </remarks>
        [HttpGet("GetStock")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<StockReadDto>))]
        public async Task<ActionResult<IEnumerable<StockReadDto>>> GetStock([FromServices] IStockService _stockService)
        {
            return Ok(await _stockService.GetStockAsync());
        }

        /// <summary>
        /// Creates a new stock entry
        /// </summary>
        /// <remarks>
        /// **Sample Request:**
        ///
        ///     POST /CreateStock
        ///
        /// **Sample Request Body:**
        ///
        ///     {
        ///         "itemCode": "ITM001",
        ///         "quantity": 100,
        ///         "createdBy": "user-guid"
        ///     }
        ///
        /// **Sample Response 201:**
        ///
        ///     {
        ///         "statusCode": 201,
        ///         "statusMessage": "Stock entry created successfully."
        ///     }
        /// </remarks>
        [HttpPost("CreateStock")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateStock([FromBody] StockCreateDto values, [FromServices] IStockService _stockService)
        {
            var result = await _stockService.CreateStockAsync(values);
            if (result.IsSuccess)
                return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
            return BadRequest(result.ErrorResponse);
        }

        /// <summary>
        /// Updates a stock entry
        /// </summary>
        /// <remarks>
        /// **Sample Request:**
        ///
        ///     PUT /UpdateStock
        ///
        /// **Sample Request Body:**
        ///
        ///     {
        ///         "stockId": 1,
        ///         "itemCode": "ITM001",
        ///         "quantity": 120,
        ///         "modifiedBy": "user-guid"
        ///     }
        ///
        /// **Sample Response 200:**
        ///
        ///     {
        ///         "statusCode": 200,
        ///         "statusMessage": "Stock entry updated successfully."
        ///     }
        /// </remarks>
        [HttpPut("UpdateStock")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> UpdateStock([FromBody] StockUpdateDto values, [FromServices] IStockService _stockService)
        {
            var result = await _stockService.UpdateStockAsync(values);
            if (result.IsSuccess)
                return Ok(result.SuccessResponse);
            return NotFound(result.ErrorResponse);
        }

        /// <summary>
        /// Deletes a stock entry by ID
        /// </summary>
        /// <param name="stockId">The ID of the stock entry to delete</param>
        /// <returns>Success or error response</returns>
        /// <remarks>
        /// **Sample Response 200:**
        ///
        ///     {
        ///         "statusCode": 200,
        ///         "statusMessage": "Stock entry with ID 1 deleted successfully."
        ///     }
        /// </remarks>
        [HttpDelete("DeleteStock/{stockId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> DeleteStock(int stockId, [FromServices] IStockService _stockService)
        {
            var result = await _stockService.DeleteStockAsync(stockId);
            if (result.IsSuccess)
                return Ok(result.SuccessResponse);
            return NotFound(result.ErrorResponse);
        }
    }
}

