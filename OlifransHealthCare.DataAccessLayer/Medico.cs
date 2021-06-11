using System;
using System.Collections.Generic;
using System.Text;

namespace OlifransHealthCare.DataAccessLayer
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EspecialidadeId { get; set; }
        public string CrmMedico { get; set; }       
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string UsuarioNome { get; set; }
        public string Senha { get; set; }
        public string CVNomeArquivo { get; set; }
        public string ImagemNomeArquivo { get; set; }


        //public int? GroupsId { get; set; }
        //public Groups Groups { get; set; }
        //public ICollection<ExameResultado> ExameResultado { get; set; } = new HashSet<ExameResultado>();
    }
}
