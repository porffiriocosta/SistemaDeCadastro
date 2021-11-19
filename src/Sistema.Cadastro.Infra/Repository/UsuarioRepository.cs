using Dapper;
using Sistema.Cadastro.Infra.Contracts;
using Sistema.Cadastro.Infra.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Cadastro.Infra.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IConnectionFactory _connection;

        public UsuarioRepository(IConnectionFactory connection)
        {
            _connection = connection;
        }
        public async Task<IEnumerable<Usuario>> Consultar()
        {
            string sql = "select * from Usuarios";

            IList<Usuario> listUsuario = new List<Usuario>();

            try
            {
                using (var connectionDb = _connection.Connection())
                {
                    connectionDb.Open();

                    var result = await connectionDb.QueryAsync<dynamic>(sql);

                    if (result.Any())
                    {
                        foreach (var item in result.ToList())
                        {
                            var usuario = new Usuario();

                            usuario.Codigo = item.codigo;
                            usuario.Nome = item.nome;
                            usuario.Cpf = item.cpf;
                            usuario.Rg = item.rg;
                            usuario.DataNascimento = item.dataNascimento;
                            usuario.Sexo = item.sexo;
                            usuario.Altura = item.altura;
                            usuario.Escolaridade = item.escolaridade;
                            usuario.Profissao = item.profissao;
                            usuario.Empresa = item.empresa;
                            usuario.Cargo = item.cargo;
                            usuario.Renda = item.renda;
                            usuario.Deficiencia = item.deficiencia;
                            usuario.Descricao = item.descricao;
                            usuario.Observacao = item.observacao;

                            listUsuario.Add(usuario);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return listUsuario;
        }

    }
}
