using System;
using System.Collections.Generic;
using System.Text;

namespace GoData.Entities.Entities
{
    public class OrganizationMember : BaseEntity
    {
        public int OrganizationId { get; set; }

        public Organization Organization { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
