namespace Projekt2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.wglab = new System.Windows.Forms.RadioButton();
            this.wszerz = new System.Windows.Forms.RadioButton();
            this.Uruchom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(917, 639);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(659, 354);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(246, 244);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // wglab
            // 
            this.wglab.AutoSize = true;
            this.wglab.Location = new System.Drawing.Point(691, 409);
            this.wglab.Name = "wglab";
            this.wglab.Size = new System.Drawing.Size(89, 28);
            this.wglab.TabIndex = 2;
            this.wglab.TabStop = true;
            this.wglab.Text = "w gląb";
            this.wglab.UseVisualStyleBackColor = true;
            // 
            // wszerz
            // 
            this.wszerz.AutoSize = true;
            this.wszerz.Location = new System.Drawing.Point(794, 409);
            this.wszerz.Name = "wszerz";
            this.wszerz.Size = new System.Drawing.Size(96, 28);
            this.wszerz.TabIndex = 3;
            this.wszerz.TabStop = true;
            this.wszerz.Text = "wszerz";
            this.wszerz.UseVisualStyleBackColor = true;
            // 
            // Uruchom
            // 
            this.Uruchom.Location = new System.Drawing.Point(703, 456);
            this.Uruchom.Name = "Uruchom";
            this.Uruchom.Size = new System.Drawing.Size(129, 45);
            this.Uruchom.TabIndex = 4;
            this.Uruchom.Text = "Uruchom";
            this.Uruchom.UseVisualStyleBackColor = true;
            this.Uruchom.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(700, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wybierz metode:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 639);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Uruchom);
            this.Controls.Add(this.wszerz);
            this.Controls.Add(this.wglab);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton wglab;
        private System.Windows.Forms.RadioButton wszerz;
        private System.Windows.Forms.Button Uruchom;
        private System.Windows.Forms.Label label1;
    }
}

