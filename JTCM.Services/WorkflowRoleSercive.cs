using System;
using System.Collections.Generic;
using JTCM.DAL.Interfaces;
using JTCM.Model;
using JTMC.Services.Interfaces;

namespace JTCM.Services
{
   

    public class WorkflowRoleSercive : IWorkflowRoleService
    {
        private readonly IWorkflowRoleRepository _repository;

        public WorkflowRoleSercive(IWorkflowRoleRepository repository)
        {
            _repository = repository;
        }
        public WorkflowRoleModel AddWorkflowRole(WorkflowRoleModel data)
        {
            try
            {
                return _repository.AddWorkflowRole(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
          
        }

        public WorkflowRoleModel UpdateWorkflowRole(WorkflowRoleModel data)
        {
            try
            {
                return _repository.UpdateWorkflowRole(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
          
        }

        public void DeleteWorkflowRole(int workflowId)
        {
            try
            {
                _repository.DeleteWorkflowRole(workflowId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
   
        }

        public List<WorkflowRoleModel> GetAll()
        {
            try
            {
                return _repository.GetAll();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        public WorkflowRoleModel GetById(int id)
        {
            try
            {
                return _repository.GetById(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
    }
}
