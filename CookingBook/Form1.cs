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
        public Recipe r = new Recipe();
        
        public Form1()
        {
            InitializeComponent();
            
            loadRecipe();
        }

        private void addNewRecipe_Click(object sender, EventArgs e)
        {
            var form = new addRecipe(this);
            form.Show();
        }

        public void loadRecipe()
        {
            recipes = r.readFromFile();
            listOfRecipe.Items.Clear();
            foreach(Recipe a in recipes)
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
                showSelected(0);
            }
        }

        public void showSelected(int selected)
        {
            nameOfRecipe.Text = recipes[selected].nameOfDish;
            levelOfHard.Text = "Poziom trudności "+recipes[selected].levelOfHard.ToString();
            timeOfPreparing.Text = "Czas "+recipes[selected].timeForPreparing.ToString()+" min";
            string pomString = "";
            foreach(Product p in recipes[selected].products)
            {
                pomString += p.name + " " + p.amount + "" + p.unit + "\n";
            }
            listOfProducts.Text = pomString;
            pomString = "";
            foreach (string p in recipes[selected].stepsOfRecipe)
            {
                pomString += p +"\n\n";
            }
            listOfSteps.Text = pomString;
            category.Text = recipes[selected].category;
        }

        private void listOfRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            showSelected(listOfRecipe.SelectedIndex);
        }

        private void removeRecipe_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Na pewno chcesz usunąć przepis?", "Pytanie", MessageBoxButtons.YesNo);
            switch (dialog)
            {
                case DialogResult.Yes:
                    recipes.RemoveAt(listOfRecipe.SelectedIndex);
                    r.saveToFile(recipes);
                    loadRecipe();
                    break;
            }
        }
    }
}
