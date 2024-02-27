namespace AV_PD_v10
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
            this.label1 = new System.Windows.Forms.Label();
            this.kopeja_cena = new System.Windows.Forms.Button();
            this.summa = new System.Windows.Forms.TextBox();
            this.cena_1 = new System.Windows.Forms.NumericUpDown();
            this.cena_2 = new System.Windows.Forms.NumericUpDown();
            this.cena_3 = new System.Windows.Forms.NumericUpDown();
            this.prece_1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.prece_3 = new System.Windows.Forms.TextBox();
            this.prece_2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cena_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cena_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cena_3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Preces nosaukums";
            // 
            // kopeja_cena
            // 
            this.kopeja_cena.Location = new System.Drawing.Point(306, 207);
            this.kopeja_cena.Name = "kopeja_cena";
            this.kopeja_cena.Size = new System.Drawing.Size(75, 23);
            this.kopeja_cena.TabIndex = 2;
            this.kopeja_cena.Text = "apreķināt";
            this.kopeja_cena.UseVisualStyleBackColor = true;
            this.kopeja_cena.Click += new System.EventHandler(this.button1_Click);
            // 
            // summa
            // 
            this.summa.Location = new System.Drawing.Point(183, 207);
            this.summa.Name = "summa";
            this.summa.Size = new System.Drawing.Size(100, 20);
            this.summa.TabIndex = 3;
            this.summa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cena_1
            // 
            this.cena_1.Location = new System.Drawing.Point(210, 85);
            this.cena_1.Name = "cena_1";
            this.cena_1.Size = new System.Drawing.Size(120, 20);
            this.cena_1.TabIndex = 4;
            this.cena_1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // cena_2
            // 
            this.cena_2.Location = new System.Drawing.Point(210, 117);
            this.cena_2.Name = "cena_2";
            this.cena_2.Size = new System.Drawing.Size(120, 20);
            this.cena_2.TabIndex = 5;
            this.cena_2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // cena_3
            // 
            this.cena_3.Location = new System.Drawing.Point(210, 145);
            this.cena_3.Name = "cena_3";
            this.cena_3.Size = new System.Drawing.Size(120, 20);
            this.cena_3.TabIndex = 7;
            this.cena_3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // prece_1
            // 
            this.prece_1.Location = new System.Drawing.Point(90, 84);
            this.prece_1.Name = "prece_1";
            this.prece_1.Size = new System.Drawing.Size(100, 20);
            this.prece_1.TabIndex = 11;
            this.prece_1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "kopumā summa";
            // 
            // prece_3
            // 
            this.prece_3.Location = new System.Drawing.Point(90, 144);
            this.prece_3.Name = "prece_3";
            this.prece_3.Size = new System.Drawing.Size(100, 20);
            this.prece_3.TabIndex = 14;
            this.prece_3.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // prece_2
            // 
            this.prece_2.Location = new System.Drawing.Point(90, 116);
            this.prece_2.Name = "prece_2";
            this.prece_2.Size = new System.Drawing.Size(100, 20);
            this.prece_2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prece_2);
            this.Controls.Add(this.prece_3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.prece_1);
            this.Controls.Add(this.cena_3);
            this.Controls.Add(this.cena_2);
            this.Controls.Add(this.cena_1);
            this.Controls.Add(this.summa);
            this.Controls.Add(this.kopeja_cena);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cena_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cena_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cena_3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kopeja_cena;
        private System.Windows.Forms.TextBox summa;
        private System.Windows.Forms.NumericUpDown cena_1;
        private System.Windows.Forms.NumericUpDown cena_2;
        private System.Windows.Forms.NumericUpDown cena_3;
        private System.Windows.Forms.TextBox prece_1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox prece_3;
        private System.Windows.Forms.TextBox prece_2;
    }
}

