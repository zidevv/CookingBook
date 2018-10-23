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
        private Form logicalParent;
        public int set;
        int pomWithCheck;
        public addRecipe(Form parent)
        {
            InitializeComponent();
            logicalParent = parent;
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
    }
}
