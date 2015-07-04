using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain_Areas.Entidades;
using Domain_Areas.Interfaces;

namespace Aplication_Areas.EditarAutomoveis
{
    public class MeusAnucios
    {
        private IAutomovelRepositorio _automovelRepositorio;
        public MeusAnucios(IAutomovelRepositorio automovelRepositorio)
        {
            _automovelRepositorio = automovelRepositorio;
        }

        public IList<Automovel> ListaAutomoveisDoCliente(Guid idCliete)
        {
           return _automovelRepositorio.BuscarAutomeveisPorId(idCliete);
        }  


    }
}
