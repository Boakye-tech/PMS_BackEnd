// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Controllers/v1/CustomerController.ProductAwarenessSources.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 20/09/2025 6:00 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Modules.Estates.Application.DTO.Setup.Customer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Modules.Estates.Presentation.Controllers.v1
{
    public partial class CustomerController : ControllerBase
    {
        //---PRODUCT AWARENESS SOURCES-------
        /// <summary>
        /// Returns a list of all product awareness sources in the system
        /// </summary>
        [HttpGet]
        [Route("GetProductAwarenessSources")]
        //[Authorize(Policy = "Permission:Customers.READ")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ProductAwarenessSourcesReadDto>))]
        public async Task<ActionResult<List<ProductAwarenessSourcesReadDto>>> GetProductAwarenessSources([FromServices] IProductAwarenessSourcesService _productAwarenessSources)
        {
            return Ok(await _productAwarenessSources.GetProductAwarenessSourcesAsync());
        }

        // POST: api/CreateProductAwarenessSources
        /// <summary>
        /// Creates a new product awareness source record in the system
        /// </summary>
        /// <remarks>
        /// Addition of new product awareness source for customer management
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreateProductAwarenessSources
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "productAwarenessSourcesId": 0,
        ///         "productAwarenessSource": "Social Media",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "productAwarenessSourcesId": 1,
        ///         "productAwarenessSource": "Social Media"
        ///     }
        /// 
        /// </remarks>
        [HttpPost]
        [Route("CreateProductAwarenessSources")]
        [Authorize(Policy = "Permission:Customers.CREATE")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ProductAwarenessSourcesReadDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ProductAwarenessSourcesReadDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ProductAwarenessSourcesReadDto))]
        public async Task<ActionResult<ProductAwarenessSourcesReadDto>> CreateProductAwarenessSources([FromServices] IProductAwarenessSourcesService _productAwarenessSources, [FromBody] ProductAwarenessSourcesCreateDto values)
        {
            try
            {
                var response = await _productAwarenessSources.AddProductAwarenessSourcesAsync(values);
                if (response.productAwarenessSourcesId > 0)
                {
                    return StatusCode(StatusCodes.Status201Created, response);
                }
                return BadRequest(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ProductAwarenessSourcesReadDto(StatusCodes.Status500InternalServerError, ex.Message));
            }
        }

        // PUT: api/UpdateProductAwarenessSources
        /// <summary>
        /// Updates an existing product awareness source record in the system
        /// </summary>
        /// <remarks>
        /// Updates the details of an existing product awareness source record
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateProductAwarenessSources
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "productAwarenessSourcesId": 1,
        ///         "productAwarenessSource": "Online Advertisement",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "productAwarenessSourcesId": 1,
        ///         "productAwarenessSource": "Online Advertisement"
        ///     }
        /// 
        /// </remarks>
        [HttpPut]
        [Route("UpdateProductAwarenessSources")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductAwarenessSourcesReadDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ProductAwarenessSourcesReadDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ProductAwarenessSourcesReadDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ProductAwarenessSourcesReadDto))]
        public async Task<ActionResult<ProductAwarenessSourcesReadDto>> UpdateProductAwarenessSources([FromServices] IProductAwarenessSourcesService _productAwarenessSources, [FromBody] ProductAwarenessSourcesUpdateDto values)
        {
            try
            {
                var response = await _productAwarenessSources.UpdateProductAwarenessSourcesAsync(values);
                if (response.productAwarenessSourcesId > 0)
                {
                    return Ok(response);
                }
                return BadRequest(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ProductAwarenessSourcesReadDto(StatusCodes.Status500InternalServerError, ex.Message));
            }
        }

        /// <summary>
        /// Deletes an existing product awareness source record by its ID
        /// </summary>
        /// <param name="productAwarenessSourcesId">The ID of the product awareness source to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteProductAwarenessSources/{productAwarenessSourcesId}")]
        [Authorize(Policy = "Permission:Customers.DELETE")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductAwarenessSourcesReadDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ProductAwarenessSourcesReadDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ProductAwarenessSourcesReadDto))]
        public async Task<ActionResult<ProductAwarenessSourcesReadDto>> DeleteProductAwarenessSources([FromServices] IProductAwarenessSourcesService _productAwarenessSources, int productAwarenessSourcesId)
        {
            try
            {
                var response = await _productAwarenessSources.DeleteProductAwarenessSourcesAsync(productAwarenessSourcesId);

                if (response.productAwarenessSourcesId > 0)
                {
                    return Ok(response);
                }
                return NotFound(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ProductAwarenessSourcesReadDto(StatusCodes.Status500InternalServerError, ex.Message));
            }
        }
    }
}
