using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

using Contmatic.Integracao.Application.Models;
using Contmatic.Integracao.Domain.Entidades;
using Contmatic.Integracao.Domain.Interfaces.Repositories;
using Contmatic.Integracao.Infrastructure.CrossCutting;


namespace Integracao.Application.Controllers
{
    [Route("api/convites")]
    public class ConvitesController : Controller
    {
        private readonly IConviteRepository _conviteRepository;
        private readonly IEmailService _emailService;
        private readonly IMapper _mapper;

        public ConvitesController(IConviteRepository conviteRepository, IEmailService emailService, IMapper mapper)
        {
            _conviteRepository = conviteRepository;
            _emailService = emailService;
            _mapper = mapper;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task Post([FromBody]ConviteModel conviteModel)
        {
            try
            {
                Convite convite = _mapper.Map<Convite>(conviteModel);
                await _conviteRepository.EnviarConviteAsync(convite);
                await _emailService.EnviarEmailAsync("Convite Integração Sistemas", "", convite.ClienteSolicitante.Pessoa.Email.Endereco, convite.ClienteConvidado.Pessoa.Email.Endereco, "password", "conta", "servidor", 01);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
