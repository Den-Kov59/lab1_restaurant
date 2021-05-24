namespace WinFormsMVP
{
    partial class StorageForm
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
            this.lbStorage = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbStorage
            // 
            this.lbStorage.FormattingEnabled = true;
            this.lbStorage.ItemHeight = 16;
            this.lbStorage.Location = new System.Drawing.Point(222, 79);
            this.lbStorage.Name = "lbStorage";
            this.lbStorage.Size = new System.Drawing.Size(372, 292);
            this.lbStorage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(356, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Storage";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(327, 387);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(172, 42);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbStorage);
            this.Name = "StorageForm";
            this.Text = "StorageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbStorage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}