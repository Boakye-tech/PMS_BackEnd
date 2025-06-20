using Microsoft.AspNetCore.Mvc;
using Modules.Estates.Application.DTO.Setup.Property;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Modules.Estates.Presentation.Controllers.v1
{
    public partial class PropertyController
    {
        /// <summary>
        /// Returns a list of rental categories
        /// </summary>
        [HttpGet]
        [Route("GetRentalCategoriesAndRentalTypes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<RentalCategoryAndRentalTypeReadDto>))]
        public IActionResult GetRentalCategoriesAndRentalTypes()
        {
            var result = _rentalsService.GetRentalCategoryAndRentalTypeAsync().Result;
            return Ok(result);
        }

        //-------------------RENTAL CATEGORIES-----------------
        /// <summary>
        /// Returns a list of rental categories
        /// </summary>
        [HttpGet]
        [Route("GetRentalCategory")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<RentalCategoryReadDto>))]
        public IActionResult RentalCategory()
        {
            var result = _rentalsService.GetRentalCategoryAsync().Result;
            return Ok(result);
        }

        /// <summary>
        /// Creates a new rental category
        /// </summary>
        [HttpPost]
        [Route("CreateRentalCategory")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public IActionResult CreateRentalCategory([FromBody] RentalCategoryCreateDto values)
        {
            var result = _rentalsService.CreateRentalCategoryAsync(values).Result;

            if (result.IsSuccess)
            {
                return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
                400 => BadRequest(result.ErrorResponse),
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };

        }

        /// <summary>
        /// Updates an existing rental category
        /// </summary>
        [HttpPut]
        [Route("UpdateRentalCategory")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public IActionResult UpdateRentalCategory([FromBody] RentalCategoryUpdateDto values)
        {
            var result = _rentalsService.UpdateRentalCategoryAsync(values).Result;
            if (result.IsSuccess)
            {
                return Ok(result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };

        }

        /// <summary>
        /// Deletes a rental category
        /// </summary>
        [HttpDelete]
        [Route("DeleteRentalCategory/{rentalCategoryId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public IActionResult DeleteRentalCategory(int rentalCategoryId)
        {
            var result = _rentalsService.DeleteRentalCategory(rentalCategoryId).Result;
            if (result.IsSuccess)
            {
                return Ok(result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };
        }

        //-------------------RENTAL TYPES-----------------
        /// <summary>
        /// Returns a list of rental types
        /// </summary>
        [HttpGet]
        [Route("GetRentalTypes/{rentalCategoryId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<RentalTypeReadDto>))]
        public IActionResult RentalType(int rentalCategoryId)
        {
            var result = _rentalsService.GetRentalTypeAsync(rentalCategoryId).Result;
            return Ok(result);
        }

        /// <summary>
        /// Creates a new rental type
        /// </summary>
        [HttpPost]
        [Route("CreateRentalType")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public IActionResult CreateRentalType([FromBody] RentalTypeCreateDto values)
        {
            var result = _rentalsService.CreateRentalTypeAsync(values).Result;
            if (result.IsSuccess)
            {
                return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
                400 => BadRequest(result.ErrorResponse),
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };

        }

        /// <summary>
        /// Updates an existing rental type
        /// </summary>
        [HttpPut]
        [Route("UpdateRentalType")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public IActionResult UpdateRentalType([FromBody] RentalTypeUpdateDto values)
        {
            var result = _rentalsService.UpdateRentalTypeAsync(values).Result;
            if (result.IsSuccess)
            {
                return Ok(result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };
        }

        /// <summary>
        /// Deletes a rental type
        /// </summary>
        [HttpDelete]
        [Route("DeleteRentalType/{rentalTypeId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public IActionResult DeleteRentalType(int rentalTypeId)
        {
            var result = _rentalsService.DeleteRentalType(rentalTypeId).Result;
            if (result.IsSuccess)
            {
                return Ok(result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };
        }

        //-------------------TYPES (e.g. Houses, ShopsAndOffices, Apartments etc)-----------------
        /// <summary>
        /// Returns a list of types(e.g. Houses, ShopsAndOffices, Apartments etc)
        /// </summary>
        [HttpGet]
        [Route("GetAllTypes")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<AllTypesRentalCategoryDto>))]
        public IActionResult AllTypes()
        {
            var result = _rentalsService.GetAllTypesAsync().Result;
            return Ok(result);
        }

        /// <summary>
        /// Creates a new type (e.g. Houses, ShopsAndOffices, Apartments etc)
        /// </summary>
        [HttpPost]
        [Route("CreateType")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public IActionResult CreateType([FromBody] TypesCreateDto values)
        {
            var result = _rentalsService.CreateTypesAsync(values).Result;
            if (result.IsSuccess)
            {
                return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
                400 => BadRequest(result.ErrorResponse),
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };

        }

        /// <summary>
        /// Updates an existing type (e.g. Houses, ShopsAndOffices, Apartments etc)
        /// </summary>
        [HttpPut]
        [Route("UpdateType")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public IActionResult UpdateType([FromBody] TypesUpdateDto values)
        {
            var result = _rentalsService.UpdateTypesAsync(values).Result;
            
            if (result.IsSuccess)
            {
                return Ok(result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
                400 => BadRequest(result.ErrorResponse),
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };

        }

        /// <summary>
        /// Deletes a type
        /// </summary>
        [HttpDelete]
        [Route("DeleteType/{typeId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public IActionResult DeleteType(int typeId)
        {
            var result = _rentalsService.DeleteTypes(typeId).Result;
            return Ok(result);
        }

        #region Obsolete Enpoints
        
        //-------------------SHOP/OFFICE TYPES-----------------
        /// <summary>
        /// Returns a list of shop/office types
        /// </summary>
        [HttpGet]
        [Route("GetShopOfficeTypes")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [Obsolete]
        public IActionResult ShopOfficeType()
        {
            var result = _rentalsService.GetShopOfficeTypesAsync().Result;
            return Ok(result);
        }

        ///// <summary>
        ///// Returns a shop/office type by ID
        ///// </summary>
        //[HttpGet]
        //[Route("ShopOfficeType/{id}")]
        //[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        //public IActionResult GetShopOfficeType(int id)
        //{
        //    var result = _rentalsService.GetShopOfficeTypesAsync(id).Result;
        //    return Ok(result);
        //}

        ///// <summary>
        ///// Returns a shop/office type by name
        ///// </summary>
        //[HttpGet]
        //[Route("ShopOfficeType/name/{name}")]
        //[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        //public IActionResult GetShopOfficeTypeByName(string name)
        //{
        //    var result = _rentalsService.GetShopOfficeTypesAsync(name).Result;
        //    return Ok(result);
        //}

        /// <summary>
        /// Creates a new shop/office type
        /// </summary>
        [HttpPost]
        [Route("CreateShopOfficeType")]
        [ProducesResponseType(typeof(int), StatusCodes.Status201Created)]
        [Obsolete]
        public IActionResult CreateShopOfficeType([FromBody] ShopOfficeTypesCreateDto values)
        {
            var result = _rentalsService.CreateShopOfficeTypesAsync(values).Result;
            return Ok(result);
        }

        /// <summary>
        /// Updates an existing shop/office type
        /// </summary>
        [HttpPut]
        [Route("UpdateShopOfficeType")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [Obsolete]
        public IActionResult UpdateShopOfficeType([FromBody] ShopOfficeTypesUpdateDto values)
        {
            var result = _rentalsService.UpdateShopOfficeTypesAsync(values).Result;
            return Ok(result);
        }

        /// <summary>
        /// Deletes a shop/office type
        /// </summary>
        [HttpDelete]
        [Route("DeleteShopOfficeType/{shopOfficeTypeId}")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [Obsolete]
        public IActionResult DeleteShopOfficeType(int shopOfficeTypeId)
        {
            var result = _rentalsService.DeleteShopOfficeTypes(shopOfficeTypeId).Result;
            return Ok(result);
        }

        //-------------------HOUSE TYPES-----------------
        /// <summary>
        /// Returns a list of house types
        /// </summary>
        [HttpGet]
        [Route("GetHouseTypes")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [Obsolete]
        public IActionResult HouseType()
        {
            var result = _rentalsService.GetHouseTypesAsync().Result;
            return Ok(result);
        }

        ///// <summary>
        ///// Returns a house type by ID
        ///// </summary>
        //[HttpGet]
        //[Route("HouseType/{id}")]
        //[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        //public IActionResult GetHouseType(int id)
        //{
        //    var result = _rentalsService.GetHouseTypesAsync(id).Result;
        //    return Ok(result);
        //}

        ///// <summary>
        ///// Returns a house type by name
        ///// </summary>
        //[HttpGet]
        //[Route("HouseType/name/{name}")]
        //[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        //public IActionResult GetHouseTypeByName(string name)
        //{
        //    var result = _rentalsService.GetHouseTypesAsync(name).Result;
        //    return Ok(result);
        //}

        /// <summary>
        /// Creates a new house type
        /// </summary>
        [HttpPost]
        [Route("CreateHouseType")]
        [ProducesResponseType(typeof(int), StatusCodes.Status201Created)]
        [Obsolete]
        public IActionResult CreateHouseType([FromBody] HouseTypesCreateDto values)
        {
            var result = _rentalsService.CreateHouseTypesAsync(values).Result;
            return Ok(result);
        }

        /// <summary>
        /// Updates an existing house type
        /// </summary>
        [HttpPut]
        [Route("UpdateHouseType")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [Obsolete]
        public IActionResult UpdateHouseType([FromBody] HouseTypesUpdateDto values)
        {
            var result = _rentalsService.UpdateHouseTypesAsync(values).Result;
            return Ok(result);
        }

        /// <summary>
        /// Deletes a house type
        /// </summary>
        [HttpDelete]
        [Route("DeleteHouseType/{houseTypeId}")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [Obsolete]
        public IActionResult DeleteHouseType(int houseTypeId)
        {
            var result = _rentalsService.DeleteHouseTypes(houseTypeId).Result;
            return Ok(result);
        }

        #endregion
    }
}

