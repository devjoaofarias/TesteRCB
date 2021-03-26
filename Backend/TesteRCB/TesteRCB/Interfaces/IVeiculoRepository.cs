using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteRCB.Domains;

namespace TesteRCB.Interfaces
{
    interface IVeiculoRepository
    {
        List<Veiculo> Listar();
        Veiculo BuscarPorId(int id);
        void Cadastrar(Veiculo novoVeiculo);
        void Deletar(int id);
        void Atualizar(int id, Veiculo veiculo);
    }
}
