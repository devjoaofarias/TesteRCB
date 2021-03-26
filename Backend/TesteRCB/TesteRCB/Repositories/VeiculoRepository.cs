using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteRCB.Domains;
using TesteRCB.Interfaces;

namespace TesteRCB.Repositories
{
    public class VeiculoRepository : IVeiculoRepository
    {
        TesteRCBContext ctx = new TesteRCBContext();
        public void Atualizar(int id, Veiculo veiculo)
        {
            Veiculo veiculoAtualizado = new Veiculo();
            veiculoAtualizado = BuscarPorId(id);
            veiculoAtualizado.Airbags = veiculo.Airbags;
            veiculoAtualizado.AnoVeiculo = veiculo.AnoVeiculo;
            veiculoAtualizado.ArCondicionado = veiculo.ArCondicionado;
            veiculoAtualizado.BancoCouro = veiculo.BancoCouro;
            veiculoAtualizado.Bluetooth = veiculo.Bluetooth;
            veiculoAtualizado.CambioAutomatico = veiculo.CambioAutomatico;
            veiculoAtualizado.ChavePresencial = veiculo.ChavePresencial;
            veiculoAtualizado.ComputadorDeBordo = veiculo.ComputadorDeBordo;
            veiculoAtualizado.ControleEsp = veiculo.ControleEsp;
            veiculoAtualizado.CorVeiculo = veiculo.CorVeiculo;
            veiculoAtualizado.Kilometragem = veiculo.Kilometragem;
            veiculoAtualizado.LuzNeblina = veiculo.LuzNeblina;
            veiculoAtualizado.Marca = veiculo.Marca;
            veiculoAtualizado.Modelo = veiculo.Modelo;
            veiculoAtualizado.NavegadorGps = veiculo.NavegadorGps;
            veiculoAtualizado.NomeProprietario = veiculo.NomeProprietario;
            veiculoAtualizado.RetrovisorFotocromico = veiculo.RetrovisorFotocromico;
            veiculoAtualizado.TelefoneProprietario = veiculo.TelefoneProprietario;
            veiculoAtualizado.TetoSolar = veiculo.TetoSolar;
            veiculoAtualizado.ValorCarro = veiculo.ValorCarro;
            veiculoAtualizado.VidroEletrico = veiculo.VidroEletrico;
            veiculoAtualizado.VolanteMultifuncional = veiculo.VolanteMultifuncional;
            ctx.Veiculo.Update(veiculoAtualizado);
            ctx.SaveChanges();
        }

        public Veiculo BuscarPorId(int id)
        {
            return ctx.Veiculo.FirstOrDefault(e => e.IdVeiculo == id);
        }

        public void Cadastrar(Veiculo novoVeiculo)
        {
            ctx.Veiculo.Add(novoVeiculo);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Veiculo veiculoApagado = new Veiculo();
            veiculoApagado = BuscarPorId(id);
            ctx.Veiculo.Remove(veiculoApagado);
            ctx.SaveChanges();
        }

        public List<Veiculo> Listar()
        {
            return ctx.Veiculo.ToList();
        }
    }
}
