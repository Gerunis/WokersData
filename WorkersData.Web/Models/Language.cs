using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersData.Web.Models
{
    public class Language
    {
        public int Id { get; set; }

        [Display(Name = "Язык программирования"),
         Required(ErrorMessage = "Обязательно для заполнения")]
        public string Name { get; set; }

        public override string ToString() => Name;
        
    }
}
