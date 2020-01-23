using AutoMapper;
using JTCM.DAL.DBModel;
using JTCM.Model;
using System;


namespace JTCM.DAL
{
    public class NormalProfile : Profile
    {
        public NormalProfile()
        {
            CreateMap<WorkflowRoleModel,WorkflowRole>().ReverseMap();
        }
    }
    public class UpdateProfile : Profile
    {
        public UpdateProfile()
        {
            CreateMap<WorkflowRoleModel,WorkflowRole>()
                .ForMember(a=>a.Id,opt=>opt.Ignore());

        }
    }
}
