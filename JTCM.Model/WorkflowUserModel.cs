using System.ComponentModel.DataAnnotations;

namespace JTCM.Model
{

    public class WorkflowUserModel
    {
       
        public int Id { get; set; }
       
        public string UserName { get; set; }
      
        public string FirstName { get; set; }
       
        public string LastName { get; set; }
    }
}