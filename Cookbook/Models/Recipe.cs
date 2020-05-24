using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CookingTime { get; set; }
        public MealType MealType { get; set; }
        public List<Product> Products { get; set; }
        //ocena musi być obliczana na podstawie ocen użytkowników. Potrzebna będzie dodatkowa tabela albo sposób uzyskiwania oceny przepisu.
        //Bardziej zawiłe zagadnienia zostawię na później
        //public int Rating { get; set; }
    }
}
