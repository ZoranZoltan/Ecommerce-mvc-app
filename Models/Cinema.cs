using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace Ecommerce_mvc_app.Models
{
    public class Cinema
    {
        [Key]

        public int Id { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Poveznice
        public List<Movie> Movies { get; set; }
    }
}
