using System;
using System.ComponentModel.DataAnnotations;

namespace GoData.Entities.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            Created = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        public DateTime Created { get; protected set;  }

        public DateTime? Modified { get; set; }

        public DateTime? Deleted { get; set; }
    }
}
