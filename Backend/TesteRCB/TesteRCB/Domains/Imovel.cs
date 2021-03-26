using System;
using System.Collections.Generic;

namespace TesteRCB.Domains
{
    public partial class Imovel
    {
        public int IdImovel { get; set; }
        public string TituloCasa { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Numero { get; set; }
        public string Endereco { get; set; }
        public decimal ValorCasa { get; set; }
        public string Area { get; set; }
        public string NomeProprietario { get; set; }
        public string TelefoneProprietario { get; set; }
        public int Quartos { get; set; }
        public int Banheiros { get; set; }
        public string TipoResidencia { get; set; }
    }
}
