using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain_Areas.Entidades;
using Domain_Areas.Interfaces;

namespace Data_Areas.EntityFramework.Repositorios
{
    public class LoguinRepositorio : RepositorioBase<Loguin> , ILoguinRepositorio
    {
        public IList<Loguin> BuscaLoguinsPorLog(string log)
        {
            return _contexto.Loguin.Where(x => x.Log == log).ToList();
        }

        public IList<Loguin> BuscaLoguin(string log, string passWorld)
        {
            return _contexto.Loguin.Where(x => x.Log == log && x.Senha == passWorld).ToList();
        }
    }
}
