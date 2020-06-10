namespace Learning_Database
{
    partial class FormMain
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
            this.cookbookDataSet = new Learning_Database.CookbookDataSet();
            this.lblRecipies = new System.Windows.Forms.Label();
            this.lstRecipies = new System.Windows.Forms.ListBox();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.btnAddRecipie = new System.Windows.Forms.Button();
            this.txtRecipieName = new System.Windows.Forms.TextBox();
            this.btnUpdateRecipieName = new System.Windows.Forms.Button();
            this.lstAllIngredients = new System.Windows.Forms.ListBox();
            this.lblAllIngredients = new System.Windows.Forms.Label();
            this.btnAddToRecipie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cookbookDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cookbookDataSet
            // 
            this.cookbookDataSet.DataSetName = "CookbookDataSet";
            this.cookbookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblRecipies
            // 
            this.lblRecipies.AutoSize = true;
            this.lblRecipies.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipies.Location = new System.Drawing.Point(12, 121);
            this.lblRecipies.Name = "lblRecipies";
            this.lblRecipies.Size = new System.Drawing.Size(75, 21);
            this.lblRecipies.TabIndex = 0;
            this.lblRecipies.Text = "Recipies:";
            // 
            // lstRecipies
            // 
            this.lstRecipies.FormattingEnabled = true;
            this.lstRecipies.Location = new System.Drawing.Point(16, 145);
            this.lstRecipies.Name = "lstRecipies";
            this.lstRecipies.Size = new System.Drawing.Size(120, 212);
            this.lstRecipies.TabIndex = 1;
            this.lstRecipies.SelectedIndexChanged += new System.EventHandler(this.lstRecipies_SelectedIndexChanged);
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.Location = new System.Drawing.Point(12, 370);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(155, 21);
            this.lblIngredients.TabIndex = 0;
            this.lblIngredients.Text = "Recipie Ingredients:";
            // 
            // lstIngredients
            // 
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.Location = new System.Drawing.Point(16, 394);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(120, 212);
            this.lstIngredients.TabIndex = 1;
            this.lstIngredients.SelectedIndexChanged += new System.EventHandler(this.lstRecipies_SelectedIndexChanged);
            // 
            // btnAddRecipie
            // 
            this.btnAddRecipie.Location = new System.Drawing.Point(16, 70);
            this.btnAddRecipie.Name = "btnAddRecipie";
            this.btnAddRecipie.Size = new System.Drawing.Size(100, 23);
            this.btnAddRecipie.TabIndex = 2;
            this.btnAddRecipie.Text = "Add Recipie:";
            this.btnAddRecipie.UseVisualStyleBackColor = true;
            this.btnAddRecipie.Click += new System.EventHandler(this.btnAddRecipie_Click);
            // 
            // txtRecipieName
            // 
            this.txtRecipieName.Location = new System.Drawing.Point(16, 44);
            this.txtRecipieName.Name = "txtRecipieName";
            this.txtRecipieName.Size = new System.Drawing.Size(217, 20);
            this.txtRecipieName.TabIndex = 3;
            // 
            // btnUpdateRecipieName
            // 
            this.btnUpdateRecipieName.Location = new System.Drawing.Point(133, 70);
            this.btnUpdateRecipieName.Name = "btnUpdateRecipieName";
            this.btnUpdateRecipieName.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateRecipieName.TabIndex = 4;
            this.btnUpdateRecipieName.Text = "Update Name:";
            this.btnUpdateRecipieName.UseVisualStyleBackColor = true;
            this.btnUpdateRecipieName.Click += new System.EventHandler(this.btnUpdateRecipieName_Click);
            // 
            // lstAllIngredients
            // 
            this.lstAllIngredients.FormattingEnabled = true;
            this.lstAllIngredients.Location = new System.Drawing.Point(268, 145);
            this.lstAllIngredients.Name = "lstAllIngredients";
            this.lstAllIngredients.Size = new System.Drawing.Size(120, 212);
            this.lstAllIngredients.TabIndex = 6;
            // 
            // lblAllIngredients
            // 
            this.lblAllIngredients.AutoSize = true;
            this.lblAllIngredients.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllIngredients.Location = new System.Drawing.Point(264, 121);
            this.lblAllIngredients.Name = "lblAllIngredients";
            this.lblAllIngredients.Size = new System.Drawing.Size(120, 21);
            this.lblAllIngredients.TabIndex = 5;
            this.lblAllIngredients.Text = "All Ingredients:";
            // 
            // btnAddToRecipie
            // 
            this.btnAddToRecipie.Location = new System.Drawing.Point(268, 370);
            this.btnAddToRecipie.Name = "btnAddToRecipie";
            this.btnAddToRecipie.Size = new System.Drawing.Size(120, 23);
            this.btnAddToRecipie.TabIndex = 7;
            this.btnAddToRecipie.Text = "Add To Recipie:";
            this.btnAddToRecipie.UseVisualStyleBackColor = true;
            this.btnAddToRecipie.Click += new System.EventHandler(this.btnAddToRecipie_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(539, 624);
            this.Controls.Add(this.btnAddToRecipie);
            this.Controls.Add(this.lstAllIngredients);
            this.Controls.Add(this.lblAllIngredients);
            this.Controls.Add(this.btnUpdateRecipieName);
            this.Controls.Add(this.txtRecipieName);
            this.Controls.Add(this.btnAddRecipie);
            this.Controls.Add(this.lstIngredients);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.lstRecipies);
            this.Controls.Add(this.lblRecipies);
            this.Name = "FormMain";
            this.Text = "Cookbook";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cookbookDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CookbookDataSet cookbookDataSet;
        private System.Windows.Forms.Label lblRecipies;
        private System.Windows.Forms.ListBox lstRecipies;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.ListBox lstIngredients;
        private System.Windows.Forms.Button btnAddRecipie;
        private System.Windows.Forms.TextBox txtRecipieName;
        private System.Windows.Forms.Button btnUpdateRecipieName;
        private System.Windows.Forms.ListBox lstAllIngredients;
        private System.Windows.Forms.Label lblAllIngredients;
        private System.Windows.Forms.Button btnAddToRecipie;
    }
}

