namespace modul_2_1302190047
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        decimal bill1;
        decimal bill2;
        int opr;
        Boolean opr_selesai = false;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textDisplay1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonSamadengan = new System.Windows.Forms.Button();
            this.textDisplay2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textDisplay1
            // 
            this.textDisplay1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textDisplay1.Location = new System.Drawing.Point(12, 100);
            this.textDisplay1.Multiline = true;
            this.textDisplay1.Name = "textDisplay1";
            this.textDisplay1.Size = new System.Drawing.Size(529, 49);
            this.textDisplay1.TabIndex = 0;
            this.textDisplay1.Text = "0";
            this.textDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(151, 254);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 50);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(288, 254);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 50);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 324);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(119, 50);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(151, 324);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(119, 50);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(288, 324);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(119, 50);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(151, 391);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(119, 50);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTambah.Location = new System.Drawing.Point(428, 183);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(113, 77);
            this.buttonTambah.TabIndex = 11;
            this.buttonTambah.Text = "+";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // buttonSamadengan
            // 
            this.buttonSamadengan.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSamadengan.Location = new System.Drawing.Point(428, 294);
            this.buttonSamadengan.Name = "buttonSamadengan";
            this.buttonSamadengan.Size = new System.Drawing.Size(113, 80);
            this.buttonSamadengan.TabIndex = 12;
            this.buttonSamadengan.Text = "=";
            this.buttonSamadengan.UseVisualStyleBackColor = true;
            this.buttonSamadengan.Click += new System.EventHandler(this.buttonSamadengan_Click);
            // 
            // textDisplay2
            // 
            this.textDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDisplay2.Location = new System.Drawing.Point(22, 111);
            this.textDisplay2.Name = "textDisplay2";
            this.textDisplay2.Size = new System.Drawing.Size(49, 20);
            this.textDisplay2.TabIndex = 13;
            this.textDisplay2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.textDisplay2);
            this.Controls.Add(this.buttonSamadengan);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textDisplay1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textDisplay1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonTambah;
        private Button buttonSamadengan;
        private TextBox textDisplay2;
    }
}