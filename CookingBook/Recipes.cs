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
        public List<String> stepsOfRecipe = new List<string>();
        public int timeForPreparing;
        public int levelOfHard;
        public string category;

        public Recipe() { }

        public Recipe(string n, List<Product> pr, List<string> str, int t, int l, string cat) {
            nameOfDish = n; products = pr; stepsOfRecipe = str; timeForPreparing = t; levelOfHard = l;
            category = cat;
        }
        

        public void saveToFile(List<Recipe> recipes)
        {
            var json = JsonConvert.SerializeObject(recipes);
            System.IO.File.WriteAllText("Recipes.txt", json);
        }

        public List<Recipe> readFromFile()
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
        public string unit;
        //public string[] unit = { "szt", "g", "ml", "kg", "ml" };
        
        public Product() { }
        
        public Product(string n, double am, string uni) { name = n; amount = am; unit = uni; }

        public void removeProductFromList(List<Product> listOfProduct, Product productForDelete)
        {
            listOfProduct.Remove(productForDelete);
        }

    }
}
