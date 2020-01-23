using System.ComponentModel.DataAnnotations;

namespace JTCM.DAL.DBModel
{
    public class WorkflowStepStatus
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
    }
}