using System.Collections.Generic;
using System.Threading.Tasks;
using TODOApplication.Models;
using TODOApplication.Repositories;

namespace TODOApplication.Services
{
    public class TodoService
    {
        private readonly TodoRepository _todoRepository;

        public TodoService(TodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task<TaskTodo> Create(TaskTodo tasktodo)
        {
            return await _todoRepository.Create(tasktodo);
        }

        public async Task<TaskTodo> Update(TaskTodo tasktodo)
        {
            return await _todoRepository.Update(tasktodo);
        }

        public async Task Delete(int id)
        {
            await _todoRepository.Delete(id);
        }

        public async Task<List<TaskTodo>> Get()
        {
            return await _todoRepository.Get();
        }
    }
}
