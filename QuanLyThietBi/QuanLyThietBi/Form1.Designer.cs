namespace QuanLyThietBi
{
    partial class Form1
    {
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
            txtMaTB = new TextBox();
            txtDonGia = new TextBox();
            txtTenTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnThem = new Button();
            btnThoat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            dgvThietBi = new DataGridView();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvThietBi).BeginInit();
            SuspendLayout();
            // 
            // txtMaTB
            // 
            txtMaTB.Location = new Point(563, 52);
            txtMaTB.Name = "txtMaTB";
            txtMaTB.Size = new Size(233, 27);
            txtMaTB.TabIndex = 0;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(563, 150);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(233, 27);
            txtDonGia.TabIndex = 1;
            // 
            // txtTenTB
            // 
            txtTenTB.Location = new Point(563, 97);
            txtTenTB.Name = "txtTenTB";
            txtTenTB.Size = new Size(233, 27);
            txtTenTB.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(451, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 3;
            label1.Text = "Thông tin thiết bị";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(451, 59);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 4;
            label2.Text = "Mã thiết bị:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(451, 104);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 5;
            label3.Text = "Tên thiết bị:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(451, 157);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 6;
            label4.Text = "Đơn giá(VND):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(451, 270);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 7;
            label5.Text = "Thao tác";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(451, 302);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(611, 302);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(451, 358);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(611, 358);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dgvThietBi
            // 
            dgvThietBi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThietBi.Location = new Point(-5, 52);
            dgvThietBi.Name = "dgvThietBi";
            dgvThietBi.RowHeadersWidth = 51;
            dgvThietBi.Size = new Size(431, 402);
            dgvThietBi.TabIndex = 12;
            dgvThietBi.CellClick += dgvThietBi_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(-5, 29);
            label6.Name = "label6";
            label6.Size = new Size(128, 20);
            label6.TabIndex = 13;
            label6.Text = "Danh sách thiết bị";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(dgvThietBi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThoat);
            Controls.Add(btnThem);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTenTB);
            Controls.Add(txtDonGia);
            Controls.Add(txtMaTB);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvThietBi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaTB;
        private TextBox txtDonGia;
        private TextBox txtTenTB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnThem;
        private Button btnThoat;
        private Button btnSua;
        private Button btnXoa;
        private DataGridView dgvThietBi;
        private Label label6;
    }
}
