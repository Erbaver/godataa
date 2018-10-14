using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoData.Entities.Entities
{
    public class Unit : BaseEntity
    {
        public string Name { get; set; }

        public int OrganizationId { get; set; }

        [NotMapped]
        public List<User> UnitMembers { get; set; }
    }
}