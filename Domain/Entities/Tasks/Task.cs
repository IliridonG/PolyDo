using Domain.Base;
using Domain.Entities.Tasks.ValueObjects;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Tasks
{
    [Table("Tasks")]
    [Comment("List of tasks")]
    public class Task : BaseEntity<TaskId>
    {
        [Required]
        [MaxLength(50)]
        [Comment("The code of the modules")]
        public string Title { get; set; }

        [Required]
        [MaxLength(50)]
        public string Description { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool IsCompleted { get; set; }

        public List<Subtask> Subtasks { get; set; }

        public Task() {}

        private Task(string title, string description, DateTime dueDate, bool isCompleted, List<Subtask> subtasks)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = isCompleted;
            Subtasks = subtasks;
        }

        public static Task Create(string title, string description, DateTime dueDate, bool isCompleted, List<Subtask> subtasks) 
        {
            return new Task(title, description, dueDate, isCompleted, subtasks);
        }

        public void SetTitle(string title) 
        {
            Title = title;
        }

        public void SetDescription(string description)
        {
            Description = description;
        }

        public void SetDueDate(DateTime dueDate)
        {
            DueDate = dueDate;
        }

        public void SetIsCompleted(bool isCompleted)
        {
            IsCompleted = isCompleted;
        }

        public void SetSubtask(List<Subtask> subtasks)
        {
            Subtasks = subtasks;
        }
    }
}
