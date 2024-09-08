using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BulkyBook.Models {
    public class Product {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Title")]
        public string Title { get; set; }
        [Required]
        [DisplayName("Description")]
        public string Description { get; set; }
        [Required]
        public string ISBN {  get; set; }
        [Required]
        public string Author { get; set; }

        // Prices : 

        //List Price
        [Required]
        [Display(Name = "List Price")]
        [Range(1, 1000)]
        public double ListPrice { get; set; }
        //List Price for 1 - 50 
        [Required]
        [Display(Name = "Price for 1-50")]
        [Range(1, 1000)]
        public double Price { get; set; }
        //List Price for 50+
        [Required]
        [Display(Name = "Price for 50+")]
        [Range(1, 1000)]
        public double Price50 { get; set; }
        //List Price for 100+ 
        [Required]
        [Display(Name = "Price for 100+")]
        [Range(1, 1000)]
        public double Price100 { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }
        public string ImageUrl { get; set; }
    }
}
