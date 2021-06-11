using System;
using System.Collections.Generic;
using System.Text;

namespace OlifransHealthCare.DataAccessLayer
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string DocumentoIndentificadorTipo { get; set; }
        public string NumeroDocumentoIndentificador { get; set; }
        public string Endereco { get; set; }
        public string EnderecoNumero { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Peso { get; set; }
        public string Altura { get; set; }
        public string Imc { get; set; }
        public string UsuarioNome { get; set; }
        public string Senha { get; set; }
        public string CVNomeArquivo { get; set; }
        public string ImagemNomeArquivo { get; set; }

        //public int MedicoId { get; set; }
        //public int? GroupsId { get; set; }
        //public Groups Groups { get; set; }
        //public ICollection<ExameResultado> ExameResultado { get; set; } = new HashSet<ExameResultado>();
        //public ICollection<Groups> Groups { get; set; } = new HashSet<Groups>();
    }
}
