using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Areas.Entidades
{
    public class Automovel
    {
        public Guid AutomovelId { get; set; }
        public Guid ClienteId { get; set; }
        public int TipoAutomovel { get; set; }
        public String Descricao { get; set; }
        public Decimal Valor { get; set; }

        //public Bitmap Imagem { get; set; }

        public virtual Cliente Cliente { get; set; } 
        public virtual Marca Marca { get; set; }
        
    }
}
