using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.Base
{
    public class Trackable
    {
        [Required]
        [DefaultValue(true)]
        public bool IsActive { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public int LastUpdatedBy { get; set; }

        public DateTime LastUpdatedDate { get; set; }
    }
}
