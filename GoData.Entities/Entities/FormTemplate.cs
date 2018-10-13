using GoData.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GoData.Entities.Entities
{
    public class FormTemplate : BaseEntity
    {
        public int OrganizationId { get; set; }

        public string Name { get; set; }

        [MaxLength]
        public string FormBody { get; set; }

        public FormTemplateStatus Status { get; set; }

    }
}
