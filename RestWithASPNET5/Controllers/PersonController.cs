using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWithASPNET5.Models;
using RestWithASPNET5.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNET5.Controllers
{   [ApiVersion("1")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private IPersonBusiness _personBusiness;

        public PersonController(ILogger<PersonController> logger, IPersonBusiness personBusiness)
        {
            _logger = logger;
            _personBusiness = personBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var persons = _personBusiness.FindAll();
            return Ok(persons);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(long id) {
            var person = _personBusiness.FindById(id);
            if(person == null) return NotFound();
            return Ok(person);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Person person) 
        {
            var newPerson = _personBusiness.Create(person);
            if(newPerson == null) return BadRequest();
            return Ok(newPerson);
        }
        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            var newPerson = _personBusiness.Update(person);
            if (newPerson == null) return BadRequest();
            return Ok(newPerson);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var newPerson = _personBusiness.FindById(id);
            if (newPerson == null) return NotFound();
            _personBusiness.Delete(id);
            return NoContent();

        }
    }
}
