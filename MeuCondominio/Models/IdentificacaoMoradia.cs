using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeuCondominio.Models
{
    public class IdentificacaoMoradia
    {
        public Enumeradores.TipoMoradia TipoMoradia { get; set; }
        public string Identificacao { get; set; }
    }
}