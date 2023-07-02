using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp.Mappers
{
    public static class PizzaExtensionsMapper
    {
        public static PizzaViewModel ToViewModel(this Pizza pizza)
        {
            return PizzaMapper.MapPizzaToViewModel(pizza);
        }
    }
}
