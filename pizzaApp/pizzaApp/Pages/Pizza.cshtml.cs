using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pizzaApp.Model;

namespace pizzaApp.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel()
            {
                ImageTitle = "Margerita",
                Name = "Margerita",
                BasePrice = 2,
                TomatoSouce = true,
                Chesse = true,
                FinalPrice = 4
            },
            new PizzasModel()
            {
                ImageTitle = "Bolognese",
                Name = "Bolognese",
                BasePrice = 2,
                TomatoSouce = true,
                Chesse = true,
                Ham = true,
                FinalPrice = 6
            },
            new PizzasModel()
            {
                ImageTitle = "Carbonara",
                Name = "Carbonara",
                BasePrice = 2,
                Chesse = true,
                FinalPrice = 3
            },
            new PizzasModel()
            {
                ImageTitle = "Hawaiian",
                Name = "Hawaiian",
                BasePrice = 2,
                TomatoSouce = true,
                Chesse = true,
                Ham = true,
                Pineapple = true,
                FinalPrice = 7
            },
            new PizzasModel()
            {
                ImageTitle = "MeatFeast",
                Name = "MeatFeast",
                BasePrice = 2,
                TomatoSouce = true,
                Chesse = true,
                Ham = true,
                Beef = true,
                FinalPrice = 8
            },
            new PizzasModel()
            {
                ImageTitle = "Mushroom",
                Name = "Mushroom",
                BasePrice = 2,
                TomatoSouce = true,
                Chesse = true,
                Mushroom = true,
                FinalPrice = 5
            },
            new PizzasModel()
            {
                ImageTitle = "Pepperoni",
                Name = "Pepperoni",
                BasePrice = 2,
                TomatoSouce = true,
                Chesse = true,
                Pepperoni = true,
                FinalPrice = 6
            },
            new PizzasModel()
            {
                ImageTitle = "Seafood",
                Name = "Seafood",
                BasePrice = 2,
                TomatoSouce = true,
                Tuna = true,
                FinalPrice = 5
            },
            new PizzasModel()
            {
                ImageTitle = "Vegetarian",
                Name = "Vegetarian",
                BasePrice = 2,
                TomatoSouce = true,
                Mushroom = true,
                Pineapple = true,
                FinalPrice = 5
            }
        };

        public void OnGet()
        {
        }
    }
}
