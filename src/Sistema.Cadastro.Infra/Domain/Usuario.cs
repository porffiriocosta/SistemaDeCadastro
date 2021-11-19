using System;

namespace Sistema.Cadastro.Infra.Domain
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public decimal Altura { get; set; }
        public string Escolaridade { get; set; }
        public string Profissao { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }
        public decimal Renda { get; set; }
        public bool Deficiencia { get; set; }
        public string Descricao { get; set; }
        public string Observacao { get; set; }

        //public Endereco Endereco { get; set; }
    }
}
