using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CookingBook
{
    
    public class Recipe
    {
        public string nameOfDish;
        public List<Product> products = new List<Product>();
        public List<String> stepsOfRecope;
        public int timeForPreparing;
        public int levelOfHard;
        public string category;

        public Recipe() { }

        public void addSteps(string step)
        {
            stepsOfRecope.Add(step);
        }

        public void saveToFile(List<Recipe> recipes)
        {
            var json = JsonConvert.SerializeObject(recipes);
            System.IO.File.WriteAllText("Recipes.txt", json);
        }

        public List<Recipe> readFromFile(string adress)
        {
            List<Recipe> recipes = new List<Recipe>();

            if (System.IO.File.Exists("Recipes.txt"))
            {
                if(System.IO.File.ReadAllText("Recipes.txt")!= string.Empty)
                {
                    recipes = JsonConvert.DeserializeObject<List<Recipe>>(System.IO.File.ReadAllText("Recipes.txt"));
                    return  recipes;
                }
                else
                {
                    return recipes;
                }
            }
            else
            {
                return recipes;
            }
         }

        public void removeRecipeFromList(Recipe recipeForDelete, List<Recipe> listOfRecipe)
        {
            listOfRecipe.Remove(recipeForDelete);
        }

    }
    public class Product
    {
        public string name;
        public double amount;
        public bool isItem;
        public string unit;
        //public string[] unit = { "szt", "g", "ml", "kg", "ml" };
        
        public Product() { }
        
        public Product(string n,bool b, double am, string uni) { name = n; isItem = b; amount = am; unit = uni; }

        public void removeProductFromList(List<Product> listOfProduct, Product productForDelete)
        {
            listOfProduct.Remove(productForDelete);
        }

    }
}
