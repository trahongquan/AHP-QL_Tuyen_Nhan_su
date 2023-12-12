using AHP.Object;
using System.Data.SqlClient;
using System.Data;

namespace AHP.Control
{
    internal class QueryGiamKhao
    {
        private SqlDataAdapter dataAdapter;
        private SqlCommand sqlCMD;

        public DataTable get_data_source()  // Lấy dữ liệu đổ ra bảng
        {
            DataTable accountTab = new DataTable();
            string query = "SELECT ma_so AS N'Mã số', trong_so AS N'Trọng số'"
                            + " FROM dbo.GiamKhao";
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

        public void insert(GiamKhao gk)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            sqlConnection.Open();

            try
            {
                string query = "INSERT INTO GiamKhao VALUES ('"
                        + gk.Ma_so + "', '"
                        + gk.Trong_so + "')";

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


        public void update(GiamKhao gk)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            sqlConnection.Open();

            try
            {
                string query = "UPDATE GiamKhao SET "

                            + "trong_so  = '" + gk.Trong_so + "' "
                        + "WHERE ma_so = '" + gk.Ma_so + "'";

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
            string query = "Delete GiamKhao Where ma_so = N'" + ma_so + "'";

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
