using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Domain_Areas.Entidades;
using Domain_Areas.Interfaces;
using Domain_Areas.Messeges;

namespace Aplication_Areas.EditarAutomoveis
{
    public class MeusAnucios
    {
        private IAutomovelRepositorio _automovelRepositorio;
        private IClienteRepositorio _clienteRepositorio;
        public MeusAnucios(IAutomovelRepositorio automovelRepositorio, IClienteRepositorio clienteRepositorio)
        {
            _automovelRepositorio = automovelRepositorio;
            _clienteRepositorio = clienteRepositorio;
        }

        public IList<Automovel> ListaAutomoveisDoCliente(Guid idCliete)
        {
           return _automovelRepositorio.BuscarAutomeveisPorId(idCliete);
        }

        public SelectList ListaDeTipoDeAutomovel(int tipoAutomovel)
        {
            IDictionary<String, int> lista = new Dictionary<string, int>();
            lista.Add(BoxMesseges.Selecione, 0);
            lista.Add("Carro", 1);
            lista.Add("Moto", 2);
            lista.Add(BoxMesseges.Utilitario, 3);
            lista.Add(BoxMesseges.Caminhao, 4);
            

            return new SelectList(lista, "Value", "Key",tipoAutomovel);
        }

        public void EditarAutomoveis(Automovel automovel)
        {
            _automovelRepositorio.Editar(automovel);
            _automovelRepositorio.Commit();
        }

        public Cliente AcharClientePorId(Guid id)
        {
            return _clienteRepositorio.Buscar(id);
        }

    }
}
