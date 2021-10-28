using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Domain.Interfaces.Rerpositories
{
    public interface ICategoriaRepository
    {
        Task<IEnumerable<Categoria>> ObterTodos();
    }
}