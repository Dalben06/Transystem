﻿using AutoMapper;
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
                var client = _mapper.Map<IEnumerable<ClientModel>>(results);
                return Ok(client);
            }
            catch (System.Exception ex)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco Dados Falhou " + ex.Message);
            }

        }


        [HttpPost]
        public async Task<IActionResult> Post(ClientModel model)
        {
            try
            {
                var Client = _mapper.Map<Client>(model);
                _Repository.add(Client);

                if (await _Repository.SaveChangesAsync())
                    return Created($"/api/client/{Client.Id}", _mapper.Map<ClientModel>(Client));
            }
            catch (System.Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco Dados Falhou");
            }

            return BadRequest();
        }

        [HttpPut("{ClientId}")]
        public async Task<IActionResult> Put(int ClientId, ClientModel model)
        {
            try
            {
                var client = await _Repository.GetClientByIdAsync(ClientId);

                if (client == null)
                {
                    return NotFound();
                }

                var clientw = _mapper.Map<Client>(model);

                _Repository.Update(clientw);
                if (await _Repository.SaveChangesAsync())
                    return Created($"/api/client/{clientw.Id}", _mapper.Map(model, clientw));
            }
            catch (System.Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco Dados Falhou");
            }

            return BadRequest();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var Client = await _Repository.GetClientByIdAsync(id);

                if (Client == null)
                {
                    return NotFound();
                }
                _Repository.Delete(Client);
                if (await _Repository.SaveChangesAsync())
                    return Created($"/api/client/{Client.Id}", _mapper.Map<Client>(Client));
            }
            catch (System.Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco Dados Falhou");
            }

            return BadRequest();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            try
            {
                var results = await _Repository.GetClientByIdAsync(Id);
                var client = _mapper.Map<ClientModel>(results);
                return Ok(client);
            }
            catch (System.Exception ex)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco Dados Falhou " + ex.Message);
            }

        }


        [HttpGet("Name/{Name}")]
        public async Task<IActionResult> GetByName(string Name)
        {
            try
            {
                var results = await _Repository.GetClientAsyncByName(Name);
                var client = _mapper.Map<IEnumerable<ClientModel>>(results);
                return Ok(client);
            }
            catch (System.Exception ex)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco Dados Falhou " + ex.Message);
            }

        }



    }
}
