using Microsoft.EntityFrameworkCore;
using QuanLyThietBi.Models;

namespace QuanLyThietBi
{
    public partial class Form1 : Form
    {

        private string? maDangChon = null;
        public Form1()
        {
            InitializeComponent();
            dgvThietBi.AutoGenerateColumns = true;
            dgvThietBi.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvThietBi.MultiSelect = false;
            dgvThietBi.ReadOnly = true;
            dgvThietBi.AllowUserToAddRows = false;


            LamMoiForm();
            TrangThaiBanDau();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //KẾT NỐI DB
        private readonly DbContextOptions<DuLieu_ThietBiContext> options =
          new DbContextOptionsBuilder<DuLieu_ThietBiContext>()
        .UseSqlServer(
            @"Server=localhost\SQLEXPRESS;
              Database=DuLieu_ThietBi;
              Integrated Security=True;
              TrustServerCertificate=True;")
        .Options;



        // LÀM MỚI FORM
        void LamMoiForm()
        {
            LoadDuLieu();
            XoaTrang();
            TrangThaiBanDau();
            dgvThietBi.ClearSelection();
        }



        //.Load dữ liệu lên form
        void LoadDuLieu()
        {
            using var db = new DuLieu_ThietBiContext(options);

            dgvThietBi.DataSource = db.ThietBis
                .AsNoTracking()
                .ToList();
        }

     
        // XÓA TRẮNG
        void XoaTrang()
        {
            txtMaTB.Clear();
            txtTenTB.Clear();
            txtDonGia.Clear();
        }

        // . TRANG THAI BAN DAU
        void TrangThaiBanDau()
        {
            maDangChon = null;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = true;

            dgvThietBi.Enabled = true;
        }

        //Chọn dòng
        private void dgvThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvThietBi.Rows[e.RowIndex];

            maDangChon =
                row.Cells["MaThietBi"].Value?.ToString();

            txtMaTB.Text = maDangChon ?? "";

            txtTenTB.Text =
                row.Cells["TenThietBi"].Value?.ToString() ?? "";

            txtDonGia.Text =
                row.Cells["DonGia"].Value?.ToString() ?? "";
           

            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThoat.Enabled = false;
        }


        //KIEM TRA DU LIEU
        bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtMaTB.Text))
            {
                MessageBox.Show("Ma thiet bi khong duoc rong!");
                txtMaTB.Focus();
                return false;
            }

            if (txtMaTB.Text.Trim().Length > 10)
            {
                MessageBox.Show("Ma thiet bi toi da 10 ky tu!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenTB.Text))
            {
                MessageBox.Show("Ten thiet bi khong duoc rong!");
                txtTenTB.Focus();
                return false;
            }

            if (txtTenTB.Text.Trim().Length > 100)
            {
                MessageBox.Show("Ten thiet bi toi da 100 ky tu!");
                return false;
            }

            // kiem tra don gia la so nguyen, so thuc
            if (!decimal.TryParse(txtDonGia.Text, out decimal donGia) || donGia <= 0)
            {
                MessageBox.Show("Don gia phai la so nguyen hoac so thuc lon hon 0!(chỉ 1 dấu .)");
                txtDonGia.Focus();
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (maDangChon != null)
            {
                MessageBox.Show("Lam moi truoc khi them!");
                return;
            }

            if (!KiemTraDuLieu())
                return;

            using var db = new DuLieu_ThietBiContext(options);

            string maNV = txtMaTB.Text.Trim();

            if (db.ThietBis.Any(nv => nv.MaThietBi == maNV))
            {
                MessageBox.Show("Thiet bi da ton tai!");
                txtMaTB.Focus();
                return;
            }

            ThietBi nvMoi = new ThietBi();

            nvMoi.MaThietBi = maNV;
            nvMoi.TenThietBi = txtTenTB.Text.Trim();
            nvMoi.DonGia = txtDonGia.Text.Trim();

            try
            {
                db.ThietBis.Add(nvMoi);
                db.SaveChanges();

                MessageBox.Show("Them thiet bi thanh cong!");
                LamMoiForm();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Khong the them: " +
                    ex.GetBaseException().Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Ban co chac chan muon thoat chuong trinh?",
                "Xac nhan thoat",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maDangChon == null)
            {
                MessageBox.Show("Vui long chon thiet bi can sua!");
                return;
            }

            if (!KiemTraDuLieu())
                return;

            using var db = new DuLieu_ThietBiContext(options);

            var nv = db.ThietBis.Find(maDangChon);

            if (nv == null)
            {
                MessageBox.Show("Khong tim thay thiet bi!");
                return;
            }

            nv.MaThietBi = txtMaTB.Text.Trim();
            nv.TenThietBi = txtTenTB.Text.Trim();
            nv.DonGia = txtDonGia.Text.Trim();


            try
            {
                db.SaveChanges();

                MessageBox.Show("Sua thiet bi thanh cong!");
                LamMoiForm();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Khong the sua: " +
                    ex.GetBaseException().Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maDangChon == null)
            {
                MessageBox.Show("Vui long chon thiet bi can xoa!");
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Ban co chac chan muon xoa?",
                "Xac nhan xoa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
                return;

            using var db = new DuLieu_ThietBiContext(options);

            var nv = db.ThietBis.Find(maDangChon);

            if (nv == null)
            {
                MessageBox.Show("Khong tim thay thiet bi!");
                return;
            }

            try
            {
                db.ThietBis.Remove(nv);
                db.SaveChanges();

                MessageBox.Show("Xoa thiet bi thanh cong!");
                LamMoiForm();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Khong the xoa: " +
                    ex.GetBaseException().Message);
            }
        }



     





    }
}
