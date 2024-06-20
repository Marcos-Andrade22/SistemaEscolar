using System.Collections.Generic;

namespace SistemaEscolar1.Models
{
    public class Materia
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        // Relacionamentos
        public ICollection<Nota> Notas { get; set; } // Uma matéria pode ter várias notas
        public ICollection<ProfessorMateria> ProfessoresMaterias { get; set; } // Relacionamento muitos-para-muitos com Professor
    }
}
