using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Areas.Entidades
{
    public class Contato
    {
        public Guid Id { get; set; }
        public Guid ClienteId { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }

        public virtual Cliente Clientes { get; set; }
    }
}
