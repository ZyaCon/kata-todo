namespace MyTodo.API.Models
{
    public class Todo
    {
        public int Id { get; }
        public string Title { get; }
        public int Order { get; }
        public string Url { get; }
        public bool IsCompleted { get; }
    }
}
