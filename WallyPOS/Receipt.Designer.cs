namespace WallyPOS
{
    partial class Receipt
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
            this.grettinglabel = new System.Windows.Forms.Label();
            this.dislineLebel = new System.Windows.Forms.Label();
            this.salebutt = new System.Windows.Forms.Button();
            this.refundbutt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grettinglabel
            // 
            this.grettinglabel.AutoSize = true;
            this.grettinglabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grettinglabel.Location = new System.Drawing.Point(26, 13);
            this.grettinglabel.Name = "grettinglabel";
            this.grettinglabel.Size = new System.Drawing.Size(50, 18);
            this.grettinglabel.TabIndex = 0;
            this.grettinglabel.Text = "label1";
            // 
            // dislineLebel
            // 
            this.dislineLebel.AutoSize = true;
            this.dislineLebel.Location = new System.Drawing.Point(46, 220);
            this.dislineLebel.Name = "dislineLebel";
            this.dislineLebel.Size = new System.Drawing.Size(35, 13);
            this.dislineLebel.TabIndex = 1;
            this.dislineLebel.Text = "label1";
            // 
            // salebutt
            // 
            this.salebutt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.salebutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salebutt.Location = new System.Drawing.Point(49, 379);
            this.salebutt.Name = "salebutt";
            this.salebutt.Size = new System.Drawing.Size(109, 73);
            this.salebutt.TabIndex = 2;
            this.salebutt.Text = "sales record";
            this.salebutt.UseVisualStyleBackColor = false;
            this.salebutt.Click += new System.EventHandler(this.salebutt_Click);
            // 
            // refundbutt
            // 
            this.refundbutt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.refundbutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refundbutt.Location = new System.Drawing.Point(554, 381);
            this.refundbutt.Name = "refundbutt";
            this.refundbutt.Size = new System.Drawing.Size(105, 69);
            this.refundbutt.TabIndex = 3;
            this.refundbutt.Text = "Refund";
            this.refundbutt.UseVisualStyleBackColor = false;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 507);
            this.Controls.Add(this.refundbutt);
            this.Controls.Add(this.salebutt);
            this.Controls.Add(this.dislineLebel);
            this.Controls.Add(this.grettinglabel);
            this.Name = "Receipt";
            this.Text = "Sales Record";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label grettinglabel;
        private System.Windows.Forms.Label dislineLebel;
        private System.Windows.Forms.Button salebutt;
        private System.Windows.Forms.Button refundbutt;
    }
}