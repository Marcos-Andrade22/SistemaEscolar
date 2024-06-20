using System.Collections.Generic;

namespace SistemaEscolar1.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }

        // Relacionamentos
        public ICollection<Nota> Notas { get; set; } // Um aluno pode ter várias notas
    }
}
