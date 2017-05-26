namespace WallyPOS
{
    partial class FrontPage
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
            this.orderButt = new System.Windows.Forms.Button();
            this.Exitbutt = new System.Windows.Forms.Button();
            this.finOrlabel = new System.Windows.Forms.Label();
            this.findOrderIDBox = new System.Windows.Forms.TextBox();
            this.cancelOrderbutt = new System.Windows.Forms.Button();
            this.paidRadioButt = new System.Windows.Forms.RadioButton();
            this.PendingRadioButt = new System.Windows.Forms.RadioButton();
            this.inventorybutt = new System.Windows.Forms.Button();
            this.closebutt = new System.Windows.Forms.Button();
            this.dispOrbutt = new System.Windows.Forms.Button();
            this.fNametextBox = new System.Windows.Forms.TextBox();
            this.nameLab = new System.Windows.Forms.Label();
            this.pendingOrderbutt = new System.Windows.Forms.Button();
            this.displayView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.displayView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderButt
            // 
            this.orderButt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.orderButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButt.Location = new System.Drawing.Point(31, 50);
            this.orderButt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orderButt.Name = "orderButt";
            this.orderButt.Size = new System.Drawing.Size(82, 63);
            this.orderButt.TabIndex = 0;
            this.orderButt.Text = "New Order";
            this.orderButt.UseVisualStyleBackColor = false;
            this.orderButt.Click += new System.EventHandler(this.orderButt_Click);
            // 
            // Exitbutt
            // 
            this.Exitbutt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Exitbutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutt.Location = new System.Drawing.Point(868, 695);
            this.Exitbutt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Exitbutt.Name = "Exitbutt";
            this.Exitbutt.Size = new System.Drawing.Size(112, 57);
            this.Exitbutt.TabIndex = 1;
            this.Exitbutt.Text = "CLOSE";
            this.Exitbutt.UseVisualStyleBackColor = false;
            // 
            // finOrlabel
            // 
            this.finOrlabel.AutoSize = true;
            this.finOrlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finOrlabel.Location = new System.Drawing.Point(275, 93);
            this.finOrlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.finOrlabel.Name = "finOrlabel";
            this.finOrlabel.Size = new System.Drawing.Size(70, 20);
            this.finOrlabel.TabIndex = 2;
            this.finOrlabel.Text = "Order ID";
            // 
            // findOrderIDBox
            // 
            this.findOrderIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findOrderIDBox.Location = new System.Drawing.Point(353, 84);
            this.findOrderIDBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.findOrderIDBox.Name = "findOrderIDBox";
            this.findOrderIDBox.Size = new System.Drawing.Size(97, 26);
            this.findOrderIDBox.TabIndex = 3;
            // 
            // cancelOrderbutt
            // 
            this.cancelOrderbutt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cancelOrderbutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelOrderbutt.Location = new System.Drawing.Point(295, 189);
            this.cancelOrderbutt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelOrderbutt.Name = "cancelOrderbutt";
            this.cancelOrderbutt.Size = new System.Drawing.Size(71, 56);
            this.cancelOrderbutt.TabIndex = 4;
            this.cancelOrderbutt.Text = "Cancel Order";
            this.cancelOrderbutt.UseVisualStyleBackColor = false;
            this.cancelOrderbutt.Click += new System.EventHandler(this.cancelOrderbutt_Click);
            // 
            // paidRadioButt
            // 
            this.paidRadioButt.AutoSize = true;
            this.paidRadioButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidRadioButt.Location = new System.Drawing.Point(279, 146);
            this.paidRadioButt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paidRadioButt.Name = "paidRadioButt";
            this.paidRadioButt.Size = new System.Drawing.Size(58, 24);
            this.paidRadioButt.TabIndex = 8;
            this.paidRadioButt.TabStop = true;
            this.paidRadioButt.Text = "Paid";
            this.paidRadioButt.UseVisualStyleBackColor = true;
            // 
            // PendingRadioButt
            // 
            this.PendingRadioButt.AutoSize = true;
            this.PendingRadioButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingRadioButt.Location = new System.Drawing.Point(365, 146);
            this.PendingRadioButt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PendingRadioButt.Name = "PendingRadioButt";
            this.PendingRadioButt.Size = new System.Drawing.Size(85, 24);
            this.PendingRadioButt.TabIndex = 9;
            this.PendingRadioButt.TabStop = true;
            this.PendingRadioButt.Text = "Pending";
            this.PendingRadioButt.UseVisualStyleBackColor = true;
            // 
            // inventorybutt
            // 
            this.inventorybutt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.inventorybutt.Location = new System.Drawing.Point(31, 146);
            this.inventorybutt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inventorybutt.Name = "inventorybutt";
            this.inventorybutt.Size = new System.Drawing.Size(100, 81);
            this.inventorybutt.TabIndex = 12;
            this.inventorybutt.Text = "Display Current Inventory";
            this.inventorybutt.UseVisualStyleBackColor = false;
            this.inventorybutt.Click += new System.EventHandler(this.inventorybutt_Click);
            // 
            // closebutt
            // 
            this.closebutt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.closebutt.Location = new System.Drawing.Point(643, 441);
            this.closebutt.Name = "closebutt";
            this.closebutt.Size = new System.Drawing.Size(91, 60);
            this.closebutt.TabIndex = 13;
            this.closebutt.Text = "Exit";
            this.closebutt.UseVisualStyleBackColor = false;
            this.closebutt.Click += new System.EventHandler(this.closebutt_Click);
            // 
            // dispOrbutt
            // 
            this.dispOrbutt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dispOrbutt.Location = new System.Drawing.Point(498, 84);
            this.dispOrbutt.Name = "dispOrbutt";
            this.dispOrbutt.Size = new System.Drawing.Size(91, 60);
            this.dispOrbutt.TabIndex = 14;
            this.dispOrbutt.Text = "Display Order";
            this.dispOrbutt.UseVisualStyleBackColor = false;
            this.dispOrbutt.Click += new System.EventHandler(this.dispOrbutt_Click);
            // 
            // fNametextBox
            // 
            this.fNametextBox.Location = new System.Drawing.Point(351, 50);
            this.fNametextBox.Name = "fNametextBox";
            this.fNametextBox.Size = new System.Drawing.Size(139, 26);
            this.fNametextBox.TabIndex = 15;
            // 
            // nameLab
            // 
            this.nameLab.AutoSize = true;
            this.nameLab.Location = new System.Drawing.Point(259, 56);
            this.nameLab.Name = "nameLab";
            this.nameLab.Size = new System.Drawing.Size(86, 20);
            this.nameLab.TabIndex = 16;
            this.nameLab.Text = "First Name";
            // 
            // pendingOrderbutt
            // 
            this.pendingOrderbutt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pendingOrderbutt.Location = new System.Drawing.Point(400, 189);
            this.pendingOrderbutt.Name = "pendingOrderbutt";
            this.pendingOrderbutt.Size = new System.Drawing.Size(125, 56);
            this.pendingOrderbutt.TabIndex = 17;
            this.pendingOrderbutt.Text = "Pay for Pending";
            this.pendingOrderbutt.UseVisualStyleBackColor = false;
            this.pendingOrderbutt.Click += new System.EventHandler(this.pendingOrderbutt_Click);
            // 
            // displayView
            // 
            this.displayView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.displayView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayView.Location = new System.Drawing.Point(12, 328);
            this.displayView.Name = "displayView";
            this.displayView.Size = new System.Drawing.Size(532, 173);
            this.displayView.TabIndex = 18;
            // 
            // FrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(759, 561);
            this.Controls.Add(this.displayView);
            this.Controls.Add(this.pendingOrderbutt);
            this.Controls.Add(this.nameLab);
            this.Controls.Add(this.fNametextBox);
            this.Controls.Add(this.dispOrbutt);
            this.Controls.Add(this.closebutt);
            this.Controls.Add(this.inventorybutt);
            this.Controls.Add(this.PendingRadioButt);
            this.Controls.Add(this.paidRadioButt);
            this.Controls.Add(this.cancelOrderbutt);
            this.Controls.Add(this.findOrderIDBox);
            this.Controls.Add(this.finOrlabel);
            this.Controls.Add(this.Exitbutt);
            this.Controls.Add(this.orderButt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrontPage";
            this.Text = "Wally\'s Point of Sale";
            ((System.ComponentModel.ISupportInitialize)(this.displayView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button orderButt;
        private System.Windows.Forms.Button Exitbutt;
        private System.Windows.Forms.Label finOrlabel;
        private System.Windows.Forms.TextBox findOrderIDBox;
        private System.Windows.Forms.Button cancelOrderbutt;
        private System.Windows.Forms.RadioButton paidRadioButt;
        private System.Windows.Forms.RadioButton PendingRadioButt;
        private System.Windows.Forms.Button inventorybutt;
        private System.Windows.Forms.Button closebutt;
        private System.Windows.Forms.Button dispOrbutt;
        private System.Windows.Forms.TextBox fNametextBox;
        private System.Windows.Forms.Label nameLab;
        private System.Windows.Forms.Button pendingOrderbutt;
        private System.Windows.Forms.DataGridView displayView;
    }
}

