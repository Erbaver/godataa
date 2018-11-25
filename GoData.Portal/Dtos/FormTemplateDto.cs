using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoData.Portal.Dtos
{
    public class FormTemplateDto
    {
        [Required]
        [Display(Name = "Form Name", Prompt = "Enter a name for your organization")]
        public string Name { get; set; }

        [MaxLength]
        [Required]
        public string FormBody { get; set; }
    }
}
