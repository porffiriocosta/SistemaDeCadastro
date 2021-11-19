using Sistema.Cadastro.Infra.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sistema.Cadastro.Aplication.Contracts
{
    public interface IUsuarioApplication
    {
        Task<IEnumerable<Usuario>> Consultar();
    }
}
