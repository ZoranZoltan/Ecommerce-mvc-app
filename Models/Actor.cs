using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce_mvc_app.Models
{
    public class Actor
    {
        [Key]

        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage ="Profile picture is required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Fill name is required")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="Name must be beween 3 and 50 chars")]
        public string FullName { get; set; }
        

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        //Poveznice
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
