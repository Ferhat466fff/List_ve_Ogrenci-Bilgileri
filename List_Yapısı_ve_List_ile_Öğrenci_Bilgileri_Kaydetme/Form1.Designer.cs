namespace List_Yapısı_ve_List_ile_Öğrenci_Bilgileri_Kaydetme
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
            this.btn_Listele1 = new System.Windows.Forms.Button();
            this.btn_Listele2 = new System.Windows.Forms.Button();
            this.btn_Listele3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Kontrol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Listele1
            // 
            this.btn_Listele1.Location = new System.Drawing.Point(22, 492);
            this.btn_Listele1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Listele1.Name = "btn_Listele1";
            this.btn_Listele1.Size = new System.Drawing.Size(354, 56);
            this.btn_Listele1.TabIndex = 0;
            this.btn_Listele1.Text = "Listele1";
            this.btn_Listele1.UseVisualStyleBackColor = true;
            this.btn_Listele1.Click += new System.EventHandler(this.btn_Listele1_Click);
            // 
            // btn_Listele2
            // 
            this.btn_Listele2.Location = new System.Drawing.Point(399, 492);
            this.btn_Listele2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Listele2.Name = "btn_Listele2";
            this.btn_Listele2.Size = new System.Drawing.Size(354, 56);
            this.btn_Listele2.TabIndex = 1;
            this.btn_Listele2.Text = "Listele2";
            this.btn_Listele2.UseVisualStyleBackColor = true;
            this.btn_Listele2.Click += new System.EventHandler(this.btn_Listele2_Click_1);
            // 
            // btn_Listele3
            // 
            this.btn_Listele3.Location = new System.Drawing.Point(778, 492);
            this.btn_Listele3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Listele3.Name = "btn_Listele3";
            this.btn_Listele3.Size = new System.Drawing.Size(354, 56);
            this.btn_Listele3.TabIndex = 2;
            this.btn_Listele3.Text = "Listele3";
            this.btn_Listele3.UseVisualStyleBackColor = true;
            this.btn_Listele3.Click += new System.EventHandler(this.btn_Listele3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 26;
            this.listBox1.Location = new System.Drawing.Point(22, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(354, 472);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 26;
            this.listBox2.Location = new System.Drawing.Point(399, 13);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(354, 472);
            this.listBox2.TabIndex = 4;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 26;
            this.listBox3.Location = new System.Drawing.Point(778, 13);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(354, 472);
            this.listBox3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 569);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sayı Giriniz:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(517, 555);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 40);
            this.textBox1.TabIndex = 7;
            // 
            // btn_Kontrol
            // 
            this.btn_Kontrol.Location = new System.Drawing.Point(661, 555);
            this.btn_Kontrol.Name = "btn_Kontrol";
            this.btn_Kontrol.Size = new System.Drawing.Size(92, 40);
            this.btn_Kontrol.TabIndex = 8;
            this.btn_Kontrol.Text = "kontrol";
            this.btn_Kontrol.UseVisualStyleBackColor = true;
            this.btn_Kontrol.Click += new System.EventHandler(this.btn_Kontrol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 635);
            this.Controls.Add(this.btn_Kontrol);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_Listele3);
            this.Controls.Add(this.btn_Listele2);
            this.Controls.Add(this.btn_Listele1);
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Listele1;
        private System.Windows.Forms.Button btn_Listele2;
        private System.Windows.Forms.Button btn_Listele3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Kontrol;
    }
}

