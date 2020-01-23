using System.ComponentModel.DataAnnotations;

namespace JTCM.DAL.DBModel
{
    public class WorkflowRoleUser
    {
        [Key]
        public int Id { get; set; }
        public WorkflowRole WorkflowRole { get; set; }
        public WorkflowUser WorkflowUser { get; set; }
    }
}