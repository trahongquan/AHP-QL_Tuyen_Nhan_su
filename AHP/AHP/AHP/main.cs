using AHP.Control;
using AHP.Object;
using System.Globalization;
using System.Windows.Forms;

namespace AHP
{
    public partial class main : Form
    {

        #region Các thuộc tính
        private QueryNhanSu queryNhanSu = new QueryNhanSu();
        private QueryTieuChuan queryTieuChuan = new QueryTieuChuan();
        int s = 0;
        #endregion
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            // Khởi chạy khi gọi vào form này
            get_tab_ns();
            get_tab_tc();
            init_matrix_tc();

            get_s();
        }
        #region Các phương thức bổ trợ
        private void get_s()
        {
            try
            {
                s = int.Parse(txt_num.Text.ToString());
            }
            catch (Exception ex)
            {
                s = 0;
                MessageBox.Show("Số lượng tuyển không đúng " + ex.Message);
            }
        }
        private void get_tab_ns()
        {
            // Lấy dữ liệu từ CSDL bảng NhanSu đổ vào dataGridView: dtgv_ns
            try
            {
                dtgv_ns.DataSource = queryNhanSu.get_data_source();
                //dtgv_ns.Columns.Add("tong_diem", "Tổng điểm");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo bảng nhân sự\n" + ex);
                return;
            }

        }
        private void get_tab_tc()
        {
            // Lấy dữ liệu từ CSDL bảng TieuChuan đổ vào dataGridView: dtgv_tc
            try
            {
                dtgv_tc.DataSource = queryTieuChuan.get_data_source();
            }
            catch
            {
                return;
            }

        }
        private TieuChuan get_tc()
        {
            // Lấy thông tin từ các textbox trong GroupView Tiêu chuẩn
            // Trả ra một đối tượng TieuChuan

            try
            {
                string ten_tieu_chuan = txt_wtieu_chuan.Text;
                if (ten_tieu_chuan.Length == 0)
                {
                    throw new Exception("Tên Bộ tiêu chuẩn rỗng");
                }

                float chuyen_mon;
                float.TryParse(txt_wchuyen_mon.Text.ToString(), out chuyen_mon);

                float kinh_nghiem;
                float.TryParse(txt_wkinh_nghiem.Text.ToString(), out kinh_nghiem);

                float ky_nang_mem;
                float.TryParse(txt_wky_nang_mem.Text.ToString(), out ky_nang_mem);

                float do_tuoi;
                float.TryParse(txt_wdo_tuoi.Text.ToString(), out do_tuoi);

                float cr;
                float.TryParse(txt_cr.Text.ToString(), out cr);

                if (cr > 10)
                {
                    throw new Exception("Hệ số nhất quán vượt quá 10%");
                }

                return new TieuChuan(ten_tieu_chuan, chuyen_mon, kinh_nghiem, ky_nang_mem, do_tuoi, cr);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi tiêu chuẩn " + ex.Message);
                //throw ex;
                return null;
            }
        }
        private void show_tc()
        {
            // Lấy thông tin từ dòng đang chọn, show ra các textbox
            try
            {
                txt_wtieu_chuan.Text = dtgv_tc.SelectedRows[0].Cells[0].Value.ToString();
                txt_wchuyen_mon.Text = dtgv_tc.SelectedRows[0].Cells[1].Value.ToString();
                txt_wkinh_nghiem.Text = dtgv_tc.SelectedRows[0].Cells[2].Value.ToString();
                txt_wky_nang_mem.Text = dtgv_tc.SelectedRows[0].Cells[3].Value.ToString();
                txt_wdo_tuoi.Text = dtgv_tc.SelectedRows[0].Cells[4].Value.ToString();
                txt_cr.Text = dtgv_tc.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch
            {
                return;
            }
        }
        private void show_ns()
        {
            txt_ma_so_ns.Text = dtgv_ns.SelectedRows[0].Cells[0].Value.ToString();
            txt_tong_diem.Text = dtgv_ns.SelectedRows[0].Cells[5].Value.ToString();
            txt_rank.Text = (dtgv_ns.SelectedRows[0].Index + 1).ToString();

            if (dtgv_ns.SelectedRows[0].Index < s)
            {
                txt_pass.BackColor = Color.Green;
                txt_pass.Text = "Trúng tuyển";
            }
            else
            {
                txt_pass.BackColor = Color.Red;
                txt_pass.Text = "Bị loại";
            }
        }

        // Xử lí ma trận AHP
        private void reset_matrix_tc()
        {
            for (int i = 0; i < 4; ++i)
            {
                dtgv_matrix_tc.Rows[i].Cells[0].ReadOnly = true;
                dtgv_matrix_tc.Rows[i].Cells[i + 1].Value = "1";
                dtgv_matrix_tc.Rows[i].Cells[i + 1].Style.BackColor = Color.Gold;

                for (int j = i + 1; j < 4; ++j)
                {
                    dtgv_matrix_tc.Rows[j].Cells[i + 1].Style.BackColor = Color.LightGray;
                    dtgv_matrix_tc.Rows[j].Cells[i + 1].Value = " ";
                    dtgv_matrix_tc.Rows[j].Cells[i + 1].ReadOnly = true;

                    dtgv_matrix_tc.Rows[i].Cells[j + 1].Value = "0";

                }
            }
        }
        private void init_matrix_tc()
        {
            dtgv_matrix_tc.Columns.Add("tieu_chi", "Tiêu\nchí");
            dtgv_matrix_tc.Columns.Add("chuyen_mon", "Chuyên\nmôn");
            dtgv_matrix_tc.Columns.Add("kinh_nghiem", "Kinh\nnghiệm");
            dtgv_matrix_tc.Columns.Add("ky_nang_mem", "Kỹ năng\nmềm");
            dtgv_matrix_tc.Columns.Add("Độ tuổi", "Độ tuổi");

            dtgv_matrix_tc.Rows.Add("Chuyên môn");
            dtgv_matrix_tc.Rows.Add("Kinh nghiệm");
            dtgv_matrix_tc.Rows.Add("Kỹ năng mềm");
            dtgv_matrix_tc.Rows.Add("Độ tuổi");

            reset_matrix_tc();
        }
        private void sync_matrix()
        {
            for (int i = 0; i < 4; ++i)
            {
                for (int j = i + 1; j < 4; ++j)
                {
                    dtgv_matrix_tc.Rows[j].Cells[i + 1].Value
                        = (1 / float.Parse(dtgv_matrix_tc.Rows[i].Cells[j + 1].Value.ToString()));
                }
            }
        }

        // Xử lí ma trận nhân sự
        private NhanSu get_ns(int i)
        {
            float chuyen_mon, kinh_nghiem, ky_nang_mem, do_tuoi;
            try
            {
                chuyen_mon = float.Parse(dtgv_ns.Rows[i].Cells[1].Value.ToString());
                kinh_nghiem = float.Parse(dtgv_ns.Rows[i].Cells[2].Value.ToString());
                ky_nang_mem = float.Parse(dtgv_ns.Rows[i].Cells[3].Value.ToString());
                do_tuoi = float.Parse(dtgv_ns.Rows[i].Cells[4].Value.ToString());
                return new NhanSu(" ", chuyen_mon, kinh_nghiem, ky_nang_mem, do_tuoi);
            }
            catch
            {
                return null;
            }
        }
        private float get_diem_ns(NhanSu ns, TieuChuan tc)
        {
            return ns.Chuyen_mon * tc.Chuyen_mon
                + ns.Kinh_nghiem * tc.Kinh_nghiem
                + ns.Ky_nang_mem * tc.Ky_nang_mem
                + ns.Do_tuoi * tc.Do_tuoi;
        }

        private void sync_ns()
        {
            get_s();
            TieuChuan tc = get_tc();
            int n = dtgv_ns.Rows.Count;


            for (int i = 0; i < n; ++i)
            {
                dtgv_ns.Rows[i].Cells[5].Value = (get_diem_ns(get_ns(i), get_tc())+1).ToString();
            }
            try
            {

                dtgv_ns.Sort(dtgv_ns.Columns[5], System.ComponentModel.ListSortDirection.Descending);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sắp xếp " + ex.Message);
            }


            MessageBox.Show("Số nhân sự đã xét theo tiêu chuẩn " + tc.Ten_tieu_chuan + ": " + n);
        }
        #endregion

        #region Các sự kiện Tiêu chuẩn
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Thêm tiêu chuẩn
            try
            {
                TieuChuan tc = get_tc();
                queryTieuChuan.insert(tc);
                MessageBox.Show("Đã thêm tiêu chuẩn " + tc.Ten_tieu_chuan);
                get_tab_tc();
            }
            catch
            {
                return;
            }
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TieuChuan tc = get_tc();
                queryTieuChuan.update(tc);
                MessageBox.Show("Đã cập nhật tiêu chuẩn " + tc.Ten_tieu_chuan);
                get_tab_tc();
            }
            catch
            {
                return;
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ten_tieu_chuan = txt_wtieu_chuan.Text;

            if (ten_tieu_chuan.Length == 0)
            {
                MessageBox.Show("Không được để trống tên tiêu chuẩn");
                return;
            }

            try
            {
                queryTieuChuan.delete(ten_tieu_chuan);
                get_tab_tc();
            }
            catch
            {
                return;
            }

        }
        private void dtgv_tc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                show_tc();
                sync_ns();
            }
            catch
            {
                return;
            }

        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset_matrix_tc();
        }
        private void btn_tinh_Click(object sender, EventArgs e)
        {
            // Khởi tạo giá trị matrix (các hàng biên (được thêm vào) = 0)
            sync_matrix();
            float[,] a = new float[5, 5];
            float[,] b = new float[5, 7];

            for (int i = 0; i < 4; ++i)
            {
                b[i, 4] = 0;
                a[i, 4] = 0;
                a[4, i] = 0;
            }

            a[4, 4] = 0;

            // Lấy giá trị từ dtgv vào matrix
            for (int i = 0; i < 4; ++i)
            {
                for (int j = 1; j < 5; ++j)
                {
                    b[i, j - 1] = a[i, j - 1] = float.Parse(dtgv_matrix_tc.Rows[i].Cells[j].Value.ToString());
                    a[4, j - 1] += a[i, j - 1];  //SUM
                }
            }

            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    a[i, j] /= a[4, j];  // chia tung cai cho SUM
                    a[i, 4] += a[i, j]; // cong don
                }
                a[i, 4] /= 4;   //Criteria weight
                b[4, i] = b[i, 5] = a[i, 4];
            }

            float lamda_max = 0;
            for (int i = 0; i < 4; ++i) // c
            {
                for (int j = 0; j < 4; ++j)
                {
                    b[i, j] *= b[4, j];
                    b[i, 4] += b[i, j];
                }

                b[i, 6] = b[i, 4] / b[i, 5];
                lamda_max += b[i, 6];
            }

            lamda_max /= 4;
            lamda_max -= 4; // n = 4
            lamda_max /= (float)2.7; //(n = 4 => HS = 0.9, n - 1 = 3; / (3 * 0.9) = 2.7) CR

            txt_wchuyen_mon.Text = a[0, 4].ToString();
            txt_wkinh_nghiem.Text = a[1, 4].ToString();
            txt_wky_nang_mem.Text = a[2, 4].ToString();
            txt_wdo_tuoi.Text = a[3, 4].ToString();
            txt_cr.Text = (lamda_max * 10).ToString();

        }
        #endregion

        #region Các sự kiện Nhân sự
        private void dtgv_ns_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                show_ns();
            }
            catch
            {
                return;
            }

        }
        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NhanSu_Frm fm = new NhanSu_Frm();
            this.Hide();
            fm.ShowDialog();
            this.Show();
            get_tab_ns();
        }
        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string st = txt_ma_so_ns.Text.ToString();

            if (st.Length != 6)
            {
                MessageBox.Show("Mã nhân sự không hợp lệ");
                return;
            }


            NhanSu_Frm fm = new NhanSu_Frm(st);
            this.Hide();
            fm.ShowDialog();
            this.Show();
            get_tab_ns();
        }
        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string ma_so = txt_ma_so_ns.Text.ToString();

            if (ma_so.Length != 6)
            {
                MessageBox.Show("Mã nhân sự không phù hợp!");
            }
            else
            {
                try
                {
                    queryNhanSu.delete(ma_so);
                    get_tab_ns();
                }
                catch (Exception ex)
                {
                    return;
                }

            }
        }
        #endregion

        private void giamKhaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiamKhao_Frm fm = new GiamKhao_Frm();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }
    }



}
