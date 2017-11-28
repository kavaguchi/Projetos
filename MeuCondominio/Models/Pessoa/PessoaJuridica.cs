using System;

namespace MeuCondominio.Models.Pessoa
{
    public class PessoaJuridica : Pessoa
    {
        public string InscricaoEstadual { get; set; }
        public string CNPJ { get; set; }
        public DateTime DataFundacao { get; set; }
    }
}