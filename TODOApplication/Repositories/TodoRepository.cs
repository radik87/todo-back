using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TODOApplication.Models;

namespace TODOApplication.Repositories
{
    public class TodoRepository
    {
        private readonly TODOContext _todoContext;

        public TodoRepository(TODOContext todoContext)
        {
            _todoContext = todoContext;
        }

        public async Task<List<TaskTodo>> Get()
        {
            return await _todoContext.TaskTodos.ToListAsync();
        }

        public async Task<TaskTodo> Create(TaskTodo tasktodo)
        {
            _todoContext.TaskTodos.Add(tasktodo);
            await _todoContext.SaveChangesAsync();

            return tasktodo;
        }

        public async Task<TaskTodo> Update(TaskTodo tasktodo)
        {
            _todoContext.Entry(tasktodo).State = EntityState.Modified;
            await _todoContext.SaveChangesAsync();

            return tasktodo;
        }

        public async Task Delete(int id)
        {
            TaskTodo taskTodo = new TaskTodo { Id = id };
            _todoContext.Entry(taskTodo).State = EntityState.Deleted;
            await _todoContext.SaveChangesAsync();
        }
    }
}