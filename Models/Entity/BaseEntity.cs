using System.ComponentModel.DataAnnotations;

namespace Beety.Domain.Entity
{
    public abstract class BaseEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
