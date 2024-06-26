CREATE DATABASE QuanLyBanHang
GO

USE QuanLyBanHang
GO

CREATE TABLE HoaDon(
    MaHoaDon INT IDENTITY(1,1) PRIMARY KEY,
    MaKhachHang nchar(10) NULL,
    TinhTrang nvarchar(50) NULL
);

CREATE TABLE ChiTietHoaDon(
	MaHoaDon INT NOT NULL,
	MaSanPham nchar(10) NOT NULL,
	SoLuongDat int NULL,
	ThanhTien decimal(18, 0) NULL,
 CONSTRAINT PK_ChiTietHoaDon PRIMARY KEY CLUSTERED 
(
	MaHoaDon ASC,
	MaSanPham ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE DonViTinh(
	MaDVT nvarchar(2) NOT NULL,
	TenDVT nvarchar(50) NULL,
 CONSTRAINT PK_DonViTinh PRIMARY KEY CLUSTERED 
(
	MaDVT ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE KhachHang(
	MaKhachHang nchar(10) NOT NULL,
	TenKhachHang nvarchar(50) NULL,
	TrangThai nvarchar(50) NULL,
 CONSTRAINT PK_KhachHang PRIMARY KEY CLUSTERED 
(
	MaKhachHang ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE QuyenDangNhap(
	MaQuyen nchar(1) NOT NULL,
	TenQuyen nvarchar(100) NULL,
 CONSTRAINT PK_QuyenDangNhap PRIMARY KEY CLUSTERED 
(
	MaQuyen ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE DanhMucSanPham(
	MaDanhMuc nchar(10) NOT NULL,
	TenDanhMuc nvarchar(50) NULL,
	TrangThai nvarchar(50) NULL,
 CONSTRAINT PK_DanhMucSanPham PRIMARY KEY CLUSTERED 
(
	MaDanhMuc ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE SanPham(
	MaSanPham nchar(10) NOT NULL,
	TenSanPham nvarchar(50) NULL,
	MaDVT nvarchar(2) NULL,
	MaDanhMuc nchar(10) NULL,
	DonGia decimal(18, 0) NULL, 
	TrangThai nvarchar(50) NULL,
 CONSTRAINT PK_SanPham PRIMARY KEY CLUSTERED 
(
	MaSanPham ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE TaiKhoan(
	TenDangNhap nvarchar(50) NOT NULL,
	MatKhau nvarchar(50) NULL,
	TenDayDu nvarchar(100) NULL,
	MaQuyen nchar(1) NULL,
	TrangThai nvarchar(50) NULL,
 CONSTRAINT PK_TaiKhoan PRIMARY KEY CLUSTERED 
(
	TenDangNhap ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE ChiTietHoaDon
ADD CONSTRAINT FK_ChiTietHoaDon_HoaDon
FOREIGN KEY (MaHoaDon)
REFERENCES HoaDon(MaHoaDon);
GO 

ALTER TABLE SanPham
ADD CONSTRAINT FK_SanPham_DanhMucSanPham
FOREIGN KEY (MaDanhMuc)
REFERENCES DanhMucSanPham(MaDanhMuc)
GO 

ALTER TABLE ChiTietHoaDon
ADD CONSTRAINT FK_ChiTietHoaDon_SanPham
FOREIGN KEY (MaSanPham)
REFERENCES SanPham(MaSanPham);
GO

ALTER TABLE SanPham
ADD CONSTRAINT FK_SanPham_DonViTinh
FOREIGN KEY (MaDVT)
REFERENCES DonViTinh(MaDVT);
GO

ALTER TABLE TaiKhoan
ADD CONSTRAINT FK_TaiKhoan_QuyenDangNhap
FOREIGN KEY (MaQuyen)
REFERENCES QuyenDangNhap(MaQuyen);

ALTER TABLE HoaDon
ADD CONSTRAINT FK_HoaDon_KhachHang
FOREIGN KEY (MaKhachHang)
REFERENCES KhachHang(MaKhachHang);
GO

INSERT QuyenDangNhap (MaQuyen, TenQuyen) 
VALUES 
(N'A', N'Admin'),
(N'U', N'User')

INSERT INTO TaiKhoan (TenDangNhap, MatKhau, TenDayDu, MaQuyen, TrangThai)
VALUES
(N'levantuan', HASHBYTES('SHA2_256', N'1'), N'Lê Văn Tuấn', N'A', N'Còn sử dụng'),
(N'nguyenthiennhan', HASHBYTES('SHA2_256', N'1'), N'Nguyễn Thiện Nhân', N'U', N'Còn sử dụng'),
(N'letanphat', HASHBYTES('SHA2_256', N'1'), N'Lê Tấn Phát', N'U', N'Còn sử dụng'),
(N'duongminhtri', HASHBYTES('SHA2_256', N'1'), N'Dương Minh Trí', N'U', N'Còn sử dụng'),
(N'phamthanhnam', HASHBYTES('SHA2_256', N'1'), N'Phạm Thành Nam', N'U', N'Còn sử dụng'),
(N'vuthihang', HASHBYTES('SHA2_256', N'1'), N'Vũ Thị Hằng', N'U', N'Còn sử dụng'),
(N'nguyenhonghanh', HASHBYTES('SHA2_256', N'1'), N'Nguyễn Hồng Hạnh', N'U', N'Còn sử dụng'),
(N'trandoan', HASHBYTES('SHA2_256', N'1'), N'Trần Đoàn', N'U', N'Còn sử dụng'),
(N'lethanhhieu', HASHBYTES('SHA2_256', N'1'), N'Lê Thanh Hiếu', N'U', N'Còn sử dụng'),
(N'hoangthithuyduong', HASHBYTES('SHA2_256', N'1'), N'Hoàng Thị Thụy Dương', N'U', N'Còn sử dụng'),
(N'nguyenminhquang', HASHBYTES('SHA2_256', N'1'), N'Nguyễn Minh Quang', N'U', N'Còn sử dụng'),
(N'phandinhphung', HASHBYTES('SHA2_256', N'1'), N'Phan Đình Phùng', N'U', N'Còn sử dụng'),
(N'nguyenduyhung', HASHBYTES('SHA2_256', N'1'), N'Nguyễn Duy Hùng', N'U', N'Còn sử dụng'),
(N'tranthanhthao', HASHBYTES('SHA2_256', N'1'), N'Trần Thanh Thảo', N'U', N'Còn sử dụng'),
(N'phamvanduc', HASHBYTES('SHA2_256', N'1'), N'Phạm Văn Đức', N'U', N'Còn sử dụng'),
(N'lethithuha', HASHBYTES('SHA2_256', N'1'), N'Lê Thị Thu Hà', N'U', N'Còn sử dụng'),
(N'nguyenquynhnhu', HASHBYTES('SHA2_256', N'1'), N'Nguyễn Quỳnh Như', N'U', N'Còn sử dụng'),
(N'vuthithanh', HASHBYTES('SHA2_256', N'1'), N'Vũ Thị Thanh', N'U', N'Còn sử dụng'),
(N'phamhuong', HASHBYTES('SHA2_256', N'1'), N'Phạm Hương', N'U', N'Còn sử dụng'),
(N'nguyenthanhtrung', HASHBYTES('SHA2_256', N'1'), N'Nguyễn Thanh Trung', N'U', N'Còn sử dụng'),
(N'nguyenthithuytrang', HASHBYTES('SHA2_256', N'1'), N'Nguyễn Thị Thúy Trang', N'U', N'Còn sử dụng'),
(N'dinhquanglinh', HASHBYTES('SHA2_256', N'1'), N'Dinh Quang Linh', N'U', N'Còn sử dụng'),
(N'hoangdinhquy', HASHBYTES('SHA2_256', N'1'), N'Hoàng Đình Quý', N'U', N'Còn sử dụng'),
(N'nguyenminhquan', HASHBYTES('SHA2_256', N'1'), N'Nguyễn Minh Quân', N'U', N'Còn sử dụng'),
(N'lethuha', HASHBYTES('SHA2_256', N'1'), N'Lê Thu Hà', N'U', N'Còn sử dụng'),
(N'trinhphuongthanh', HASHBYTES('SHA2_256', N'1'), N'Trịnh Phương Thanh', N'U', N'Còn sử dụng'),
(N'huynhthithanhthuy', HASHBYTES('SHA2_256', N'1'), N'Huỳnh Thị Thanh Thúy', N'U', N'Còn sử dụng'),
(N'dinhanhquan', HASHBYTES('SHA2_256', N'1'), N'Dinh Anh Quân', N'U', N'Còn sử dụng'),
(N'phamdinhtung', HASHBYTES('SHA2_256', N'1'), N'Phạm Đình Tùng', N'U', N'Còn sử dụng'),
(N'nguyenthihien', HASHBYTES('SHA2_256', N'1'), N'Nguyễn Thị Hiền', N'U', N'Còn sử dụng'),
(N'vuthuylinh', HASHBYTES('SHA2_256', N'1'), N'Vũ Thụy Linh', N'U', N'Còn sử dụng'),
(N'nguyenthihong', HASHBYTES('SHA2_256', N'1'), N'Nguyễn Thị Hồng', N'U', N'Còn sử dụng'),
(N'letuankhanh', HASHBYTES('SHA2_256', N'1'), N'Lê Tuấn Khánh', N'U', N'Còn sử dụng');
GO 

INSERT INTO KhachHang (MaKhachHang, TenKhachHang, TrangThai)
VALUES
('KH001', N'Nguyễn Văn An', N'Còn sử dụng'),
('KH002', N'Trần Thị Bình', N'Còn sử dụng'),
('KH003', N'Lê Văn Cảnh', N'Còn sử dụng'),
('KH004', N'Phạm Thị Duyên', N'Còn sử dụng'),
('KH005', N'Lý Thị Hoa', N'Còn sử dụng'),
('KH006', N'Nguyễn Văn Dũng', N'Còn sử dụng'),
('KH007', N'Trần Thị Hương', N'Còn sử dụng'),
('KH008', N'Lê Văn Hùng', N'Còn sử dụng'),
('KH009', N'Phạm Thị Lan', N'Còn sử dụng'),
('KH010', N'Nguyễn Văn Mạnh', N'Còn sử dụng'),
('KH011', N'Trần Thị Ngọc', N'Còn sử dụng'),
('KH012', N'Lê Văn Oanh', N'Còn sử dụng'),
('KH013', N'Phạm Thị Phương', N'Còn sử dụng'),
('KH014', N'Nguyễn Văn Quân', N'Còn sử dụng'),
('KH015', N'Trần Thị Thảo', N'Còn sử dụng'),
('KH016', N'Lê Văn Uyên', N'Còn sử dụng'),
('KH017', N'Phạm Thị Vân', N'Còn sử dụng'),
('KH018', N'Nguyễn Văn Xương', N'Còn sử dụng'),
('KH019', N'Trần Thị Yến', N'Còn sử dụng'),
('KH020', N'Lê Văn Zin', N'Còn sử dụng'),
('KH021', N'Phạm Thị Thư', N'Còn sử dụng'),
('KH022', N'Nguyễn Văn Đạt', N'Còn sử dụng'),
('KH023', N'Trần Thị Ánh', N'Còn sử dụng'),
('KH024', N'Lê Văn Phúc', N'Còn sử dụng'),
('KH025', N'Phạm Thị Hà', N'Còn sử dụng'),
('KH026', N'Nguyễn Văn Trung', N'Còn sử dụng'),
('KH027', N'Trần Thị Lan', N'Còn sử dụng'),
('KH028', N'Lê Văn Quyền', N'Còn sử dụng'),
('KH029', N'Phạm Thị Nga', N'Còn sử dụng'),
('KH030', N'Nguyễn Văn Hải', N'Còn sử dụng');
GO

INSERT INTO DonViTinh (MaDVT, TenDVT)
VALUES
('C', N'Cái'),
('CH', N'Chai'),
('KG', N'Kilogram'),
('L', N'Lít'),
('G', N'Gam'),
('M', N'Mét'),
('T', N'Túi'),
('B', N'Block'),
('TH', N'Thùng'),
('P', N'Phần');
GO

INSERT INTO DanhMucSanPham (MaDanhMuc, TenDanhMuc, TrangThai)
VALUES
('DMP001', N'Đồ gia dụng', N'Còn sử dụng'),
('DMP002', N'Tiêu dùng', N'Còn sử dụng'),
('DMP003', N'Đồ ăn', N'Còn sử dụng'),
('DMP004', N'Đồ uống', N'Còn sử dụng'),
('DMP005', N'Điện tử', N'Còn sử dụng'),
('DMP006', N'Quần áo', N'Còn sử dụng'),
('DMP007', N'Giày dép', N'Còn sử dụng'),
('DMP008', N'Phụ kiện', N'Còn sử dụng'),
('DMP009', N'Đồ chơi', N'Còn sử dụng'),
('DMP010', N'Sách vở', N'Còn sử dụng');
GO

INSERT INTO SanPham (MaSanPham, TenSanPham, MaDVT, MaDanhMuc, DonGia, TrangThai)
VALUES
('SP001', N'Bình nước thủy tinh 500ml', 'CH', 'DMP001', 15000, N'Còn sử dụng'),
('SP002', N'Chảo chống dính', 'C', 'DMP001', 250000, N'Còn sử dụng'),
('SP003', N'Bát đĩa sứ', 'C', 'DMP001', 20000, N'Còn sử dụng'),
('SP004', N'Ti vi 32 inch', 'C', 'DMP002', 6000000, N'Còn sử dụng'),
('SP005', N'Bàn là ướt', 'C', 'DMP002', 1200000, N'Còn sử dụng'),
('SP006', N'Nước giặt Omo 1kg', 'KG', 'DMP003', 50000, N'Còn sử dụng'),
('SP007', N'Mì gói Omachi', 'C', 'DMP003', 5000, N'Còn sử dụng'),
('SP008', N'Bia Heineken lon 330ml', 'CH', 'DMP004', 17000, N'Còn sử dụng'),
('SP009', N'Sữa tươi Vinamilk 1L', 'CH', 'DMP004', 25000, N'Còn sử dụng'),
('SP010', N'Ống hút thép không gỉ', 'C', 'DMP001', 50000, N'Còn sử dụng'),
('SP011', N'Tủ lạnh LG 200L', 'C', 'DMP002', 4000000, N'Còn sử dụng'),
('SP012', N'Chén đĩa nhựa', 'C', 'DMP001', 10000, N'Còn sử dụng'),
('SP013', N'Nồi cơm điện', 'C', 'DMP001', 500000, N'Còn sử dụng'),
('SP014', N'Điều hòa Panasonic 1.5HP', 'C', 'DMP002', 8000000, N'Còn sử dụng'),
('SP015', N'Quạt điện', 'C', 'DMP002', 300000, N'Còn sử dụng'),
('SP016', N'Xà phòng Tide', 'C', 'DMP003', 15000, N'Còn sử dụng'),
('SP017', N'Rượu vang nho đỏ', 'CH', 'DMP004', 250000, N'Còn sử dụng'),
('SP018', N'Sữa chua Vinamilk', 'C', 'DMP003', 5000, N'Còn sử dụng'),
('SP019', N'Đèn led Philips', 'C', 'DMP002', 200000, N'Còn sử dụng'),
('SP020', N'Bột giặt Surf', 'KG', 'DMP003', 30000, N'Còn sử dụng'),
('SP021', N'Gạo nếp Hà Nội', 'KG', 'DMP003', 25000, N'Còn sử dụng'),
('SP022', N'Tivi Samsung 50 inch', 'C', 'DMP002', 10000000, N'Còn sử dụng'),
('SP023', N'Nước ngọt Coca-Cola 500ml', 'CH', 'DMP004', 10000, N'Còn sử dụng'),
('SP024', N'Bánh mì sandwich', 'C', 'DMP003', 10000, N'Còn sử dụng'),
('SP025', N'Đèn pin', 'C', 'DMP002', 50000, N'Còn sử dụng'),
('SP026', N'Hũ đựng thức ăn', 'C', 'DMP001', 150000, N'Còn sử dụng'),
('SP027', N'Máy tính xách tay Dell', 'C', 'DMP002', 12000000, N'Còn sử dụng'),
('SP028', N'Sữa rửa mặt Neutrogena', 'CH', 'DMP003', 80000, N'Còn sử dụng'),
('SP029', N'Ghế xoay văn phòng', 'C', 'DMP001', 500000, N'Còn sử dụng'),
('SP030', N'Ổ cắm điện đa năng', 'C', 'DMP001', 200000, N'Còn sử dụng');
GO

SELECT * FROM TaiKhoan
SELECT * FROM QuyenDangNhap
SELECT * FROM KhachHang
SELECT * FROM DanhMucSanPham
SELECT * FROM SanPham
SELECT * FROM DonViTinh
SELECT * FROM HoaDon
SELECT * FROM ChiTietHoaDon