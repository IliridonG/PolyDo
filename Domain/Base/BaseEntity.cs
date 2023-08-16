using System.ComponentModel.DataAnnotations;

namespace Domain.Base
{
    public abstract class BaseEntity<TId> : Trackable
    {
        [Key]
        public TId Id { get; protected set; }
        protected BaseEntity(TId id)
        {
            Id = id;

        }
        protected BaseEntity()
        {

        }
    }
}
