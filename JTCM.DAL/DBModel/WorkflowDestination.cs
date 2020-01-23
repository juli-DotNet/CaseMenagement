

using System.ComponentModel.DataAnnotations;

namespace JTCM.DAL.DBModel
{
    public class WorkflowDestination
    {
        [Key]
        public int Id { get; set; }
        public WorkflowStep From_WorkflowStep { get; set; }
        public WorkflowStep To_WorkflowStep { get; set; }
        public WorkflowRole WorkflowRole { get; set; }
    }
}