using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Areas.Entidades
{
    public class Endereco
    {
        public Guid Id { get; set; }
        public Guid ClienteId { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public int Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        //public virtual ClientePessoaFisica Clientes { get; set; }
    }
}
