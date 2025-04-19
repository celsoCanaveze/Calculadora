namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnplus = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btntimes = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            this.btnroot = new System.Windows.Forms.Button();
            this.btncube = new System.Windows.Forms.Button();
            this.btnequals = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnplus
            // 
            this.btnplus.Location = new System.Drawing.Point(23, 122);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(63, 63);
            this.btnplus.TabIndex = 0;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnminus
            // 
            this.btnminus.Location = new System.Drawing.Point(161, 122);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(63, 63);
            this.btnminus.TabIndex = 1;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btntimes
            // 
            this.btntimes.Location = new System.Drawing.Point(92, 122);
            this.btntimes.Name = "btntimes";
            this.btntimes.Size = new System.Drawing.Size(63, 63);
            this.btntimes.TabIndex = 2;
            this.btntimes.Text = "*";
            this.btntimes.UseVisualStyleBackColor = true;
            this.btntimes.Click += new System.EventHandler(this.btntimes_Click);
            // 
            // btndivide
            // 
            this.btndivide.Location = new System.Drawing.Point(230, 122);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(63, 63);
            this.btndivide.TabIndex = 3;
            this.btndivide.Text = "/";
            this.btndivide.UseVisualStyleBackColor = true;
            this.btndivide.Click += new System.EventHandler(this.btndivide_Click);
            // 
            // btnroot
            // 
            this.btnroot.Location = new System.Drawing.Point(299, 122);
            this.btnroot.Name = "btnroot";
            this.btnroot.Size = new System.Drawing.Size(63, 63);
            this.btnroot.TabIndex = 6;
            this.btnroot.Text = "√";
            this.btnroot.UseVisualStyleBackColor = true;
            this.btnroot.Click += new System.EventHandler(this.btnroot_Click);
            // 
            // btncube
            // 
            this.btncube.Location = new System.Drawing.Point(368, 122);
            this.btncube.Name = "btncube";
            this.btncube.Size = new System.Drawing.Size(63, 63);
            this.btncube.TabIndex = 5;
            this.btncube.Text = "x^3";
            this.btncube.UseVisualStyleBackColor = true;
            this.btncube.Click += new System.EventHandler(this.btncube_Click);
            // 
            // btnequals
            // 
            this.btnequals.Location = new System.Drawing.Point(368, 191);
            this.btnequals.Name = "btnequals";
            this.btnequals.Size = new System.Drawing.Size(63, 132);
            this.btnequals.TabIndex = 4;
            this.btnequals.Text = "=\r\n";
            this.btnequals.UseVisualStyleBackColor = true;
            this.btnequals.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(23, 260);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(63, 63);
            this.btn0.TabIndex = 7;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(161, 260);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(63, 63);
            this.btn2.TabIndex = 10;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(230, 260);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(63, 63);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(92, 260);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(63, 63);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(23, 191);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(63, 63);
            this.btn5.TabIndex = 13;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(92, 191);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(63, 63);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(299, 260);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(63, 63);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(230, 191);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(63, 63);
            this.btn8.TabIndex = 16;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(299, 191);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(63, 63);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(161, 191);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(63, 63);
            this.btn7.TabIndex = 14;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.BackColor = System.Drawing.Color.White;
            this.txtresultado.Enabled = false;
            this.txtresultado.Location = new System.Drawing.Point(23, 27);
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(408, 74);
            this.txtresultado.TabIndex = 17;
            this.txtresultado.Text = "teste";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(453, 341);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnroot);
            this.Controls.Add(this.btncube);
            this.Controls.Add(this.btnequals);
            this.Controls.Add(this.btndivide);
            this.Controls.Add(this.btntimes);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnplus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btntimes;
        private System.Windows.Forms.Button btndivide;
        private System.Windows.Forms.Button btnroot;
        private System.Windows.Forms.Button btncube;
        private System.Windows.Forms.Button btnequals;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.TextBox txtresultado;
    }
}

