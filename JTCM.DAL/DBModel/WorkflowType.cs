using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JTCM.DAL.DBModel
{
    public class WorkflowType
    {
        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        [Required]
        public string Name { get; set; }
    }
}
