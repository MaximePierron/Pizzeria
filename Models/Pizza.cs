using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace pizzas_mama.Models
{
    public class Pizza
    {
        [JsonIgnore]
        public int PizzaID { get; set; }
        [Display(Name ="Nom")]
        public string nom { get; set; }
        [Display(Name ="Prix(€)")]
        public float prix { get; set; }
        [Display(Name="Végétarienne")]
        public bool vegetarienne { get; set; }
        [Display(Name="Ingrédients")]
        [JsonIgnore]
        public string ingredients { get; set; }
        [JsonPropertyName("ingredients")]
        public string[] ingredientsList
        {
            get
            {
                if((ingredientsList == null) || (ingredientsList.Count == 0))
                {
                    return null;
                }
                return ingredientsList.Split(", ");
            }
        }
    }
}
