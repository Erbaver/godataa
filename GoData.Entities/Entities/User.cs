using System.Collections.Generic;

namespace GoData.Entities.Entities
{
    public class User : BaseEntity
    {
        
        public string UserObjectId { get; set; }

        public int DefaultOrganization { get; set; }

        public virtual ICollection<Role> Roles { get; set; }

        public virtual ICollection<OrganizationMember> Organizations { get; set; }

        public virtual ICollection<UnitMember> Units { get; set; }

    }
}
