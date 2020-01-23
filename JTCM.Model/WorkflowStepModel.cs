using System.ComponentModel.DataAnnotations;

namespace JTCM.Model
{
    public class WorkflowStepModel
    {
       
        public int Id { get; set; }
        
        public string Name { get; set; }
      
        public bool IsStarting { get; set; }
      
        public bool IsEnding { get; set; }
        public WorkflowTypeModel WorkflowType { get; set; }
        public WorkflowModel Workflow { get; set; }
        public WorkflowStepTypeModel WorkflowStepType { get; set; }
        public WorkflowStepStatusModel WorkflowStepStatus { get; set; }
        public WorkflowPhaseModel WorkflowPhase { get; set; }
    }
}