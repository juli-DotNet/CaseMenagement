using System.ComponentModel.DataAnnotations;

namespace JTCM.Model
{
    public class WorkflowStepStatusModel
    {
       
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}