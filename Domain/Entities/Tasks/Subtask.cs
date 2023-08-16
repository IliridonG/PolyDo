using Domain.Base;
using Domain.Entities.Tasks.ValueObjects;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Tasks
{
    public class Subtask : BaseEntity<SubTaskId>
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength]
        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        [Required]
        [DefaultValue(true)]
        public bool IsCompleted { get; set; }

        [ForeignKey("Task")]
        public TaskId TaskId { get; set; }
        public Task Task { get; set; }
    }
}
