using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteRCB.Domains;
using TesteRCB.Interfaces;
using TesteRCB.Repositories;

namespace TesteRCB.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ImovelController : ControllerBase
    {
        private IImovelRepository _imovelRepository;

        public ImovelController()
        {
            _imovelRepository = new ImovelRepository();
        }

        /// <summary>
        /// Listar todos imóveis
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_imovelRepository.Listar());
        }

        /// <summary>
        /// Listar um imóvel específico(id)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_imovelRepository.BuscarPorId(id));
        }

        /// <summary>
        /// Cadastrar um imóvel
        /// </summary>
        /// <param name="novoImovel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(Imovel novoImovel)
        {
            _imovelRepository.Cadastrar(novoImovel);
            return StatusCode(200);
        }

        /// <summary>
        /// Deletar um imóvel(id)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _imovelRepository.Deletar(id);
            return StatusCode(200);
        }

        /// <summary>
        /// Alterar um imóvel(id)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="imovel"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Imovel imovel)
        {
            _imovelRepository.Atualizar(id, imovel);
            return StatusCode(200);
        }
    }
}
