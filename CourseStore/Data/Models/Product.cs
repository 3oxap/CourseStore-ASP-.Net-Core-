using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseStore.Data.Models
{
    public class Product
    {
        [BindNever]
        public int Id { get; set; }

        [Display(Name = "Add name")]
        [MinLength(3)]
        [Required(ErrorMessage = "length at least 3 characters")]
        public string name{ get; set; }

        [Display(Name = "Add short description")]
        [MinLength(5)]
        [Required(ErrorMessage = "length at least 5 characters")]
        public string shortDesc { get; set; }

        [Display(Name = "Add long description")]
        [MinLength(10)]
        [Required(ErrorMessage = "length at least 10 characters")]
        public string longDesc { get; set; }

        [Display(Name = "Add img")]
        public string img { get; set; }

        [Display(Name = "Add price")]
        [Required(ErrorMessage = "length at least 1 characters")]
        public ushort price { get; set; }

        [Display(Name = "Is favourite")]
        public bool isFavourite { get; set; }

        [Display(Name = "Available")]
        public bool available { get; set; }

        [Display(Name = "Add category")]
        [Required(ErrorMessage = "length at least 1 characters")]
        public int categoryID { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public virtual Category Category { get; set; }
    }
}
