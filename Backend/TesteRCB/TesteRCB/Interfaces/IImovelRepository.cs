using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteRCB.Domains;

namespace TesteRCB.Interfaces
{
    interface IImovelRepository
    {
        List<Imovel> Listar();
        Imovel BuscarPorId(int id);
        void Cadastrar(Imovel novoImovel);
        void Deletar(int id);
        void Atualizar(int id, Imovel imovel);
    }
}
