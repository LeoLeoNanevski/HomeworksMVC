using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp.Mappers
{
    public static class PizzaMapper
    {
        public static PizzaViewModel MapPizzaToViewModel(Pizza pizza)
        {
            decimal price = pizza.HasExtras ? pizza.Price + 10 : pizza.Price;

            return new PizzaViewModel
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Price = pizza.Price,
                PizzaSize = pizza.PizzaSize,
                HasExtras = pizza.HasExtras

    };


        }
    }
}
