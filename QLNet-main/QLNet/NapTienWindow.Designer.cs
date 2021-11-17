
namespace QLNet
{
    partial class NapTienWindow
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
            this.dataGridView_Users = new System.Windows.Forms.DataGridView();
            this.textBox_Tien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Nap = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Users
            // 
            this.dataGridView_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Users.Location = new System.Drawing.Point(16, 15);
            this.dataGridView_Users.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Users.Name = "dataGridView_Users";
            this.dataGridView_Users.RowHeadersWidth = 51;
            this.dataGridView_Users.Size = new System.Drawing.Size(573, 185);
            this.dataGridView_Users.TabIndex = 0;
            this.dataGridView_Users.Click += new System.EventHandler(this.dataGridView_Users_Click);
            // 
            // textBox_Tien
            // 
            this.textBox_Tien.Location = new System.Drawing.Point(215, 260);
            this.textBox_Tien.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Tien.Name = "textBox_Tien";
            this.textBox_Tien.Size = new System.Drawing.Size(156, 22);
            this.textBox_Tien.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 263);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số tiền nạp";
            // 
            // button_Nap
            // 
            this.button_Nap.Location = new System.Drawing.Point(130, 313);
            this.button_Nap.Margin = new System.Windows.Forms.Padding(4);
            this.button_Nap.Name = "button_Nap";
            this.button_Nap.Size = new System.Drawing.Size(100, 28);
            this.button_Nap.TabIndex = 3;
            this.button_Nap.Text = "NẠP";
            this.button_Nap.UseVisualStyleBackColor = true;
            this.button_Nap.Click += new System.EventHandler(this.button_Nap_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(312, 313);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(100, 28);
            this.button_Cancel.TabIndex = 4;
            this.button_Cancel.Text = "THOÁT";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // NapTienWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 386);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Nap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Tien);
            this.Controls.Add(this.dataGridView_Users);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NapTienWindow";
            this.Text = "NapTienWindow";
            this.Load += new System.EventHandler(this.NapTienWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Users;
        private System.Windows.Forms.TextBox textBox_Tien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Nap;
        private System.Windows.Forms.Button button_Cancel;
    }
}