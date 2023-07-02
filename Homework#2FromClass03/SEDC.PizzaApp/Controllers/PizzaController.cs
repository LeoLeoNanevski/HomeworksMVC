using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Mappers;
using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult GetAllPizzas()
        {
            List<Pizza> pizzasDb = StaticDb.Pizzas;
            return View(pizzasDb);
        }

        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("Error", "Home");
            }

            //Pizza pizza = StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);
            //if (pizza == null)
            //{
            //    return RedirectToAction("Error", "Home");
            //}

            //return View(pizza);

            Pizza pizza = StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);

            if (pizza == null)
            {
                return new EmptyResult();
            }

            PizzaViewModel pizzaViewModel = PizzaMapper.MapPizzaToViewModel(pizza);

            return View(pizzaViewModel);
        }

        public IActionResult Index()
        {
            List<Pizza> pizzas = StaticDb.Pizzas;

            List<PizzaViewModel> pizzaViewModels = new List<PizzaViewModel>();
            foreach (var pizza in pizzas)
            {
                PizzaViewModel pizzaViewModel = PizzaMapper.MapPizzaToViewModel(pizza);
                pizzaViewModels.Add(pizzaViewModel);
            }

            return View(pizzaViewModels);
        }

    }
}
