namespace GoData.Entities.Entities
{
    public class OrganizationUnit : BaseEntity
    {
        public int OrganizationId { get; set; }

        public int UnitId { get; set; }

        public Unit Unit { get; set; }
    }
}
