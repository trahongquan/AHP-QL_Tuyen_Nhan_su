

namespace AHP.Object
{
    internal class NhanSu
    {
        #region Các_thuộc tính
        private string ma_so;
        private float chuyen_mon;
        private float kinh_nghiem;
        private float ky_nang_mem;
        private float do_tuoi;
        private bool trung_tuyen = false;
        private float diem_so = -1;
        #endregion


        #region Các_phương_thức

        //Khởi tạo
        public NhanSu(string ma_so, float chuyen_mon, float kinh_nghiem, float ky_nang_mem, float do_tuoi)
        {
            this.Ma_so = ma_so;
            this.Chuyen_mon = chuyen_mon;
            this.Kinh_nghiem = kinh_nghiem;
            this.Ky_nang_mem = ky_nang_mem;
            this.Do_tuoi = do_tuoi;
        }

        // get, set để có thể đọc ghi được từ bên ngoài class này
        public string Ma_so { get => ma_so; set => ma_so = value; }
        public float Chuyen_mon { get => chuyen_mon; set => chuyen_mon = value; }
        public float Kinh_nghiem { get => kinh_nghiem; set => kinh_nghiem = value; }
        public float Ky_nang_mem { get => ky_nang_mem; set => ky_nang_mem = value; }
        public float Do_tuoi { get => do_tuoi; set => do_tuoi = value; }
        public bool Trung_tuyen { get => trung_tuyen; set => trung_tuyen = value; }
        public float Diem_so { get => diem_so; set => diem_so = value; }
        #endregion
    }
}
