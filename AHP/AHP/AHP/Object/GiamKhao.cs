

namespace AHP.Object
{
    internal class GiamKhao
    {
        #region Các thuộc tính
        private string ma_so;
        private int trong_so;
        #endregion

        #region Các phương thức

        //Khởi tạo
        public GiamKhao(string ma_so, int trong_so)
        {
            this.Ma_so = ma_so;
            this.Trong_so = trong_so;
        }

        // get, set để đọc ghi được từ bên ngoài class này
        public string Ma_so { get => ma_so; set => ma_so = value; }
        public int Trong_so { get => trong_so; set => trong_so = value; }
        #endregion
    }
}
