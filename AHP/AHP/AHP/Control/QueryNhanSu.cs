using AHP.Object;
using System.Data.SqlClient;
using System.Data;

namespace AHP.Control
{
    internal class QueryNhanSu
    {
        private SqlDataAdapter dataAdapter;
        private SqlCommand sqlCMD;

        public DataTable get_data_source()  // Lấy dữ liệu đổ ra bảng
        {
            DataTable accountTab = new DataTable();
            string query = "SELECT ma_so AS N'Mã số', chuyen_mon AS N'Chuyên môn', "
                            + "kinh_nghiem AS N'Kinh nghiệm', ky_nang_mem AS N'Kỹ năng mềm', do_tuoi AS N'Độ tuổi', tong_diem AS N'Tổng điểm'"
                            + " FROM NhanSu";
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

        public void insert(NhanSu ns)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            sqlConnection.Open();

            try
            {
                string query = "INSERT INTO NhanSu VALUES ('"
                        + ns.Ma_so + "', "
                        + ns.Chuyen_mon + ", "
                        + ns.Kinh_nghiem + ", "
                        + ns.Ky_nang_mem + ", "
                        + ns.Do_tuoi + ",0)";

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

        public void update(NhanSu ns)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            sqlConnection.Open();

            try
            {
                string query = "UPDATE NhanSu SET "

                            + "chuyen_mon  = " + ns.Chuyen_mon + " "
                            + ", kinh_nghiem = " + ns.Kinh_nghiem + " "
                            + ", ky_nang_mem = " + ns.Ky_nang_mem + ""
                            + ", do_tuoi = " + ns.Do_tuoi + " "
                        + "WHERE ma_so = '" + ns.Ma_so + "'";

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

        public void delete(string ma_so)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "Delete NhanSu Where ma_so = N'" + ma_so + "'";

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
