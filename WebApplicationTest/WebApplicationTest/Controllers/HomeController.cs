using Microsoft.AspNetCore.Mvc;
using WebApplicationTest.Models;
using WebApplicationTest.Data;

namespace WebApplicationTest.Controllers {
    public class HomeController : Controller {
        
        private readonly DataContext _dataContext;

        public HomeController(DataContext dataContext) {
            _dataContext = dataContext;
        }

        public IActionResult Index() {
            var value = _dataContext.Order.ToList();
            return View(value);
        }

        public IActionResult AddOrder(Order new_order) {
            var _Order = new Order {
                sender_address = new_order.sender_address,
                sender_city = new_order.sender_city,
                recipient_address = new_order.recipient_address,
                recipient_city = new_order.recipient_city,
                weight = new_order.weight,
                date = new_order.date
            };
            if((new_order.sender_city!=null) &&
               (new_order.sender_address != null) &&
               (new_order.recipient_city != null) &&
               (new_order.recipient_address != null) &&
               (new_order.weight != null) &&
               (new_order.date != DateTime.MinValue)) {

                _dataContext.Order.Add(_Order);
                _dataContext.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
            else {
                return View(_Order);
            }
        }
    }
}