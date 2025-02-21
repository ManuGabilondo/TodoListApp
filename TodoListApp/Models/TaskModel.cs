using System.ComponentModel.DataAnnotations;

namespace TodoListApp.Models
{
    public class TaskModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public bool IsCompleted { get; set; }
    }
}
