
namespace Pong
{
    partial class Form1
    {
        // Sebastians branch test
        // Test 2
        // Test 3
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.Platta1 = new System.Windows.Forms.PictureBox();
            this.Platta2 = new System.Windows.Forms.PictureBox();
            this.Boll = new System.Windows.Forms.PictureBox();
            this.Poäng = new System.Windows.Forms.TextBox();
            this.Poäng1 = new System.Windows.Forms.TextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Platta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boll)).BeginInit();
            this.SuspendLayout();
            // 
            // Platta1
            // 
            this.Platta1.BackColor = System.Drawing.Color.Blue;
            this.Platta1.Location = new System.Drawing.Point(41, 239);
            this.Platta1.Name = "Platta1";
            this.Platta1.Size = new System.Drawing.Size(47, 197);
            this.Platta1.TabIndex = 0;
            this.Platta1.TabStop = false;
            this.Platta1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Platta2
            // 
            this.Platta2.BackColor = System.Drawing.Color.Red;
            this.Platta2.Location = new System.Drawing.Point(1372, 239);
            this.Platta2.Name = "Platta2";
            this.Platta2.Size = new System.Drawing.Size(47, 197);
            this.Platta2.TabIndex = 1;
            this.Platta2.TabStop = false;
            this.Platta2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Boll
            // 
            this.Boll.BackColor = System.Drawing.Color.White;
            this.Boll.Location = new System.Drawing.Point(679, 320);
            this.Boll.Name = "Boll";
            this.Boll.Size = new System.Drawing.Size(20, 19);
            this.Boll.TabIndex = 3;
            this.Boll.TabStop = false;
            this.Boll.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Poäng
            // 
            this.Poäng.Location = new System.Drawing.Point(1215, 12);
            this.Poäng.Name = "Poäng";
            this.Poäng.Size = new System.Drawing.Size(100, 23);
            this.Poäng.TabIndex = 4;
            // 
            // Poäng1
            // 
            this.Poäng1.Location = new System.Drawing.Point(127, 12);
            this.Poäng1.Name = "Poäng1";
            this.Poäng1.Size = new System.Drawing.Size(100, 23);
            this.Poäng1.TabIndex = 5;
            // 
            // Timer
            // 
            this.Timer.Interval = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(661, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1444, 790);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Poäng1);
            this.Controls.Add(this.Poäng);
            this.Controls.Add(this.Boll);
            this.Controls.Add(this.Platta2);
            this.Controls.Add(this.Platta1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Platta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Platta1;
        private System.Windows.Forms.PictureBox Platta2;
        private System.Windows.Forms.PictureBox Boll;
        private System.Windows.Forms.TextBox Poäng;
        private System.Windows.Forms.TextBox Poäng1;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label1;
    }
}

