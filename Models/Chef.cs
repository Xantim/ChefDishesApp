using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AS_ChefDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefID {get;set;}
        
        [Required]
        public string FirstName {get;set;}
        [Required]
        public string LastName {get;set;}
        
        [Required]
        [PastDate]
        public DateTime DoB {get;set;}
        // public int DishID {get;set;} // you don't need this since nav prop already set on the many table 
        public List<Dish> CreatedDishes {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }

    public class PastDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // You first may want to unbox "value" here and cast to to a DateTime variable!
            
            if (value is DateTime) {
                DateTime v = (DateTime) value;
                if (v <= DateTime.Now) {
                    return ValidationResult.Success;
                }
                else {
                    return new ValidationResult("Date must be in the past");
                }
            } 
            else {
                return new ValidationResult("Date must be a date object");
            }
            
        }
    }
}