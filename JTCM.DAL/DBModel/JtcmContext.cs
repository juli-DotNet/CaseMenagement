using System;
using Microsoft.EntityFrameworkCore;

namespace JTCM.DAL.DBModel
{
    public class JtcmContext : DbContext
    {
        public JtcmContext(DbContextOptions<JtcmContext> options)
            : base(options)
        { }

        //public DbSet<WorkflowType> WorkflowType { get; set; }
        //public DbSet<UserWorkflowStep> UserWorkflowStep { get; set; }
        //public DbSet<UserWorkflowStepStatus> UserWorkflowStepStatus { get; set; }
        //public DbSet<Workflow> Workflow { get; set; }
        //public DbSet<WorkflowDestination> WorkflowDestination { get; set; }
        //public DbSet<WorkflowPhase> WorkflowPhase { get; set; }
        //public DbSet<WorkflowStep> WorkflowStep { get; set; }
        //public DbSet<WorkflowStepStatus> WorkflowStepStatus { get; set; }
        //public DbSet<WorkflowStepType> WorkflowStepType { get; set; }

        public DbSet<WorkflowRole> WorkflowRole { get; set; }
        public DbSet<WorkflowUser> WorkflowUser { get; set; }
        public DbSet<WorkflowRoleUser> WorkflowRoleUser { get; set; }

    }
}