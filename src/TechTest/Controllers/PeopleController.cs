using System;
using Microsoft.AspNetCore.Mvc;
using TechTest.Repositories;
using TechTest.Repositories.Models;

namespace TechTest.Controllers
{
    [Route("api/people")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        public PeopleController(IPersonRepository personRepository)
        {
            this.PersonRepository = personRepository;
        }

        private IPersonRepository PersonRepository { get; }

        [HttpGet]
        public IActionResult GetAll()
        {
            
           
            // TODO: Step 1 below..
            
            var person = PersonRepository.GetAll();
            return Ok(person);

            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            // TODO: Step 2 below..
            
            var person = PersonRepository.Update(id);

            if (person == null)
            {
                return NotFound();
            }

            return Ok(person);
            
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, PersonUpdate personUpdate)
        {
            // TODO: Step 3 below..
            
            
            if (personUpdate.Id != id)
            {
                return NotFound();
            }

            if (PersonRepository.Update(id) == null)
            {
                return NotFound();
            }

            PersonRepository.Update(id);
            return RedirectToAction("Index");

            throw new NotImplementedException();
        }
    }
}