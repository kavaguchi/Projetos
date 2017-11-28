using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeuCondominio.Models
{
    public class PessoaFisica: Pessoa
    {
        public string RG { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public Enumeradores.Sexo Sexo { get; set; }
    }
}