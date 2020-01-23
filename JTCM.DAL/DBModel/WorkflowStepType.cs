using System.ComponentModel.DataAnnotations;

namespace JTCM.DAL.DBModel
{
    public class WorkflowStepType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
    }
}