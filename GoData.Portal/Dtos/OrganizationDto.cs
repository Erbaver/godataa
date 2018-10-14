using System.ComponentModel.DataAnnotations;

namespace GoData.Portal.Dtos
{
    public class OrganizationDto
    {
        [Required]
        [Display(Name = "Organization Name", Prompt = "Enter a name for your organization")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Organization Address", Prompt = "Enter an address for your organization")]
        public string Address { get; set; }
    }
}
