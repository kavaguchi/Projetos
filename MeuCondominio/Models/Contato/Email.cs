using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeuCondominio.Models.Contato
{
    public class Email
    {
        public Int64 Id { get; set; }
        public string Endereco { get; set; }
        public Enumeradores.TipoEmail TipoEmail { get; set; }
    }
}