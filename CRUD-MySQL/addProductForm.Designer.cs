namespace CRUD_MySQL
{
    partial class addProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addProductForm));
            this.label1 = new System.Windows.Forms.Label();
            this.proName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.proPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.proStocks = new System.Windows.Forms.TextBox();
            this.saveProduct = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.categoriesList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Prompt SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(261, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "เพิ่มข้อมูลสินค้า";
            // 
            // proName
            // 
            this.proName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.proName.Font = new System.Drawing.Font("Prompt", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.proName.Location = new System.Drawing.Point(283, 109);
            this.proName.Name = "proName";
            this.proName.Size = new System.Drawing.Size(196, 30);
            this.proName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Prompt", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(213, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "ขื่อสินค้า";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Prompt", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(204, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "ราคาสินค้า";
            // 
            // proPrice
            // 
            this.proPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.proPrice.Font = new System.Drawing.Font("Prompt", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.proPrice.Location = new System.Drawing.Point(283, 217);
            this.proPrice.MaxLength = 1000;
            this.proPrice.Name = "proPrice";
            this.proPrice.Size = new System.Drawing.Size(196, 30);
            this.proPrice.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Prompt", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(167, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "สต็อกสินค้าสินค้า";
            // 
            // proStocks
            // 
            this.proStocks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.proStocks.Font = new System.Drawing.Font("Prompt", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.proStocks.Location = new System.Drawing.Point(283, 277);
            this.proStocks.MaxLength = 99;
            this.proStocks.Name = "proStocks";
            this.proStocks.Size = new System.Drawing.Size(196, 30);
            this.proStocks.TabIndex = 5;
            // 
            // saveProduct
            // 
            this.saveProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveProduct.Font = new System.Drawing.Font("Prompt", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.saveProduct.Location = new System.Drawing.Point(283, 334);
            this.saveProduct.Name = "saveProduct";
            this.saveProduct.Size = new System.Drawing.Size(97, 35);
            this.saveProduct.TabIndex = 7;
            this.saveProduct.Text = "บันทึกข้อมูล";
            this.saveProduct.UseVisualStyleBackColor = true;
            this.saveProduct.Click += new System.EventHandler(this.saveProduct_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Prompt", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.Location = new System.Drawing.Point(386, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "รีเช็ต";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Prompt", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(181, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "หมวดหมู่สินค้า";
            // 
            // categoriesList
            // 
            this.categoriesList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoriesList.Font = new System.Drawing.Font("Prompt", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.categoriesList.FormattingEnabled = true;
            this.categoriesList.Location = new System.Drawing.Point(283, 163);
            this.categoriesList.Name = "categoriesList";
            this.categoriesList.Size = new System.Drawing.Size(196, 30);
            this.categoriesList.TabIndex = 11;
            // 
            // addProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 454);
            this.Controls.Add(this.categoriesList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.saveProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.proStocks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.proPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.proName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addProductForm";
            this.Text = "เพิ่มข้อมูลสินค้า";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox proName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox proPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox proStocks;
        private System.Windows.Forms.Button saveProduct;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox categoriesList;
    }
}