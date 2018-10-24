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
    public partial class addRecipe : Form
    {
        public Form1 form;
        public List<Product> products = new List<Product>();
        public List<string> steps=new List<string>();
        public bool edit = false;
        public int set, editHelper;
        int pomWithCheck;
        public addRecipe(Form1 parentForm)
        {
            InitializeComponent();
            form = parentForm;
            set = 1;
            addNewRecipe(set);

        }
        public void addNewRecipe(int sets)
        {
            switch (sets)
            {
                case 1:
                    setVisiable(enterPanel1, this);
                    backStepsOfAddNewRecipe.Visible = false;
                    break;
                case 2:

                    setVisiable(enterProductPanel, this);
                    backStepsOfAddNewRecipe.Visible = true;
                    nextStepOfEnterRecipe.Visible = true;
                    break;
                case 3:
                    setVisiable(enterStepsPanel, this);
                    backStepsOfAddNewRecipe.Visible = true;
                    nextStepOfEnterRecipe.Visible = false;
                    break;
            }
        }
        public void setVisiable(System.Windows.Forms.Panel a, System.Windows.Forms.Form b)
        {
            foreach(Control c in b.Controls)
            {
                if(c is Panel)
                {
                    c.Visible = false;
                }
            }
            a.Visible = true;
        }

        public void checkCorrectData(int sets)
        {
            pomWithCheck = 0;
            
            switch (sets)
            {

                case 2:
                    if (string.IsNullOrWhiteSpace(enterNameOfRecipe.Text)) { MessageBox.Show("Wprowadz poprawną nazwę przepisu."); pomWithCheck++; }
                    foreach (char i in enterTimeOfPrep.Text)
                    {
                        if (!char.IsNumber(i))
                        {
                            MessageBox.Show("Wprowadz Czas potrzebny na przygotowanie.");
                            pomWithCheck++;
                            break;
                        }
                    }
                    if (enterLevelOfHard.SelectedIndex==-1) { MessageBox.Show("Wprowadz poziom trudności."); pomWithCheck++; }
                    if (enterCategory.SelectedIndex == -1) { MessageBox.Show("Wprowadz kategorie."); pomWithCheck++; }
                    break;
                case 3:
                    if (listOfProduct.Items.Count == 0)
                    {
                        MessageBox.Show("Dodaj conajmniej jeden produkt.");
                        pomWithCheck++;
                    }
                    break;
                case 4:
                    if (listOfEnterSteps.Items.Count == 0)
                    {
                        MessageBox.Show("Dodaj przynajmniej jeden krok.");pomWithCheck++;
                    }
                    break;
            }
        }

        private void nextStepOfEnterRecipe_Click(object sender, EventArgs e)
        {
            if (set < 3) set++;
            checkCorrectData(set);
            if (pomWithCheck == 0)
            {
                addNewRecipe(set);
            }
            else
            {
                set--;
            }
        }

        private void backStepsOfAddNewRecipe_Click(object sender, EventArgs e)
        {
            if (set > 1) set--;
            addNewRecipe(set);
        }

        private void exitFromAddNewRecipe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void addNextProductToTheListOfProduct(List<Product> products)
        {
            pomWithCheck = 0;
            if (string.IsNullOrWhiteSpace(enterNameOfProduct.Text)) { MessageBox.Show("Wprowadz nazwę produktu."); pomWithCheck++; }
            foreach(char i in enterAmountOfProduct.Text)
            {
                if (!char.IsNumber(i))
                {
                    MessageBox.Show("Wprowadz poprawna ilosc produktu.");
                    pomWithCheck++;
                    break;
                }
            }
            if(setCategoryOfAmount.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz rodzaj ilosci produktów.");
                pomWithCheck++;
            }
            if (pomWithCheck == 0)
            {
                products.Add(new Product(enterNameOfProduct.Text.ToLower(), int.Parse(enterAmountOfProduct.Text), setCategoryOfAmount.Text));
                refreshListOfProduct(products);
                clearTextForTheAddNewRecepie(this.enterProductPanel);
            }
        }

        public void refreshListOfProduct(List<Product> products)
        {
            string str;
            listOfProduct.Items.Clear();
            foreach(Product p in products)
            {
                str = p.name + " " + p.amount + "" + p.unit;
                listOfProduct.Items.Add(str);
            }
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            addNextProductToTheListOfProduct(products);
        }

        public void clearTextForTheAddNewRecepie(System.Windows.Forms.Panel b)
        {
            foreach(Control a in b.Controls)
            {
                if(a is TextBox)
                {
                    a.Text = "";
                }else if(a is ComboBox)
                {
                    a.Text = "";
                }
            }
        }

        public void removeFromProductList(int numerOfPositionOnListOfProduct)
        {
            if (numerOfPositionOnListOfProduct >= 0 && numerOfPositionOnListOfProduct <= products.Count-1)
            {
                products.RemoveAt(numerOfPositionOnListOfProduct);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            removeFromProductList(listOfProduct.SelectedIndex);
            refreshListOfProduct(products);
        }

        private void addSteps_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                pomWithCheck = 0;
                if (string.IsNullOrWhiteSpace(enterStepsBox.Text))
                {
                    MessageBox.Show("Wprowadz jakiś tekst jako krok");
                    pomWithCheck++;
                }
                else
                {
                    steps.Add(enterStepsBox.Text);
                    refreshStepsListbox(steps);
                    enterStepsBox.Text = "";
                    edit = false;
                }
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(enterStepsBox.Text))
                {
                    steps[editHelper] = enterStepsBox.Text;
                    refreshStepsListbox(steps);
                    enterStepsBox.Text = "";
                    edit = false;
                }
                else
                {
                    steps.RemoveAt(editHelper);
                    refreshStepsListbox(steps);
                    edit = false;
                }
            }
        }

        public void refreshStepsListbox(List<string> steps)
        {
            string str;
            listOfEnterSteps.Items.Clear();
            foreach (string p in steps)
            {
                str = (listOfEnterSteps.Items.Count+1) +" ";
                if (p.Length >= 25)
                {
                    for (int i = 0; i < 25; i++)
                        str += p[i];
                }
                else
                {
                    for (int i = 0; i < p.Length; i++)
                        str += p[i];
                }
                listOfEnterSteps.Items.Add(str);
            }
        }

        private void editSelectedStep_Click(object sender, EventArgs e)
        {
            editHelper = listOfEnterSteps.SelectedIndex;
            enterStepsBox.Text = steps[editHelper];
            edit = true;
        }

        private void saveRecipe_Click(object sender, EventArgs e)
        {
           form.recipes.Add(new Recipe(enterNameOfRecipe.Text.ToLower(), products, steps, int.Parse(enterLevelOfHard.Text), int.Parse(enterTimeOfPrep.Text), enterCategory.Text));
            form.r.saveToFile(form.recipes);
            
            form.loadRecipe(form.recipes, form.isSearch);

            this.Close();
            
        }
    }
}
