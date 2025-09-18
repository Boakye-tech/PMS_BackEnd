// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/



using Microsoft.AspNetCore.Http;

namespace Modules.Finance.Application.UseCases
{
	public class BankBranchService : IBankBranchService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BankBranchService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ReturnResponsesDto> CreateBankBranchAsync(BankBranchCreateDto values)
        {
            try
            {
                var existingBank = await _unitOfWork.Bank.Get(b => b.BankId == values.BankId);
                if (existingBank == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Bank Id does not exist." },
                        SuccessResponse = null
                    };
                }

                var existingBankBranch = await _unitOfWork.BankBranch.Get(b => b.BranchId == values.BranchId);
                if (existingBankBranch != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Bank Branch already exists." },
                        SuccessResponse = null
                    };
                }

                BankBranch branch = new(values.BankId, values.BranchId, values.BranchName!)
                {
                    CreatedBy = values.CreatedBy,
                    CreatedOn = DateTime.Now
                };

                _unitOfWork.BankBranch.Insert(branch);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Bank Branch created successfully." }
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

        public async Task<IEnumerable<BankBranchReadDto>> GetBankBranchAsync()
        {
            
            var bankbranches = await _unitOfWork.BankBranch.GetAll();
            return _mapper.Map<IEnumerable<BankBranchReadDto>>(bankbranches);
        }

        public Task<BankBranchReadDto> GetBankBranchAsync(int value)
        {
            throw new NotImplementedException();
        }

        public Task<BankBranchReadDto> GetBankBranchAsync(string value)
        {
            throw new NotImplementedException();
        }

        public Task<BankBranchReadDto> UpdateBankBranchAsync(BankBranchUpdateDto values)
        {
            throw new NotImplementedException();
        }
    }
}

