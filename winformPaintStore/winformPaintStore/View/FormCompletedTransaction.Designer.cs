
namespace winformPaintStore.View
{
    partial class FormCompletedTransaction
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_BuyerName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_totalCost = new System.Windows.Forms.Label();
            this.lbl_BuyerMoney = new System.Windows.Forms.Label();
            this.lbl_Changes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thank you, ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Cost : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Buyer Money : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Changes : ";
            // 
            // lbl_BuyerName
            // 
            this.lbl_BuyerName.AutoSize = true;
            this.lbl_BuyerName.Location = new System.Drawing.Point(131, 71);
            this.lbl_BuyerName.Name = "lbl_BuyerName";
            this.lbl_BuyerName.Size = new System.Drawing.Size(62, 13);
            this.lbl_BuyerName.TabIndex = 4;
            this.lbl_BuyerName.Text = "BuyerName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "have a great day";
            // 
            // lbl_totalCost
            // 
            this.lbl_totalCost.AutoSize = true;
            this.lbl_totalCost.Location = new System.Drawing.Point(159, 127);
            this.lbl_totalCost.Name = "lbl_totalCost";
            this.lbl_totalCost.Size = new System.Drawing.Size(48, 13);
            this.lbl_totalCost.TabIndex = 6;
            this.lbl_totalCost.Text = "totalCost";
            // 
            // lbl_BuyerMoney
            // 
            this.lbl_BuyerMoney.AutoSize = true;
            this.lbl_BuyerMoney.Location = new System.Drawing.Point(159, 173);
            this.lbl_BuyerMoney.Name = "lbl_BuyerMoney";
            this.lbl_BuyerMoney.Size = new System.Drawing.Size(65, 13);
            this.lbl_BuyerMoney.TabIndex = 7;
            this.lbl_BuyerMoney.Text = "buyerMoney";
            // 
            // lbl_Changes
            // 
            this.lbl_Changes.AutoSize = true;
            this.lbl_Changes.Location = new System.Drawing.Point(159, 218);
            this.lbl_Changes.Name = "lbl_Changes";
            this.lbl_Changes.Size = new System.Drawing.Size(75, 13);
            this.lbl_Changes.TabIndex = 8;
            this.lbl_Changes.Text = "buyerChanges";
            // 
            // FormCompletedTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 377);
            this.Controls.Add(this.lbl_Changes);
            this.Controls.Add(this.lbl_BuyerMoney);
            this.Controls.Add(this.lbl_totalCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_BuyerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCompletedTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompletedTransactionPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_BuyerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_totalCost;
        private System.Windows.Forms.Label lbl_BuyerMoney;
        private System.Windows.Forms.Label lbl_Changes;
    }
}