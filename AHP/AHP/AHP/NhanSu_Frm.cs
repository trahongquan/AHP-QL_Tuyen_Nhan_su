using AHP.Control;
using AHP.Object;
using System.Data;
using System.Windows.Forms;

namespace AHP
{
    public partial class NhanSu_Frm : Form
    {
        private bool is_add = true;

        public NhanSu_Frm()
        {
            InitializeComponent();
        }

        public NhanSu_Frm(String ma_so)
        {
            InitializeComponent();
            this.Text = "Sửa thông tin nhân sự";
            is_add = false;
            txt_ma_so.Text = ma_so;
            txt_ma_so.ReadOnly = true;

        }
        private void NhanSu_Frm_Load(object sender, EventArgs e)
        {
            get_tab();
            DataTable dataTable = (DataTable)dtgv_diem.DataSource;
            dtgv_diem.Columns.Add("chuyen_mon", "Chuyên môn");
            dtgv_diem.Columns.Add("kinh_nghiem", "Kinh nghiệm");
            dtgv_diem.Columns.Add("ky_nang_mem", "Kỹ năng mềm");
            dtgv_diem.Columns.Add("do_tuoi", "Độ tuổi");
            //dtgv_diem.Rows.Add("/");

            DataGridViewRow row = (DataGridViewRow)dtgv_diem.Rows[1].Clone();
            dataTable.Rows.Add(row);
            dtgv_diem.DataSource = dataTable;
            dataTable.AcceptChanges();

            int n = dtgv_diem.Rows.Count - 1;
            dtgv_diem.Rows[n].Cells[0].Value = "   /";
        }

        #region Bổ trợ
        private NhanSu get_ns()
        {

            string ma_so = txt_ma_so.Text;
            if (ma_so.Length == 0)
            {
                MessageBox.Show("Mã số rỗng");
                return null;
            }
            else
            {
                try
                {
                    float chuyen_mon;
                    float.TryParse(txt_chuyen_mon.Text.ToString(), out chuyen_mon);

                    float kinh_nghiem;
                    float.TryParse(txt_kinh_nghiem.Text.ToString(), out kinh_nghiem);

                    float ky_nang_mem;
                    float.TryParse(txt_ky_nang_mem.Text.ToString(), out ky_nang_mem);

                    float do_tuoi;
                    float.TryParse(txt_do_tuoi.Text.ToString(), out do_tuoi);

                    return new NhanSu(ma_so, chuyen_mon, kinh_nghiem, ky_nang_mem, do_tuoi);
                }
                catch (Exception ex)
                {
                    return null;
                }


            }


        }
        private void get_tab()
        {
            QueryGiamKhao queryGiamKhao = new QueryGiamKhao();
            dtgv_diem.DataSource = queryGiamKhao.get_data_source();
        }
        private void get_average()
        {
            float s = 0;
            int n = dtgv_diem.Rows.Count - 1;

            float[] sn = new float[n];
            float chuyen_mon = 0, kinh_nghiem = 0, ky_nang_mem = 0, do_tuoi = 0;
            float tmp;
            string st = "";

            for (int i = 0; i < n; ++i)
            {
                float.TryParse(dtgv_diem.Rows[i].Cells[1].Value.ToString(), out sn[i]);
                s += sn[i];
            }

            for (int i = 0; i < n; ++i)
            {
                st = dtgv_diem.Rows[i].Cells[2].Value.ToString();
                float.TryParse(st, out tmp);
                chuyen_mon += tmp * sn[i];

                st = dtgv_diem.Rows[i].Cells[3].Value.ToString();
                float.TryParse(st, out tmp);
                kinh_nghiem += tmp * sn[i];

                st = dtgv_diem.Rows[i].Cells[4].Value.ToString();
                float.TryParse(st, out tmp);
                ky_nang_mem += tmp * sn[i];

                st = dtgv_diem.Rows[i].Cells[5].Value.ToString();
                float.TryParse(st, out tmp);
                do_tuoi += tmp * sn[i];
            }

            chuyen_mon /= s;
            kinh_nghiem /= s;
            ky_nang_mem /= s;
            do_tuoi /= s;

            MessageBox.Show("chuyen_mon " + chuyen_mon + "\nkinh_nghiem " + kinh_nghiem
                + "\nky_nang_mem " + ky_nang_mem + "\ndo_tuoi " + do_tuoi);

            txt_chuyen_mon.Text = chuyen_mon.ToString();
            txt_kinh_nghiem.Text = kinh_nghiem.ToString();
            txt_ky_nang_mem.Text = ky_nang_mem.ToString();
            txt_do_tuoi.Text = do_tuoi.ToString();


        }

        #endregion

        private void tinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                get_average();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + e);
            }

        }

        private void doneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryNhanSu query = new QueryNhanSu();
            NhanSu ns = get_ns();
            if (is_add)
            {
                query.insert(ns);
            }
            else
            {
                try
                {
                    query.update(ns);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex);
                    return;
                }
            }

            this.Close();
        }
    }
}
