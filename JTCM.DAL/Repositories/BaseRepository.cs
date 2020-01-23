using AutoMapper;

namespace JTCM.DAL.Repositories
{
    public class BaseRepository
    {
         readonly IMapper _mapper;

        public BaseRepository(IMapper mapper)
        {
            _mapper = mapper;
        }


        //void SetMappingUpdateProfile()
        //{
        //    _mapper.
        //}

    }
}