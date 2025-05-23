﻿// /**************************************************
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
	public class ResidentTypeService: IResidentTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public ResidentTypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ResidentTypeReadDto> AddResidentTypeAsync(ResidentTypeCreateDto values)
        {
            ResidentType request = new(values.residentTypeId, values.residentTypes!)
            {
                CreatedBy = values.createdBy,
                CreatedOn = DateTime.Now
            };

            _unitOfWork.ResidentType.Insert(request);
            await _unitOfWork.Complete();

            return new ResidentTypeReadDto(request.ResidentTypeId, request.ResidentTypes!);
        }

        public async Task<string> DeleteResidentTypeAsync(int value)
        {
            var response = await _unitOfWork.ResidentType.Get(value);

            if (response is null)
            {
                return "400 - BadRequest";
            }

            _unitOfWork.ResidentType.Delete(response);
            await _unitOfWork.Complete();

            return "success";
        }

        public async Task<IEnumerable<ResidentTypeReadDto>> GetResidentTypeAsync()
        {
            var response = await _unitOfWork.ResidentType.GetAll();
            return _mapper.Map<IEnumerable<ResidentTypeReadDto>>(response);
        }

        public async Task<ResidentTypeReadDto> GetResidentTypeAsync(int value)
        {
            var response = await _unitOfWork.ResidentType.Get(value);
            return _mapper.Map<ResidentTypeReadDto>(response);
        }

        public async Task<ResidentTypeReadDto> GetResidentTypeAsync(string value)
        {
            var response = await _unitOfWork.ResidentType.Get(r => r.ResidentTypes == value);
            return _mapper.Map<ResidentTypeReadDto>(response);
        }

        public async Task<ResidentTypeReadDto> UpdateResidentTypeAsync(ResidentTypeUpdateDto values)
        {
            ResidentType request = new(values.residentTypeId, values.residentTypes!)
            {
                ModifiedBy = values.modifiedBy,
                ModifiedOn = DateTime.Now
            };

            _unitOfWork.ResidentType.Update(request);
            await _unitOfWork.Complete();

            return new ResidentTypeReadDto(request.ResidentTypeId, request.ResidentTypes!);
        }
    }
}

