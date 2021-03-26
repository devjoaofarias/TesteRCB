using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteRCB.Domains;
using TesteRCB.Interfaces;

namespace TesteRCB.Repositories
{
    public class ImovelRepository : IImovelRepository
    {
        TesteRCBContext ctx = new TesteRCBContext();
        public void Atualizar(int id, Imovel imovel)
        {
            Imovel imovelAtualizado = new Imovel();
            imovelAtualizado.Area = imovel.Area;
            imovelAtualizado.Banheiros = imovel.Banheiros;
            imovelAtualizado.Cep = imovel.Cep;
            imovelAtualizado.Cidade = imovel.Cidade;
            imovelAtualizado.Endereco = imovel.Endereco;
            imovelAtualizado.Estado = imovel.Estado;
            imovelAtualizado.NomeProprietario = imovel.NomeProprietario;
            imovelAtualizado.Numero = imovel.Numero;
            imovelAtualizado.Quartos = imovel.Quartos;
            imovelAtualizado.TelefoneProprietario = imovel.TelefoneProprietario;
            imovelAtualizado.TipoResidencia = imovel.TipoResidencia;
            imovelAtualizado.TituloCasa = imovel.TituloCasa;
            imovelAtualizado.ValorCasa = imovel.ValorCasa;
            ctx.Imovel.Update(imovelAtualizado);
            ctx.SaveChanges();
        }

        public Imovel BuscarPorId(int id)
        {
            return ctx.Imovel.FirstOrDefault(e => e.IdImovel == id);
        }

        public void Cadastrar(Imovel novoImovel)
        {
            ctx.Imovel.Add(novoImovel);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Imovel imovelApagado = new Imovel();
            imovelApagado = BuscarPorId(id);
            ctx.Imovel.Remove(imovelApagado);
            ctx.SaveChanges();
        }

        public List<Imovel> Listar()
        {
            return ctx.Imovel.ToList();
        }
    }
}
