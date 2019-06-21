using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersData.Web.Models
{
    public class Worker
    {
        public int Id { get; set; }

        [Display(Name = "Имя"),
         Required(ErrorMessage = "Обязательно для заполнения"), 
         StringLength(20,MinimumLength = 2,ErrorMessage = "Минимум три буквы, максимум 20."),
         RegularExpression(@"^\D+$",ErrorMessage = "Не должно содержать чисел.")]
        public string FirstName { get; set; }

        [Display(Name = "Фамилия"),
         Required(ErrorMessage = "Обязательно для заполнения"),
         StringLength(20, MinimumLength = 2, ErrorMessage = "Минимум три буквы, максимум 20."),
         RegularExpression(@"^\D+$", ErrorMessage = "Не должно содержать чисел.")]
        public string LastName { get; set; }

        [Display(Name = "Пол")]
        public Sex Sex { get; set; }

        [Display(Name = "Возраст"),
         Required(ErrorMessage = "Обязательно для заполнения"), 
         Range(12, 120, ErrorMessage = "Возраст от 12 до 120 лет.")]
        public int Age { get; set; }

        [Display(Name = "Отдел")]
        public virtual Department Department { get; set; }

        [Display(Name = "Язык")]
        public virtual Language Language { get; set; }

    }

    public enum Sex
    {
        [Display(Name = "Муж")]
        Male,
        [Display(Name = "Жен")]
        Female
    }
}
