namespace WallyPOS
{
    partial class OrderForm
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
            this.PhoneNolabel = new System.Windows.Forms.Label();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.FindCbutt = new System.Windows.Forms.Button();
            this.fnamelabel = new System.Windows.Forms.Label();
            this.fNameBox = new System.Windows.Forms.TextBox();
            this.LNamelabel = new System.Windows.Forms.Label();
            this.LNameBox = new System.Windows.Forms.TextBox();
            this.CreateCusbutt = new System.Windows.Forms.Button();
            this.selectProductlab = new System.Windows.Forms.Label();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.Quantlabel = new System.Windows.Forms.Label();
            this.orderdetailButt = new System.Windows.Forms.Button();
            this.branchlabel = new System.Windows.Forms.Label();
            this.checkInventorybutt = new System.Windows.Forms.Button();
            this.statusLlabel = new System.Windows.Forms.Label();
            this.paidradioButt = new System.Windows.Forms.RadioButton();
            this.pendingradioButt = new System.Windows.Forms.RadioButton();
            this.orderButt = new System.Windows.Forms.Button();
            this.receiptbutt = new System.Windows.Forms.Button();
            this.EOrderbutt = new System.Windows.Forms.Button();
            this.branchBox = new System.Windows.Forms.ComboBox();
            this.ProductListBox = new System.Windows.Forms.ComboBox();
            this.orderIDtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OrdIDtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PhoneNolabel
            // 
            this.PhoneNolabel.AutoSize = true;
            this.PhoneNolabel.Location = new System.Drawing.Point(12, 15);
            this.PhoneNolabel.Name = "PhoneNolabel";
            this.PhoneNolabel.Size = new System.Drawing.Size(79, 20);
            this.PhoneNolabel.TabIndex = 1;
            this.PhoneNolabel.Text = "Phone No";
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(107, 15);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(138, 26);
            this.PhoneBox.TabIndex = 2;
            // 
            // FindCbutt
            // 
            this.FindCbutt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FindCbutt.Location = new System.Drawing.Point(285, 3);
            this.FindCbutt.Name = "FindCbutt";
            this.FindCbutt.Size = new System.Drawing.Size(93, 50);
            this.FindCbutt.TabIndex = 3;
            this.FindCbutt.Text = "Find Customer";
            this.FindCbutt.UseVisualStyleBackColor = false;
            this.FindCbutt.Click += new System.EventHandler(this.FindCbutt_Click);
            // 
            // fnamelabel
            // 
            this.fnamelabel.AutoSize = true;
            this.fnamelabel.Location = new System.Drawing.Point(457, 12);
            this.fnamelabel.Name = "fnamelabel";
            this.fnamelabel.Size = new System.Drawing.Size(86, 20);
            this.fnamelabel.TabIndex = 6;
            this.fnamelabel.Text = "Firsr Name";
            // 
            // fNameBox
            // 
            this.fNameBox.Location = new System.Drawing.Point(552, 9);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Size = new System.Drawing.Size(192, 26);
            this.fNameBox.TabIndex = 7;
            // 
            // LNamelabel
            // 
            this.LNamelabel.AutoSize = true;
            this.LNamelabel.Location = new System.Drawing.Point(459, 47);
            this.LNamelabel.Name = "LNamelabel";
            this.LNamelabel.Size = new System.Drawing.Size(86, 20);
            this.LNamelabel.TabIndex = 8;
            this.LNamelabel.Text = "Last Name";
            // 
            // LNameBox
            // 
            this.LNameBox.Location = new System.Drawing.Point(554, 44);
            this.LNameBox.Name = "LNameBox";
            this.LNameBox.Size = new System.Drawing.Size(192, 26);
            this.LNameBox.TabIndex = 9;
            // 
            // CreateCusbutt
            // 
            this.CreateCusbutt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CreateCusbutt.Location = new System.Drawing.Point(599, 86);
            this.CreateCusbutt.Name = "CreateCusbutt";
            this.CreateCusbutt.Size = new System.Drawing.Size(112, 52);
            this.CreateCusbutt.TabIndex = 10;
            this.CreateCusbutt.Text = "Add Customer";
            this.CreateCusbutt.UseVisualStyleBackColor = false;
            this.CreateCusbutt.Click += new System.EventHandler(this.CreateCusbutt_Click);
            // 
            // selectProductlab
            // 
            this.selectProductlab.AutoSize = true;
            this.selectProductlab.Location = new System.Drawing.Point(12, 292);
            this.selectProductlab.Name = "selectProductlab";
            this.selectProductlab.Size = new System.Drawing.Size(113, 20);
            this.selectProductlab.TabIndex = 12;
            this.selectProductlab.Text = "Select Product";
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(461, 293);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(79, 26);
            this.quantityBox.TabIndex = 13;
            // 
            // Quantlabel
            // 
            this.Quantlabel.AutoSize = true;
            this.Quantlabel.Location = new System.Drawing.Point(387, 296);
            this.Quantlabel.Name = "Quantlabel";
            this.Quantlabel.Size = new System.Drawing.Size(68, 20);
            this.Quantlabel.TabIndex = 14;
            this.Quantlabel.Text = "Quantity";
            // 
            // orderdetailButt
            // 
            this.orderdetailButt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.orderdetailButt.Location = new System.Drawing.Point(552, 288);
            this.orderdetailButt.Name = "orderdetailButt";
            this.orderdetailButt.Size = new System.Drawing.Size(114, 50);
            this.orderdetailButt.TabIndex = 15;
            this.orderdetailButt.Text = "Add Order Detail";
            this.orderdetailButt.UseVisualStyleBackColor = false;
            this.orderdetailButt.Click += new System.EventHandler(this.orderdetailButt_Click);
            // 
            // branchlabel
            // 
            this.branchlabel.AutoSize = true;
            this.branchlabel.Location = new System.Drawing.Point(12, 134);
            this.branchlabel.Name = "branchlabel";
            this.branchlabel.Size = new System.Drawing.Size(60, 20);
            this.branchlabel.TabIndex = 16;
            this.branchlabel.Text = "Branch";
            // 
            // checkInventorybutt
            // 
            this.checkInventorybutt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checkInventorybutt.Location = new System.Drawing.Point(16, 349);
            this.checkInventorybutt.Name = "checkInventorybutt";
            this.checkInventorybutt.Size = new System.Drawing.Size(108, 64);
            this.checkInventorybutt.TabIndex = 18;
            this.checkInventorybutt.Text = "Check Inventory";
            this.checkInventorybutt.UseVisualStyleBackColor = false;
            this.checkInventorybutt.Click += new System.EventHandler(this.checkInventorybutt_Click);
            // 
            // statusLlabel
            // 
            this.statusLlabel.AutoSize = true;
            this.statusLlabel.Location = new System.Drawing.Point(3, 196);
            this.statusLlabel.Name = "statusLlabel";
            this.statusLlabel.Size = new System.Drawing.Size(100, 20);
            this.statusLlabel.TabIndex = 19;
            this.statusLlabel.Text = "Order Status";
            // 
            // paidradioButt
            // 
            this.paidradioButt.AutoSize = true;
            this.paidradioButt.Location = new System.Drawing.Point(125, 196);
            this.paidradioButt.Name = "paidradioButt";
            this.paidradioButt.Size = new System.Drawing.Size(58, 24);
            this.paidradioButt.TabIndex = 20;
            this.paidradioButt.TabStop = true;
            this.paidradioButt.Text = "Paid";
            this.paidradioButt.UseVisualStyleBackColor = true;
            // 
            // pendingradioButt
            // 
            this.pendingradioButt.AutoSize = true;
            this.pendingradioButt.Location = new System.Drawing.Point(207, 196);
            this.pendingradioButt.Name = "pendingradioButt";
            this.pendingradioButt.Size = new System.Drawing.Size(85, 24);
            this.pendingradioButt.TabIndex = 21;
            this.pendingradioButt.TabStop = true;
            this.pendingradioButt.Text = "Pending";
            this.pendingradioButt.UseVisualStyleBackColor = true;
            // 
            // orderButt
            // 
            this.orderButt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.orderButt.Location = new System.Drawing.Point(298, 131);
            this.orderButt.Name = "orderButt";
            this.orderButt.Size = new System.Drawing.Size(98, 42);
            this.orderButt.TabIndex = 22;
            this.orderButt.Text = "Order";
            this.orderButt.UseVisualStyleBackColor = false;
            this.orderButt.Click += new System.EventHandler(this.orderButt_Click);
            // 
            // receiptbutt
            // 
            this.receiptbutt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.receiptbutt.Location = new System.Drawing.Point(537, 420);
            this.receiptbutt.Name = "receiptbutt";
            this.receiptbutt.Size = new System.Drawing.Size(118, 71);
            this.receiptbutt.TabIndex = 23;
            this.receiptbutt.Text = "Customer Receipt";
            this.receiptbutt.UseVisualStyleBackColor = false;
            this.receiptbutt.Click += new System.EventHandler(this.receiptbutt_Click);
            // 
            // EOrderbutt
            // 
            this.EOrderbutt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.EOrderbutt.Location = new System.Drawing.Point(662, 581);
            this.EOrderbutt.Name = "EOrderbutt";
            this.EOrderbutt.Size = new System.Drawing.Size(96, 45);
            this.EOrderbutt.TabIndex = 24;
            this.EOrderbutt.Text = "Exit Order";
            this.EOrderbutt.UseVisualStyleBackColor = false;
            this.EOrderbutt.Click += new System.EventHandler(this.EOrderbutt_Click);
            // 
            // branchBox
            // 
            this.branchBox.FormattingEnabled = true;
            this.branchBox.Items.AddRange(new object[] {
            "Sports World",
            "Cambridge Mall   ",
            "St. Jacobs"});
            this.branchBox.Location = new System.Drawing.Point(94, 131);
            this.branchBox.Name = "branchBox";
            this.branchBox.Size = new System.Drawing.Size(121, 28);
            this.branchBox.TabIndex = 25;
            // 
            // ProductListBox
            // 
            this.ProductListBox.FormattingEnabled = true;
            this.ProductListBox.Items.AddRange(new object[] {
            "Disco Queen Wallpaper (roll)",
            "Countryside Wallpaper (roll)",
            "Victorian Lace Wallpaper (roll)",
            "Drywall Tape (roll) ",
            "Darywall tape (pkg) ",
            "Drywall Repair Compound (tube)"});
            this.ProductListBox.Location = new System.Drawing.Point(155, 290);
            this.ProductListBox.Name = "ProductListBox";
            this.ProductListBox.Size = new System.Drawing.Size(223, 28);
            this.ProductListBox.TabIndex = 26;
            // 
            // orderIDtextBox
            // 
            this.orderIDtextBox.Location = new System.Drawing.Point(555, 239);
            this.orderIDtextBox.Name = "orderIDtextBox";
            this.orderIDtextBox.Size = new System.Drawing.Size(100, 26);
            this.orderIDtextBox.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Latest OrderID";
            // 
            // OrdIDtextBox
            // 
            this.OrdIDtextBox.Location = new System.Drawing.Point(537, 387);
            this.OrdIDtextBox.Name = "OrdIDtextBox";
            this.OrdIDtextBox.Size = new System.Drawing.Size(100, 26);
            this.OrdIDtextBox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "OrderID";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OrdIDtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderIDtextBox);
            this.Controls.Add(this.ProductListBox);
            this.Controls.Add(this.branchBox);
            this.Controls.Add(this.EOrderbutt);
            this.Controls.Add(this.receiptbutt);
            this.Controls.Add(this.orderButt);
            this.Controls.Add(this.pendingradioButt);
            this.Controls.Add(this.paidradioButt);
            this.Controls.Add(this.statusLlabel);
            this.Controls.Add(this.checkInventorybutt);
            this.Controls.Add(this.branchlabel);
            this.Controls.Add(this.orderdetailButt);
            this.Controls.Add(this.Quantlabel);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.selectProductlab);
            this.Controls.Add(this.CreateCusbutt);
            this.Controls.Add(this.LNameBox);
            this.Controls.Add(this.LNamelabel);
            this.Controls.Add(this.fNameBox);
            this.Controls.Add(this.fnamelabel);
            this.Controls.Add(this.FindCbutt);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.PhoneNolabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PhoneNolabel;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.Button FindCbutt;
        private System.Windows.Forms.Label fnamelabel;
        private System.Windows.Forms.TextBox fNameBox;
        private System.Windows.Forms.Label LNamelabel;
        private System.Windows.Forms.TextBox LNameBox;
        private System.Windows.Forms.Button CreateCusbutt;
        private System.Windows.Forms.Label selectProductlab;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.Label Quantlabel;
        private System.Windows.Forms.Button orderdetailButt;
        private System.Windows.Forms.Label branchlabel;
        private System.Windows.Forms.Button checkInventorybutt;
        private System.Windows.Forms.Label statusLlabel;
        private System.Windows.Forms.RadioButton paidradioButt;
        private System.Windows.Forms.RadioButton pendingradioButt;
        private System.Windows.Forms.Button orderButt;
        private System.Windows.Forms.Button receiptbutt;
        private System.Windows.Forms.Button EOrderbutt;
        private System.Windows.Forms.ComboBox branchBox;
        private System.Windows.Forms.ComboBox ProductListBox;
        private System.Windows.Forms.TextBox orderIDtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OrdIDtextBox;
        private System.Windows.Forms.Label label3;
    }
}