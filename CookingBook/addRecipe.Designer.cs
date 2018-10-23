namespace CookingBook
{
    partial class addRecipe
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
            this.enterPanel1 = new System.Windows.Forms.Panel();
            this.enterStepsPanel = new System.Windows.Forms.Panel();
            this.saveRecipe = new System.Windows.Forms.Button();
            this.editSelectedStep = new System.Windows.Forms.Button();
            this.addSteps = new System.Windows.Forms.Button();
            this.listOfEnterSteps = new System.Windows.Forms.ListBox();
            this.enterStepsBox = new System.Windows.Forms.RichTextBox();
            this.enterProductPanel = new System.Windows.Forms.Panel();
            this.enterNameOfRecipe = new System.Windows.Forms.TextBox();
            this.enterLevelOfHard = new System.Windows.Forms.TextBox();
            this.enterTimeOfPreparing = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.exitFromAddNewRecipe = new System.Windows.Forms.Button();
            this.nextStepOfEnterRecipe = new System.Windows.Forms.Button();
            this.backStepsOfAddNewRecipe = new System.Windows.Forms.Button();
            this.enterNameOfProduct = new System.Windows.Forms.TextBox();
            this.enterAmountOfProduct = new System.Windows.Forms.TextBox();
            this.setCategoryOfAmount = new System.Windows.Forms.ComboBox();
            this.enterPanel1.SuspendLayout();
            this.enterStepsPanel.SuspendLayout();
            this.enterProductPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // enterPanel1
            // 
            this.enterPanel1.Controls.Add(this.label3);
            this.enterPanel1.Controls.Add(this.label2);
            this.enterPanel1.Controls.Add(this.label1);
            this.enterPanel1.Controls.Add(this.enterTimeOfPreparing);
            this.enterPanel1.Controls.Add(this.enterLevelOfHard);
            this.enterPanel1.Controls.Add(this.enterNameOfRecipe);
            this.enterPanel1.Location = new System.Drawing.Point(0, 0);
            this.enterPanel1.Name = "enterPanel1";
            this.enterPanel1.Size = new System.Drawing.Size(736, 462);
            this.enterPanel1.TabIndex = 0;
            // 
            // enterStepsPanel
            // 
            this.enterStepsPanel.Controls.Add(this.saveRecipe);
            this.enterStepsPanel.Controls.Add(this.editSelectedStep);
            this.enterStepsPanel.Controls.Add(this.addSteps);
            this.enterStepsPanel.Controls.Add(this.listOfEnterSteps);
            this.enterStepsPanel.Controls.Add(this.enterStepsBox);
            this.enterStepsPanel.Location = new System.Drawing.Point(0, 0);
            this.enterStepsPanel.Name = "enterStepsPanel";
            this.enterStepsPanel.Size = new System.Drawing.Size(736, 462);
            this.enterStepsPanel.TabIndex = 3;
            // 
            // saveRecipe
            // 
            this.saveRecipe.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveRecipe.Location = new System.Drawing.Point(410, 407);
            this.saveRecipe.Name = "saveRecipe";
            this.saveRecipe.Size = new System.Drawing.Size(314, 27);
            this.saveRecipe.TabIndex = 4;
            this.saveRecipe.Text = "Zapisz Przepis";
            this.saveRecipe.UseVisualStyleBackColor = true;
            // 
            // editSelectedStep
            // 
            this.editSelectedStep.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editSelectedStep.Location = new System.Drawing.Point(410, 295);
            this.editSelectedStep.Name = "editSelectedStep";
            this.editSelectedStep.Size = new System.Drawing.Size(314, 27);
            this.editSelectedStep.TabIndex = 3;
            this.editSelectedStep.Text = "Edytuj Ruch";
            this.editSelectedStep.UseVisualStyleBackColor = true;
            // 
            // addSteps
            // 
            this.addSteps.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSteps.Location = new System.Drawing.Point(410, 252);
            this.addSteps.Name = "addSteps";
            this.addSteps.Size = new System.Drawing.Size(314, 27);
            this.addSteps.TabIndex = 2;
            this.addSteps.Text = "Dodaj Ruch";
            this.addSteps.UseVisualStyleBackColor = true;
            // 
            // listOfEnterSteps
            // 
            this.listOfEnterSteps.FormattingEnabled = true;
            this.listOfEnterSteps.Location = new System.Drawing.Point(410, 35);
            this.listOfEnterSteps.Name = "listOfEnterSteps";
            this.listOfEnterSteps.Size = new System.Drawing.Size(314, 199);
            this.listOfEnterSteps.TabIndex = 1;
            // 
            // enterStepsBox
            // 
            this.enterStepsBox.Location = new System.Drawing.Point(12, 33);
            this.enterStepsBox.Name = "enterStepsBox";
            this.enterStepsBox.Size = new System.Drawing.Size(382, 401);
            this.enterStepsBox.TabIndex = 0;
            this.enterStepsBox.Text = "";
            // 
            // enterProductPanel
            // 
            this.enterProductPanel.Controls.Add(this.setCategoryOfAmount);
            this.enterProductPanel.Controls.Add(this.enterAmountOfProduct);
            this.enterProductPanel.Controls.Add(this.enterNameOfProduct);
            this.enterProductPanel.Controls.Add(this.label5);
            this.enterProductPanel.Controls.Add(this.label4);
            this.enterProductPanel.Location = new System.Drawing.Point(0, 0);
            this.enterProductPanel.Name = "enterProductPanel";
            this.enterProductPanel.Size = new System.Drawing.Size(733, 459);
            this.enterProductPanel.TabIndex = 4;
            // 
            // enterNameOfRecipe
            // 
            this.enterNameOfRecipe.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNameOfRecipe.Location = new System.Drawing.Point(12, 72);
            this.enterNameOfRecipe.Name = "enterNameOfRecipe";
            this.enterNameOfRecipe.Size = new System.Drawing.Size(229, 34);
            this.enterNameOfRecipe.TabIndex = 0;
            // 
            // enterLevelOfHard
            // 
            this.enterLevelOfHard.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterLevelOfHard.Location = new System.Drawing.Point(12, 163);
            this.enterLevelOfHard.Name = "enterLevelOfHard";
            this.enterLevelOfHard.Size = new System.Drawing.Size(229, 34);
            this.enterLevelOfHard.TabIndex = 1;
            // 
            // enterTimeOfPreparing
            // 
            this.enterTimeOfPreparing.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterTimeOfPreparing.Location = new System.Drawing.Point(12, 245);
            this.enterTimeOfPreparing.Name = "enterTimeOfPreparing";
            this.enterTimeOfPreparing.Size = new System.Drawing.Size(229, 34);
            this.enterTimeOfPreparing.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wprowadz nazwę potrawy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wprowadz czas przygotowania";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wprowadz poziom trudności";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Wprowadz nazwę produktu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Wprowadz ilość produktu";
            // 
            // exitFromAddNewRecipe
            // 
            this.exitFromAddNewRecipe.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitFromAddNewRecipe.Location = new System.Drawing.Point(12, 490);
            this.exitFromAddNewRecipe.Name = "exitFromAddNewRecipe";
            this.exitFromAddNewRecipe.Size = new System.Drawing.Size(229, 57);
            this.exitFromAddNewRecipe.TabIndex = 6;
            this.exitFromAddNewRecipe.Text = "Zakończ";
            this.exitFromAddNewRecipe.UseVisualStyleBackColor = true;
            // 
            // nextStepOfEnterRecipe
            // 
            this.nextStepOfEnterRecipe.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextStepOfEnterRecipe.Location = new System.Drawing.Point(495, 490);
            this.nextStepOfEnterRecipe.Name = "nextStepOfEnterRecipe";
            this.nextStepOfEnterRecipe.Size = new System.Drawing.Size(229, 57);
            this.nextStepOfEnterRecipe.TabIndex = 5;
            this.nextStepOfEnterRecipe.Text = "Dalej";
            this.nextStepOfEnterRecipe.UseVisualStyleBackColor = true;
            // 
            // backStepsOfAddNewRecipe
            // 
            this.backStepsOfAddNewRecipe.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backStepsOfAddNewRecipe.Location = new System.Drawing.Point(247, 490);
            this.backStepsOfAddNewRecipe.Name = "backStepsOfAddNewRecipe";
            this.backStepsOfAddNewRecipe.Size = new System.Drawing.Size(229, 57);
            this.backStepsOfAddNewRecipe.TabIndex = 7;
            this.backStepsOfAddNewRecipe.Text = "Wstecz";
            this.backStepsOfAddNewRecipe.UseVisualStyleBackColor = true;
            // 
            // enterNameOfProduct
            // 
            this.enterNameOfProduct.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNameOfProduct.Location = new System.Drawing.Point(17, 35);
            this.enterNameOfProduct.Name = "enterNameOfProduct";
            this.enterNameOfProduct.Size = new System.Drawing.Size(270, 34);
            this.enterNameOfProduct.TabIndex = 8;
            // 
            // enterAmountOfProduct
            // 
            this.enterAmountOfProduct.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterAmountOfProduct.Location = new System.Drawing.Point(17, 125);
            this.enterAmountOfProduct.Name = "enterAmountOfProduct";
            this.enterAmountOfProduct.Size = new System.Drawing.Size(191, 34);
            this.enterAmountOfProduct.TabIndex = 9;
            // 
            // setCategoryOfAmount
            // 
            this.setCategoryOfAmount.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.setCategoryOfAmount.FormattingEnabled = true;
            this.setCategoryOfAmount.Items.AddRange(new object[] {
            "Szt",
            "Kg",
            "g",
            "l",
            "ml"});
            this.setCategoryOfAmount.Location = new System.Drawing.Point(214, 125);
            this.setCategoryOfAmount.Name = "setCategoryOfAmount";
            this.setCategoryOfAmount.Size = new System.Drawing.Size(73, 35);
            this.setCategoryOfAmount.TabIndex = 10;
            // 
            // addRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 559);
            this.Controls.Add(this.backStepsOfAddNewRecipe);
            this.Controls.Add(this.exitFromAddNewRecipe);
            this.Controls.Add(this.nextStepOfEnterRecipe);
            this.Controls.Add(this.enterPanel1);
            this.Controls.Add(this.enterProductPanel);
            this.Controls.Add(this.enterStepsPanel);
            this.Name = "addRecipe";
            this.Text = "Zapisz Nowy Przepis";
            this.enterPanel1.ResumeLayout(false);
            this.enterPanel1.PerformLayout();
            this.enterStepsPanel.ResumeLayout(false);
            this.enterProductPanel.ResumeLayout(false);
            this.enterProductPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel enterPanel1;
        private System.Windows.Forms.TextBox enterLevelOfHard;
        private System.Windows.Forms.TextBox enterNameOfRecipe;
        private System.Windows.Forms.Panel enterStepsPanel;
        private System.Windows.Forms.Button saveRecipe;
        private System.Windows.Forms.Button editSelectedStep;
        private System.Windows.Forms.Button addSteps;
        private System.Windows.Forms.ListBox listOfEnterSteps;
        private System.Windows.Forms.RichTextBox enterStepsBox;
        private System.Windows.Forms.Panel enterProductPanel;
        private System.Windows.Forms.TextBox enterTimeOfPreparing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox setCategoryOfAmount;
        private System.Windows.Forms.TextBox enterAmountOfProduct;
        private System.Windows.Forms.TextBox enterNameOfProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exitFromAddNewRecipe;
        private System.Windows.Forms.Button nextStepOfEnterRecipe;
        private System.Windows.Forms.Button backStepsOfAddNewRecipe;
    }
}