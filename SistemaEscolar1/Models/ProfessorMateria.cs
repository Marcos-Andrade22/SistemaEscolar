namespace SistemaEscolar1.Models
{
    public class ProfessorMateria
    {
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }

        public int MateriaId { get; set; }
        public Materia Materia { get; set; }
    }
}
