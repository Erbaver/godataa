using GoData.Entities.Enums;

namespace GoData.Entities.Entities
{
    public class OrganizationMember : BaseEntity
    {
        public string UserId { get; set; }

        public int OrganizationId { get; set; }

        public Roles Role { get; set; }
    }
}
