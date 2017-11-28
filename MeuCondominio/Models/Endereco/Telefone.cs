using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeuCondominio.Models.Endereco
{
    public class Telefone
    {
        public int CodigoArea { get; set; }
        public int DDD { get; set; }
        public Int64 Numero { get; set; }
        public int Ramal { get; set; }
        public Enumeradores.TipoTelefone TipoTelefone { get; set; }
        
    }
}