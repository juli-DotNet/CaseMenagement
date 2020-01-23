using System.ComponentModel.DataAnnotations;

namespace JTCM.Model
{
    public class WorkflowPhaseModel
    {
        
        public int Id { get; set; }
       
        public string Name { get; set; }
       
        public int DurationDays { get; set; }

    }
}