using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoData.Entities.Entities
{
    public class Organization : BaseEntity
    {
        public string Name { get; set; }

        public string Address { get; set; }

        [NotMapped]
        public List<User> Members { get; set; }

        [NotMapped]
        public List<Unit> Units { get; set; }
    }
}
