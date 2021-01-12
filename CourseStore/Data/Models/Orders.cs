using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseStore.Data.Models
{
    public class Orders
    {
        [BindNever]
        public int id { get; set; }
        [Display(Name ="Enter name")]
        [MinLength(4)]
        [Required(ErrorMessage = "Name length less than 4 characters")]
        public string name { get; set; }
        [Display(Name = "Enter surname")]    
        [MinLength(4)]
        [Required(ErrorMessage = "Surname length less than 4 characters")]
        public string surname { get; set; }
        [Display(Name = "Enter adress")]
        [MinLength(4)]
        [Required(ErrorMessage = "Adress length less than 4 characters")]
        public string adress { get; set; }
        [Display(Name = "Enter phone")]
        [MinLength(11)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone length less than 11 characters")]
        public string phone { get; set; }
        [Display(Name = "Enter email")]
        [DataType(DataType.EmailAddress)]
        [MinLength(8)]
        [Required(ErrorMessage = "Email length less than 8 characters")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetails> orderDetails { get; set; }
    }
}
