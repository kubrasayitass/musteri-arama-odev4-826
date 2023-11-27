namespace müsteri_arama_ödev4_826
{
    partial class Form1
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
            this.lblMusterileri = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMusterileri
            // 
            this.lblMusterileri.AutoSize = true;
            this.lblMusterileri.Location = new System.Drawing.Point(30, 44);
            this.lblMusterileri.Name = "lblMusterileri";
            this.lblMusterileri.Size = new System.Drawing.Size(57, 13);
            this.lblMusterileri.TabIndex = 0;
            this.lblMusterileri.Text = "Müşterileri:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(26, 218);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(61, 13);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Müşteri adı:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "efe",
            "kübra",
            "eymen",
            "nisa",
            "ömer",
            "sukeyna ",
            "deniz",
            "mehmet",
            "umut",
            "rabia",
            "yunus"});
            this.listBox1.Location = new System.Drawing.Point(92, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 160);
            this.listBox1.TabIndex = 2;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(73, 256);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(139, 31);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(102, 218);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblMusterileri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusterileri;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAd;
    }
}

