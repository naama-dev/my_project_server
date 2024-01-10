using DAL.Interface;
using Models.Models;
using Microsoft.EntityFrameworkCore;
namespace DAL.Data
{
    public class ToDoData: IToDo
    {
        private readonly DataProjectContext _context;

        public ToDoData(DataProjectContext context)
        {
            _context = context;
        }
        public async Task<List<ToDo>> getAllToDo()
        {
            var tasks = await _context.ToDo.ToListAsync();
            return tasks;
        }
    }
}
