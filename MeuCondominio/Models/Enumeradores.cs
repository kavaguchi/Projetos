using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeuCondominio.Models
{
    public class Enumeradores
    {
        public enum TipoEndereco
        {
            Principal = 0,
            Residencial = 1,
            Comercial = 2,
            Outros = 3
        }

        public enum TipoTelefone
        {
            Principal = 0,
            Residencial = 1,
            Comercial = 2,
            Recado = 3,
            Outros = 4

        }

        public enum Sexo 
        {   Masculino = 0, 
            Feminino = 1,
            Outros = 2
        }
    }
}