// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/ILeaseTypeAndPeriodService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/05/2025 9:28 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;

namespace Modules.Estates.Application.UseCases.Setup.Property;

public class LeaseTypeAndPeriodService : ILeaseTypeAndPeriodService
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;

	public LeaseTypeAndPeriodService(IUnitOfWork unitOfWork, IMapper mapper)
	{
		_unitOfWork = unitOfWork;
		_mapper = mapper;
	}

	public async Task<IEnumerable<LeaseTypeAndPeriodReadDto>> GetLeaseTypeAndPeriodAsync()
	{
		var leaseTypes = await _unitOfWork.LeaseTypeAndPeriod.GetAll();
		return _mapper.Map<IEnumerable<LeaseTypeAndPeriodReadDto>>(leaseTypes);
	}

	public async Task<LeaseTypeAndPeriodReadDto> GetLeaseTypeAndPeriodAsync(int value)
	{
		var leaseType = await _unitOfWork.LeaseTypeAndPeriod.Get(value);
		return _mapper.Map<LeaseTypeAndPeriodReadDto>(leaseType);
	}

	public async Task<LeaseTypeAndPeriodReadDto> GetLeaseTypeAndPeriodAsync(string value)
	{
		var leaseType = await _unitOfWork.LeaseTypeAndPeriod.Get(l => l.LeaseType == value);
		return _mapper.Map<LeaseTypeAndPeriodReadDto>(leaseType);
	}

	public async Task<ReturnResponsesDto> CreateLeaseTypeAndPeriodAsync(LeaseTypeAndPeriodCreateDto values)
	{
		try
		{
			int leaseTypePeriodId = 0;

			var existingLeaseType = await _unitOfWork.LeaseTypeAndPeriod.Get(l => l.LeaseType == values.LeaseType);
			if (existingLeaseType != null)
			{
				return new ReturnResponsesDto
				{
					IsSuccess = false,
					ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Lease Type already exists." },
					SuccessResponse = null
				};
			}

			var leaseType = LeaseTypeAndPeriod.Create(leaseTypePeriodId, values.LeaseType!, values.LeasePeriod);
			leaseType.CreatedBy = values.CreatedBy;
			leaseType.CreatedOn = DateTime.Now;

			_unitOfWork.LeaseTypeAndPeriod.Insert(leaseType);
			await _unitOfWork.Complete();

			return new ReturnResponsesDto
			{
				IsSuccess = true,
				ErrorResponse = null,
				SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Lease Type and Period details created successfully." },
			};
		}
		catch (Exception ex)
		{
			return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message ?? ex.InnerException!.Message }, SuccessResponse = null };
		}
	}

	public async Task<ReturnResponsesDto> UpdateLeaseTypeAndPeriodAsync(LeaseTypeAndPeriodUpdateDto values)
	{
		try
		{
			var leaseType = await _unitOfWork.LeaseTypeAndPeriod.Get(values.LeaseTypePeriodId);
			if (leaseType == null)
			{
				return new ReturnResponsesDto
				{
					IsSuccess = false,
					ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Lease Type and Period with ID {values.LeaseTypePeriodId} not found." },
					SuccessResponse = null
				};
			}

			leaseType.Update(values.LeaseTypePeriodId, values.LeaseType!, values.LeasePeriod);
			leaseType.ModifiedBy = values.ModifiedBy;
			leaseType.ModifiedOn = DateTime.Now;

			_unitOfWork.LeaseTypeAndPeriod.Update(leaseType);
			await _unitOfWork.Complete();

			return new ReturnResponsesDto
			{
				IsSuccess = true,
				ErrorResponse = null,
				SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Lease Type and Period details modified successfully." },
			};
		}
		catch (Exception ex)
		{
			return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
		}
	}

	public async Task<ReturnResponsesDto> DeleteLeaseTypeAndPeriod(int leaseTypePeriodId)
	{
		try
		{
			var leaseType = await _unitOfWork.LeaseTypeAndPeriod.Get(leaseTypePeriodId);
			if (leaseType == null)
			{
				return new ReturnResponsesDto
				{
					IsSuccess = false,
					ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Lease Type and Period with ID {leaseTypePeriodId} not found." },
					SuccessResponse = null
				};
			}

			_unitOfWork.LeaseTypeAndPeriod.Delete(leaseType);
			await _unitOfWork.Complete();

			return new ReturnResponsesDto
			{
				IsSuccess = true,
				ErrorResponse = null,
				SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Lease Type and Period with ID {leaseTypePeriodId} deleted successfully." }
			};
		}
		catch (Exception ex)
		{
			return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
		}
	}
}

