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
        public int Marca { get; set; }
        //public Bitmap Imagem { get; set; }
        
        public Cliente Clientes { get; set; } 
    }
}
