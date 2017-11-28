using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeuCondominio.Models
{
    public class PessoaJuridica
    {
        public string InscricaoEstadual { get; set; }
        public string CNPJ { get; set; }
        public DateTime DataFundacao { get; set; }
    }
}