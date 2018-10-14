using System.Collections.Generic;

namespace GoData.Entities.Entities
{
    public class User : BaseEntity
    {
        
        public int UserObjectId { get; set; }

        public List<Role> Roles { get; set; }

        public virtual ICollection<OrganizationMember> Organizations { get; set; }

        public virtual ICollection<UnitMember> Units { get; set; }

    }
}
