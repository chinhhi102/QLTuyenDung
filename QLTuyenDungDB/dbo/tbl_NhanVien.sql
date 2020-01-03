CREATE TABLE [dbo].[tbl_NhanVien]
(
	[NhanVienID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [HoTen] NVARCHAR(50) NULL, 
    [NgaySinh] DATE NULL, 
    [QueQuan] NVARCHAR(50) NULL, 
    [GioiTinh] BIT NULL, 
    [DanToc] NVARCHAR(50) NULL, 
    [SDT] NVARCHAR(20) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [PhongBanID] INT NULL, 
    [ChucVuID] INT NULL, 
    [TDHVID] INT NULL, 
    [BacLuongID] INT NULL, 
    [TrangThai] INT NULL, 
    [ChuyenMonID] INT NULL, 
    [HoSoPVID] INT NULL
)
