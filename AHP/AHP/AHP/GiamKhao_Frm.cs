using AHP.Control;
using AHP.Object;

namespace AHP
{
    public partial class GiamKhao_Frm : Form
    {
        private QueryGiamKhao queryGiamKhao = new QueryGiamKhao();
        public GiamKhao_Frm()
        {
            InitializeComponent();
            get_tab_gk();
        }

        private GiamKhao get_gk()
        {
            try
            {
                string ma_so = txt_ma_so.Text.ToString();
                if (ma_so.Length != 6)
                {
                    throw new Exception("Mã số giám khảo rỗng");
                }

                int trong_so;
                int.TryParse(txt_trong_so.Text.ToString(), out trong_so);

                return new GiamKhao(ma_so, trong_so);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void get_tab_gk()
        {
            // Lấy dữ liệu từ CSDL 
            try
            {
                dtgv_gk.DataSource = queryGiamKhao.get_data_source();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Thêm gíam khảo
            try
            {
                GiamKhao gk = get_gk();
                queryGiamKhao.insert(gk);
                MessageBox.Show("Đã thêm Giám khảo " + gk.Ma_so);
                get_tab_gk();
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
                GiamKhao gk = get_gk();
                queryGiamKhao.update(gk);
                MessageBox.Show("Đã cập nhật Giám khảo " + gk.Ma_so);
                get_tab_gk();
            }
            catch
            {
                return;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string ma_so = txt_ma_so.Text.ToString();
                if (ma_so.Length == 0)
                {
                    throw new Exception("Mã số giám khảo rỗng");
                }

                queryGiamKhao.delete(ma_so);
            }
            catch
            {
                return;
            }
        }

        private void dtgv_gk_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_ma_so.Text = dtgv_gk.SelectedRows[0].Cells[0].Value.ToString();
                txt_trong_so.Text = dtgv_gk.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch
            {
                return;
            }
        }
    }
}
