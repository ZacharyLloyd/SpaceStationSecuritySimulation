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
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusMessageBox = new System.Windows.Forms.TextBox();
            this.InputBase2 = new System.Windows.Forms.TextBox();
            this.InputBase16 = new System.Windows.Forms.TextBox();
            this.EnterCodes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(73, 108);
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
            this.decription1.Location = new System.Drawing.Point(273, 2);
            this.decription1.Multiline = true;
            this.decription1.Name = "decription1";
            this.decription1.Size = new System.Drawing.Size(767, 86);
            this.decription1.TabIndex = 1;
            this.decription1.Text = resources.GetString("decription1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Decimal Base 10";
            // 
            // label_display_base10
            // 
            this.label_display_base10.AutoSize = true;
            this.label_display_base10.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_display_base10.Location = new System.Drawing.Point(386, 197);
            this.label_display_base10.Name = "label_display_base10";
            this.label_display_base10.Size = new System.Drawing.Size(70, 18);
            this.label_display_base10.TabIndex = 3;
            this.label_display_base10.Text = "No Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hex Base 16";
            // 
            // label_display_base16
            // 
            this.label_display_base16.AutoSize = true;
            this.label_display_base16.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_display_base16.Location = new System.Drawing.Point(386, 285);
            this.label_display_base16.Name = "label_display_base16";
            this.label_display_base16.Size = new System.Drawing.Size(67, 18);
            this.label_display_base16.TabIndex = 5;
            this.label_display_base16.Text = "No code";
            this.label_display_base16.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Binary Base 2";
            // 
            // label_display_base2
            // 
            this.label_display_base2.AutoSize = true;
            this.label_display_base2.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_display_base2.Location = new System.Drawing.Point(386, 371);
            this.label_display_base2.Name = "label_display_base2";
            this.label_display_base2.Size = new System.Drawing.Size(67, 18);
            this.label_display_base2.TabIndex = 7;
            this.label_display_base2.Text = "No code";
            this.label_display_base2.Visible = false;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(1007, 120);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(74, 13);
            this.StatusLabel.TabIndex = 9;
            this.StatusLabel.Text = "Status Display";
            // 
            // StatusMessageBox
            // 
            this.StatusMessageBox.Location = new System.Drawing.Point(919, 144);
            this.StatusMessageBox.Multiline = true;
            this.StatusMessageBox.Name = "StatusMessageBox";
            this.StatusMessageBox.ReadOnly = true;
            this.StatusMessageBox.Size = new System.Drawing.Size(260, 159);
            this.StatusMessageBox.TabIndex = 10;
            // 
            // InputBase2
            // 
            this.InputBase2.Location = new System.Drawing.Point(604, 369);
            this.InputBase2.Name = "InputBase2";
            this.InputBase2.Size = new System.Drawing.Size(100, 20);
            this.InputBase2.TabIndex = 11;
            // 
            // InputBase16
            // 
            this.InputBase16.Location = new System.Drawing.Point(604, 283);
            this.InputBase16.Name = "InputBase16";
            this.InputBase16.Size = new System.Drawing.Size(100, 20);
            this.InputBase16.TabIndex = 12;
            // 
            // EnterCodes
            // 
            this.EnterCodes.Enabled = false;
            this.EnterCodes.Location = new System.Drawing.Point(615, 452);
            this.EnterCodes.Name = "EnterCodes";
            this.EnterCodes.Size = new System.Drawing.Size(75, 23);
            this.EnterCodes.TabIndex = 13;
            this.EnterCodes.Text = "Enter Codes";
            this.EnterCodes.UseVisualStyleBackColor = true;
            this.EnterCodes.Click += new System.EventHandler(this.EnterCodes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1279, 633);
            this.Controls.Add(this.EnterCodes);
            this.Controls.Add(this.InputBase16);
            this.Controls.Add(this.InputBase2);
            this.Controls.Add(this.StatusMessageBox);
            this.Controls.Add(this.StatusLabel);
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
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox StatusMessageBox;
        private System.Windows.Forms.TextBox InputBase2;
        private System.Windows.Forms.TextBox InputBase16;
        private System.Windows.Forms.Button EnterCodes;
    }
}

