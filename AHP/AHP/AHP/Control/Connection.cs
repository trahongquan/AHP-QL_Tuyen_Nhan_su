using System.Data.SqlClient;

namespace AHP.Control
{
    internal class Connection
    {
        private static string link = @"Data Source=DESKTOP-9VDVVGR\SQLEXPRESS;Initial Catalog=AhpDB;Integrated Security=True";

        public Connection()
        {

        }
        public static SqlConnection getConnection()
        {
            SqlConnection x = new SqlConnection();
            try
            {
                x = new SqlConnection(link);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo liên kết\n" + ex.Message);
                throw ex;
            }

            return x;
        }
    }
}
