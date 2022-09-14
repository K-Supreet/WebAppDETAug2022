using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using MvcDemo.Models;

namespace MvcDemo.Controllers
{
    public class EventsController : Controller
    {
        public List<Booking> events { get; set; }
        public IActionResult Index()
        {
            events = new List<Booking>();
            events.Add(new Booking { Title = "Ask CEO", EventDate = DateTime.Today, Qty = 10 });
            return View(events);
        }
    }
}
