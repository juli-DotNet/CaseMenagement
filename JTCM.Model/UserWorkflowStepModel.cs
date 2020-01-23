using System;
using System.ComponentModel.DataAnnotations;


namespace JTCM.Model
{
    public class UserWorkflowStepModel
    {
      
        public int Id { get; set; }
       
        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }
      
        public WorkflowUserModel WorkflowUser { get; set; }
        public WorkflowDestinationModel WorkflowDestination { get; set; }
        public UserWorkflowStepStatusModel UserWorkflowStepStatus { get; set; }

    }
}