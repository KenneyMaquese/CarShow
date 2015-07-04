using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain_Areas.Entidades;
using Domain_Areas.Interfaces;

namespace Data_Areas.EntityFramework.Repositorios
{
    public class ContatoRepositorio : RepositorioBase<Contato> , IContatoRepositorio
    {
        public List<Contato> ListaDeContatos(int id)
        {
            return _contexto.Contato.ToList();
        }
    }
}
