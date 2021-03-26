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
    public class VeiculoController : ControllerBase
    {
        private IVeiculoRepository _veiculoRepository;

        public VeiculoController()
        {
            _veiculoRepository = new VeiculoRepository();
        }

        /// <summary>
        /// Listar todos os veículos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_veiculoRepository.Listar());
        }

        /// <summary>
        /// Listar um veículo específico(id)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_veiculoRepository.BuscarPorId(id));
        }

        /// <summary>
        /// Cadastrar um veículo
        /// </summary>
        /// <param name="novoVeiculo"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(Veiculo novoVeiculo)
        {
            _veiculoRepository.Cadastrar(novoVeiculo);
            return StatusCode(200);
        }

        /// <summary>
        /// Deletar um veículo(id)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _veiculoRepository.Deletar(id);
            return StatusCode(200);
        }

        /// <summary>
        /// Alterar um veículo(id)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="veiculo"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Veiculo veiculo)
        {
            _veiculoRepository.Atualizar(id, veiculo);
            return StatusCode(200);
        }
    }
}
