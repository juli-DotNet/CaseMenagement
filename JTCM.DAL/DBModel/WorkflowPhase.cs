using System.ComponentModel.DataAnnotations;

namespace JTCM.DAL.DBModel
{
    public class WorkflowPhase
    {
        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        [Required]
        public string Name { get; set; }
        [Required]
        public int DurationDays { get; set; }

    }
}