
namespace Polar
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Panel panel1;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxXmin = new System.Windows.Forms.TextBox();
            this.textBoxYmin = new System.Windows.Forms.TextBox();
            this.textBoxXmax = new System.Windows.Forms.TextBox();
            this.textBoxYmax = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Pakhnin_proj = new System.Windows.Forms.GroupBox();
            panel1 = new System.Windows.Forms.Panel();
            this.Pakhnin_proj.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(200, 100);
            panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "X max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Y max";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(507, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Угол Ф";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(505, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "r-радиус";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 49);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // textBoxXmin
            // 
            this.textBoxXmin.Location = new System.Drawing.Point(49, 26);
            this.textBoxXmin.Name = "textBoxXmin";
            this.textBoxXmin.Size = new System.Drawing.Size(50, 20);
            this.textBoxXmin.TabIndex = 12;
            this.textBoxXmin.Text = "-10";
            this.textBoxXmin.TextChanged += new System.EventHandler(this.textBoxXmin_TextChanged);
            // 
            // textBoxYmin
            // 
            this.textBoxYmin.Location = new System.Drawing.Point(49, 94);
            this.textBoxYmin.Name = "textBoxYmin";
            this.textBoxYmin.Size = new System.Drawing.Size(50, 20);
            this.textBoxYmin.TabIndex = 13;
            this.textBoxYmin.Text = "-10";
            // 
            // textBoxXmax
            // 
            this.textBoxXmax.Location = new System.Drawing.Point(163, 29);
            this.textBoxXmax.Name = "textBoxXmax";
            this.textBoxXmax.Size = new System.Drawing.Size(50, 20);
            this.textBoxXmax.TabIndex = 14;
            this.textBoxXmax.Text = "10";
            this.textBoxXmax.TextChanged += new System.EventHandler(this.textBoxXmax_TextChanged);
            // 
            // textBoxYmax
            // 
            this.textBoxYmax.Location = new System.Drawing.Point(164, 92);
            this.textBoxYmax.Name = "textBoxYmax";
            this.textBoxYmax.Size = new System.Drawing.Size(50, 20);
            this.textBoxYmax.TabIndex = 15;
            this.textBoxYmax.Text = "10";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 25;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(557, 36);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(50, 20);
            this.textBox5.TabIndex = 20;
            this.textBox5.Text = "1";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(559, 94);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(50, 20);
            this.textBox6.TabIndex = 21;
            this.textBox6.Text = "1";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 939);
            this.panel2.TabIndex = 22;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // Pakhnin_proj
            // 
            this.Pakhnin_proj.Controls.Add(this.label1);
            this.Pakhnin_proj.Controls.Add(this.button1);
            this.Pakhnin_proj.Controls.Add(this.textBox6);
            this.Pakhnin_proj.Controls.Add(this.textBoxXmin);
            this.Pakhnin_proj.Controls.Add(this.textBox5);
            this.Pakhnin_proj.Controls.Add(this.label10);
            this.Pakhnin_proj.Controls.Add(this.label2);
            this.Pakhnin_proj.Controls.Add(this.textBoxYmin);
            this.Pakhnin_proj.Controls.Add(this.label9);
            this.Pakhnin_proj.Controls.Add(this.label3);
            this.Pakhnin_proj.Controls.Add(this.label8);
            this.Pakhnin_proj.Controls.Add(this.textBoxXmax);
            this.Pakhnin_proj.Controls.Add(this.textBox2);
            this.Pakhnin_proj.Controls.Add(this.label4);
            this.Pakhnin_proj.Controls.Add(this.label7);
            this.Pakhnin_proj.Controls.Add(this.textBoxYmax);
            this.Pakhnin_proj.Controls.Add(this.label5);
            this.Pakhnin_proj.Controls.Add(this.label6);
            this.Pakhnin_proj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pakhnin_proj.Location = new System.Drawing.Point(0, 939);
            this.Pakhnin_proj.Name = "Pakhnin_proj";
            this.Pakhnin_proj.Size = new System.Drawing.Size(1080, 141);
            this.Pakhnin_proj.TabIndex = 23;
            this.Pakhnin_proj.TabStop = false;
            this.Pakhnin_proj.Text = "Pakhnin_proj";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 1080);
            this.Controls.Add(this.panel2);
            this.Controls.Add(panel1);
            this.Controls.Add(this.Pakhnin_proj);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "GUU Polarka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Pakhnin_proj.ResumeLayout(false);
            this.Pakhnin_proj.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxXmin;
        private System.Windows.Forms.TextBox textBoxYmin;
        private System.Windows.Forms.TextBox textBoxXmax;
        private System.Windows.Forms.TextBox textBoxYmax;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox Pakhnin_proj;
    }
}

