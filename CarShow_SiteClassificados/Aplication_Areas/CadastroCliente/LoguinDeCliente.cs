using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Razor.Parser.SyntaxTree;
using Domain_Areas.Entidades;
using Domain_Areas.Interfaces;

namespace Aplication_Areas.CadastroCliente
{
    public class LoguinDeCliente : ILoguinDeCliente
    {
        private readonly ILoguinRepositorio _loguinRepositorio;
        private readonly IClienteRepositorio _clienteFisicoRepositorio;

        public bool Logado { get; private set; }

        #region Construtor
        public LoguinDeCliente(ILoguinRepositorio loguinRepositorio, IClienteRepositorio clienteFisicoRepositorio)
        {
            _loguinRepositorio = loguinRepositorio;
            _clienteFisicoRepositorio = clienteFisicoRepositorio;
            Logado = false;
        }
        #endregion

        #region Metodos Publicos
        public Loguin BuscarLoguin(Loguin loguin)
        {
            var Loguin =  BuscaLoguinPorLogEPassWorld(loguin.Log, loguin.Senha);

            if (Loguin != null)
            {
                Loguin.Cliente = BuscaClienteDoLog(Loguin.Id);
                Logado = true;
            }
            return Loguin;
        }

        public Loguin BuscaLoguinPorLogEPassWorld(string log, string passWorld)
        {            
            var lista = _loguinRepositorio.BuscaLoguin(log, passWorld);
            return lista.Count > 0 ? lista.First() : null;
        }

        #endregion

        private Cliente BuscaClienteDoLog(Guid id)
        {
            return _clienteFisicoRepositorio.Buscar(id);
        }
    }
}
