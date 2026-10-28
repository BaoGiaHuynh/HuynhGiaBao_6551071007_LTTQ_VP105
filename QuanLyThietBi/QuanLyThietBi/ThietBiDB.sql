CREATE DATABASE DuLieu_ThietBi;
USE DuLieu_ThietBi;


CREATE TABLE ThietBi(
	MaThietBi NVARCHAR(10) PRIMARY KEY,
	TenThietBi NVARCHAR(100) NOT NULL,
	DonGia NVARCHAR(12) NOT NUlL,
);


INSERT INTO ThietBi(MaThietBi, TenThietBi, DonGia)
VALUES (N'TB001', N'Máy tính xách tay Dell', N'15.000.000'),
		(N'TB002', N'Máy in HP LaserJet', N'5.500.000'),
		(N'TB003', N'Màn hình Samsung', N'3.800.000'),
		(N'TB004', N'Bàn phím cơ Logitech', N'1.200.000'),
		(N'TB005', N'Chuột không dây', N'450.000')
;

