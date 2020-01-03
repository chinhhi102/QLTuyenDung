CREATE TABLE [dbo].[tbl_TaiKhoan]
(
	[TaiKhoanID] INT NOT NULL IDENTITY , 
    [TenTaiKhoan] NVARCHAR(50) NOT NULL, 
    [MatKhau] NVARCHAR(50) NULL, 
    CONSTRAINT [PK_tbl_TaiKhoan] PRIMARY KEY ([TaiKhoanID], [TenTaiKhoan])
)
