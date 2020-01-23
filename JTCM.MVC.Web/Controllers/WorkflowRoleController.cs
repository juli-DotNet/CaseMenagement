using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JTCM.Model;
using JTMC.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JTCM.MVC.Web.Controllers
{
    public class WorkflowRoleController : BaseController
    {
        private readonly IWorkflowRoleService _service;

        public WorkflowRoleController( IWorkflowRoleService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            var result = _service.GetAll();
            return View(result);
         
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(WorkflowRoleModel dt)
        {
           var result= _service.AddWorkflowRole(dt);
            return View(result);
        }
        public IActionResult Edit(int id)
        {
            var result = _service.GetById(id);
            return View(result);
        }
        public IActionResult Delete(int id)
        {
            _service.DeleteWorkflowRole(id);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var model=_service.GetById(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(WorkflowRoleModel dt)
        {
            var result = _service.UpdateWorkflowRole(dt);
            return View(result);
        }
        public IActionResult List()
        {
            var result = _service.GetAll();
            return View(result);
        }

    }
}