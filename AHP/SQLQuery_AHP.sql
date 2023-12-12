CREATE DATABASE AhpDB
GO

USE AhpDB
GO

CREATE TABLE TieuChuan
(
	ten_tieu_chuan NVARCHAR(64) PRIMARY KEY,
	w_chuyen_mon REAL NOT NULL,
	w_kinh_nghiem REAL NOT NULL,
	w_ky_nang_mem REAL NOT NULL,
	w_do_tuoi REAL NOT NULL,
	CR REAL NOT NULL
)
GO

CREATE TABLE NhanSu
(
	ma_so CHAR(6) PRIMARY KEY,
	chuyen_mon REAL NOT NULL,
	kinh_nghiem REAL NOT NULL,
	ky_nang_mem REAL NOT NULL,
	do_tuoi REAL NOT NULL,
	tong_diem REAL NULL
)
GO

CREATE TABLE GiamKhao
(
	ma_so CHAR(6) PRIMARY KEY,
	trong_so INT NOT NULL
)
GO

