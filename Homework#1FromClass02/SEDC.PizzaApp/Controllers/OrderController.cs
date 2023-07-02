using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        [Route("ListOrders")]
        public IActionResult Index()
        {
            return View();
        }


        [Route("Order/Details/{id?}")]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }

            var order = _orders.FirstOrDefault(o => o.Id == id);
            if (order == null)
            {
                return View("NotFound");
            }

            return View(order);
        }

        public IActionResult OrderData()
        {
            var order = new { Id = 12, IsDelivered = false }; // Dummy Order
            return new JsonResult(order); // return type: JsonResult
        }

        [Route("Order/JsonData")]
        public IActionResult JsonData()
        {
            var ordersData = new OrdersData
            {
                Id = 5,
                NameSurname = "John Krokodilov",
                TotalPrice = 399
            };

            // Return the model as JSON
            return new JsonResult(ordersData);
        }

        private static List<OrdersData> _orders = new List<OrdersData>
        {
                new OrdersData { Id = 6, NameSurname = "Suzana Turundzieva", TotalPrice = 699 },
                new OrdersData { Id = 7, NameSurname = "Gjoko SoModrotoOko", TotalPrice = 499 },
        };



    }

}
