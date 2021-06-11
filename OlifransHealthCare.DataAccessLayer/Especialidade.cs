using System;
using System.Collections.Generic;
using System.Text;


namespace OlifransHealthCare.DataAccessLayer
{
    public class Especialidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string DescricaoEspecialidade { get; set; }

        //public ICollection<ExameResultado> ExameResultado { get; set; } = new HashSet<ExameResultado>();
    }
}
