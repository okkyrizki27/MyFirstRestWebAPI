using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstRestWebAPI.Data;
using MyFirstRestWebAPI.Models;

namespace MyFirstRestWebAPI.Controllers
{
    [Route("api/myfirstrestwebapi")]
    [ApiController]
    public class MyFirstWebAPIController : ControllerBase
    {
        private readonly IMyFirstRestWebAPIRepo _repository;
        public MyFirstWebAPIController(IMyFirstRestWebAPIRepo repository)
        {
            _repository = repository;
        }

        //private readonly MockMyFirstWebAPIRepo _repository = new MockMyFirstWebAPIRepo();

        //GET api/myfirstwebapi
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetItems()
        {
            var commandItems = _repository.GetItems();
            return Ok(commandItems);
        }

        //GET api/myfirrstwebapi/{id}
        [HttpGet("{id}")]
        public ActionResult<Command> GetItemById(int id)
        {
            var commandItem = _repository.GetItemById(id);
            return Ok(commandItem);
        }
    }
}
