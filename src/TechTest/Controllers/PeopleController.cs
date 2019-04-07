using System;
using System.Collections.Generic;
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
            // TODO: Step 1
            //
            // Implement a JSON endpoint that returns the full list
            // of people from the PeopleRepository. If there are zero
            // people returned from PeopleRepository then an empty
            // JSON array should be returned.
            IEnumerable<Person> persons = new List<Person>();
            persons = PersonRepository.GetAll();

            return this.Ok(persons);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            // TODO: Step 2
            //
            // Implement a JSON endpoint that returns a single person
            // from the PeopleRepository based on the id parameter.
            // If null is returned from the PeopleRepository with
            // the supplied id then a NotFound should be returned.
            var person = PersonRepository.Get(id);

            if (person != null)
            {
                return this.Ok(person);
            }
            // somethig went wrong
            return this.NotFound();
        }


        [HttpPut("{id}")]
        public IActionResult Update(int id, PersonUpdate personUpdate)
        {
            // TODO: Step 3
            //
            // Implement an endpoint that receives a JSON object to
            // update a person using the PeopleRepository based on
            // the id parameter. Once the person has been successfully
            // updated, the person should be returned from the endpoint.
            // If null is returned from the PeopleRepository then a
            // NotFound should be returned.

            // get the original person    
            Person existingPerson = PersonRepository.Get(id);
            // check we have them
            if (existingPerson == null)
            {
                return this.NotFound();
            }
            
            // The PersonRepository needs a Person, so create a new person with the updated details
            Person updatedPerson = new Person() {
                Id = existingPerson.Id,
                FirstName = existingPerson.FirstName,
                LastName = existingPerson.LastName,
                Authorised = personUpdate.Authorised,
                Enabled = personUpdate.Enabled,
                Colours = personUpdate.Colours
            };

            // send the updated details to the Repository
            var response = PersonRepository.Update(updatedPerson);

            return this.Ok(response);
        }
    }
}