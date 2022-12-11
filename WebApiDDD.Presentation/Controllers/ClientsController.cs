using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDDWebAPI.Application.DTO.DTO;
using DDDWebAPI.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApiDDD.Presentation.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientSController : ControllerBase
    {

        private readonly IApplicationServiceClient _applicationServiceClient;


        public ClientSController(IApplicationServiceClient ApplicationServiceClient)
        {
            _applicationServiceClient = ApplicationServiceClient;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceClient.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceClient.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ClientDTO clientDTO)
        {
            try
            {
                if (clientDTO == null)
                    return NotFound();

                _applicationServiceClientE.Add(clientDTO);
                return Ok("ClientE Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ClientDTO clientDTO)
        {
            try
            {
                if (clientDTO == null)
                    return NotFound();

                _applicationServiceClient.Update(clientDTO);
                return Ok("ClientE Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] ClientDTO clientDTO)
        {
            try
            {
                if (clientDTO == null)
                    return NotFound();

                _applicationServiceClient.Remove(clientDTO);
                return Ok("Cliente Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}