using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Areas.Entidades
{
    public class Loguin
    {
        public Guid Id { get; set; }
        //public Guid ClienteId { get; set; } retirei o atributo porque o id é pk e fk de cliente
        public String Log { get; set; }
        public String Senha { get; set; }
        public String SenhaAntiga { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
