using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace Cookbook.Models
{
    public class MealType
    {
        [Key]
        public int Id { get; set; }
        public string TypeOfMeal { get; set; }

    }
}
