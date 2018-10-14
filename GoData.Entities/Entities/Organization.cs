using System.Collections.Generic;

namespace GoData.Entities.Entities
{
    public class Organization : BaseEntity
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public virtual ICollection<OrganizationMember> Members { get; set; }

        public virtual ICollection<OrganizationUnit> Units { get; set; }

        public virtual ICollection<DataForm> DataForms { get; set; }

        public virtual ICollection<FormTemplate> FormTemplates { get; set; }

    }
}
