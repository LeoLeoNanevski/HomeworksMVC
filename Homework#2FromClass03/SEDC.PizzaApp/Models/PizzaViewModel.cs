using SEDC.PizzaApp.Models.Enums;

namespace SEDC.PizzaApp.Models
{
    public class PizzaViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public PizzaSize PizzaSize { get; set; }
        public bool HasExtras { get; internal set; }
    }
}
