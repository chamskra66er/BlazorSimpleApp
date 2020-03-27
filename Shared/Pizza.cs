using System;
using System.Collections.Generic;
using System.Text;

namespace NewBlazor.Shared
{
    public enum Spiciness
    { 
        None, Spicy, Hot
    }
    public class Pizza
    {
        //public Pizza(int id, string name, double price, Spiciness spiciness)
        //{
        //    this.Id = id;
        //    this.Name = name;
        //    this.Price = price;
        //    this.Spiciness = spiciness;
        //}
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Spiciness Spiciness { get; set; }
    }
}
