namespace GoData.Entities.Entities
{
    public class UnitMember : BaseEntity
    {
        public int UserId { get; set; }

        public User User { get; set; }

        public int UnitId { get; set; }

        public Unit Unit { get; set; }
    }
}
