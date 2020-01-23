using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JTCM.Model;
using JTMC.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Host;

namespace Api.Controllers
{
    [Produces("application/json")]
    [Route("api/WorkflowRole")]
    public class WorkflowRoleController : Controller
    {
        private readonly IWorkflowRoleService _service;

        public WorkflowRoleController(IWorkflowRoleService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var list = _service.GetAll();

                return Ok(list);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var list = _service.GetById(id);

                if (list == null)
                {
                    return NotFound();
                }
                return Ok(list);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                return BadRequest($"{e.Message}");
            }
        }
        [HttpPost]
        public IActionResult Post([FromBody] WorkflowRoleModel model)
        {
            try
            {
                var result = _service.AddWorkflowRole(model);
                
                return Created("",result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                return BadRequest($"{e.Message}");
            }
        }
        [HttpPut]
        public IActionResult Put([FromBody] WorkflowRoleModel model)
        {
            try
            {
                var result = _service.UpdateWorkflowRole(model);

                return Ok(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                return BadRequest($"{e.Message}");
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
               _service.DeleteWorkflowRole(id);

                return NotFound();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                return BadRequest($"{e.Message}");
            }
        }
        
    }
}