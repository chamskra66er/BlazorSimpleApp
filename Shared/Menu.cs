using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewBlazor.Shared
{
    public class Menu
    {
        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();
        public Pizza GetPizza(int id) =>
            Pizzas.SingleOrDefault(piz=>piz.Id==id);
    }
}
