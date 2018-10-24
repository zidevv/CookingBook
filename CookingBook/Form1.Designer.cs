namespace CookingBook
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listOfRecipe = new System.Windows.Forms.ListBox();
            this.listOfSteps = new System.Windows.Forms.RichTextBox();
            this.nameOfRecipe = new System.Windows.Forms.Label();
            this.listOfProducts = new System.Windows.Forms.Label();
            this.levelOfHard = new System.Windows.Forms.Label();
            this.timeOfPreparing = new System.Windows.Forms.Label();
            this.addNewRecipe = new System.Windows.Forms.Button();
            this.removeRecipe = new System.Windows.Forms.Button();
            this.category = new System.Windows.Forms.Label();
            this.searchRecipe = new System.Windows.Forms.Button();
            this.clearSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listOfRecipe
            // 
            this.listOfRecipe.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfRecipe.FormattingEnabled = true;
            this.listOfRecipe.ItemHeight = 16;
            this.listOfRecipe.Location = new System.Drawing.Point(12, 12);
            this.listOfRecipe.Name = "listOfRecipe";
            this.listOfRecipe.Size = new System.Drawing.Size(217, 772);
            this.listOfRecipe.TabIndex = 0;
            this.listOfRecipe.SelectedIndexChanged += new System.EventHandler(this.listOfRecipe_SelectedIndexChanged);
            // 
            // listOfSteps
            // 
            this.listOfSteps.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listOfSteps.Location = new System.Drawing.Point(434, 210);
            this.listOfSteps.Name = "listOfSteps";
            this.listOfSteps.ReadOnly = true;
            this.listOfSteps.Size = new System.Drawing.Size(639, 578);
            this.listOfSteps.TabIndex = 1;
            this.listOfSteps.Text = "";
            // 
            // nameOfRecipe
            // 
            this.nameOfRecipe.AutoSize = true;
            this.nameOfRecipe.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfRecipe.Location = new System.Drawing.Point(430, 12);
            this.nameOfRecipe.Name = "nameOfRecipe";
            this.nameOfRecipe.Size = new System.Drawing.Size(71, 27);
            this.nameOfRecipe.TabIndex = 2;
            this.nameOfRecipe.Text = "label1";
            // 
            // listOfProducts
            // 
            this.listOfProducts.AutoSize = true;
            this.listOfProducts.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfProducts.Location = new System.Drawing.Point(244, 207);
            this.listOfProducts.Name = "listOfProducts";
            this.listOfProducts.Size = new System.Drawing.Size(61, 23);
            this.listOfProducts.TabIndex = 3;
            this.listOfProducts.Text = "label1";
            // 
            // levelOfHard
            // 
            this.levelOfHard.AutoSize = true;
            this.levelOfHard.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelOfHard.Location = new System.Drawing.Point(852, 9);
            this.levelOfHard.Name = "levelOfHard";
            this.levelOfHard.Size = new System.Drawing.Size(77, 30);
            this.levelOfHard.TabIndex = 4;
            this.levelOfHard.Text = "label1";
            // 
            // timeOfPreparing
            // 
            this.timeOfPreparing.AutoSize = true;
            this.timeOfPreparing.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOfPreparing.Location = new System.Drawing.Point(852, 51);
            this.timeOfPreparing.Name = "timeOfPreparing";
            this.timeOfPreparing.Size = new System.Drawing.Size(77, 30);
            this.timeOfPreparing.TabIndex = 5;
            this.timeOfPreparing.Text = "label1";
            // 
            // addNewRecipe
            // 
            this.addNewRecipe.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewRecipe.Location = new System.Drawing.Point(235, 12);
            this.addNewRecipe.Name = "addNewRecipe";
            this.addNewRecipe.Size = new System.Drawing.Size(189, 30);
            this.addNewRecipe.TabIndex = 6;
            this.addNewRecipe.Text = "Dodaj Nowy Przepis";
            this.addNewRecipe.UseVisualStyleBackColor = true;
            this.addNewRecipe.Click += new System.EventHandler(this.addNewRecipe_Click);
            // 
            // removeRecipe
            // 
            this.removeRecipe.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeRecipe.Location = new System.Drawing.Point(235, 59);
            this.removeRecipe.Name = "removeRecipe";
            this.removeRecipe.Size = new System.Drawing.Size(189, 30);
            this.removeRecipe.TabIndex = 7;
            this.removeRecipe.Text = "Usuń Przepis";
            this.removeRecipe.UseVisualStyleBackColor = true;
            this.removeRecipe.Click += new System.EventHandler(this.removeRecipe_Click);
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(430, 58);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(63, 23);
            this.category.TabIndex = 8;
            this.category.Text = "label1";
            // 
            // searchRecipe
            // 
            this.searchRecipe.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRecipe.Location = new System.Drawing.Point(235, 110);
            this.searchRecipe.Name = "searchRecipe";
            this.searchRecipe.Size = new System.Drawing.Size(189, 30);
            this.searchRecipe.TabIndex = 9;
            this.searchRecipe.Text = "Wyszukaj Przepisu";
            this.searchRecipe.UseVisualStyleBackColor = true;
            this.searchRecipe.Click += new System.EventHandler(this.searchRecipe_Click);
            // 
            // clearSearch
            // 
            this.clearSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSearch.Location = new System.Drawing.Point(235, 146);
            this.clearSearch.Name = "clearSearch";
            this.clearSearch.Size = new System.Drawing.Size(189, 30);
            this.clearSearch.TabIndex = 10;
            this.clearSearch.Text = "Wyczysc wyszukiwanie";
            this.clearSearch.UseVisualStyleBackColor = true;
            this.clearSearch.Click += new System.EventHandler(this.clearSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 805);
            this.Controls.Add(this.clearSearch);
            this.Controls.Add(this.searchRecipe);
            this.Controls.Add(this.category);
            this.Controls.Add(this.removeRecipe);
            this.Controls.Add(this.addNewRecipe);
            this.Controls.Add(this.timeOfPreparing);
            this.Controls.Add(this.levelOfHard);
            this.Controls.Add(this.listOfProducts);
            this.Controls.Add(this.nameOfRecipe);
            this.Controls.Add(this.listOfSteps);
            this.Controls.Add(this.listOfRecipe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listOfRecipe;
        private System.Windows.Forms.RichTextBox listOfSteps;
        private System.Windows.Forms.Label nameOfRecipe;
        private System.Windows.Forms.Label listOfProducts;
        private System.Windows.Forms.Label levelOfHard;
        private System.Windows.Forms.Label timeOfPreparing;
        private System.Windows.Forms.Button addNewRecipe;
        private System.Windows.Forms.Button removeRecipe;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Button searchRecipe;
        private System.Windows.Forms.Button clearSearch;
    }
}

