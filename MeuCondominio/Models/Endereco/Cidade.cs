using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeuCondominio.Models.Endereco
{
    public class Cidade
    {
        public Int64 Id { get; set; }
        public string Nome { get; set; }
        public int IdUF { get; set; }
        public int CodigoBGE { get; set; }
    }
}