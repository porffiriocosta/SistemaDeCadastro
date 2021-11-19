using Sistema.Cadastro.Infra.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sistema.Cadastro.Infra.Contracts
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> Consultar();       
    }
}
