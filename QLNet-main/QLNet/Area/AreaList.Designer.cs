
namespace QLNet
{
    partial class AreaList
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
            this.dataGridView_listArea = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_listCom = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listCom)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_listArea
            // 
            this.dataGridView_listArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listArea.Location = new System.Drawing.Point(26, 63);
            this.dataGridView_listArea.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_listArea.Name = "dataGridView_listArea";
            this.dataGridView_listArea.RowHeadersWidth = 51;
            this.dataGridView_listArea.Size = new System.Drawing.Size(306, 365);
            this.dataGridView_listArea.TabIndex = 8;
            this.dataGridView_listArea.Click += new System.EventHandler(this.dataGridView_listArea_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Danh sách khu vực";
            // 
            // dataGridView_listCom
            // 
            this.dataGridView_listCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listCom.Location = new System.Drawing.Point(445, 63);
            this.dataGridView_listCom.Name = "dataGridView_listCom";
            this.dataGridView_listCom.RowHeadersWidth = 51;
            this.dataGridView_listCom.RowTemplate.Height = 24;
            this.dataGridView_listCom.Size = new System.Drawing.Size(838, 375);
            this.dataGridView_listCom.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = ">>>>>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Chi tiết khu vực :";
            // 
            // AreaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 552);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_listCom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_listArea);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AreaList";
            this.Text = "AreaList";
            this.Load += new System.EventHandler(this.AreaList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listCom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_listArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_listCom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}