using Ninject.Modules;
using Sistema.Cadastro.Aplication.Contracts;
using Sistema.Cadastro.Aplication.Service;
using Sistema.Cadastro.Infra.Connection;
using Sistema.Cadastro.Infra.Contracts;
using Sistema.Cadastro.Infra.Repository;

namespace Sistema.Cadastro.Views
{
    public class FormModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IConnectionFactory>().To<ConnectionFactory>();
            Bind<IUsuarioRepository>().To<UsuarioRepository>();
            Bind<IUsuarioApplication>().To<UsuarioApplication>();
        }

        public static FormModule Create()
        {
            return new FormModule();
        }
    }
}
