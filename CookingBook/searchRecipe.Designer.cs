namespace CookingBook
{
    partial class searchRecipe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchCategory = new System.Windows.Forms.ComboBox();
            this.searchProductFirst = new System.Windows.Forms.TextBox();
            this.searchProductSecend = new System.Windows.Forms.TextBox();
            this.searchProductThird = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(12, 297);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(336, 81);
            this.search.TabIndex = 0;
            this.search.Text = "Szukaj";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Składnik pierwszy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Składnik drugi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Skłądnik trzeci";
            // 
            // searchCategory
            // 
            this.searchCategory.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCategory.FormattingEnabled = true;
            this.searchCategory.Items.AddRange(new object[] {
            "Sniadanie",
            "Obiad",
            "Kolacja",
            "Drugie Sniadanie",
            "Podwieczorek"});
            this.searchCategory.Location = new System.Drawing.Point(12, 35);
            this.searchCategory.Name = "searchCategory";
            this.searchCategory.Size = new System.Drawing.Size(229, 31);
            this.searchCategory.TabIndex = 11;
            // 
            // searchProductFirst
            // 
            this.searchProductFirst.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProductFirst.Location = new System.Drawing.Point(12, 105);
            this.searchProductFirst.Name = "searchProductFirst";
            this.searchProductFirst.Size = new System.Drawing.Size(229, 32);
            this.searchProductFirst.TabIndex = 12;
            // 
            // searchProductSecend
            // 
            this.searchProductSecend.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProductSecend.Location = new System.Drawing.Point(16, 179);
            this.searchProductSecend.Name = "searchProductSecend";
            this.searchProductSecend.Size = new System.Drawing.Size(229, 32);
            this.searchProductSecend.TabIndex = 13;
            // 
            // searchProductThird
            // 
            this.searchProductThird.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProductThird.Location = new System.Drawing.Point(16, 246);
            this.searchProductThird.Name = "searchProductThird";
            this.searchProductThird.Size = new System.Drawing.Size(229, 32);
            this.searchProductThird.TabIndex = 14;
            // 
            // searchRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 391);
            this.Controls.Add(this.searchProductThird);
            this.Controls.Add(this.searchProductSecend);
            this.Controls.Add(this.searchProductFirst);
            this.Controls.Add(this.searchCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search);
            this.Name = "searchRecipe";
            this.Text = "searchRecipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox searchCategory;
        private System.Windows.Forms.TextBox searchProductFirst;
        private System.Windows.Forms.TextBox searchProductSecend;
        private System.Windows.Forms.TextBox searchProductThird;
    }
}