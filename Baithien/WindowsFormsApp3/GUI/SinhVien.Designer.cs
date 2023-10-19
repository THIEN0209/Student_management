
namespace WindowsFormsApp3
{
    partial class SinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinhVien));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtHOTEN = new System.Windows.Forms.TextBox();
            this.txtNGANH = new System.Windows.Forms.TextBox();
            this.txtLOP = new System.Windows.Forms.TextBox();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.btnTHEM = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataDANHSACHSV = new System.Windows.Forms.DataGridView();
            this.ColMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNGANH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbogioitinh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateNGAYSINH = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataDANHSACHSV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Số Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên Sinh Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngành";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lớp";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(158, 22);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(193, 26);
            this.txtMSSV.TabIndex = 5;
            // 
            // txtHOTEN
            // 
            this.txtHOTEN.Location = new System.Drawing.Point(158, 69);
            this.txtHOTEN.Name = "txtHOTEN";
            this.txtHOTEN.Size = new System.Drawing.Size(193, 26);
            this.txtHOTEN.TabIndex = 6;
            // 
            // txtNGANH
            // 
            this.txtNGANH.Location = new System.Drawing.Point(532, 22);
            this.txtNGANH.Name = "txtNGANH";
            this.txtNGANH.Size = new System.Drawing.Size(208, 26);
            this.txtNGANH.TabIndex = 8;
            // 
            // txtLOP
            // 
            this.txtLOP.Location = new System.Drawing.Point(532, 69);
            this.txtLOP.Name = "txtLOP";
            this.txtLOP.Size = new System.Drawing.Size(100, 26);
            this.txtLOP.TabIndex = 9;
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.Location = new System.Drawing.Point(640, 117);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(100, 43);
            this.btnCANCEL.TabIndex = 10;
            this.btnCANCEL.Text = "Cancel";
            this.btnCANCEL.UseVisualStyleBackColor = true;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            // 
            // btnTHEM
            // 
            this.btnTHEM.Location = new System.Drawing.Point(105, 189);
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(75, 35);
            this.btnTHEM.TabIndex = 11;
            this.btnTHEM.Text = "Thêm";
            this.btnTHEM.UseVisualStyleBackColor = true;
            this.btnTHEM.Click += new System.EventHandler(this.btnTHEM_Click);
            // 
            // btnXOA
            // 
            this.btnXOA.Location = new System.Drawing.Point(225, 189);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(75, 35);
            this.btnXOA.TabIndex = 12;
            this.btnXOA.Text = "Xóa";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // btnSUA
            // 
            this.btnSUA.Location = new System.Drawing.Point(348, 189);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(75, 35);
            this.btnSUA.TabIndex = 13;
            this.btnSUA.Text = "Sửa";
            this.btnSUA.UseVisualStyleBackColor = true;
            this.btnSUA.Click += new System.EventHandler(this.btnSUA_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 234);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(414, 26);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataDANHSACHSV
            // 
            this.dataDANHSACHSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDANHSACHSV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataDANHSACHSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDANHSACHSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMSSV,
            this.ColHOTEN,
            this.ColNGAYSINH,
            this.ColNGANH,
            this.ColLOP,
            this.ColGIOITINH});
            this.dataDANHSACHSV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataDANHSACHSV.Location = new System.Drawing.Point(0, 288);
            this.dataDANHSACHSV.Name = "dataDANHSACHSV";
            this.dataDANHSACHSV.RowHeadersWidth = 62;
            this.dataDANHSACHSV.RowTemplate.Height = 28;
            this.dataDANHSACHSV.Size = new System.Drawing.Size(1107, 188);
            this.dataDANHSACHSV.TabIndex = 17;
            this.dataDANHSACHSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDANHSACHSV_CellClick);
            this.dataDANHSACHSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDANHSACHSV_CellContentClick);
            // 
            // ColMSSV
            // 
            this.ColMSSV.DataPropertyName = "MaSV";
            this.ColMSSV.HeaderText = "Mã Số Sinh Viên";
            this.ColMSSV.MinimumWidth = 8;
            this.ColMSSV.Name = "ColMSSV";
            // 
            // ColHOTEN
            // 
            this.ColHOTEN.DataPropertyName = "TenSV";
            this.ColHOTEN.HeaderText = "Họ Tên";
            this.ColHOTEN.MinimumWidth = 8;
            this.ColHOTEN.Name = "ColHOTEN";
            // 
            // ColNGAYSINH
            // 
            this.ColNGAYSINH.DataPropertyName = "NgaySinh";
            this.ColNGAYSINH.HeaderText = "Ngày Sinh";
            this.ColNGAYSINH.MinimumWidth = 8;
            this.ColNGAYSINH.Name = "ColNGAYSINH";
            // 
            // ColNGANH
            // 
            this.ColNGANH.DataPropertyName = "Nganh";
            this.ColNGANH.HeaderText = "Ngành";
            this.ColNGANH.MinimumWidth = 8;
            this.ColNGANH.Name = "ColNGANH";
            // 
            // ColLOP
            // 
            this.ColLOP.DataPropertyName = "Lop";
            this.ColLOP.HeaderText = "Lớp ";
            this.ColLOP.MinimumWidth = 8;
            this.ColLOP.Name = "ColLOP";
            // 
            // ColGIOITINH
            // 
            this.ColGIOITINH.DataPropertyName = "GioiTinh";
            this.ColGIOITINH.HeaderText = "Giới Tính";
            this.ColGIOITINH.MinimumWidth = 8;
            this.ColGIOITINH.Name = "ColGIOITINH";
            // 
            // cbogioitinh
            // 
            this.cbogioitinh.FormattingEnabled = true;
            this.cbogioitinh.Location = new System.Drawing.Point(532, 123);
            this.cbogioitinh.Name = "cbogioitinh";
            this.cbogioitinh.Size = new System.Drawing.Size(100, 28);
            this.cbogioitinh.TabIndex = 21;
            this.cbogioitinh.SelectedIndexChanged += new System.EventHandler(this.cbogioitinh_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Giới Tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(453, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Tìm Kiếm";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dateNGAYSINH
            // 
            this.dateNGAYSINH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNGAYSINH.Location = new System.Drawing.Point(158, 128);
            this.dateNGAYSINH.Name = "dateNGAYSINH";
            this.dateNGAYSINH.Size = new System.Drawing.Size(200, 26);
            this.dateNGAYSINH.TabIndex = 24;
            // 
            // SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1107, 476);
            this.Controls.Add(this.dateNGAYSINH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbogioitinh);
            this.Controls.Add(this.dataDANHSACHSV);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSUA);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.btnTHEM);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.txtLOP);
            this.Controls.Add(this.txtNGANH);
            this.Controls.Add(this.txtHOTEN);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "SinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ SINH VIÊN";
            this.TransparencyKey = System.Drawing.Color.DarkSlateGray;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDANHSACHSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtHOTEN;
        private System.Windows.Forms.TextBox txtNGANH;
        private System.Windows.Forms.TextBox txtLOP;
        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.Button btnTHEM;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataDANHSACHSV;
        private System.Windows.Forms.ComboBox cbogioitinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNGANH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGIOITINH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateNGAYSINH;
    }
}

