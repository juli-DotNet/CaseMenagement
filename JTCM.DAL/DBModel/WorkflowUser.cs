using System.ComponentModel.DataAnnotations;

namespace JTCM.DAL.DBModel
{

    public class WorkflowUser
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string UserName { get; set; }
        [StringLength(150)]
        public string FirstName { get; set; }
        [StringLength(150)]
        public string LastName { get; set; }
    }
}