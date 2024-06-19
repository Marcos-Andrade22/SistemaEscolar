namespace SistemaEscolar1.Models
{
    public class Nota
    {
        public int Id { get; set; }
        public int Valor { get; set; }

        // Chaves estrangeiras
        public int AlunoId { get; set; }
        public int MateriaId { get; set; }

        // Relacionamentos
        public Aluno Aluno { get; set; } // Uma nota pertence a um aluno
        public Materia Materia { get; set; } // Uma nota pertence a uma matéria
    }
}
