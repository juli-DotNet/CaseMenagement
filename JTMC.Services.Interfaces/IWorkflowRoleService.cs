using System;
using System.Collections.Generic;
using JTCM.Model;

namespace JTMC.Services.Interfaces
{
    public interface IWorkflowRoleService
    {
        WorkflowRoleModel AddWorkflowRole(WorkflowRoleModel data);
        WorkflowRoleModel UpdateWorkflowRole(WorkflowRoleModel data);
        void  DeleteWorkflowRole(int workflowId);
        List<WorkflowRoleModel> GetAll();
        WorkflowRoleModel GetById(int id);
    }
}
