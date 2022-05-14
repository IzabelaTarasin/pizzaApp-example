using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pizzaApp.Data;
using pizzaApp.Model;

namespace pizzaApp.Pages
{
	public class OrdersModel : PageModel
    {
        public List<PizzaOrder> PizzaOrders = new List<PizzaOrder>();

        private readonly ApplicationDBContext _contex;


        public OrdersModel(ApplicationDBContext contex)
        {
            _contex = contex;
        }

        public void OnGet()
        {
            PizzaOrders = _contex.PizzaOrders.ToList();
        }
    }
}
