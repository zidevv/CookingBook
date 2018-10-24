using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookingBook
{
    
    public partial class Form1 : Form
    {
        
        public List<Recipe> recipes = new List<Recipe>();
        public bool isSearch = false;
        public Recipe r = new Recipe();
        public List<Recipe> helpSearcher = new List<Recipe>();
        
        public Form1()
        {
            InitializeComponent();
            
            loadRecipe(recipes, isSearch);
        }

        private void addNewRecipe_Click(object sender, EventArgs e)
        {
            var form = new addRecipe(this);
            form.Show();
        }

        public void loadRecipe(List<Recipe> b, bool isSearch)
        {

            if (!isSearch)
            {
                recipes = r.readFromFile();
                listOfRecipe.Items.Clear();
                foreach (Recipe a in recipes)
                {
                    listOfRecipe.Items.Add(a.nameOfDish);
                }
                if (listOfRecipe.Items.Count == 0)
                {
                    nameOfRecipe.Text = "";
                    levelOfHard.Text = "";
                    timeOfPreparing.Text = "";
                    listOfProducts.Text = "";
                    listOfSteps.Text = "";
                    category.Text = "";
                }
                else
                {
                    showSelected(0, recipes);
                }
            }
            else
            {
                
                listOfRecipe.Items.Clear();
                foreach (Recipe a in b)
                {
                    if(a!=null) listOfRecipe.Items.Add(a.nameOfDish);
                }
                if (listOfRecipe.Items.Count == 0)
                {
                    nameOfRecipe.Text = "";
                    levelOfHard.Text = "";
                    timeOfPreparing.Text = "";
                    listOfProducts.Text = "";
                    listOfSteps.Text = "";
                    category.Text = "";
                }
                else
                {
                    showSelected(0,b);
                }
            }
            
                
            
        }

        public void showSelected(int selected, List<Recipe> a)
        {

            if (selected >= 0 && selected < a.Count)
            {
                nameOfRecipe.Text = a[selected].nameOfDish;
                levelOfHard.Text = "Poziom trudności " + a[selected].levelOfHard.ToString();
                timeOfPreparing.Text = "Czas " + a[selected].timeForPreparing.ToString() + " min";
                string pomString = "";
                foreach (Product p in a[selected].products)
                {
                    pomString += p.name + " " + p.amount + "" + p.unit + "\n";
                }
                listOfProducts.Text = pomString;
                pomString = "";
                foreach (string p in a[selected].stepsOfRecipe)
                {
                    pomString += p + "\n\n";
                }
                listOfSteps.Text = pomString;
                category.Text = a[selected].category;
            }
        }
        

        private void listOfRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isSearch)
            {
                showSelected(listOfRecipe.SelectedIndex, recipes);
            }
            else
            {
                showSelected(listOfRecipe.SelectedIndex, helpSearcher);
            }
        }

        private void removeRecipe_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Na pewno chcesz usunąć przepis?", "Pytanie", MessageBoxButtons.YesNo);
            switch (dialog)
            {
                case DialogResult.Yes:
                    recipes.Remove(recipes.Find(x => x.nameOfDish.Equals(listOfRecipe.Text)));
                    r.saveToFile(recipes);
                    isSearch = false;
                    loadRecipe(recipes, isSearch);
                    showSelected(0, recipes);
                    break;
            }
        }

        private void searchRecipe_Click(object sender, EventArgs e)
        {
            searchRecipe searchRecipeOpen = new searchRecipe(this);
            searchRecipeOpen.Show();
            isSearch = true;
        }

        private void clearSearch_Click(object sender, EventArgs e)
        {
            isSearch = false;
            loadRecipe(recipes, isSearch);
        }
    }
}
