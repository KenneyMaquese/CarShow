using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Data_Areas.EntityFramework.Repositorios;
using Domain_Areas.Entidades;
using Domain_Areas.Enumeradores;
using Domain_Areas.Interfaces;
using Domain_Areas.Messeges;


namespace Aplication_Areas.CadastroCliente
{
    public class CadastroCliente
    {
        private readonly ILoguinRepositorio _loguinRepositorio;
        private readonly IClienteRepositorio _clienteFisicoRepositorio;

        private bool _palavraPasseIgual { get; set; }
        private bool _logDuplicado { get; set; }

        public CadastroCliente(ILoguinRepositorio loguinRepositorio,
            IClienteRepositorio clienteFisicoRepositorio)
        {
            _clienteFisicoRepositorio = clienteFisicoRepositorio;
            _loguinRepositorio = loguinRepositorio;
        }
        //Criar metodos aqui ou importar de interfaces 
        public void AdicionarLoguin(Loguin loguin)
        {
            _palavraPasseIgual = VerificaPassWorldIgual(loguin.Senha, loguin.SenhaAntiga);

            if (_palavraPasseIgual)
            {
                var loguins = _loguinRepositorio.BuscaLoguinsPorLog(loguin.Log);

                if (loguins.Count > 0)
                {
                    _logDuplicado = true;
                }

                if (!_logDuplicado)
                {
                    try
                    {
                        loguin.Cliente.ClienteId = CriaIdentidade();
                        loguin.Id = CriaIdentidade();
                        _clienteFisicoRepositorio.Criar(loguin.Cliente);
                        _loguinRepositorio.Criar(loguin);
                        _clienteFisicoRepositorio.Commit();

                    }
                    catch (Exception e )
                    {
                        
                        throw;
                    }
                    
                }
                
            }
        }

        public SelectList CarregaTipoDeCliente()
        {
            IDictionary<String,int> lista = new Dictionary<string, int>();
            lista.Add(BoxMesseges.Selecione,0);
            lista.Add(BoxMesseges.ClientePessoaFisica, 1);
            lista.Add(BoxMesseges.ClientePessoaJuridica,2);

            return new SelectList(lista, "Value", "Key");
        }

        public Guid CriaIdentidade()
        {
            return Guid.NewGuid();
        }

        public bool VerificaPassWorldIgual(string passe, string confirmapasse)
        {
            return (passe.Equals(confirmapasse));
        }

    }
}
