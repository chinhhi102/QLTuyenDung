CREATE TABLE [dbo].[tbl_TinhHinhThuViec]
(
	[TinhHinhThuViecID] INT NOT NULL PRIMARY KEY IDENTITY, 
	[ThuViecID] INT NULL,
    [KhaNangLamViec] NVARCHAR(MAX) NULL, 
    [ThaiDoLamViec] NVARCHAR(MAX) NULL, 
    [KinhNghiemLamViec] NVARCHAR(MAX) NULL, 
    [HieuQuaLamViec] NVARCHAR(MAX) NULL, 
    [NgayCapNhap] DATE NULL
    
)
