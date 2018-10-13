using System.Collections.Generic;

namespace GoData.Entities.Entities
{
    public class Organization : BaseEntity
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public List<OrganizationMember> OrganizationMembers { get; set; }
    }
}
