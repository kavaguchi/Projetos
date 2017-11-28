using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeuCondominio.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }
        public Int64 IdPessoa { get; set; }
    }
}