// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 19/09/2025 4:45 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;


namespace Modules.Finance.Application.UseCases.Setups
{
    public class DebtorGroupsService : IDebtorGroupsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DebtorGroupsService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DebtorGroupsReadDto>> GetDebtorGroupsAsync()
        {
            var debtorGroups = await _unitOfWork.DebtorGroups.GetAll();
            return _mapper.Map<IEnumerable<DebtorGroupsReadDto>>(debtorGroups);
        }

        public async Task<DebtorGroupsReadDto> GetDebtorGroupsAsync(int debtorGroupsId)
        {
            var debtorGroup = await _unitOfWork.DebtorGroups.Get(dg => dg.DebtorGroupsId == debtorGroupsId);
            return _mapper.Map<DebtorGroupsReadDto>(debtorGroup);
        }

        public async Task<ReturnResponsesDto> CreateDebtorGroupsAsync(DebtorGroupsCreateDto values)
        {
            try
            {
                var existingDebtorGroup = await _unitOfWork.DebtorGroups.Get(dg => dg.GroupName == values.GroupName && dg.DebtorTypesId == values.DebtorTypesId);
                if (existingDebtorGroup != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Debtor Group already exists for this Debtor Type." },
                        SuccessResponse = null
                    };
                }

                var debtorGroup = new DebtorGroups(values.DebtorTypesId, 0, values.GroupName!, values.Description)
                {
                    CreatedBy = values.CreatedBy,
                    CreatedOn = DateTime.Now
                };

                _unitOfWork.DebtorGroups.Insert(debtorGroup);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Debtor Group created successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message },
                    SuccessResponse = null
                };
            }
        }

        public async Task<ReturnResponsesDto> UpdateDebtorGroupsAsync(DebtorGroupsUpdateDto values)
        {
            try
            {
                var debtorGroup = await _unitOfWork.DebtorGroups.Get(dg => dg.DebtorGroupsId == values.DebtorGroupsId);
                if (debtorGroup == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "Debtor Group not found." },
                        SuccessResponse = null
                    };
                }

                var existingDebtorGroup = await _unitOfWork.DebtorGroups.Get(dg => dg.GroupName == values.GroupName && dg.DebtorTypesId == values.DebtorTypesId && dg.DebtorGroupsId != values.DebtorGroupsId);
                if (existingDebtorGroup != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Debtor Group already exists for this Debtor Type." },
                        SuccessResponse = null
                    };
                }

                debtorGroup.Update(values.DebtorTypesId, values.DebtorGroupsId, values.GroupName!, values.Description);
                debtorGroup.ModifiedBy = values.ModifiedBy;
                debtorGroup.ModifiedOn = DateTime.Now;

                _unitOfWork.DebtorGroups.Update(debtorGroup);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Debtor Group updated successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message },
                    SuccessResponse = null
                };
            }
        }

        public async Task<ReturnResponsesDto> DeleteDebtorGroupsAsync(int debtorGroupsId)
        {
            try
            {
                var debtorGroup = await _unitOfWork.DebtorGroups.Get(dg => dg.DebtorGroupsId == debtorGroupsId);
                if (debtorGroup == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "Debtor Group not found." },
                        SuccessResponse = null
                    };
                }

                _unitOfWork.DebtorGroups.Delete(debtorGroup);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Debtor Group deleted successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message },
                    SuccessResponse = null
                };
            }
        }
    }
}
