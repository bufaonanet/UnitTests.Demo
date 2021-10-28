using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoApp.Data.Context;
using ToDoApp.Domain.Entities;
using ToDoApp.Domain.Interfaces.Rerpositories;

namespace ToDoApp.Data.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly DataContext _context;

        public CategoriaRepository(DataContext context) =>
            _context = context;

        public async Task<IEnumerable<Categoria>> ObterTodos()
        {
            return await _context.Categorias
                .AsNoTracking()
                .ToListAsync();
        }
    }
}