using GoData.Entities.Enums;
using System.Collections.Generic;

namespace GoData.Entities.Entities
{
    public class User : BaseEntity
    {
        public string UserId { get; set; }

        public int OrganizationId { get; set; }

        public int UnitId { get; set; }

        public List<Roles> Roles { get; set; }
    }
}
