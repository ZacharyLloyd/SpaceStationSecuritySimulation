namespace SpaceStationSecuritySimulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.decription1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_display_base10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_display_base16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_display_base2 = new System.Windows.Forms.Label();
            this.decription2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(614, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Random Generation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // decription1
            // 
            this.decription1.BackColor = System.Drawing.Color.White;
            this.decription1.Font = new System.Drawing.Font("Modern No. 20", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decription1.Location = new System.Drawing.Point(356, 12);
            this.decription1.Name = "decription1";
            this.decription1.Size = new System.Drawing.Size(649, 26);
            this.decription1.TabIndex = 1;
            this.decription1.Text = "Welcome, this is a random number generator that converts to Hex and binary from D" +
    "ecimal. ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Decimal Base 10";
            // 
            // label_display_base10
            // 
            this.label_display_base10.AutoSize = true;
            this.label_display_base10.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_display_base10.Location = new System.Drawing.Point(867, 260);
            this.label_display_base10.Name = "label_display_base10";
            this.label_display_base10.Size = new System.Drawing.Size(70, 18);
            this.label_display_base10.TabIndex = 3;
            this.label_display_base10.Text = "No Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hex Base 16";
            // 
            // label_display_base16
            // 
            this.label_display_base16.AutoSize = true;
            this.label_display_base16.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_display_base16.Location = new System.Drawing.Point(867, 390);
            this.label_display_base16.Name = "label_display_base16";
            this.label_display_base16.Size = new System.Drawing.Size(67, 18);
            this.label_display_base16.TabIndex = 5;
            this.label_display_base16.Text = "No code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Binary Base 2";
            // 
            // label_display_base2
            // 
            this.label_display_base2.AutoSize = true;
            this.label_display_base2.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_display_base2.Location = new System.Drawing.Point(867, 511);
            this.label_display_base2.Name = "label_display_base2";
            this.label_display_base2.Size = new System.Drawing.Size(67, 18);
            this.label_display_base2.TabIndex = 7;
            this.label_display_base2.Text = "No code";
            // 
            // decription2
            // 
            this.decription2.AutoSize = true;
            this.decription2.Font = new System.Drawing.Font("Modern No. 20", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decription2.Location = new System.Drawing.Point(375, 56);
            this.decription2.Name = "decription2";
            this.decription2.Size = new System.Drawing.Size(614, 20);
            this.decription2.TabIndex = 8;
            this.decription2.Text = "All you have to do is press the Random Generation button and watch the magic happ" +
    "en.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1279, 633);
            this.Controls.Add(this.decription2);
            this.Controls.Add(this.label_display_base2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_display_base16);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_display_base10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decription1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "StarBase13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox decription1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_display_base10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_display_base16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_display_base2;
        private System.Windows.Forms.Label decription2;
    }
}

