
namespace QLNet
{
    partial class LichSuDangNhap
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
            this.dataGridView_History = new System.Windows.Forms.DataGridView();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Tim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.dataGridView_user = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_History)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_History
            // 
            this.dataGridView_History.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_History.Location = new System.Drawing.Point(296, 12);
            this.dataGridView_History.Name = "dataGridView_History";
            this.dataGridView_History.RowHeadersWidth = 51;
            this.dataGridView_History.RowTemplate.Height = 24;
            this.dataGridView_History.Size = new System.Drawing.Size(453, 287);
            this.dataGridView_History.TabIndex = 0;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.Location = new System.Drawing.Point(454, 424);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(153, 51);
            this.button_Cancel.TabIndex = 8;
            this.button_Cancel.Text = "THOÁT";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Tim
            // 
            this.button_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Tim.Location = new System.Drawing.Point(156, 426);
            this.button_Tim.Margin = new System.Windows.Forms.Padding(4);
            this.button_Tim.Name = "button_Tim";
            this.button_Tim.Size = new System.Drawing.Size(146, 49);
            this.button_Tim.TabIndex = 7;
            this.button_Tim.Text = "TÌM";
            this.button_Tim.UseVisualStyleBackColor = true;
            this.button_Tim.Click += new System.EventHandler(this.button_Tim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 348);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm kiếm theo tài khoản";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UserName.Location = new System.Drawing.Point(321, 343);
            this.textBox_UserName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(226, 30);
            this.textBox_UserName.TabIndex = 5;
            // 
            // dataGridView_user
            // 
            this.dataGridView_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_user.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_user.Name = "dataGridView_user";
            this.dataGridView_user.RowHeadersWidth = 51;
            this.dataGridView_user.RowTemplate.Height = 24;
            this.dataGridView_user.Size = new System.Drawing.Size(215, 287);
            this.dataGridView_user.TabIndex = 9;
            this.dataGridView_user.Click += new System.EventHandler(this.dataGridView_user_Click);
            // 
            // LichSuDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 488);
            this.Controls.Add(this.dataGridView_user);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Tim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.dataGridView_History);
            this.Name = "LichSuDangNhap";
            this.Text = "LichSuDangNhap";
            this.Load += new System.EventHandler(this.LichSuDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_History)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_History;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Tim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.DataGridView dataGridView_user;
    }
}