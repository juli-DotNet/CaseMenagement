using System.ComponentModel.DataAnnotations;

namespace JTCM.DAL.DBModel
{
    public class Workflow
    {
        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        [Required]
        public string Name { get; set; }

        public WorkflowType WorkflowType { get; set; }
    }
}