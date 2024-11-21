using BasicMvcProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicMvcProject.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()

        {
            var customer1 = new Customer
            {
                Id = 1,
                Name = "Ömer",
                SurName = "Kozluca",
                Email = "Omer@hotmail.com"

            };

            var orders = new List<Order>()
            {
                new Order {Id = 1, ProductName ="Ford", Price=27500, Quantity= 2 },
                new Order {Id = 2, ProductName ="TOYOTA", Price=37250, Quantity= 2 },
                new Order {Id = 3, ProductName ="FIAT", Price=14320, Quantity= 2 }
            };

            var viewModel = new CustomerOrderViewModel()
            {
                Customer = customer1,
                Orders = orders
            };


            return View(viewModel);

        }
    }
}
