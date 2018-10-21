using System.Collections.Generic;

namespace GoData.Entities.Entities
{
    public class User : BaseEntity
    {
        
        public string UserObjectId { get; set; }

        public int DefaultOrganization { get; set; }

        public ICollection<Role> Roles { get; set; }

        public ICollection<OrganizationMember> Organizations { get; set; }

        public ICollection<UnitMember> Units { get; set; }

    }
}
