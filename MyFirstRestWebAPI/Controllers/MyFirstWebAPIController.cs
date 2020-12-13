using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyFirstRestWebAPI.Data;
using MyFirstRestWebAPI.Dtos;
using MyFirstRestWebAPI.Models;

namespace MyFirstRestWebAPI.Controllers
{
    [Route("api/myfirstrestwebapi")]
    [ApiController]
    public class MyFirstWebAPIController : ControllerBase
    {
        private readonly IMyFirstRestWebAPIRepo _repository;
        private readonly IMapper _mapper;

        public MyFirstWebAPIController(IMyFirstRestWebAPIRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //private readonly MockMyFirstWebAPIRepo _repository = new MockMyFirstWebAPIRepo();

        //GET api/myfirstwebapi
        [HttpGet]
        public ActionResult <IEnumerable<MyFirstRestWebAPIReadDTO>> GetItems()
        {
            var commandItems = _repository.GetItems();
            return Ok(_mapper.Map<IEnumerable<MyFirstRestWebAPIReadDTO>>(commandItems));
        }

        //GET api/myfirrstwebapi/{id}
        [HttpGet("{id}", Name = "GetItemById")]
        public ActionResult<MyFirstRestWebAPIReadDTO> GetItemById(int id)
        {
            var commandItem = _repository.GetItemById(id);

            if (commandItem != null)
            {
                return Ok(_mapper.Map<MyFirstRestWebAPIReadDTO>(commandItem));
            }
            return NotFound();
        }

        //POST api/myfirrstwebapi
        [HttpPost]
        public ActionResult<MyFirstRestWebAPIReadDTO> CreateItem(MyFirstRestWebAPICreateDTO myFirstRestWebAPICreateDTO)
        {
            var itemModel = _mapper.Map<Command>(myFirstRestWebAPICreateDTO);
            _repository.CreateItem(itemModel);
            _repository.SaveChanges();

            var myFirstRestWebAPIReadDTO = _mapper.Map<MyFirstRestWebAPIReadDTO>(itemModel);

            return CreatedAtRoute(nameof(GetItemById), new { Id = myFirstRestWebAPIReadDTO.Id }, myFirstRestWebAPIReadDTO);
            //return Ok(myFirstRestWebAPIReadDTO);
        }

        //PUT api/myfirrstwebapi/{id}
        [HttpPut("{id}")]
        public ActionResult Update(int id, MyFirstRestWebAPIUpdateDTO myFirstRestWebAPIUpdateDTO)
        {
            var itemModelFromRepo = _repository.GetItemById(id);
            if(itemModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(myFirstRestWebAPIUpdateDTO, itemModelFromRepo);
            _repository.Update(itemModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }
    }
}
