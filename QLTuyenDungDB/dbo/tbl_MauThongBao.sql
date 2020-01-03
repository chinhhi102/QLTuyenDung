CREATE TABLE [dbo].[tbl_MauThongBao]
(
	[ThongBaoID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [NoiLamViec] NVARCHAR(MAX) NULL, 
	[YeuCauKyThuat] NVARCHAR(MAX) NULL,
    [SL] INT NULL, 
	[ChucVu] NVARCHAR(50) NULL,
    [YeuCauKhac] NVARCHAR(MAX) NULL, 
    [YeuCauNgoaiNgu] NVARCHAR(MAX) NULL,
	[TuoiTu] INT NULL,
	[TuoiDen] INT NULL,
    [MucLuong] NVARCHAR(250) NULL, 
    [ThoiGianLamViec] NVARCHAR(MAX) NULL, 
    [TinhTrangHonNhan] NVARCHAR(MAX) NULL, 
    [HinhThucTuyen] NVARCHAR(50) NULL, 
    [NgayTaoMau] DATE NULL DEFAULT GETDATE()
)
