
namespace winformPaintStore.View
{
    partial class FormPayment
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
            this.dgv_ShoppingCartPay = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_TotalCost = new System.Windows.Forms.Label();
            this.btwn_Pay = new System.Windows.Forms.Button();
            this.tb_TelpNumber = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_BuyerMoney = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ShoppingCartPay)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_ShoppingCartPay
            // 
            this.dgv_ShoppingCartPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ShoppingCartPay.Location = new System.Drawing.Point(23, 108);
            this.dgv_ShoppingCartPay.Name = "dgv_ShoppingCartPay";
            this.dgv_ShoppingCartPay.Size = new System.Drawing.Size(438, 282);
            this.dgv_ShoppingCartPay.TabIndex = 0;
            this.dgv_ShoppingCartPay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ShoppingCartPay_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 58);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ShoppingCart :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Buyer Name :";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(684, 172);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(199, 20);
            this.tb_Name.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(608, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Cost : ";
            // 
            // lbl_TotalCost
            // 
            this.lbl_TotalCost.AutoSize = true;
            this.lbl_TotalCost.Location = new System.Drawing.Point(723, 124);
            this.lbl_TotalCost.Name = "lbl_TotalCost";
            this.lbl_TotalCost.Size = new System.Drawing.Size(77, 13);
            this.lbl_TotalCost.TabIndex = 7;
            this.lbl_TotalCost.Text = "ShoppingCart :";
            // 
            // btwn_Pay
            // 
            this.btwn_Pay.Location = new System.Drawing.Point(682, 327);
            this.btwn_Pay.Name = "btwn_Pay";
            this.btwn_Pay.Size = new System.Drawing.Size(201, 53);
            this.btwn_Pay.TabIndex = 8;
            this.btwn_Pay.Text = "Pay";
            this.btwn_Pay.UseVisualStyleBackColor = true;
            this.btwn_Pay.Click += new System.EventHandler(this.btwn_Pay_Click);
            // 
            // tb_TelpNumber
            // 
            this.tb_TelpNumber.Location = new System.Drawing.Point(684, 208);
            this.tb_TelpNumber.Name = "tb_TelpNumber";
            this.tb_TelpNumber.Size = new System.Drawing.Size(199, 20);
            this.tb_TelpNumber.TabIndex = 9;
            // 
            // tb_Address
            // 
            this.tb_Address.Location = new System.Drawing.Point(684, 243);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(199, 20);
            this.tb_Address.TabIndex = 10;
            // 
            // tb_BuyerMoney
            // 
            this.tb_BuyerMoney.Location = new System.Drawing.Point(682, 278);
            this.tb_BuyerMoney.Name = "tb_BuyerMoney";
            this.tb_BuyerMoney.Size = new System.Drawing.Size(199, 20);
            this.tb_BuyerMoney.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(565, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Telp Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(565, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Address : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(565, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Enter money :";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(492, 327);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(141, 53);
            this.btn_back.TabIndex = 15;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 438);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_BuyerMoney);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.tb_TelpNumber);
            this.Controls.Add(this.btwn_Pay);
            this.Controls.Add(this.lbl_TotalCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_ShoppingCartPay);
            this.Name = "FormPayment";
            this.Text = "PaymentPage";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ShoppingCartPay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ShoppingCartPay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_TotalCost;
        private System.Windows.Forms.Button btwn_Pay;
        private System.Windows.Forms.TextBox tb_TelpNumber;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_BuyerMoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_back;
    }
}