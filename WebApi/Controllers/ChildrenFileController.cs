using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using WebApi.Data;
using WebApi.Models;


namespace WebApi.Controllers
{
    [ApiController]
    [Route("/children")]
    public class ChildrenFileController :ControllerBase
    {
        private IChildrenService childrenService;

        public ChildrenFileController(IChildrenService service)
        {
            childrenService = service;
        }

        [HttpGet]
        [Route("{Address}")]
        public async Task<ActionResult<IList<Child>>> GetChild([FromRoute] string Address)
        {
            try
            {
                IList<Child> children = await childrenService.GetChildrenAsync(Address);
                return Ok(children);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        
        /*[HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Child>> GetChild([FromRoute] string address, [FromRoute]int id)
        {
            try
            {
                Child child = await childrenService.get(address);
                return Ok(family);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }*/
        
        [HttpDelete]
        [Route("{address}/{CprNumber:int}")]
        public async Task<ActionResult> DeleteChild([FromRoute] string Address, [FromRoute] int CprNumber)
        {
            try
            {
                await childrenService.RemoveChildAsync(CprNumber, Address);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpPost]
        [Route("{Address}")]
        public async Task<ActionResult<Child>> AddChild([FromBody] Child child, [FromRoute] string address)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Child toAdd = await childrenService.AddChildAsync(child, address);
                return Created($"/{toAdd}", toAdd);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        
        /*[HttpPatch]
        [Route("{address}")]
        public async Task<ActionResult<Family>> UpdateFamily([FromBody] Family family)
        {
            try
            {
                Family toUpdate = await familyService.UpdateFamilyAsync(family);
                return Created($"/{toUpdate}", toUpdate);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }*/
    }
}