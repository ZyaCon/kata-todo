using MyTodo.API.Models;

namespace MyTodo.API.Services
{
    public interface ITodoService
    {
        public Task<List<Todo>> GetAllTodos();

    }
    public class TodoService : ITodoService
    {
        public Task<List<Todo>> GetAllTodos()
        {
            throw new NotImplementedException();
        }
    }
}
