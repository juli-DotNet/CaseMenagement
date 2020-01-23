using System.ComponentModel.DataAnnotations;

namespace JTCM.Model
{
    public class WorkflowModel
    {
        
        public int Id { get; set; }
      
        public string Name { get; set; }

        public WorkflowTypeModel WorkflowType { get; set; }
    }
}