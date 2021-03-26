using System;
using System.Collections.Generic;

namespace TesteRCB.Domains
{
    public partial class Veiculo
    {
        public int IdVeiculo { get; set; }
        public string NomeProprietario { get; set; }
        public string TelefoneProprietario { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string AnoVeiculo { get; set; }
        public string CorVeiculo { get; set; }
        public string Kilometragem { get; set; }
        public decimal ValorCarro { get; set; }
        public bool? BancoCouro { get; set; }
        public bool? VidroEletrico { get; set; }
        public bool? ArCondicionado { get; set; }
        public bool? TetoSolar { get; set; }
        public bool? ChavePresencial { get; set; }
        public bool? NavegadorGps { get; set; }
        public bool? ComputadorDeBordo { get; set; }
        public bool? RetrovisorFotocromico { get; set; }
        public bool? CambioAutomatico { get; set; }
        public bool? VolanteMultifuncional { get; set; }
        public bool? Bluetooth { get; set; }
        public bool? Airbags { get; set; }
        public bool? ControleEsp { get; set; }
        public bool? LuzNeblina { get; set; }
    }
}
