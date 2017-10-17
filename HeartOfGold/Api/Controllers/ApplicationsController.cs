using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HeartOfGold.Business.Writers;
using HeartOfGold.Business.Readers;
using HeartOfGold.Business.Models;
using AutoMapper;
using HeartOfGold.DataAccess.Entities;

namespace HeartOfGold.Api.Controllers
{
    [Route("api/[Controller]")]
    public class ApplicationsController : Controller
    {
        private IApplicationWriter writer;
        private IApplicationReader reader;

        public ApplicationsController(IApplicationWriter applicationWriter, IApplicationReader applicationReader)
        {
            writer = applicationWriter;
            reader = applicationReader;
        }
        // GET /applications
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var result = await reader.GetAll();

                return Ok(result);
            }
            catch (BusinessException ex)
            {
                return BadRequest(ex.ErrorMessage);
            }
        }
        // Get /applications/id
        [Route("{id}:int")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var result = await reader.Get(id);
                if (result == null)
                {
                    return NotFound("Applicatie werd niet gevonden");
                }
                return Ok(result);
            }
            catch (BusinessException ex)
            {
                return BadRequest(ex.ErrorMessage);
            }
        }

        //Put /applications/id
        [HttpPut]
        [Route("{id}:int")]
        public async Task<IActionResult> Put(int id, [FromBody] ApplicationModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var entity = Mapper.Map<Application>(model);
                writer.Update(entity, id);
                return Ok(model);
            }
            catch (BusinessException ex)
            {
                return BadRequest(ex.ErrorMessage);
            }
            catch (Exception ex)
            {
                //toDo:: Map internalserver error
                return BadRequest(ex.Message);
            }
        }

        //Post /applications
        [HttpPost]
        [Route("{id}:int")]
        public async Task<IActionResult> Post ([FromBody] ApplicationModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var entity = Mapper.Map<Application>(model);
                writer.Insert(entity);
                return Ok(model);
            }
            catch (BusinessException ex)
            {
                return BadRequest(ex.ErrorMessage);
            }
            catch(Exception ex)
            {
                //toDo:: Map internalServer error
                return BadRequest(ex.Message);
            }
        }
    }
}