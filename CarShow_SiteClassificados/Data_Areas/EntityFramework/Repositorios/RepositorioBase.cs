using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Areas.EntityFramework;
using Data_Areas.EntityFramework.Contexto;
using Domain_Areas.Interfaces;

namespace Data_Areas.EntityFramework.Repositorios
{
    public class RepositorioBase<TEntidade> : IRepositorioBase<TEntidade> where TEntidade : class
    {
        protected ContextoDb _contexto;

        public RepositorioBase()
        {
            _contexto = new ContextoDb();
        } 

        public void Criar(TEntidade entidade)
        {
            _contexto.Set<TEntidade>().Add(entidade);
        }

        public void Excluir(TEntidade entidade)
        {
            _contexto.Set<TEntidade>().Remove(entidade);
        }

        public void Editar(TEntidade entidade)
        {
            _contexto.Entry(entidade).State = EntityState.Modified;
        }

        public TEntidade Buscar(Guid id)
        {
            return _contexto.Set<TEntidade>().Find(id);
        }

        public void Commit()
        {
            _contexto.SaveChanges();
        }
    }
}
