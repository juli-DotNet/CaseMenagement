using System.ComponentModel.DataAnnotations;

namespace JTCM.DAL.DBModel
{
    public class WorkflowRole
    {
        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        [Required]
        public string Name { get; set; }
    }
}