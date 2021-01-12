using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseStore.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name ="Add name")]
        [MinLength(3)]
        [Required(ErrorMessage = "length at least 3 characters")]
        public string name { get; set; }
        [Display(Name = "Add surname")]
        [MinLength(5)]
        [Required(ErrorMessage = "length at least 3 characters")]
        public string surname { get; set; }
        [Display(Name = "Add adres")]
        [MinLength(6)]
        [Required(ErrorMessage = "length at least 6 characters")]
        public string adress { get; set; }
        [Display(Name = "Add phone")]
        [DataType(DataType.PhoneNumber)]
        [MinLength(11)]
        [Required(ErrorMessage = "length at least 11 characters")]
        public string phone { get; set; }
        [Display(Name = "Add email")]
        [MinLength(6)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "length at least 6 characters")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}
