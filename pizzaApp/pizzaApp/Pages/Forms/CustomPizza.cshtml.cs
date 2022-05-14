using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pizzaApp.Model;

namespace pizzaApp.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.TomatoSouce)
            {
                PizzaPrice += 1;
            }
            if (Pizza.Chesse)
            {
                PizzaPrice += 1;
            }
            if (Pizza.Pepperoni)
            {
                PizzaPrice += 2;
            }
            if (Pizza.Mushroom)
            {
                PizzaPrice += 1;
            }
            if (Pizza.Tuna)
            {
                PizzaPrice += 2;
            }
            if (Pizza.Pineapple)
            {
                PizzaPrice += 1;
            }
            if (Pizza.Ham)
            {
                PizzaPrice += 2;
            }
            if (Pizza.Beef)
            {
                PizzaPrice += 2;
            }

            return RedirectToPage("/Checkout/Checkout", new { Pizza.Name, PizzaPrice });
            /*https://localhost:5001/Checkout/Checkout?PizzaPrice=6 tak bedzie wygladac pasek adresu jak klikniemy submit*/
        }
    }
}
