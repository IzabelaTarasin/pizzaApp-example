using System;
using Microsoft.EntityFrameworkCore;
using pizzaApp.Model;

namespace pizzaApp.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders {get; set;}

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }
    }
}
