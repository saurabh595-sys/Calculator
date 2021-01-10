
namespace Calculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.TextBox();
            this.textADD = new System.Windows.Forms.TextBox();
            this.textSUB = new System.Windows.Forms.TextBox();
            this.textDiv = new System.Windows.Forms.TextBox();
            this.textMULT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(392, 59);
            this.text1.Multiline = true;
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(179, 34);
            this.text1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 107);
            this.label1.MaximumSize = new System.Drawing.Size(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(5, 10);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 62);
            this.label2.MaximumSize = new System.Drawing.Size(500, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number2";
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(392, 117);
            this.text2.Multiline = true;
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(179, 34);
            this.text2.TabIndex = 1;
            // 
            // textADD
            // 
            this.textADD.Location = new System.Drawing.Point(392, 182);
            this.textADD.Multiline = true;
            this.textADD.Name = "textADD";
            this.textADD.ReadOnly = true;
            this.textADD.Size = new System.Drawing.Size(179, 34);
            this.textADD.TabIndex = 1;
            // 
            // textSUB
            // 
            this.textSUB.Location = new System.Drawing.Point(392, 240);
            this.textSUB.Multiline = true;
            this.textSUB.Name = "textSUB";
            this.textSUB.ReadOnly = true;
            this.textSUB.Size = new System.Drawing.Size(179, 34);
            this.textSUB.TabIndex = 1;
            // 
            // textDiv
            // 
            this.textDiv.Location = new System.Drawing.Point(392, 305);
            this.textDiv.Multiline = true;
            this.textDiv.Name = "textDiv";
            this.textDiv.ReadOnly = true;
            this.textDiv.Size = new System.Drawing.Size(179, 34);
            this.textDiv.TabIndex = 1;
            // 
            // textMULT
            // 
            this.textMULT.Location = new System.Drawing.Point(392, 366);
            this.textMULT.Multiline = true;
            this.textMULT.Name = "textMULT";
            this.textMULT.ReadOnly = true;
            this.textMULT.Size = new System.Drawing.Size(179, 34);
            this.textMULT.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "ADD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "MULT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "SUB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "DIV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 547);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textMULT);
            this.Controls.Add(this.textDiv);
            this.Controls.Add(this.textSUB);
            this.Controls.Add(this.textADD);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox textADD;
        private System.Windows.Forms.TextBox textSUB;
        private System.Windows.Forms.TextBox textDiv;
        private System.Windows.Forms.TextBox textMULT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

