using Sistema.Cadastro.Aplication.Contracts;
using Sistema.Cadastro.Infra.Contracts;
using Sistema.Cadastro.Infra.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sistema.Cadastro.Aplication.Service
{
    public class UsuarioApplication : IUsuarioApplication
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioApplication(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public async Task<IEnumerable<Usuario>> Consultar()
        {
            return await _usuarioRepository.Consultar();
        }
    }
}
