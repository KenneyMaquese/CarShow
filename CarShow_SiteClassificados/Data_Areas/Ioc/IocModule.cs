using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Areas.EntityFramework.Repositorios;
using Domain_Areas.Interfaces;
using Ninject.Modules;

namespace Data_Areas.Ioc
{
    public class IocModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof (IRepositorioBase<>)).To(typeof (RepositorioBase<>));
            Bind<IContatoRepositorio>().To<ContatoRepositorio>();
            Bind<IClienteRepositorio>().To<ClienteRepositorio>();
            Bind<ILoguinRepositorio>().To<LoguinRepositorio>();
            Bind<IEnderecoRepositorio>().To<EnderecoRepositorio>();
            Bind<ICadastroDeCliente>().To<ICadastroDeCliente>();
            Bind<IAutomovelRepositorio>().To<AutomovelRepositorio>();

        }
    }
}
