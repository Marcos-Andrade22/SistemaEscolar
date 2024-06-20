using SistemaEscolar1.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SistemaEscolar1.Services
{
    public class AlunoService : IAlunoService
    {
        private readonly HttpClient _httpClient;

        public AlunoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Aluno>> ListarAlunosAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Aluno>>("api/alunos");
        }
    }
}
