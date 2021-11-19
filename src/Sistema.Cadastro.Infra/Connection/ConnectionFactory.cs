using Sistema.Cadastro.Infra.Contracts;
using System.Data;
using System.Data.SqlClient;

namespace Sistema.Cadastro.Infra.Connection
{
    public class ConnectionFactory : IConnectionFactory
    {
        public IDbConnection Connection()
        {
            return new SqlConnection("Data Source=Reginaldo-PC;Initial Catalog=SistemaCadastro;Integrated Security=True");
        }
    }
}
