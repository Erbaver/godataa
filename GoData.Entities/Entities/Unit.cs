using System.Collections.Generic;

namespace GoData.Entities.Entities
{
    public class Unit : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<UnitMember> Members { get; set; }

        public ICollection<DataForm> DataForms { get; set; }

        public ICollection<FormTemplate> FormTemplates { get; set; }

        public OrganizationUnit Organization { get; set; }
    }
}