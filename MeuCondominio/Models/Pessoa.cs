using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MeuCondominio.Models;

namespace MeuCondominio.Models
{
    public class Pessoa
    {
        public Int64 Id { get; set; }
        public string Nome { get; set; }
        public IList<Endereco.Endereco> Endereco { get; set; }
        public IList<Endereco.Telefone> Telefone { get; set; }
    }
}