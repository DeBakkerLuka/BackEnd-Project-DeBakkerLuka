using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PROJECT_QUIZ.Models.Models
{
    public class Person: IdentityUser
    {
        public enum GenderType
        {
            [Display(Name = "Mannelijk")]
            Male = 0,
            [Display(Name = "Vrouwelijk")]
            Female = 1
        }

        [NotMapped]
        [Display(Name = "Geboorte datum")]
        [DataType(DataType.DateTime, ErrorMessage = "Kies een datum")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime? DateOfBirth { get; set; }


        //[EmailAddress(ErrorMessage = "Ongeldig Email adres.")]
        //[DefaultValue("")]
        //public string Email { get; set; }

        //[Required(ErrorMessage = "Een {0} is verplicht")]
        [NotMapped]
        [Display(Name = "Naam")]
        [MaxLength(25)]
        public string Name { get; set; }

        [NotMapped]
        [Display(Name = "Geslacht")]
        //[Required(ErrorMessage = "Verplichte keuze.")]
        [EnumDataType(typeof(GenderType), ErrorMessage = "{0} is geen geldige keuze.")]
        [Range(0, 1, ErrorMessage = "ongeldige keuze")]
        public GenderType Gender { get; set; }


        [NotMapped]
        [ScaffoldColumn(false)]
        public string ImgUrl
        {
            get
            {
                return (this.Name != null) ? "/Images/" + Name.Trim() + ".jpg" : "";
            }
        }

        //public ICollection<PersonsEducations> PersonsEducations { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; } = new List<IdentityUserRole<string>>();
    }
}
