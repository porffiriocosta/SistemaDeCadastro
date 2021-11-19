using System.Data;

namespace Sistema.Cadastro.Infra.Contracts
{
    public interface IConnectionFactory
    {
        IDbConnection Connection();
    }
}
