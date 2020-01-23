using System;
using System.ComponentModel.DataAnnotations;


namespace JTCM.DAL.DBModel
{
    public class UserWorkflowStep
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }
        [Required]
        public WorkflowUser WorkflowUser { get; set; }
        public WorkflowDestination WorkflowDestination { get; set; }
        public UserWorkflowStepStatus UserWorkflowStepStatus { get; set; }

    }
}