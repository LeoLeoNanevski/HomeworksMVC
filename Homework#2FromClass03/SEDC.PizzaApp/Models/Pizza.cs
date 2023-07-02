using SEDC.PizzaApp.Models.Enums;

namespace SEDC.PizzaApp.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public int Price { get; set; }
        public bool IsOnPromotion { get; set; }


        //homework
        public decimal Price { get; set; }
        public PizzaSize PizzaSize { get; set; }
        public bool HasExtras { get; set; }

    }
}
