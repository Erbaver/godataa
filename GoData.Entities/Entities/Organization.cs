using System.Collections.Generic;

namespace GoData.Entities.Entities
{
    public class Organization : BaseEntity
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public ICollection<OrganizationMember> Members { get; set; }

        public ICollection<OrganizationUnit> Units { get; set; }

        public ICollection<DataForm> DataForms { get; set; }

        public ICollection<FormTemplate> FormTemplates { get; set; }

    }
}
