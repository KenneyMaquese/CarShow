using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Data_Areas.EntityFramework.Maps;
using Domain_Areas.Entidades;

namespace Data_Areas.EntityFramework.Contexto
{
    public class ContextoDb : DbContext
    {
        //Set a Classe que vai criar uma tabela
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Loguin> Loguin { get; set; }
        public DbSet<Contato> Contato { get; set; } 
        public DbSet<Automovel> Automovel { get; set; }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new ContatoMap());
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new EnderecoMap());
            modelBuilder.Configurations.Add(new LoguinMap());
            modelBuilder.Configurations.Add(new AutomovelMap());
        }
    }
}
