
namespace WindowsFormsApp3.GUI
{
    partial class NhaTruong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhaTruong));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMAGV = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtHOTENGV = new System.Windows.Forms.TextBox();
            this.cboLOPCV = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataQUANLYGV = new System.Windows.Forms.DataGridView();
            this.ColMAGIANGVIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHOVANTENGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLOPCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTHEMGV = new System.Windows.Forms.Button();
            this.btnXOAGV = new System.Windows.Forms.Button();
            this.btnSUAGV = new System.Windows.Forms.Button();
            this.dateNSGV = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataQUANLYGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Giảng Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(36, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(408, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lớp Cố Vấn";
            // 
            // txtMAGV
            // 
            this.txtMAGV.Location = new System.Drawing.Point(123, 26);
            this.txtMAGV.Name = "txtMAGV";
            this.txtMAGV.Size = new System.Drawing.Size(150, 26);
            this.txtMAGV.TabIndex = 3;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(504, 26);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(100, 26);
            this.txtSDT.TabIndex = 4;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // txtHOTENGV
            // 
            this.txtHOTENGV.Location = new System.Drawing.Point(123, 73);
            this.txtHOTENGV.Name = "txtHOTENGV";
            this.txtHOTENGV.Size = new System.Drawing.Size(150, 26);
            this.txtHOTENGV.TabIndex = 5;
            // 
            // cboLOPCV
            // 
            this.cboLOPCV.FormattingEnabled = true;
            this.cboLOPCV.Location = new System.Drawing.Point(504, 76);
            this.cboLOPCV.Name = "cboLOPCV";
            this.cboLOPCV.Size = new System.Drawing.Size(121, 28);
            this.cboLOPCV.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(457, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "SĐT";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(91, 219);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(547, 26);
            this.textBox5.TabIndex = 13;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(12, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tìm Kiếm";
            // 
            // dataQUANLYGV
            // 
            this.dataQUANLYGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataQUANLYGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataQUANLYGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataQUANLYGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMAGIANGVIEN,
            this.ColHOVANTENGV,
            this.ColNGAYSINH,
            this.ColLOPCV,
            this.ColSDT});
            this.dataQUANLYGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataQUANLYGV.Location = new System.Drawing.Point(0, 294);
            this.dataQUANLYGV.Name = "dataQUANLYGV";
            this.dataQUANLYGV.RowHeadersWidth = 62;
            this.dataQUANLYGV.RowTemplate.Height = 28;
            this.dataQUANLYGV.Size = new System.Drawing.Size(1188, 213);
            this.dataQUANLYGV.TabIndex = 15;
            // 
            // ColMAGIANGVIEN
            // 
            this.ColMAGIANGVIEN.DataPropertyName = "MaGV";
            this.ColMAGIANGVIEN.HeaderText = "Mã Giảng Viên";
            this.ColMAGIANGVIEN.MinimumWidth = 8;
            this.ColMAGIANGVIEN.Name = "ColMAGIANGVIEN";
            // 
            // ColHOVANTENGV
            // 
            this.ColHOVANTENGV.DataPropertyName = "TenGV";
            this.ColHOVANTENGV.HeaderText = "Tên";
            this.ColHOVANTENGV.MinimumWidth = 8;
            this.ColHOVANTENGV.Name = "ColHOVANTENGV";
            // 
            // ColNGAYSINH
            // 
            this.ColNGAYSINH.DataPropertyName = "NgaySinh";
            this.ColNGAYSINH.HeaderText = "Ngày Sinh";
            this.ColNGAYSINH.MinimumWidth = 8;
            this.ColNGAYSINH.Name = "ColNGAYSINH";
            // 
            // ColLOPCV
            // 
            this.ColLOPCV.DataPropertyName = "LopCV";
            this.ColLOPCV.HeaderText = "Lớp Cố Vấn";
            this.ColLOPCV.MinimumWidth = 8;
            this.ColLOPCV.Name = "ColLOPCV";
            // 
            // ColSDT
            // 
            this.ColSDT.DataPropertyName = "SDT";
            this.ColSDT.HeaderText = "SĐT";
            this.ColSDT.MinimumWidth = 8;
            this.ColSDT.Name = "ColSDT";
            // 
            // btnTHEMGV
            // 
            this.btnTHEMGV.Location = new System.Drawing.Point(811, 20);
            this.btnTHEMGV.Name = "btnTHEMGV";
            this.btnTHEMGV.Size = new System.Drawing.Size(87, 45);
            this.btnTHEMGV.TabIndex = 16;
            this.btnTHEMGV.Text = "Thêm";
            this.btnTHEMGV.UseVisualStyleBackColor = true;
            this.btnTHEMGV.Click += new System.EventHandler(this.btnTHEMGV_Click);
            // 
            // btnXOAGV
            // 
            this.btnXOAGV.Location = new System.Drawing.Point(811, 73);
            this.btnXOAGV.Name = "btnXOAGV";
            this.btnXOAGV.Size = new System.Drawing.Size(87, 45);
            this.btnXOAGV.TabIndex = 17;
            this.btnXOAGV.Text = "Xóa";
            this.btnXOAGV.UseVisualStyleBackColor = true;
            this.btnXOAGV.Click += new System.EventHandler(this.btnXOAGV_Click);
            // 
            // btnSUAGV
            // 
            this.btnSUAGV.Location = new System.Drawing.Point(940, 20);
            this.btnSUAGV.Name = "btnSUAGV";
            this.btnSUAGV.Size = new System.Drawing.Size(87, 45);
            this.btnSUAGV.TabIndex = 18;
            this.btnSUAGV.Text = "Sửa";
            this.btnSUAGV.UseVisualStyleBackColor = true;
            this.btnSUAGV.Click += new System.EventHandler(this.btnSUAGV_Click);
            // 
            // dateNSGV
            // 
            this.dateNSGV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNSGV.Location = new System.Drawing.Point(123, 122);
            this.dateNSGV.Name = "dateNSGV";
            this.dateNSGV.Size = new System.Drawing.Size(195, 26);
            this.dateNSGV.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(36, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ngày Sinh";
            // 
            // NhaTruong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1188, 507);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateNSGV);
            this.Controls.Add(this.btnSUAGV);
            this.Controls.Add(this.btnXOAGV);
            this.Controls.Add(this.btnTHEMGV);
            this.Controls.Add(this.dataQUANLYGV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboLOPCV);
            this.Controls.Add(this.txtHOTENGV);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtMAGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NhaTruong";
            this.Text = "NhaTruong";
            this.Load += new System.EventHandler(this.NhaTruong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataQUANLYGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMAGV;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtHOTENGV;
        private System.Windows.Forms.ComboBox cboLOPCV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataQUANLYGV;
        private System.Windows.Forms.Button btnTHEMGV;
        private System.Windows.Forms.Button btnXOAGV;
        private System.Windows.Forms.Button btnSUAGV;
        private System.Windows.Forms.DateTimePicker dateNSGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMAGIANGVIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHOVANTENGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLOPCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSDT;
    }
}