
namespace winformPaintStore
{
    partial class FormHomePage
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
            this.dgv_paintList = new System.Windows.Forms.DataGridView();
            this.dgv_ShoppingCart = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.btn_AddtoCart = new System.Windows.Forms.Button();
            this.btn_RemovefromCart = new System.Windows.Forms.Button();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.tb_SearchByBrand = new System.Windows.Forms.TextBox();
            this.tb_SearchByColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_paintList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ShoppingCart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_paintList
            // 
            this.dgv_paintList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_paintList.Location = new System.Drawing.Point(12, 98);
            this.dgv_paintList.Name = "dgv_paintList";
            this.dgv_paintList.Size = new System.Drawing.Size(446, 267);
            this.dgv_paintList.TabIndex = 0;
            this.dgv_paintList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_paintList_CellClick);
            // 
            // dgv_ShoppingCart
            // 
            this.dgv_ShoppingCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ShoppingCart.Location = new System.Drawing.Point(509, 98);
            this.dgv_ShoppingCart.Name = "dgv_ShoppingCart";
            this.dgv_ShoppingCart.Size = new System.Drawing.Size(441, 267);
            this.dgv_ShoppingCart.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "list of available paints";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(694, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "shopping cart";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "WELLCOME";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Admin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 65);
            this.panel1.TabIndex = 9;
            // 
            // btn_Admin
            // 
            this.btn_Admin.Location = new System.Drawing.Point(867, 21);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(75, 23);
            this.btn_Admin.TabIndex = 9;
            this.btn_Admin.Text = "Admin";
            this.btn_Admin.UseVisualStyleBackColor = true;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // btn_AddtoCart
            // 
            this.btn_AddtoCart.Location = new System.Drawing.Point(509, 379);
            this.btn_AddtoCart.Name = "btn_AddtoCart";
            this.btn_AddtoCart.Size = new System.Drawing.Size(117, 36);
            this.btn_AddtoCart.TabIndex = 10;
            this.btn_AddtoCart.Text = "Add to Cart";
            this.btn_AddtoCart.UseVisualStyleBackColor = true;
            this.btn_AddtoCart.Click += new System.EventHandler(this.btn_AddtoCart_Click);
            // 
            // btn_RemovefromCart
            // 
            this.btn_RemovefromCart.Location = new System.Drawing.Point(663, 379);
            this.btn_RemovefromCart.Name = "btn_RemovefromCart";
            this.btn_RemovefromCart.Size = new System.Drawing.Size(117, 36);
            this.btn_RemovefromCart.TabIndex = 11;
            this.btn_RemovefromCart.Text = "Remvoe from Cart";
            this.btn_RemovefromCart.UseVisualStyleBackColor = true;
            this.btn_RemovefromCart.Click += new System.EventHandler(this.btn_RemovefromCart_Click);
            // 
            // btn_Pay
            // 
            this.btn_Pay.Location = new System.Drawing.Point(814, 379);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(117, 36);
            this.btn_Pay.TabIndex = 13;
            this.btn_Pay.Text = "Pay";
            this.btn_Pay.UseVisualStyleBackColor = true;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            // 
            // tb_SearchByBrand
            // 
            this.tb_SearchByBrand.Location = new System.Drawing.Point(29, 395);
            this.tb_SearchByBrand.Name = "tb_SearchByBrand";
            this.tb_SearchByBrand.Size = new System.Drawing.Size(180, 20);
            this.tb_SearchByBrand.TabIndex = 14;
            this.tb_SearchByBrand.TextChanged += new System.EventHandler(this.tb_SearchByBrand_TextChanged);
            // 
            // tb_SearchByColor
            // 
            this.tb_SearchByColor.Location = new System.Drawing.Point(231, 395);
            this.tb_SearchByColor.Name = "tb_SearchByColor";
            this.tb_SearchByColor.Size = new System.Drawing.Size(180, 20);
            this.tb_SearchByColor.TabIndex = 15;
            this.tb_SearchByColor.TextChanged += new System.EventHandler(this.tb_SearchByColor_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "search by color :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "search by brand :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(464, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Note :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(464, 473);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(416, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Add to Cart : first select (click item) that you want in paint data grid  -> clic" +
    "k Add to Cart ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(464, 497);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(488, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Remove form Cart : first select (click item) that you want to remove from shoppin" +
    "g cart -> click Remove";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Note :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 473);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(258, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "write the brand you want on the search by brand box ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 497);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(247, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "write the color you want on the search by color box";
            // 
            // FormHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 529);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_SearchByColor);
            this.Controls.Add(this.tb_SearchByBrand);
            this.Controls.Add(this.btn_Pay);
            this.Controls.Add(this.btn_RemovefromCart);
            this.Controls.Add(this.btn_AddtoCart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_ShoppingCart);
            this.Controls.Add(this.dgv_paintList);
            this.Name = "FormHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.FormHomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_paintList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ShoppingCart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_paintList;
        private System.Windows.Forms.DataGridView dgv_ShoppingCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_AddtoCart;
        private System.Windows.Forms.Button btn_RemovefromCart;
        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.TextBox tb_SearchByBrand;
        private System.Windows.Forms.TextBox tb_SearchByColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

