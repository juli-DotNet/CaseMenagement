using System.ComponentModel.DataAnnotations;

namespace JTCM.Model
{
    public class WorkflowRoleUserModel
    {
      
        public int Id { get; set; }
        public WorkflowRoleModel WorkflowRole { get; set; }
        public WorkflowUserModel WorkflowUser { get; set; }
    }
}