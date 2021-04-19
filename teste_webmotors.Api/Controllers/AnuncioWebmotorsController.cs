using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using teste_webmotors.Api.Dtos;
using teste_webmotors.Api.Extensions;
using teste_webmotors.Data;
using teste_webmotors.Domain.Models;
using teste_webmotors.Domain.Models.AnuncioWebmotorsAgregates;
using teste_webmotors.Domain.Models.AnuncioWebmotorsAgregates.Entities;

namespace teste_webmotors.Api.Controllers
{
    [ApiController]
    [Route("api/anuncio")]
    public class AnuncioWebmotorsController : ControllerBase
    {
        private readonly IAnuncioWebmotorsService _anuncioWebmotorsService;
        private readonly IRepositoryQuery _repositoryQuery;
        private readonly IValidatorFactory _validatorFactory;
        private readonly IMapper _mapper;

        public AnuncioWebmotorsController(IAnuncioWebmotorsService anuncioWebmotorsService, IRepositoryQuery repositoryQuery, IValidatorFactory validatorFactory ,IMapper mapper)
        {
            _anuncioWebmotorsService = anuncioWebmotorsService;
            _repositoryQuery = repositoryQuery;
            _validatorFactory = validatorFactory;
            _mapper = mapper;
        }

        /// <summary>
        /// Criar um novo anuncio
        /// </summary>
        /// <param name="anuncioDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> CriarAnuncio([FromBody] AnuncioWebmotorsCreateDto anuncioDto)
        {
            var anuncio = _mapper.Map<AnuncioWebmotors>(anuncioDto);

            await _anuncioWebmotorsService.CriarAnuncio(anuncio);

            return StatusCode(StatusCodes.Status201Created);
        }

        /// <summary>
        /// Atualizar um anuncio existente
        /// </summary>
        /// <param name="anuncioDto"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<ActionResult> AtualizarAnuncio([FromBody] AnuncioWebmotorsUpdateDto anuncioDto)
        {
            var existeAnuncio = _repositoryQuery.Query<AnuncioWebmotors>()
                .FirstOrDefault(x => x.Id == anuncioDto.Id);

            if (existeAnuncio == null)
                return NotFound("Anuncio não encontrado");

            var anuncio = _mapper.Map<AnuncioWebmotors>(anuncioDto);

            await _anuncioWebmotorsService.AtualizarAnuncio(anuncio);

            return Ok();
        }

        /// <summary>
        /// Deletar um anuncio
        /// </summary>
        /// <param name="anuncioId"></param>
        /// <returns></returns>
        [HttpDelete("{anuncioId}")]
        public async Task<ActionResult> DeletarAnuncio([FromRoute] int anuncioId)
        {
            var existeAnuncio = _repositoryQuery.Query<AnuncioWebmotors>()
                .FirstOrDefault(x => x.Id == anuncioId);

            if (existeAnuncio == null)
                return NotFound("Anuncio não encontrado");

            await _anuncioWebmotorsService.DeletarAnuncio(existeAnuncio);

            return Ok();
        }

        /// <summary>
        /// Obter todos os anuncios cadastrados
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IQueryable<AnuncioWebmotors>> ObterAnuncios()
        {
            var anuncios = _repositoryQuery.Query<AnuncioWebmotors>()
                .AsNoTracking();

            return Ok(anuncios);
        }

        /// <summary>
        /// Obter um anuncio cadastrado pelo Id
        /// </summary>
        /// <param name="anuncioId"></param>
        /// <returns></returns>
        [HttpGet("{anuncioId}")]
        public ActionResult<AnuncioWebmotors> ObterAnuncioById([FromRoute] int anuncioId)
        {
            var existeAnuncio = _repositoryQuery.Query<AnuncioWebmotors>()
                .FirstOrDefault(x => x.Id == anuncioId);

            if (existeAnuncio == null)
                return NotFound("Anuncio não encontrado");

            return Ok(existeAnuncio);
        }
    }
}
