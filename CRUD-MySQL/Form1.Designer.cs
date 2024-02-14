namespace CRUD_MySQL
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.เมนToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productManages = new System.Windows.Forms.ToolStripMenuItem();
            this.showProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.productTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.howProductTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductType = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeManages = new System.Windows.Forms.ToolStripMenuItem();
            this.showEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.usersManages = new System.Windows.Forms.ToolStripMenuItem();
            this.showUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.addUser = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuList = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.menuList.SuspendLayout();
            this.SuspendLayout();
            // 
            // เมนToolStripMenuItem
            // 
            this.เมนToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productManages,
            this.productTypes,
            this.employeeManages,
            this.usersManages,
            this.logout});
            this.เมนToolStripMenuItem.Name = "เมนToolStripMenuItem";
            this.เมนToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.เมนToolStripMenuItem.Text = "เมนู";
            // 
            // productManages
            // 
            this.productManages.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showProducts});
            this.productManages.Name = "productManages";
            this.productManages.Size = new System.Drawing.Size(224, 26);
            this.productManages.Text = "จัดการข้อมูลสินค้า";
            // 
            // showProducts
            // 
            this.showProducts.Name = "showProducts";
            this.showProducts.Size = new System.Drawing.Size(224, 26);
            this.showProducts.Text = "แสดงรายการสินค้า";
            this.showProducts.Click += new System.EventHandler(this.showProducts_Click);
            // 
            // productTypes
            // 
            this.productTypes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howProductTypes,
            this.addProductType});
            this.productTypes.Name = "productTypes";
            this.productTypes.Size = new System.Drawing.Size(224, 26);
            this.productTypes.Text = "จัดการประเภทสินค้า";
            // 
            // howProductTypes
            // 
            this.howProductTypes.Name = "howProductTypes";
            this.howProductTypes.Size = new System.Drawing.Size(240, 26);
            this.howProductTypes.Text = "แสดงรายการประเภทสินค้า";
            // 
            // addProductType
            // 
            this.addProductType.Name = "addProductType";
            this.addProductType.Size = new System.Drawing.Size(240, 26);
            this.addProductType.Text = "เพิ่มข้อมูลประเภทสินค้า";
            // 
            // employeeManages
            // 
            this.employeeManages.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showEmployees,
            this.addEmployee});
            this.employeeManages.Name = "employeeManages";
            this.employeeManages.Size = new System.Drawing.Size(224, 26);
            this.employeeManages.Text = "จัดการข้อมูลพนักงาน";
            // 
            // showEmployees
            // 
            this.showEmployees.Name = "showEmployees";
            this.showEmployees.Size = new System.Drawing.Size(205, 26);
            this.showEmployees.Text = "แสดงข้อมูลพนักงาน";
            // 
            // addEmployee
            // 
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(205, 26);
            this.addEmployee.Text = "เพิ่มข้อมูลพนักงาน";
            // 
            // usersManages
            // 
            this.usersManages.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showUsers,
            this.addUser});
            this.usersManages.Name = "usersManages";
            this.usersManages.Size = new System.Drawing.Size(224, 26);
            this.usersManages.Text = "จัดการสมาชิก";
            // 
            // showUsers
            // 
            this.showUsers.Name = "showUsers";
            this.showUsers.Size = new System.Drawing.Size(196, 26);
            this.showUsers.Text = "แสดงข้อมูลสมาชิก";
            // 
            // addUser
            // 
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(196, 26);
            this.addUser.Text = "เพิ่มข้อมูลสมาชิก";
            // 
            // logout
            // 
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(224, 26);
            this.logout.Text = "ออกจากระบบ";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // menuList
            // 
            this.menuList.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menuList.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.เมนToolStripMenuItem});
            this.menuList.Location = new System.Drawing.Point(0, 0);
            this.menuList.Name = "menuList";
            this.menuList.Size = new System.Drawing.Size(1139, 28);
            this.menuList.TabIndex = 1;
            this.menuList.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "คิดไม่ออกว่าจะทำอะไรดี เดี๋ยวมาคิดอีกที";
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuList);
            this.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "dashboard";
            this.Text = "Dashboard";
            this.menuList.ResumeLayout(false);
            this.menuList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem เมนToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productManages;
        private System.Windows.Forms.ToolStripMenuItem showProducts;
        private System.Windows.Forms.ToolStripMenuItem productTypes;
        private System.Windows.Forms.ToolStripMenuItem howProductTypes;
        private System.Windows.Forms.ToolStripMenuItem addProductType;
        private System.Windows.Forms.ToolStripMenuItem employeeManages;
        private System.Windows.Forms.ToolStripMenuItem showEmployees;
        private System.Windows.Forms.ToolStripMenuItem addEmployee;
        private System.Windows.Forms.ToolStripMenuItem usersManages;
        private System.Windows.Forms.ToolStripMenuItem showUsers;
        private System.Windows.Forms.ToolStripMenuItem addUser;
        private System.Windows.Forms.ToolStripMenuItem logout;
        private System.Windows.Forms.MenuStrip menuList;
        private System.Windows.Forms.Label label1;
    }
}

