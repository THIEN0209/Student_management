
namespace WindowsFormsApp3
{
    partial class DangNhap1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDANGNHAP = new System.Windows.Forms.Button();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.txtMATKHAU = new System.Windows.Forms.TextBox();
            this.txtTAIKHOAN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(252, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(255, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu";
            // 
            // btnDANGNHAP
            // 
            this.btnDANGNHAP.Location = new System.Drawing.Point(353, 281);
            this.btnDANGNHAP.Name = "btnDANGNHAP";
            this.btnDANGNHAP.Size = new System.Drawing.Size(106, 47);
            this.btnDANGNHAP.TabIndex = 2;
            this.btnDANGNHAP.Text = "Đăng Nhập";
            this.btnDANGNHAP.UseVisualStyleBackColor = true;
            this.btnDANGNHAP.Click += new System.EventHandler(this.btnDANGNHAP_Click);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Location = new System.Drawing.Point(477, 281);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(106, 47);
            this.btnTHOAT.TabIndex = 3;
            this.btnTHOAT.Text = "Thoát";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // txtMATKHAU
            // 
            this.txtMATKHAU.Location = new System.Drawing.Point(353, 232);
            this.txtMATKHAU.Name = "txtMATKHAU";
            this.txtMATKHAU.PasswordChar = '*';
            this.txtMATKHAU.Size = new System.Drawing.Size(230, 26);
            this.txtMATKHAU.TabIndex = 4;
            // 
            // txtTAIKHOAN
            // 
            this.txtTAIKHOAN.Location = new System.Drawing.Point(353, 186);
            this.txtTAIKHOAN.Name = "txtTAIKHOAN";
            this.txtTAIKHOAN.Size = new System.Drawing.Size(230, 26);
            this.txtTAIKHOAN.TabIndex = 5;
            // 
            // DangNhap1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 612);
            this.Controls.Add(this.txtTAIKHOAN);
            this.Controls.Add(this.txtMATKHAU);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnDANGNHAP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DangNhap1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap1";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.Load += new System.EventHandler(this.DangNhap1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDANGNHAP;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.TextBox txtMATKHAU;
        private System.Windows.Forms.TextBox txtTAIKHOAN;
    }
}