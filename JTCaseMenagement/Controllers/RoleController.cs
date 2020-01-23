using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JTMC.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JTCM.Web.Controllers
{
    public class RoleController : Controller
    {
        private readonly IWorkflowRoleService service;
        public RoleController(IWorkflowRoleService _service )
        {
            service = _service;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}