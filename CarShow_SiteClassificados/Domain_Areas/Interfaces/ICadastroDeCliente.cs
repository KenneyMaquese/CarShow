using System;
using System.Web.Mvc;

namespace Domain_Areas.Interfaces
{
    public interface ICadastroDeCliente
    {
        bool VerificaPassWorldIgual(String passe, String confirmapasse);

        SelectList CarregaTipoDeCliente();

        Guid CriaIdentidade();

    }
}