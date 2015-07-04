using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain_Areas.Entidades;

namespace Domain_Areas.Interfaces
{ 
    public interface ILoguinRepositorio: IRepositorioBase<Loguin>
    {
        //
        IList<Loguin> BuscaLoguinsPorLog(String log);
         IList<Loguin> BuscaLoguin(String log, String passWorld);
    }
}
