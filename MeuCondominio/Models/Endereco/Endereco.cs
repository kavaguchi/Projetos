using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeuCondominio.Models.Endereco
{
    public class Endereco
    {
        public Int64 Id { get; set; }
        public Enumeradores.TipoEndereco TipoEndereco { get; set; }
        public Int64 IdCidade { get; set; }
        public Int64 IdBairro { get; set; }
        public string Logradouro { get; set; }
        public Int64 Numero { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public string Observacao { get; set; }
    }
}