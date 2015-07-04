using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain_Areas.Entidades;

namespace Domain_Areas.Interfaces
{
    public interface IEnderecoRepositorio : IRepositorioBase<Endereco>
    {
        List<Endereco> ListaDeEnderecos(Guid id);
    }
}
