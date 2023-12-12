using System.Data.SqlClient;
using System.Data;
using AHP.Object;

namespace AHP.Control
{
    internal class QueryTieuChuan
    {
        private SqlDataAdapter dataAdapter;
        private SqlCommand sqlCMD;

        public DataTable get_data_source()  // Lấy ra tất cả các cột trong bảng TiêuChuẩn từ csdl: AHP
        {
            DataTable accountTab = new DataTable();
            string query = "SELECT ten_tieu_chuan AS N'Bộ tiêu chuẩn', w_chuyen_mon AS N'TS Chuyên môn', "
                            + "w_kinh_nghiem AS N'TS Kinh nghiệm', w_ky_nang_mem AS N'TS Kỹ năng mềm', W_do_tuoi AS N'TS Độ tuổi', CR"
                            + " FROM dbo.TieuChuan";
            try
            {
                using (SqlConnection sqlConnection = Connection.getConnection())
                {
                    sqlConnection.Open();
                    dataAdapter = new SqlDataAdapter(query, sqlConnection);
                    dataAdapter.Fill(accountTab);
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }

            return accountTab;
        }

        public void insert(TieuChuan tc)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            sqlConnection.Open();

            try 
            { 
                string query = "INSERT INTO TieuChuan VALUES (N'"
                        + tc.Ten_tieu_chuan + "', "
                        + tc.Chuyen_mon + ", "
                        + tc.Kinh_nghiem + ", "
                        + tc.Ky_nang_mem + ", "
                        + tc.Do_tuoi + ", "
                        + tc.Cr + ")";

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn\n" + ex.Message);
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public void update(TieuChuan tc)    // tìm hàng có tên giống và sửa các thông tin còn lại
        {
            SqlConnection sqlConnection = Connection.getConnection();
            sqlConnection.Open();

            try
            {
                string query = "UPDATE TieuChuan SET "
                        
                            + "w_chuyen_mon  = " + tc.Chuyen_mon
                            + ", w_kinh_nghiem = " + tc.Kinh_nghiem
                            + ", w_ky_nang_mem = " + tc.Ky_nang_mem
                            + ", w_do_tuoi = " + tc.Do_tuoi
                            + ", cr = " + tc.Cr
                        + "WHERE ten_tieu_chuan = N'" + tc.Ten_tieu_chuan + "'";

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn\n" + ex.Message);
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public void delete(string ten_tieu_chuan)   // xóa hàng có tên giống
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "Delete TieuChuan Where ten_tieu_chuan = N'" + ten_tieu_chuan + "'";

            try
            {
                sqlConnection.Open();

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn\n", ex.Message);
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        
    }
}
