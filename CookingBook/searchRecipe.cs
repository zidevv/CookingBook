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
    public partial class searchRecipe : Form
    {
        public Form1 form;
        public searchRecipe(Form1 parentForm)
        {
            InitializeComponent();
            form = parentForm;
        }

        private void search_Click(object sender, EventArgs e)
        {
            form.helpSearcher = searchRecipeMetod();
            form.loadRecipe(form.helpSearcher, form.isSearch);
            this.Close();

        }

        public List<Recipe> searchRecipeMetod()
        {
            List<Recipe> recipeWithCategory = new List<Recipe>();
            int countOfSearch = 0;
            List<Recipe> recipes1 = new List<Recipe>();
            List<Recipe> recipes2 = new List<Recipe>();
            List<Recipe> recipes3 = new List<Recipe>();
            List<Recipe> result = new List<Recipe>();

            foreach (Recipe b in form.recipes)
            {
                if (b.category == searchCategory.Text)
                {
                    recipeWithCategory.Add(b);
                }
            }
            if (recipeWithCategory.Count == 0)
            {
                recipeWithCategory = form.recipes;
            }

            foreach (Control a in this.Controls)
            {
                if (a is TextBox && !string.IsNullOrEmpty(a.Text))
                {
                    countOfSearch++;
                    switch (countOfSearch)
                    {
                        
                        case 1:
                            foreach (Recipe b in recipeWithCategory)
                            {
                                if (b.products.Find(x => x.name.Equals(a.Text)) != null)
                                {
                                    recipes1.Add(b);
                                }
                                
                            }

                            break;
                        case 2:
                            foreach (Recipe b in recipes1)
                            {
                                if (b.products.Find(x => x.name.Equals(a.Text)) != null)
                                {
                                    recipes2.Add(b);
                                }
                                
                            }
                            break;
                        case 3:
                            foreach (Recipe b in recipes2)
                            {
                                if (b.products.Find(x => x.name.Equals(a.Text)) != null)
                                {
                                    recipes3.Add(b);
                                }
                            }
                            break;
                    }
                }
                
            }
            switch (countOfSearch)
            {
                case 0:
                    result = recipeWithCategory;
                    break;
                case 1:
                    result = recipes1;
                    break;
                case 2:
                    result = recipes2;
                    break;
                case 3:
                    result = recipes3;
                    break;
            }

            return result;
        }
    }
    }

