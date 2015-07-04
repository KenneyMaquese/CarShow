using System;
using System.Collections.Generic;
using System.Linq;
using Domain_Areas.Entidades;
using Domain_Areas.Interfaces;

namespace Data_Areas.EntityFramework.Repositorios
{
    public class AutomovelRepositorio : RepositorioBase<Automovel>, IAutomovelRepositorio
    {
        public IList<Automovel> BuscarAutomeveisPorId(Guid id)
        {
            return _contexto.Automovel.Where(x => x.ClienteId == id).OrderBy(x => x.TipoAutomovel).ToList();
        }
    }
}