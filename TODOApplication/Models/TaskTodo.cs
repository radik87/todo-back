using System;

namespace TODOApplication.Models
{
    public class TaskTodo
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime DueDate { get; set; }

        public string Attachment { get; set; }

        public string Summary { get; set; }

        public bool IsCompleted { get; set; } = false;
    }
}
