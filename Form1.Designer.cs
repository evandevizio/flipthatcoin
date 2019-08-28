using System;

namespace FlipThatCoin
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
            this.button_single = new System.Windows.Forms.Button();
            this.button_best2of3 = new System.Windows.Forms.Button();
            this.button_flip = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_reset = new System.Windows.Forms.Button();
            this.heads_check1 = new System.Windows.Forms.CheckBox();
            this.heads_check2 = new System.Windows.Forms.CheckBox();
            this.tails_check2 = new System.Windows.Forms.CheckBox();
            this.tails_check1 = new System.Windows.Forms.CheckBox();
            this.headsLabel = new System.Windows.Forms.Label();
            this.tailsLabel = new System.Windows.Forms.Label();
            this.button_about = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.result_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roundTextView = new System.Windows.Forms.Label();
            this.headsRoundText = new System.Windows.Forms.TextBox();
            this.tailsRoundText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_single
            // 
            this.button_single.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_single.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_single.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_single.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_single.Location = new System.Drawing.Point(15, 43);
            this.button_single.Name = "button_single";
            this.button_single.Size = new System.Drawing.Size(82, 49);
            this.button_single.TabIndex = 0;
            this.button_single.Text = "Single";
            this.button_single.UseVisualStyleBackColor = false;
            this.button_single.Click += new System.EventHandler(this.button_single_click);
            // 
            // button_best2of3
            // 
            this.button_best2of3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_best2of3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_best2of3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_best2of3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_best2of3.Location = new System.Drawing.Point(109, 44);
            this.button_best2of3.Name = "button_best2of3";
            this.button_best2of3.Size = new System.Drawing.Size(85, 48);
            this.button_best2of3.TabIndex = 1;
            this.button_best2of3.Text = "Best Of 3";
            this.button_best2of3.UseVisualStyleBackColor = false;
            this.button_best2of3.Click += new System.EventHandler(this.button_best2of3_click);
            // 
            // button_flip
            // 
            this.button_flip.BackColor = System.Drawing.Color.Goldenrod;
            this.button_flip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_flip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_flip.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_flip.ForeColor = System.Drawing.Color.Black;
            this.button_flip.Location = new System.Drawing.Point(51, 164);
            this.button_flip.Name = "button_flip";
            this.button_flip.Size = new System.Drawing.Size(238, 80);
            this.button_flip.TabIndex = 2;
            this.button_flip.Text = "FLIP";
            this.button_flip.UseVisualStyleBackColor = false;
            this.button_flip.Click += new System.EventHandler(this.button_flip_click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_single);
            this.panel1.Controls.Add(this.button_best2of3);
            this.panel1.Location = new System.Drawing.Point(65, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 115);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mode:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(63, 60);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(212, 78);
            this.textBox1.TabIndex = 4;
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.Red;
            this.button_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button_reset.ForeColor = System.Drawing.Color.Black;
            this.button_reset.Location = new System.Drawing.Point(119, 418);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(97, 45);
            this.button_reset.TabIndex = 5;
            this.button_reset.Text = "RESET";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_click);
            // 
            // heads_check1
            // 
            this.heads_check1.AutoCheck = false;
            this.heads_check1.AutoSize = true;
            this.heads_check1.Location = new System.Drawing.Point(443, 333);
            this.heads_check1.Name = "heads_check1";
            this.heads_check1.Size = new System.Drawing.Size(15, 14);
            this.heads_check1.TabIndex = 7;
            this.heads_check1.UseVisualStyleBackColor = true;
            // 
            // heads_check2
            // 
            this.heads_check2.AutoCheck = false;
            this.heads_check2.AutoSize = true;
            this.heads_check2.Location = new System.Drawing.Point(443, 377);
            this.heads_check2.Name = "heads_check2";
            this.heads_check2.Size = new System.Drawing.Size(15, 14);
            this.heads_check2.TabIndex = 8;
            this.heads_check2.UseVisualStyleBackColor = true;
            // 
            // tails_check2
            // 
            this.tails_check2.AutoCheck = false;
            this.tails_check2.AutoSize = true;
            this.tails_check2.Location = new System.Drawing.Point(559, 377);
            this.tails_check2.Name = "tails_check2";
            this.tails_check2.Size = new System.Drawing.Size(15, 14);
            this.tails_check2.TabIndex = 11;
            this.tails_check2.UseVisualStyleBackColor = true;
            // 
            // tails_check1
            // 
            this.tails_check1.AutoCheck = false;
            this.tails_check1.AutoSize = true;
            this.tails_check1.Location = new System.Drawing.Point(559, 333);
            this.tails_check1.Name = "tails_check1";
            this.tails_check1.Size = new System.Drawing.Size(15, 14);
            this.tails_check1.TabIndex = 10;
            this.tails_check1.UseVisualStyleBackColor = true;
            // 
            // headsLabel
            // 
            this.headsLabel.AutoSize = true;
            this.headsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline);
            this.headsLabel.Location = new System.Drawing.Point(416, 284);
            this.headsLabel.Name = "headsLabel";
            this.headsLabel.Size = new System.Drawing.Size(75, 26);
            this.headsLabel.TabIndex = 13;
            this.headsLabel.Text = "Heads";
            // 
            // tailsLabel
            // 
            this.tailsLabel.AutoSize = true;
            this.tailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline);
            this.tailsLabel.Location = new System.Drawing.Point(536, 284);
            this.tailsLabel.Name = "tailsLabel";
            this.tailsLabel.Size = new System.Drawing.Size(57, 26);
            this.tailsLabel.TabIndex = 14;
            this.tailsLabel.Text = "Tails";
            // 
            // button_about
            // 
            this.button_about.BackColor = System.Drawing.Color.PowderBlue;
            this.button_about.BackgroundImage = global::FlipThatCoin.Properties.Resources.info;
            this.button_about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_about.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_about.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_about.ForeColor = System.Drawing.Color.Transparent;
            this.button_about.Location = new System.Drawing.Point(625, 425);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(41, 40);
            this.button_about.TabIndex = 15;
            this.button_about.UseVisualStyleBackColor = false;
            this.button_about.Click += new System.EventHandler(this.button_info_click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlipThatCoin.Properties.Resources.unknown;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(409, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(416, 220);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(167, 32);
            this.textBox2.TabIndex = 16;
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_label.Location = new System.Drawing.Point(473, 185);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(66, 20);
            this.result_label.TabIndex = 17;
            this.result_label.Text = "Result:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Status:";
            // 
            // roundTextView
            // 
            this.roundTextView.AutoSize = true;
            this.roundTextView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundTextView.Location = new System.Drawing.Point(337, 416);
            this.roundTextView.Name = "roundTextView";
            this.roundTextView.Size = new System.Drawing.Size(81, 25);
            this.roundTextView.TabIndex = 19;
            this.roundTextView.Text = "Round:";
            // 
            // headsRoundText
            // 
            this.headsRoundText.Location = new System.Drawing.Point(441, 418);
            this.headsRoundText.MaxLength = 2;
            this.headsRoundText.Name = "headsRoundText";
            this.headsRoundText.Size = new System.Drawing.Size(20, 20);
            this.headsRoundText.TabIndex = 20;
            // 
            // tailsRoundText
            // 
            this.tailsRoundText.Location = new System.Drawing.Point(557, 418);
            this.tailsRoundText.MaxLength = 2;
            this.tailsRoundText.Name = "tailsRoundText";
            this.tailsRoundText.Size = new System.Drawing.Size(19, 20);
            this.tailsRoundText.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(690, 494);
            this.Controls.Add(this.tailsRoundText);
            this.Controls.Add(this.headsRoundText);
            this.Controls.Add(this.roundTextView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.tailsLabel);
            this.Controls.Add(this.headsLabel);
            this.Controls.Add(this.tails_check2);
            this.Controls.Add(this.tails_check1);
            this.Controls.Add(this.heads_check2);
            this.Controls.Add(this.heads_check1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_flip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flip That Coin!";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_single;
        private System.Windows.Forms.Button button_best2of3;
        private System.Windows.Forms.Button button_flip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_reset;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox heads_check1;
        private System.Windows.Forms.CheckBox heads_check2;
        private System.Windows.Forms.CheckBox tails_check2;
        private System.Windows.Forms.CheckBox tails_check1;
        private System.Windows.Forms.Label headsLabel;
        private System.Windows.Forms.Label tailsLabel;
        private System.Windows.Forms.Button button_about;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label roundTextView;
        private System.Windows.Forms.TextBox headsRoundText;
        private System.Windows.Forms.TextBox tailsRoundText;
    }
}

