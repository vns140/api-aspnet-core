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
using Microsoft.Extensions.Configuration;

namespace Integracao.Application.Controllers
{
    [Route("api/convites")]
    public class ConvitesController : Controller
    {
        private readonly IConviteRepository _conviteRepository;
        private readonly IEmailService _emailService;
        private readonly IMapper _mapper;
        public static IConfiguration _configuration;

        public ConvitesController(IConviteRepository conviteRepository, IEmailService emailService, IMapper mapper, IConfiguration configuration)
        {
            _conviteRepository = conviteRepository;
            _emailService = emailService;
            _mapper = mapper;
            _configuration = configuration;
        }

        /// <summary>
        /// Obtêm todos os valores
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Obtêm por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Envia um convite para um cliente
        /// </summary>
        /// <param name="conviteModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task Post([FromBody]ConviteModel conviteModel)
        {
            try
            {
                Convite convite = _mapper.Map<Convite>(conviteModel);
                if(convite.Valido)
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
