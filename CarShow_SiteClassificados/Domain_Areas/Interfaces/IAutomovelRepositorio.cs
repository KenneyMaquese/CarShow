using System;
using System.Collections;
using System.Collections.Generic;
using Domain_Areas.Entidades;

namespace Domain_Areas.Interfaces
{
    public interface IAutomovelRepositorio : IRepositorioBase<Automovel>
    {
        IList<Automovel> BuscarAutomeveisPorId(Guid id);
    }
}