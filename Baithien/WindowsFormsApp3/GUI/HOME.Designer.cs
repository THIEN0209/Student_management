
namespace WindowsFormsApp3.GUI
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
            this.btnOUT = new System.Windows.Forms.Button();
            this.btnTRUONG = new System.Windows.Forms.Button();
            this.btnGIANVIEN2 = new System.Windows.Forms.Button();
            this.btnGIANVIEN1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelbody = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOUT
            // 
            this.btnOUT.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnOUT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOUT.BackgroundImage")));
            this.btnOUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOUT.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOUT.Location = new System.Drawing.Point(1014, 0);
            this.btnOUT.Name = "btnOUT";
            this.btnOUT.Size = new System.Drawing.Size(75, 72);
            this.btnOUT.TabIndex = 4;
            this.btnOUT.Text = " ";
            this.btnOUT.UseVisualStyleBackColor = false;
            this.btnOUT.Click += new System.EventHandler(this.btnOUT_Click);
            // 
            // btnTRUONG
            // 
            this.btnTRUONG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTRUONG.BackgroundImage")));
            this.btnTRUONG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTRUONG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTRUONG.Location = new System.Drawing.Point(0, 390);
            this.btnTRUONG.Name = "btnTRUONG";
            this.btnTRUONG.Size = new System.Drawing.Size(200, 159);
            this.btnTRUONG.TabIndex = 5;
            this.btnTRUONG.UseVisualStyleBackColor = true;
            this.btnTRUONG.Click += new System.EventHandler(this.btnTRUONG_Click);
            // 
            // btnGIANVIEN2
            // 
            this.btnGIANVIEN2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGIANVIEN2.BackgroundImage")));
            this.btnGIANVIEN2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGIANVIEN2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGIANVIEN2.Location = new System.Drawing.Point(0, 222);
            this.btnGIANVIEN2.Name = "btnGIANVIEN2";
            this.btnGIANVIEN2.Size = new System.Drawing.Size(200, 168);
            this.btnGIANVIEN2.TabIndex = 6;
            this.btnGIANVIEN2.UseVisualStyleBackColor = true;
            this.btnGIANVIEN2.Click += new System.EventHandler(this.btnGIANVIEN2_Click);
            // 
            // btnGIANVIEN1
            // 
            this.btnGIANVIEN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGIANVIEN1.BackgroundImage")));
            this.btnGIANVIEN1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGIANVIEN1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGIANVIEN1.Location = new System.Drawing.Point(0, 70);
            this.btnGIANVIEN1.Name = "btnGIANVIEN1";
            this.btnGIANVIEN1.Size = new System.Drawing.Size(200, 152);
            this.btnGIANVIEN1.TabIndex = 7;
            this.btnGIANVIEN1.UseVisualStyleBackColor = true;
            this.btnGIANVIEN1.Click += new System.EventHandler(this.btnGIANVIEN1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnGIANVIEN1);
            this.panel1.Controls.Add(this.btnGIANVIEN2);
            this.panel1.Controls.Add(this.btnTRUONG);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 549);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnOUT);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1089, 72);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Trang Chủ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelbody
            // 
            this.panelbody.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelbody.BackgroundImage")));
            this.panelbody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelbody.Location = new System.Drawing.Point(200, 72);
            this.panelbody.Name = "panelbody";
            this.panelbody.Size = new System.Drawing.Size(1089, 477);
            this.panelbody.TabIndex = 9;
            this.panelbody.Paint += new System.Windows.Forms.PaintEventHandler(this.panelbody_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1289, 549);
            this.Controls.Add(this.panelbody);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOUT;
        private System.Windows.Forms.Button btnTRUONG;
        private System.Windows.Forms.Button btnGIANVIEN2;
        private System.Windows.Forms.Button btnGIANVIEN1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelbody;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}