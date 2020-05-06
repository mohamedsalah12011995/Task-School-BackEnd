using AutoMapper;
using School.Data;

namespace School.Domain
{
    /// <summary>
    /// BaseService All shared proprties for all services here 
    /// </summary>
    public class BaseService
    {
        public SchoolContext dbcontext { set; get; }
        public IMapper mapper { set; get; }

    }
}

