
namespace QLNet
{
    partial class ListMenu
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
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.textBox_FoodName = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelFoodName = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Location = new System.Drawing.Point(376, 15);
            this.dataGridViewMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.RowHeadersWidth = 51;
            this.dataGridViewMenu.Size = new System.Drawing.Size(522, 217);
            this.dataGridViewMenu.TabIndex = 0;
            this.dataGridViewMenu.Click += new System.EventHandler(this.dataGridViewMenu_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(499, 263);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 28);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "CHỈNH SỬA";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(628, 263);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(100, 28);
            this.buttonXoa.TabIndex = 2;
            this.buttonXoa.Text = "XÓA";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(765, 263);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "THOÁT";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(192, 235);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "THÊM";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(213, 139);
            this.textBox_Price.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(132, 22);
            this.textBox_Price.TabIndex = 8;
            // 
            // textBox_FoodName
            // 
            this.textBox_FoodName.Location = new System.Drawing.Point(213, 84);
            this.textBox_FoodName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_FoodName.Name = "textBox_FoodName";
            this.textBox_FoodName.Size = new System.Drawing.Size(132, 22);
            this.textBox_FoodName.TabIndex = 7;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(76, 144);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(57, 17);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Giá tiền";
            // 
            // labelFoodName
            // 
            this.labelFoodName.AutoSize = true;
            this.labelFoodName.Location = new System.Drawing.Point(76, 87);
            this.labelFoodName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFoodName.Name = "labelFoodName";
            this.labelFoodName.Size = new System.Drawing.Size(84, 17);
            this.labelFoodName.TabIndex = 5;
            this.labelFoodName.Text = "Tên món ăn";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(213, 39);
            this.textBox_Id.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(132, 22);
            this.textBox_Id.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID món ăn";
            // 
            // ListMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 374);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.textBox_FoodName);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelFoodName);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataGridViewMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListMenu";
            this.Text = "ListMenu";
            this.Load += new System.EventHandler(this.ListMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.TextBox textBox_FoodName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelFoodName;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label1;
    }
}