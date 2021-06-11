using System;
using System.Collections.Generic;
using System.Text;

namespace OlifransHealthCare.DataAccessLayer
{
    public class Consulta
    {
        public int Id { get; set; }
        public int MedicoId { get; set; }
        public int EspecialidadeId { get; set; }
        public int PacienteId { get; set; }
        public DateTime DataConsulta { get; set; }
        public float ValorConsulta { get; set; }
        public string Observacao { get; set; }

        //public ICollection<Estudante> Estudante { get; set; } = new HashSet<Estudante>();
        //public ICollection<Exame> Exame { get; set; } = new HashSet<Exame>();

    }
}
