using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain_Areas.Entidades;
using Domain_Areas.Interfaces;

namespace Data_Areas.EntityFramework.Repositorios
{
    public class EnderecoRepositorio : RepositorioBase<Endereco> , IEnderecoRepositorio
    {
        public List<Endereco> ListaDeEnderecos(Guid id)
        {
            return _contexto.Endereco.Where(x => x.Id == id).ToList();
        }
    }
}
