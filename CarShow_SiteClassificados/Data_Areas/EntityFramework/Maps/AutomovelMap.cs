using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain_Areas.Entidades;

namespace Data_Areas.EntityFramework.Maps
{
    public class AutomovelMap : EntityTypeConfiguration<Automovel>
    {
        public AutomovelMap()
        {
            HasKey(x => x.AutomovelId);
            HasRequired(x => x.Clientes);
        }
    }
}
