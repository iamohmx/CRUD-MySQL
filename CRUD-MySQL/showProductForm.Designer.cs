namespace CRUD_MySQL
{
    partial class showProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showProductForm));
            this.showProductViews = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.proId = new System.Windows.Forms.Label();
            this.updateData = new System.Windows.Forms.Button();
            this.proName = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.proPrice = new System.Windows.Forms.TextBox();
            this.proStocks = new System.Windows.Forms.TextBox();
            this.categoriesList = new System.Windows.Forms.ComboBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.addDataBtn = new System.Windows.Forms.Button();
            this.loadData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showProductViews)).BeginInit();
            this.SuspendLayout();
            // 
            // showProductViews
            // 
            this.showProductViews.AllowUserToOrderColumns = true;
            this.showProductViews.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showProductViews.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showProductViews.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showProductViews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showProductViews.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showProductViews.Location = new System.Drawing.Point(56, 178);
            this.showProductViews.Name = "showProductViews";
            this.showProductViews.RowHeadersWidth = 51;
            this.showProductViews.RowTemplate.Height = 24;
            this.showProductViews.Size = new System.Drawing.Size(761, 357);
            this.showProductViews.TabIndex = 2;
            this.showProductViews.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showProductViews_CellContentClick);
            this.showProductViews.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.showProductViews_CellMouseUp);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchTextBox.Font = new System.Drawing.Font("Prompt", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.searchTextBox.Location = new System.Drawing.Point(523, 125);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(218, 33);
            this.searchTextBox.TabIndex = 4;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBtn.Font = new System.Drawing.Font("Prompt", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.searchBtn.Location = new System.Drawing.Point(747, 125);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 33);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "ค้นหา";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Prompt", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(400, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "ค้นหารายการ";
            // 
            // proId
            // 
            this.proId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.proId.AutoSize = true;
            this.proId.Font = new System.Drawing.Font("Prompt", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.proId.Location = new System.Drawing.Point(51, 78);
            this.proId.Name = "proId";
            this.proId.Size = new System.Drawing.Size(82, 26);
            this.proId.TabIndex = 9;
            this.proId.Text = "รหัสสินค้า";
            // 
            // updateData
            // 
            this.updateData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateData.Font = new System.Drawing.Font("Prompt", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.updateData.Location = new System.Drawing.Point(666, 71);
            this.updateData.Name = "updateData";
            this.updateData.Size = new System.Drawing.Size(75, 33);
            this.updateData.TabIndex = 8;
            this.updateData.Text = "อัพเดต";
            this.updateData.UseVisualStyleBackColor = true;
            this.updateData.Click += new System.EventHandler(this.updateData_Click);
            // 
            // proName
            // 
            this.proName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.proName.Font = new System.Drawing.Font("Prompt", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.proName.Location = new System.Drawing.Point(201, 70);
            this.proName.Name = "proName";
            this.proName.Size = new System.Drawing.Size(180, 33);
            this.proName.TabIndex = 7;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteBtn.Font = new System.Drawing.Font("Prompt", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.deleteBtn.Location = new System.Drawing.Point(747, 71);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 33);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.Text = "ลบ";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // proPrice
            // 
            this.proPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.proPrice.Font = new System.Drawing.Font("Prompt", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.proPrice.Location = new System.Drawing.Point(520, 70);
            this.proPrice.Name = "proPrice";
            this.proPrice.Size = new System.Drawing.Size(60, 33);
            this.proPrice.TabIndex = 12;
            // 
            // proStocks
            // 
            this.proStocks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.proStocks.Font = new System.Drawing.Font("Prompt", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.proStocks.Location = new System.Drawing.Point(586, 70);
            this.proStocks.Name = "proStocks";
            this.proStocks.Size = new System.Drawing.Size(60, 33);
            this.proStocks.TabIndex = 13;
            // 
            // categoriesList
            // 
            this.categoriesList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoriesList.Font = new System.Drawing.Font("Prompt", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.categoriesList.FormattingEnabled = true;
            this.categoriesList.Location = new System.Drawing.Point(387, 70);
            this.categoriesList.Name = "categoriesList";
            this.categoriesList.Size = new System.Drawing.Size(127, 34);
            this.categoriesList.TabIndex = 14;
            // 
            // Id
            // 
            this.Id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Id.Font = new System.Drawing.Font("Prompt", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Id.Location = new System.Drawing.Point(139, 71);
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Size = new System.Drawing.Size(44, 33);
            this.Id.TabIndex = 15;
            // 
            // addDataBtn
            // 
            this.addDataBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addDataBtn.Font = new System.Drawing.Font("Prompt", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.addDataBtn.Location = new System.Drawing.Point(601, 12);
            this.addDataBtn.Name = "addDataBtn";
            this.addDataBtn.Size = new System.Drawing.Size(106, 33);
            this.addDataBtn.TabIndex = 16;
            this.addDataBtn.Text = "เพิ่มข้อมูล";
            this.addDataBtn.UseVisualStyleBackColor = true;
            this.addDataBtn.Click += new System.EventHandler(this.addDataBtn_Click);
            // 
            // loadData
            // 
            this.loadData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadData.Font = new System.Drawing.Font("Prompt", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.loadData.Location = new System.Drawing.Point(716, 12);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(106, 33);
            this.loadData.TabIndex = 17;
            this.loadData.Text = "รีเฟรช";
            this.loadData.UseVisualStyleBackColor = true;
            this.loadData.Click += new System.EventHandler(this.loadData_Click);
            // 
            // showProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 598);
            this.Controls.Add(this.loadData);
            this.Controls.Add(this.addDataBtn);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.categoriesList);
            this.Controls.Add(this.proStocks);
            this.Controls.Add(this.proPrice);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.proId);
            this.Controls.Add(this.updateData);
            this.Controls.Add(this.proName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.showProductViews);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "showProductForm";
            this.Text = "แสดงรายการสินค้า";
            ((System.ComponentModel.ISupportInitialize)(this.showProductViews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView showProductViews;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label proId;
        private System.Windows.Forms.Button updateData;
        private System.Windows.Forms.TextBox proName;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox proPrice;
        private System.Windows.Forms.TextBox proStocks;
        private System.Windows.Forms.ComboBox categoriesList;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Button addDataBtn;
        private System.Windows.Forms.Button loadData;
    }
}