using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain_Areas.Entidades;

namespace Data_Areas.EntityFramework.Maps
{
    class ContatoMap : EntityTypeConfiguration<Contato>
    {
        public ContatoMap()
        {
            HasKey(x => x.Id);
            HasRequired(x => x.Cliente);
        }
    }
}