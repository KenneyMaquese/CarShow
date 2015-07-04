using System.Collections.Generic;
using Domain_Areas.Entidades;

namespace Domain_Areas.Interfaces
{
    public interface IContatoRepositorio : IRepositorioBase<Contato>
    {
        List<Contato> ListaDeContatos(int id);
    }
}