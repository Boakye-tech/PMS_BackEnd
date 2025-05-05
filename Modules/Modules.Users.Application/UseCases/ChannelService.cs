// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Users.Application.UseCases
{
	public class ChannelService : IChannelService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ChannelService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ChannelReadDto> AddChannelAsync(ChannelCreateDto values)
        {
            Channels channel = Channels.CreateUpdate(values.ChannelId, values.ChannelName!);

            channel.CreatedBy = values.CreatedBy;
            channel.CreatedOn = DateTime.Now;

            _unitOfWork.Channels.Insert(channel);
            await _unitOfWork.Complete();

            return new ChannelReadDto(channel.ChannelId, channel.ChannelName!);

        }

        public async Task<string> DeleteChannelAsync(int value)
        {
            var response = await _unitOfWork.Channels.Get(value);

            if (response is null)
                return "BadRequest";

            _unitOfWork.Channels.Delete(response);
            await _unitOfWork.Complete();

            return "success";
        }

        public async Task<IEnumerable<ChannelReadDto>> GetChannelAsync()
        {
            var response = await _unitOfWork.Channels.GetAll();
            return _mapper.Map<IEnumerable<ChannelReadDto>>(response);
        }

        public Task<ChannelReadDto> GetChannelAsync(int value)
        {
            throw new NotImplementedException();
        }

        public Task<ChannelReadDto> GetChannelAsync(string value)
        {
            throw new NotImplementedException();
        }

        public async Task<ChannelReadDto> UpdateChannelAsync(ChannelUpdateDto values)
        {
            Channels channel = Channels.CreateUpdate(values.ChannelId, values.ChannelName!);

            channel.ModifiedBy = values.ModifiedBy;
            channel.ModifiedOn = DateTime.Now;


            _unitOfWork.Channels.Update(channel);
            await _unitOfWork.Complete();

            return new ChannelReadDto(channel.ChannelId, channel.ChannelName!);

        }



    }
}

