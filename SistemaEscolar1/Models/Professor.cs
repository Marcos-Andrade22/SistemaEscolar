using System.Collections.Generic;

namespace SistemaEscolar1.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        // Relacionamentos
        public ICollection<ProfessorMateria> ProfessoresMaterias { get; set; } // Relacionamento muitos-para-muitos com Materia
    }
}
