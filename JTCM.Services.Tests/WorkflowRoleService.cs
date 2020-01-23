using JTCM.DAL.Interfaces;
using JTCM.Model;
using JTMC.Services.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace JTCM.Services.Tests
{
    [TestClass]
    public class WorkflowRoleService
    {
        [TestMethod]
        public void Test_Add_WorkflowRole()
        {
            //mock
            var excepcted = new WorkflowRoleModel
            {
                Id = 1,
                Name = "Test"
            };
            var mock = new Mock<IWorkflowRoleRepository>();
            mock.Setup(p => p.AddWorkflowRole(excepcted)).Returns(excepcted);
            //Initialization
            IWorkflowRoleService ser = new WorkflowRoleSercive(mock.Object);
            //excpeted??
             //Exec   
            var result = ser.AddWorkflowRole(excepcted);
            //Assertion
            Assert.AreEqual("Test", result.Name);
        }
        [TestMethod]
        public void Test_GetById_WorkflowRole()
        {
            //mock
            var excepcted = new WorkflowRoleModel
            {
                Id = 1,
                Name = "Test"
            };
            var mock = new Mock<IWorkflowRoleRepository>();
            mock.Setup(p => p.GetById(1)).Returns(excepcted);
            //Initialization
            IWorkflowRoleService ser = new WorkflowRoleSercive(mock.Object);
            //expected
            //??
            //execution
            var result = ser.GetById(1);
            //Assertions
            Assert.AreEqual(1, result.Id);
        }
        [TestMethod]
        public void Test_Update_WorkflowRole()
        {
            //mock
            var model = new WorkflowRoleModel
            {
                Id = 1,
                Name = "Test"
            };
            var mock = new Mock<IWorkflowRoleRepository>();
            mock.Setup(p => p.UpdateWorkflowRole(model)).Returns(model);

            IWorkflowRoleService ser = new WorkflowRoleSercive(mock.Object);
            var result = ser.UpdateWorkflowRole(model);
            Assert.AreEqual(1, result.Id);
            Assert.AreEqual("Test", result.Name);
        }
    }
}
