using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersData.Web.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Display(Name = "Отдел"),
         Required(ErrorMessage = "Обязательно для заполнения")]
        public string Name { get; set; }

        [Display(Name = "Этаж"),
         Required(ErrorMessage = "Обязательно для заполнения"),
         Range(-10,200)]
        public int Floor { get; set; }

        public override string ToString() => Name;
    }
}
