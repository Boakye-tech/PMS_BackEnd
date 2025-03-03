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
            Channels Channel = new(values.ChannelId, values.ChannelName!)
            {
                CreatedBy = values.CreatedBy,
                CreatedOn = DateTime.Now
            };

            _unitOfWork.Channels.Insert(Channel);
            await _unitOfWork.Complete();

            return new ChannelReadDto(Channel.ChannelId, Channel.ChannelName!);
        }

        public async Task<string> DeleteChannelAsync(int value)
        {
            //throw new NotImplementedException();

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
            //throw new NotImplementedException();
            Channels Channel = new(values.ChannelId, values.ChannelName!)
            {
                ModifiedBy = values.ModifiedBy,
                ModifiedOn = DateTime.Now
            };

            _unitOfWork.Channels.Update(Channel);
            await _unitOfWork.Complete();

            return new ChannelReadDto(Channel.ChannelId, Channel.ChannelName!);

        }



    }
}

