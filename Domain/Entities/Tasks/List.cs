using Domain.Base;
using Domain.Entities.Tasks.ValueObjects;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Tasks
{
    public class List : BaseEntity<ListId>
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [ForeignKey("Task")]
        public int TaskId { get; set; }
        public Task Task { get; set; }
    }
}
