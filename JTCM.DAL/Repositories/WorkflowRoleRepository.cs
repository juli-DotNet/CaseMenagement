using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using JTCM.DAL.DBModel;
using JTCM.DAL.Interfaces;
using JTCM.Model;

namespace JTCM.DAL.Repositories
{
    public class WorkflowRoleRepository : BaseRepository, IWorkflowRoleRepository
    {
        private readonly JtcmContext _context;
        private readonly IMapper _mapper;

        public WorkflowRoleRepository(JtcmContext context, IMapper mapper)
        :base(mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public WorkflowRoleModel AddWorkflowRole(WorkflowRoleModel data)
        {
          
            WorkflowRole model = _mapper.Map<WorkflowRole>(data);

           var result= _context.WorkflowRole.Add(model);
            _context.SaveChanges();
            return _mapper.Map<WorkflowRoleModel>(result.Entity);

        }

        public void DeleteWorkflowRole(int workflowId)
        {
            var result = _context.WorkflowRole.FirstOrDefault(a => a.Id == workflowId);

            if (result==null)
            {
                throw new KeyNotFoundException("Item cant be found");
            }

            _context.WorkflowRole.Remove(result);
            _context.SaveChanges();
        }

        public List<WorkflowRoleModel> GetAll()
        {
            var list = _context.WorkflowRole.AsEnumerable();

            return list.Select(a => _mapper.Map<WorkflowRoleModel>(a)).ToList();
        }

        public WorkflowRoleModel GetById(int id)
        {
            var result = _context.WorkflowRole.FirstOrDefault(a => a.Id == id);
            if (result == null)
            {
                throw new KeyNotFoundException("Item cant be found");
            }
            return _mapper.Map<WorkflowRoleModel>(result);
        }

        public WorkflowRoleModel UpdateWorkflowRole(WorkflowRoleModel data)
        {
            var result = _context.WorkflowRole.FirstOrDefault(a => a.Id == data.Id);
            if (result == null)
            {
                throw new KeyNotFoundException("Item cant be found");
            }
            //result = _mapper.Map<WorkflowRole>(data, opt => opt.CreateInstance<UpdateProfile>());
            
            Mapping.MapWorkflowRole(result,data);
            _context.SaveChanges();
            return data;
        }
    }
}
