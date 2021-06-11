using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlifransHealthCare.ViewModels
{
    class PacienteViewModel
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
    }
}
