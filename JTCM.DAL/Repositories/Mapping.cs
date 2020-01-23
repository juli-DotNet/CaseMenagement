using JTCM.DAL.DBModel;
using JTCM.Model;

namespace JTCM.DAL.Repositories
{
    public static class Mapping
    {
        public static void MapWorkflowRole(WorkflowRole ds, WorkflowRoleModel sc)
        {
            ds.Name = sc.Name;
        }
    }
}