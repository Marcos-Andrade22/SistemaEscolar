using SistemaEscolar1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaEscolar1.Services
{
    public interface IAlunoService
    {
        Task<List<Aluno>> ListarAlunosAsync();
    }
}
