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
            
            var people = this.PersonRepository.GetAll();

            
            return this.Ok(people);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            // TODO: Step 2 below..
            
           var person = this.PersonRepository.Get(id);

            if (person == null)
            {
                return NotFound();
            }
            else
            {
                return this.Ok(person);
            }

            
            //throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, PersonUpdate personUpdate)
        {
            // TODO: Step 3 below..
            
           var person = this.PersonRepository.Get(id);

            if (person == null)
            {
                return NotFound();
            }
            else
            {
                this.PersonRepository.Update(person);
                return this.Ok(person);
            }
             
           
            //throw new NotImplementedException();
        }
    }
}