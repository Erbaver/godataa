using System.Collections.Generic;

namespace GoData.Entities.Entities
{
    public class Unit : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<UnitMember> Members { get; set; }

        public virtual ICollection<DataForm> DataForms { get; set; }

        public virtual ICollection<FormTemplate> FormTemplates { get; set; }

        public OrganizationUnit Organization { get; set; }
    }
}