using System.Threading.Tasks;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Domain.Interfaces.Services
{
    public interface ITarefaService
    {
        Task<bool> AtualizarTarefa(Tarefa tarefa);

        Task<bool> ConcluirTarefa(Tarefa tarefa);

        Task<bool> CriarTarefa(Tarefa tarefa);

        Task<bool> RemoverTarefa(Tarefa tarefa);
    }
}