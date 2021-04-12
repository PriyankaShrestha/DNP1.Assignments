using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Data;
using WebApi.Models;


namespace WebApi.Controllers
{
    [ApiController]
    [Route("/adults")]
    public class AdultFileController : ControllerBase
    {
        private IAdultService adultService;

        public AdultFileController(IAdultService service)
        {
            adultService = service;
        }

        [HttpGet]
        [Route("/{address}")]
        public async Task<ActionResult<IList<Adult>>> GetAdults([FromRoute] string Address)
        {
            try
            {
                IList<Adult> adults = await adultService.GetAdultsAsync(Address);
                return Ok(adults);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpGet]
        [Route("{address}/{id:int}")]
        public async Task<ActionResult<Adult>> GetAdult([FromRoute] string address, int id)
        {
            try
            {
                Adult adult = await adultService.GetAdultAsync(id, address);
                return Ok(adult);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteAdult([FromBody] Adult adult, [FromRoute] string address)
        {
            try
            {
                await adultService.RemoveAdultAsync(adult, address);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpPost]
        [Route("/address")]
        public async Task<ActionResult<Adult>> AddAdult([FromBody] Adult adult,[FromRoute] string address)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Adult toAdd = await adultService.AddAdultAsync(adult, address);
                return Created($"/{toAdd}", toAdd);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpPatch]
        [Route("{address}")]
        public async Task<ActionResult<Adult>> UpdateAdult([FromBody] Adult adult, [FromRoute] string address)
        {
            try
            {
                Adult toUpdate = await adultService.UpdateAdultAsync(adult, address);
                return Created($"/{toUpdate}", toUpdate);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        [Route("{address}/{id:int}")]
        public async Task<ActionResult> PostJob([FromBody] Job job, [FromRoute] string address, [FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Job toAdd = await adultService.AddJobAsync(job, address, id);
                return Created($"/{toAdd}", toAdd);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}