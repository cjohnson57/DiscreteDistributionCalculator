namespace DiscreteDistributionCalculator
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
            this.Binomial = new System.Windows.Forms.Button();
            this.Poisson = new System.Windows.Forms.Button();
            this.Evaluate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Value = new System.Windows.Forms.TextBox();
            this.Mean = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Pascal = new System.Windows.Forms.Button();
            this.PMF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Binomial
            // 
            this.Binomial.Location = new System.Drawing.Point(15, 18);
            this.Binomial.Name = "Binomial";
            this.Binomial.Size = new System.Drawing.Size(75, 23);
            this.Binomial.TabIndex = 1;
            this.Binomial.Text = "Binomial";
            this.Binomial.UseVisualStyleBackColor = true;
            this.Binomial.Click += new System.EventHandler(this.Binomial_Click);
            // 
            // Poisson
            // 
            this.Poisson.Location = new System.Drawing.Point(116, 18);
            this.Poisson.Name = "Poisson";
            this.Poisson.Size = new System.Drawing.Size(75, 23);
            this.Poisson.TabIndex = 3;
            this.Poisson.Text = "Poisson";
            this.Poisson.UseVisualStyleBackColor = true;
            this.Poisson.Click += new System.EventHandler(this.Poisson_Click);
            // 
            // Evaluate
            // 
            this.Evaluate.Location = new System.Drawing.Point(342, 61);
            this.Evaluate.Name = "Evaluate";
            this.Evaluate.Size = new System.Drawing.Size(75, 23);
            this.Evaluate.TabIndex = 4;
            this.Evaluate.Text = "Evaluate";
            this.Evaluate.UseVisualStyleBackColor = true;
            this.Evaluate.Click += new System.EventHandler(this.Evaluate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(326, 113);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(138, 20);
            this.Value.TabIndex = 6;
            // 
            // Mean
            // 
            this.Mean.Location = new System.Drawing.Point(175, 113);
            this.Mean.Name = "Mean";
            this.Mean.Size = new System.Drawing.Size(145, 20);
            this.Mean.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "PMF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mean";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Evaluated Value";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(342, 35);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            // 
            // Pascal
            // 
            this.Pascal.Location = new System.Drawing.Point(217, 18);
            this.Pascal.Name = "Pascal";
            this.Pascal.Size = new System.Drawing.Size(75, 23);
            this.Pascal.TabIndex = 13;
            this.Pascal.Text = "Pascal";
            this.Pascal.UseVisualStyleBackColor = true;
            this.Pascal.Click += new System.EventHandler(this.Pascal_Click);
            // 
            // PMF
            // 
            this.PMF.Location = new System.Drawing.Point(12, 113);
            this.PMF.Name = "PMF";
            this.PMF.Size = new System.Drawing.Size(157, 20);
            this.PMF.TabIndex = 14;
            // 
            // Form1
            // 
            this.AcceptButton = this.Evaluate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 141);
            this.Controls.Add(this.PMF);
            this.Controls.Add(this.Pascal);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Mean);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Evaluate);
            this.Controls.Add(this.Poisson);
            this.Controls.Add(this.Binomial);
            this.Name = "Form1";
            this.Text = "Discrete Distribution Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Binomial;
        private System.Windows.Forms.Button Poisson;
        private System.Windows.Forms.Button Evaluate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.TextBox Mean;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Pascal;
        private System.Windows.Forms.TextBox PMF;
    }
}

