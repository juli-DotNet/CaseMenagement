

using System.ComponentModel.DataAnnotations;

namespace JTCM.Model
{
    public class WorkflowDestinationModel
    {
        [Key]
        public int Id { get; set; }
        public WorkflowStepModel From_WorkflowStep { get; set; }
        public WorkflowStepModel To_WorkflowStep { get; set; }
        public WorkflowRoleModel WorkflowRole { get; set; }
    }
}