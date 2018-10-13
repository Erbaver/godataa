using System;
using System.ComponentModel.DataAnnotations;

namespace GoData.Entities.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Modified { get; set; }

        public DateTime? Deleted { get; set; }
    }
}
