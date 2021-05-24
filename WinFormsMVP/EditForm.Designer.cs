using System;

namespace WinFormsMVP
{
    partial class EditForm
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
            this.lbMenu = new System.Windows.Forms.ListBox();
            this.tbProdQuant = new System.Windows.Forms.TextBox();
            this.tbDishName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lbIngrAvailable = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSelectedIngr = new System.Windows.Forms.ListBox();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.btnRemoveDish = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDishWeight = new System.Windows.Forms.Label();
            this.tbDishTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMenu
            // 
            this.lbMenu.FormattingEnabled = true;
            this.lbMenu.ItemHeight = 16;
            this.lbMenu.Location = new System.Drawing.Point(12, 55);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(141, 228);
            this.lbMenu.TabIndex = 0;
            // 
            // tbProdQuant
            // 
            this.tbProdQuant.Location = new System.Drawing.Point(542, 117);
            this.tbProdQuant.Name = "tbProdQuant";
            this.tbProdQuant.Size = new System.Drawing.Size(100, 22);
            this.tbProdQuant.TabIndex = 1;
            this.tbProdQuant.TextChanged += new System.EventHandler(this.tbProdQuant_TextChanged);
            // 
            // tbDishName
            // 
            this.tbDishName.Location = new System.Drawing.Point(321, 90);
            this.tbDishName.Name = "tbDishName";
            this.tbDishName.Size = new System.Drawing.Size(100, 22);
            this.tbDishName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dish Name";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(539, 90);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(94, 17);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "ProductName";
            // 
            // lbIngrAvailable
            // 
            this.lbIngrAvailable.FormattingEnabled = true;
            this.lbIngrAvailable.ItemHeight = 16;
            this.lbIngrAvailable.Location = new System.Drawing.Point(513, 150);
            this.lbIngrAvailable.Name = "lbIngrAvailable";
            this.lbIngrAvailable.Size = new System.Drawing.Size(163, 164);
            this.lbIngrAvailable.TabIndex = 4;
            this.lbIngrAvailable.SelectedIndexChanged += new System.EventHandler(this.lbIngrAvailable_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(315, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Create New Dish";
            // 
            // lbSelectedIngr
            // 
            this.lbSelectedIngr.FormattingEnabled = true;
            this.lbSelectedIngr.ItemHeight = 16;
            this.lbSelectedIngr.Location = new System.Drawing.Point(309, 191);
            this.lbSelectedIngr.Name = "lbSelectedIngr";
            this.lbSelectedIngr.Size = new System.Drawing.Size(139, 132);
            this.lbSelectedIngr.TabIndex = 6;
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Location = new System.Drawing.Point(524, 349);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(118, 29);
            this.btnAddIngredient.TabIndex = 7;
            this.btnAddIngredient.Text = "Add ingredient";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // btnAddDish
            // 
            this.btnAddDish.Location = new System.Drawing.Point(321, 396);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(118, 29);
            this.btnAddDish.TabIndex = 7;
            this.btnAddDish.Text = "Add dish";
            this.btnAddDish.UseVisualStyleBackColor = true;
            this.btnAddDish.Click += new System.EventHandler(this.btnAddDish_Click);
            // 
            // btnRemoveDish
            // 
            this.btnRemoveDish.Location = new System.Drawing.Point(25, 326);
            this.btnRemoveDish.Name = "btnRemoveDish";
            this.btnRemoveDish.Size = new System.Drawing.Size(118, 29);
            this.btnRemoveDish.TabIndex = 7;
            this.btnRemoveDish.Text = "Remove dish";
            this.btnRemoveDish.UseVisualStyleBackColor = true;
            this.btnRemoveDish.Click += new System.EventHandler(this.btnRemoveDish_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Amount, kg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dish Weight";
            // 
            // lblDishWeight
            // 
            this.lblDishWeight.AutoSize = true;
            this.lblDishWeight.Location = new System.Drawing.Point(346, 350);
            this.lblDishWeight.Name = "lblDishWeight";
            this.lblDishWeight.Size = new System.Drawing.Size(31, 17);
            this.lblDishWeight.TabIndex = 2;
            this.lblDishWeight.Text = "0kg";
            // 
            // tbDishTime
            // 
            this.tbDishTime.Location = new System.Drawing.Point(321, 138);
            this.tbDishTime.Name = "tbDishTime";
            this.tbDishTime.Size = new System.Drawing.Size(100, 22);
            this.tbDishTime.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cooking Time, m";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(706, 180);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 49);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(706, 376);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 49);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemoveDish);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddDish);
            this.Controls.Add(this.btnAddIngredient);
            this.Controls.Add(this.lbSelectedIngr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbIngrAvailable);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblDishWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDishTime);
            this.Controls.Add(this.tbDishName);
            this.Controls.Add(this.tbProdQuant);
            this.Controls.Add(this.lbMenu);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.ListBox lbMenu;
        private System.Windows.Forms.TextBox tbProdQuant;
        private System.Windows.Forms.TextBox tbDishName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.ListBox lbIngrAvailable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbSelectedIngr;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.Button btnRemoveDish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDishWeight;
        private System.Windows.Forms.TextBox tbDishTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
    }
}