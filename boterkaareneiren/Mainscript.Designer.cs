﻿namespace boterkaareneiren
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
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(9, 110);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(70, 70);
            this.b1.TabIndex = 0;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(85, 110);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(70, 70);
            this.b2.TabIndex = 1;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.button2_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(161, 110);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(70, 70);
            this.b3.TabIndex = 2;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.button3_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(9, 186);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(70, 70);
            this.b4.TabIndex = 5;
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.button4_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(85, 186);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(70, 70);
            this.b5.TabIndex = 4;
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.button5_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(161, 186);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(70, 70);
            this.b6.TabIndex = 3;
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.button6_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(9, 262);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(70, 70);
            this.b7.TabIndex = 8;
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.button7_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(85, 262);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(70, 70);
            this.b8.TabIndex = 7;
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.button8_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(161, 262);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(70, 70);
            this.b9.TabIndex = 6;
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Klik op een vak om te beginnen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Speler X is aan de beurt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Name = "Form1";
            this.Text = "2 Player Boter Kaas en Eieren";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

