using System;
using System.ComponentModel.DataAnnotations;

namespace AS_ChefDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishID {get;set;}
        [Required]
        public string Name {get;set;}
        [Required]
        [Range(1,int.MaxValue,ErrorMessage = "Please enter a value bigger than {1}")]
        public int Calories {get;set;}
        
        [Required]
        [Range(1,5)]
        public int Tastiness {get;set;}
        
        [Required]
        public string Description {get;set;}
        public int ChefID {get;set;}
        public Chef Creator {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }  
}