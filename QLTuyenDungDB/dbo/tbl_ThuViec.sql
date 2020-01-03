CREATE TABLE [dbo].[tbl_ThuViec]
(
	[ThuViecID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [NhanVienID] INT NULL, 
    [NgayThuViec] DATE NULL, 
    [NgayKetThucThuViec] DATE NULL
)
