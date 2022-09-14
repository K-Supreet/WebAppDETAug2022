using Microsoft.AspNetCore.Mvc;
using MvcDemo.Services;
using WebAppDETAug2022.Models;

namespace MvcDemo.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzas = PizzaServices.GetAll();
            return View(pizzas);
        }
        public IActionResult Detail(int id)
        {
            Pizza p = PizzaServices.Get(id);
            return View(p);
        }
        public IActionResult List()
        {
            List<Pizza> pizzas = PizzaServices.GetAll();
            return View(pizzas);
        }
        public IActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Create(Pizza p)
        {
            PizzaServices.Add(p);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)

        {
            Pizza p = PizzaServices.Get(id);
            if (p != null)
                return View(p);
            else
                return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Delete(Pizza p)
        {
            PizzaServices.Delete(p.Id);
            return RedirectToAction("List");
        }
        public IActionResult Edit()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Edit(int ID, string Name, PizzaSize Size, bool IsGlutenFree, decimal Price)
        {
            Pizza p = new Pizza { Id = ID, Name = Name, Size = Size, Price = Price, IsGlutenFree = IsGlutenFree };
            PizzaServices.Update(p);
            return RedirectToAction("List");
        }
    }
}
