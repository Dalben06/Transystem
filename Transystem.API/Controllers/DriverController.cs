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
    public class DriverController : ControllerBase
    {

        public IDriverRepository _Repository { get; }
        public IMapper _mapper { get; }

        public DriverController(IDriverRepository repository, IMapper mapper)
        {
            _Repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var results = await _Repository.GetAllDriverAsync();
                var Driver = _mapper.Map<IEnumerable<DriverModel>>(results);
                return Ok(Driver);
            }
            catch (System.Exception ex)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco Dados Falhou " + ex.Message);
            }

        }


        [HttpPost]
        public async Task<IActionResult> Post(DriverModel model)
        {
            try
            {
                var Driver = _mapper.Map<Driver>(model);
                _Repository.add(Driver);

                if (await _Repository.SaveChangesAsync())
                    return Created($"/api/Driver/{Driver.Id}", _mapper.Map<DriverModel>(Driver));
            }
            catch (System.Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco Dados Falhou");
            }

            return BadRequest();
        }

        [HttpPut("{DriverId}")]
        public async Task<IActionResult> Put(int DriverId, DriverModel model)
        {
            try
            {
                var Driver = await _Repository.GetDriverByIdAsync(DriverId);

                if (Driver == null)
                {
                    return NotFound();
                }

                var Driverw = _mapper.Map<Driver>(model);

                _Repository.Update(Driverw);
                if (await _Repository.SaveChangesAsync())
                    return Created($"/api/Driver/{Driverw.Id}", _mapper.Map(model, Driverw));
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
                var Driver = await _Repository.GetDriverByIdAsync(id);

                if (Driver == null)
                {
                    return NotFound();
                }
                _Repository.Delete(Driver);
                if (await _Repository.SaveChangesAsync())
                    return Created($"/api/Driver/{Driver.Id}", _mapper.Map<Driver>(Driver));
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
                var results = await _Repository.GetDriverByIdAsync(Id);
                var Driver = _mapper.Map<DriverModel>(results);
                return Ok(Driver);
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
                var results = await _Repository.GetDriverAsyncByName(Name);
                var Driver = _mapper.Map<IEnumerable<DriverModel>>(results);
                return Ok(Driver);
            }
            catch (System.Exception ex)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco Dados Falhou " + ex.Message);
            }

        }

    }
}
