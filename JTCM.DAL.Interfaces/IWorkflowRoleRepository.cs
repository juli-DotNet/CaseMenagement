using JTCM.Model;
using System;
using System.Collections.Generic;

namespace JTCM.DAL.Interfaces
{
    public interface IWorkflowRoleRepository
    {
        WorkflowRoleModel AddWorkflowRole(WorkflowRoleModel data);
        WorkflowRoleModel UpdateWorkflowRole(WorkflowRoleModel data);
        void DeleteWorkflowRole(int workflowId);
        List<WorkflowRoleModel> GetAll();
        WorkflowRoleModel GetById(int id);
    }
}
