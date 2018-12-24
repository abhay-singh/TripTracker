﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TripTracker.BackService.Models;

namespace TripTracker.BackService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripsController : ControllerBase
    {

        private Repository _repository;
        public TripsController(Models.Repository repository)
        {

            _repository = repository;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Models.Trip> Get()
        {
            return _repository.Get();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Trip> Get(int id)
        {
            return _repository.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Trip value)
        {
            _repository.Add(value);

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Trip value)
        {
            _repository.update(value);

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.remove(id);
        }
    }
}
