using GoData.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace GoData.Entities.Entities
{
    public class DataForm : BaseEntity
    {
        public string Name { get; set; }

        [MaxLength]
        public string Response { get; set; }

        public DataFormStatus Status { get; set; }

        public virtual Organization Organization { get; set; }

        public int OrganizationId { get; set; }

        public virtual Unit Unit { get; set; }

        public int UnitId { get; set; }
    }
}
