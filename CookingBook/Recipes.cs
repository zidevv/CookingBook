using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingBook
{
    
    public class Recipes
    {
        public string nameOfDish; 
    }
    public class Product
    {
        public string name;
        public double amount;
        public bool isItem;
        public string unit;
        //public string[] unit = { "szt", "g", "ml", "kg", "ml" };
        //default
        public Product() { }
        //is amount
        public Product(string n,bool b, double am, string uni) { name = n; isItem = b; amount = am; unit = uni; }
        
    }
}
