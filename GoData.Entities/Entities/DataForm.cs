using GoData.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace GoData.Entities.Entities
{
    public class DataForm : BaseEntity
    {
        public int OrganizationId { get; set; }

        public string Name { get; set; }

        [MaxLength]
        public string Response { get; set; }

        public DataFormStatus Status { get; set; }
    }
}
