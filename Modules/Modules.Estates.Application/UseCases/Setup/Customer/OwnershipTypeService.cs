// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/



namespace Modules.Estates.Application.UseCases.Setup.Customer
{
	public class OwnershipTypeService : IOwnershipTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public OwnershipTypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<OwnershipTypeReadDto> AddOwnershipTypeAsync(OwnershipTypeCreateDto values)
        {
            //throw new NotImplementedException();
            OwnershipType request = new(values.ownershipTypeId, values.ownershipTypes!)
            {
                CreatedBy = values.createdby,
                CreatedOn = DateTime.Now
            };

            _unitOfWork.OwnershipType.Insert(request);
            await _unitOfWork.Complete();

            return new OwnershipTypeReadDto(request.OwnershipTypeId, request.OwnershipTypes!);
        }

        public async Task<string> DeleteOwnershipTypeAsync(int value)
        {
            var ownershiptype = await _unitOfWork.OwnershipType.Get(value);

            if (ownershiptype is null)
            {
                return "400 - BadRequest";
            }

            _unitOfWork.OwnershipType.Delete(ownershiptype);
            await _unitOfWork.Complete();

            return "success";
                
        }

        public async Task<IEnumerable<OwnershipTypeReadDto>> GetOwnershipTypeAsync()
        {
            var response = await _unitOfWork.OwnershipType.GetAll();
            return _mapper.Map<IEnumerable<OwnershipTypeReadDto>>(response);

        }

        public async Task<OwnershipTypeReadDto> GetOwnershipTypeAsync(int value)
        {
            var response = await _unitOfWork.OwnershipType.Get(value);
            return _mapper.Map<OwnershipTypeReadDto>(response);

        }

        public async Task<OwnershipTypeReadDto> GetOwnershipTypeAsync(string value)
        {
            var response = await _unitOfWork.OwnershipType.Get(o => o.OwnershipTypes == value);
            return _mapper.Map<OwnershipTypeReadDto>(response);
        }

        public async Task<OwnershipTypeReadDto> UpdateOwnershipTypeAsync(OwnershipTypeUpdateDto values)
        {
            //throw new NotImplementedException();
            OwnershipType request = new(values.ownershipTypeId, values.ownershipTypes!)
            {
                ModifiedBy = values.modifiedby,
                ModifiedOn = DateTime.Now
            };

            _unitOfWork.OwnershipType.Update(request);
            await _unitOfWork.Complete();

            return new OwnershipTypeReadDto(request.OwnershipTypeId, request.OwnershipTypes!);
        }
    }
}

