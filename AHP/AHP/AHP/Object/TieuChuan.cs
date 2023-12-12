

namespace AHP.Object
{
    internal class TieuChuan
    {
        #region Các_thuộc_tính
        private string ten_tieu_chuan;
        private float chuyen_mon;
        private float kinh_nghiem;
        private float ky_nang_mem;
        private float do_tuoi;
        private float cr = 0;
        #endregion

        #region Các_phương_thức
        //Khởi tạo
        public TieuChuan(string ten_tieu_chuan, float chuyen_mon, float kinh_nghiem, float ky_nang_mem, float do_tuoi, float cr)
        {
            this.ten_tieu_chuan = ten_tieu_chuan;
            this.Chuyen_mon = chuyen_mon;
            this.Kinh_nghiem = kinh_nghiem;
            this.Ky_nang_mem = ky_nang_mem;
            this.Do_tuoi = do_tuoi;
            this.cr = cr;
        }

        // get, set để đọc ghi được từ bên ngoài class này
        public float Chuyen_mon { get => chuyen_mon; set => chuyen_mon = value; }
        public float Kinh_nghiem { get => kinh_nghiem; set => kinh_nghiem = value; }
        public float Ky_nang_mem { get => ky_nang_mem; set => ky_nang_mem = value; }
        public float Do_tuoi { get => do_tuoi; set => do_tuoi = value; }
        public string Ten_tieu_chuan { get => ten_tieu_chuan; set => ten_tieu_chuan = value; }
        public float Cr { get => cr; set => cr = value; }

        private void get_ahp()
        {
            // Tính toán các số liệu theo AHP
            float[,] a = new float[5,5];

            for (int i = 0 ; i < 5; i++)
            {
                  
            }
        }
        
        #endregion
    }
}
