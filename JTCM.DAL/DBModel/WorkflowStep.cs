using System.ComponentModel.DataAnnotations;

namespace JTCM.DAL.DBModel
{
    public class WorkflowStep
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        [Required]
        public bool IsStarting { get; set; }
        [Required]
        public bool IsEnding { get; set; }
        public WorkflowType WorkflowType { get; set; }
        public Workflow Workflow { get; set; }
        public WorkflowStepType WorkflowStepType { get; set; }
        public WorkflowStepStatus WorkflowStepStatus { get; set; }
        public WorkflowPhase WorkflowPhase { get; set; }
    }
}