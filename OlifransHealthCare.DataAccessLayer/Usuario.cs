using System;
using System.Collections.Generic;
using System.Text;

namespace OlifransHealthCare.DataAccessLayer
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string UsuarioNome { get; set; }
        public string Senha { get; set; }
        public int Funcao { get; set; }

       //public ICollection<Groups> Groups { get; set; } = new HashSet<Groups>();
    }
}
