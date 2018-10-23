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
        }
    }
}
