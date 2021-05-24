namespace WinFormsMVP
{
    partial class StartMenu
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnStorage = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMenu
            // 
            this.lbMenu.FormattingEnabled = true;
            this.lbMenu.ItemHeight = 16;
            this.lbMenu.Location = new System.Drawing.Point(162, 84);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbMenu.Size = new System.Drawing.Size(403, 228);
            this.lbMenu.TabIndex = 0;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblMenu.Location = new System.Drawing.Point(309, 34);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(81, 31);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menu";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(284, 338);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(161, 51);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(607, 84);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(161, 51);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnStorage
            // 
            this.btnStorage.Location = new System.Drawing.Point(607, 170);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Size = new System.Drawing.Size(161, 51);
            this.btnStorage.TabIndex = 4;
            this.btnStorage.Text = "Storage";
            this.btnStorage.UseVisualStyleBackColor = true;
            this.btnStorage.Click += new System.EventHandler(this.btnStorage_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(607, 261);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(161, 51);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit Menu";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnStorage);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lbMenu);
            this.Name = "StartMenu";
            this.Text = "Start Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMenu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnStorage;
        private System.Windows.Forms.Button btnEdit;
    }
}

