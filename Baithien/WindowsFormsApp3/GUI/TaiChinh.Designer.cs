
namespace WindowsFormsApp3.GUI
{
    partial class TaiChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaiChinh));
            this.dataLAMVIEC = new System.Windows.Forms.DataGridView();
            this.ColMAGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGIOLAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNGAYNGHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTHANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTIMKIEM = new System.Windows.Forms.TextBox();
            this.btnCAPNHAT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSONL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHSL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSUA = new System.Windows.Forms.Button();
            this.txtSONN = new System.Windows.Forms.TextBox();
            this.txtMAGV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTENGV = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataLAMVIEC)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLAMVIEC
            // 
            this.dataLAMVIEC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataLAMVIEC.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataLAMVIEC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLAMVIEC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMAGV,
            this.ColHOTEN,
            this.ColHSL,
            this.ColGIOLAM,
            this.ColNGAYNGHI,
            this.ColTHANHTIEN});
            this.dataLAMVIEC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataLAMVIEC.Location = new System.Drawing.Point(0, 246);
            this.dataLAMVIEC.Name = "dataLAMVIEC";
            this.dataLAMVIEC.RowHeadersWidth = 62;
            this.dataLAMVIEC.RowTemplate.Height = 28;
            this.dataLAMVIEC.Size = new System.Drawing.Size(901, 204);
            this.dataLAMVIEC.TabIndex = 0;
            // 
            // ColMAGV
            // 
            this.ColMAGV.DataPropertyName = "MaGV";
            this.ColMAGV.HeaderText = "Mã Giảng Viên";
            this.ColMAGV.MinimumWidth = 8;
            this.ColMAGV.Name = "ColMAGV";
            this.ColMAGV.ReadOnly = true;
            // 
            // ColHOTEN
            // 
            this.ColHOTEN.DataPropertyName = "HoTen";
            this.ColHOTEN.HeaderText = "Họ Tên";
            this.ColHOTEN.MinimumWidth = 8;
            this.ColHOTEN.Name = "ColHOTEN";
            // 
            // ColHSL
            // 
            this.ColHSL.DataPropertyName = "HSL";
            this.ColHSL.HeaderText = "Hệ Số Lương";
            this.ColHSL.MinimumWidth = 8;
            this.ColHSL.Name = "ColHSL";
            // 
            // ColGIOLAM
            // 
            this.ColGIOLAM.DataPropertyName = "NgayLam";
            this.ColGIOLAM.HeaderText = "Ngày Làm";
            this.ColGIOLAM.MinimumWidth = 8;
            this.ColGIOLAM.Name = "ColGIOLAM";
            // 
            // ColNGAYNGHI
            // 
            this.ColNGAYNGHI.DataPropertyName = "NgayN";
            this.ColNGAYNGHI.HeaderText = "Ngày Nghỉ";
            this.ColNGAYNGHI.MinimumWidth = 8;
            this.ColNGAYNGHI.Name = "ColNGAYNGHI";
            // 
            // ColTHANHTIEN
            // 
            this.ColTHANHTIEN.DataPropertyName = "ThanhTien";
            this.ColTHANHTIEN.HeaderText = "Thành Tiền";
            this.ColTHANHTIEN.MinimumWidth = 8;
            this.ColTHANHTIEN.Name = "ColTHANHTIEN";
            // 
            // txtTIMKIEM
            // 
            this.txtTIMKIEM.Location = new System.Drawing.Point(64, 190);
            this.txtTIMKIEM.Name = "txtTIMKIEM";
            this.txtTIMKIEM.Size = new System.Drawing.Size(278, 26);
            this.txtTIMKIEM.TabIndex = 1;
            this.txtTIMKIEM.TextChanged += new System.EventHandler(this.txtTIMKIEM_TextChanged);
            // 
            // btnCAPNHAT
            // 
            this.btnCAPNHAT.Location = new System.Drawing.Point(463, 185);
            this.btnCAPNHAT.Name = "btnCAPNHAT";
            this.btnCAPNHAT.Size = new System.Drawing.Size(109, 36);
            this.btnCAPNHAT.TabIndex = 5;
            this.btnCAPNHAT.Text = "Cập Nhật";
            this.btnCAPNHAT.UseVisualStyleBackColor = true;
            this.btnCAPNHAT.Click += new System.EventHandler(this.btnCAPNHAT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(367, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tìm Kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(293, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Số ngày nghỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(13, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mã Giảng Viên";
            // 
            // txtSONL
            // 
            this.txtSONL.Location = new System.Drawing.Point(410, 15);
            this.txtSONL.Name = "txtSONL";
            this.txtSONL.Size = new System.Drawing.Size(124, 26);
            this.txtSONL.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(290, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Số Ngày Làm";
            // 
            // txtHSL
            // 
            this.txtHSL.Location = new System.Drawing.Point(133, 116);
            this.txtHSL.Name = "txtHSL";
            this.txtHSL.Size = new System.Drawing.Size(124, 26);
            this.txtHSL.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(26, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Hệ Số Lương";
            // 
            // btnSUA
            // 
            this.btnSUA.Location = new System.Drawing.Point(596, 185);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(109, 36);
            this.btnSUA.TabIndex = 24;
            this.btnSUA.Text = "Sửa";
            this.btnSUA.UseVisualStyleBackColor = true;
            this.btnSUA.Click += new System.EventHandler(this.btnSUA_Click);
            // 
            // txtSONN
            // 
            this.txtSONN.Location = new System.Drawing.Point(410, 55);
            this.txtSONN.Name = "txtSONN";
            this.txtSONN.Size = new System.Drawing.Size(124, 26);
            this.txtSONN.TabIndex = 25;
            // 
            // txtMAGV
            // 
            this.txtMAGV.Location = new System.Drawing.Point(133, 15);
            this.txtMAGV.Name = "txtMAGV";
            this.txtMAGV.Size = new System.Drawing.Size(124, 26);
            this.txtMAGV.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(24, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Họ Tên";
            // 
            // txtTENGV
            // 
            this.txtTENGV.Location = new System.Drawing.Point(131, 61);
            this.txtTENGV.Name = "txtTENGV";
            this.txtTENGV.Size = new System.Drawing.Size(124, 26);
            this.txtTENGV.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(732, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 36);
            this.button1.TabIndex = 29;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TaiChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTENGV);
            this.Controls.Add(this.txtMAGV);
            this.Controls.Add(this.txtSONN);
            this.Controls.Add(this.btnSUA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHSL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSONL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCAPNHAT);
            this.Controls.Add(this.txtTIMKIEM);
            this.Controls.Add(this.dataLAMVIEC);
            this.Name = "TaiChinh";
            this.Text = "Cục Tài Chính";
            this.Load += new System.EventHandler(this.TaiChinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLAMVIEC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataLAMVIEC;
        private System.Windows.Forms.TextBox txtTIMKIEM;
        private System.Windows.Forms.Button btnCAPNHAT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSONL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHSL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.TextBox txtSONN;
        private System.Windows.Forms.TextBox txtMAGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTENGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMAGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGIOLAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNGAYNGHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTHANHTIEN;
        private System.Windows.Forms.Button button1;
    }
}