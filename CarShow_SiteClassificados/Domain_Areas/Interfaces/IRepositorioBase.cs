using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Areas.Interfaces
{
    public interface IRepositorioBase<TEntidade> where TEntidade : class
    {
        void Criar(TEntidade entidade);
        void Excluir(TEntidade entidade);
        void Editar(TEntidade entidade);
        TEntidade Buscar(Guid id);
        void Commit();
        //List<TEntidade> BuscarLista(int id);
    }
}