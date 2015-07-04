using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain_Areas.Entidades;

namespace Data_Areas.EntityFramework.Maps
{
    class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            HasKey(x => x.ClienteId);
        }
    }
}
