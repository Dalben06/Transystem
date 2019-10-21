using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transystem.API.Models;
using Transystem.Domain.Entitys;
using Transystem.Repository.Interfaces;

namespace Transystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {

        public IClientRepository _Repository { get; }
        public IMapper _mapper { get; }

        public ClientController(IClientRepository repository, IMapper mapper)
        {
            _Repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var results = await _Repository.GetAllClientAsync();
                var eventos = _mapper.Map<IEnumerable<ClientModel>>(results);
                return Ok(eventos);
            }
            catch (System.Exception ex)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco Dados Falhou " + ex.Message);
            }

        }


        //[HttpPost]
        //public async Task<IActionResult> Post(ClientModel model)
        //{
        //    try
        //    {
        //        var Client = _mapper.Map<Client>(model);
        //        _Repository.add(Client);

        //        if (await _Repository.SaveChangesAsync())
        //            return Created($"/api/evento/{ClientModel.Id}", _mapper.Map<ClientModel>(model));
        //    }
        //    catch (System.Exception)
        //    {

        //        return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco Dados Falhou");
        //    }

        //    return BadRequest();
        //}
    }
}
