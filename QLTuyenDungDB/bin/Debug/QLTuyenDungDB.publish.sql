﻿/*
Deployment script for QLTuyenDungDB

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "QLTuyenDungDB"
:setvar DefaultFilePrefix "QLTuyenDungDB"
:setvar DefaultDataPath "C:\Users\chinhhi102\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB"
:setvar DefaultLogPath "C:\Users\chinhhi102\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [master];


GO

IF (DB_ID(N'$(DatabaseName)') IS NOT NULL) 
BEGIN
    ALTER DATABASE [$(DatabaseName)]
    SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [$(DatabaseName)];
END

GO
PRINT N'Creating $(DatabaseName)...'
GO
CREATE DATABASE [$(DatabaseName)]
    ON 
    PRIMARY(NAME = [$(DatabaseName)], FILENAME = N'$(DefaultDataPath)$(DefaultFilePrefix)_Primary.mdf')
    LOG ON (NAME = [$(DatabaseName)_log], FILENAME = N'$(DefaultLogPath)$(DefaultFilePrefix)_Primary.ldf') COLLATE SQL_Latin1_General_CP1_CI_AS
GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CLOSE OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
USE [$(DatabaseName)];


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                NUMERIC_ROUNDABORT OFF,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON,
                CURSOR_DEFAULT LOCAL,
                CURSOR_CLOSE_ON_COMMIT OFF,
                AUTO_CREATE_STATISTICS ON,
                AUTO_SHRINK OFF,
                AUTO_UPDATE_STATISTICS ON,
                RECURSIVE_TRIGGERS OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ALLOW_SNAPSHOT_ISOLATION OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET READ_COMMITTED_SNAPSHOT OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_UPDATE_STATISTICS_ASYNC OFF,
                PAGE_VERIFY NONE,
                DATE_CORRELATION_OPTIMIZATION OFF,
                DISABLE_BROKER,
                PARAMETERIZATION SIMPLE,
                SUPPLEMENTAL_LOGGING OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET TRUSTWORTHY OFF,
        DB_CHAINING OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET HONOR_BROKER_PRIORITY OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
ALTER DATABASE [$(DatabaseName)]
    SET TARGET_RECOVERY_TIME = 0 SECONDS 
    WITH ROLLBACK IMMEDIATE;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET FILESTREAM(NON_TRANSACTED_ACCESS = OFF),
                CONTAINMENT = NONE 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CREATE_STATISTICS ON(INCREMENTAL = OFF),
                MEMORY_OPTIMIZED_ELEVATE_TO_SNAPSHOT = OFF,
                DELAYED_DURABILITY = DISABLED 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE (QUERY_CAPTURE_MODE = ALL, DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_PLANS_PER_QUERY = 200, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 367), MAX_STORAGE_SIZE_MB = 100) 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE = OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
    END


GO
IF fulltextserviceproperty(N'IsFulltextInstalled') = 1
    EXECUTE sp_fulltext_database 'enable';


GO
PRINT N'Creating [dbo].[tbl_ChucVu]...';


GO
CREATE TABLE [dbo].[tbl_ChucVu] (
    [ChucVuID]   INT            IDENTITY (1, 1) NOT NULL,
    [TenChucVu]  NVARCHAR (50)  NULL,
    [NoiDungCV]  NVARCHAR (MAX) NULL,
    [QuyenLoiCV] NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([ChucVuID] ASC)
);


GO
PRINT N'Creating [dbo].[tbl_ChuyenMon]...';


GO
CREATE TABLE [dbo].[tbl_ChuyenMon] (
    [ChuyenMonID]    INT           IDENTITY (1, 1) NOT NULL,
    [TenChuyenMonID] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([ChuyenMonID] ASC)
);


GO
PRINT N'Creating [dbo].[tbl_HoSoPV]...';


GO
CREATE TABLE [dbo].[tbl_HoSoPV] (
    [HoSoPVID]   INT  IDENTITY (1, 1) NOT NULL,
    [NgayPV]     DATE NULL,
    [KetQuaPV]   INT  NULL,
    [NhanVienID] INT  NULL,
    PRIMARY KEY CLUSTERED ([HoSoPVID] ASC)
);


GO
PRINT N'Creating [dbo].[tbl_MauThongBao]...';


GO
CREATE TABLE [dbo].[tbl_MauThongBao] (
    [ThongBaoID]       INT            IDENTITY (1, 1) NOT NULL,
    [NoiLamViec]       NVARCHAR (MAX) NULL,
    [YeuCauKyThuat]    NVARCHAR (MAX) NULL,
    [SL]               INT            NULL,
    [ChucVuID]         INT            NULL,
    [YeuCauKhac]       NVARCHAR (MAX) NULL,
    [YeuCauNgoaiNgu]   NVARCHAR (MAX) NULL,
    [TuoiTu]           INT            NULL,
    [TuoiDen]          INT            NULL,
    [MucLuong]         NVARCHAR (250) NULL,
    [ThoiGianLamViec]  NVARCHAR (MAX) NULL,
    [TinhTrangHonNhan] NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([ThongBaoID] ASC)
);


GO
PRINT N'Creating [dbo].[tbl_NhanVien]...';


GO
CREATE TABLE [dbo].[tbl_NhanVien] (
    [NhanVienID]  INT           IDENTITY (1, 1) NOT NULL,
    [HoTen]       NVARCHAR (50) NULL,
    [NgaySinh]    DATE          NULL,
    [QueQuan]     NVARCHAR (50) NULL,
    [GioiTinh]    BIT           NULL,
    [DanToc]      NVARCHAR (50) NULL,
    [SDT]         NVARCHAR (20) NULL,
    [Email]       NVARCHAR (50) NULL,
    [PhongBanID]  INT           NULL,
    [ChucVuID]    INT           NULL,
    [TDHVID]      INT           NULL,
    [BacLuongID]  INT           NULL,
    [TrangThai]   INT           NULL,
    [ChuyenMonID] INT           NULL,
    [HoSoPVID]    INT           NULL,
    PRIMARY KEY CLUSTERED ([NhanVienID] ASC)
);


GO
PRINT N'Creating [dbo].[tbl_PhongBan]...';


GO
CREATE TABLE [dbo].[tbl_PhongBan] (
    [PhongBanID]  INT            IDENTITY (1, 1) NOT NULL,
    [TenPhongBan] NVARCHAR (50)  NULL,
    [DiaChi]      NVARCHAR (250) NULL,
    [SDTPB]       NVARCHAR (20)  NULL,
    PRIMARY KEY CLUSTERED ([PhongBanID] ASC)
);


GO
PRINT N'Creating [dbo].[tbl_TaiKhoan]...';


GO
CREATE TABLE [dbo].[tbl_TaiKhoan] (
    [TaiKhoanID]  INT           IDENTITY (1, 1) NOT NULL,
    [TenTaiKhoan] NVARCHAR (50) NOT NULL,
    [MatKhau]     NVARCHAR (50) NULL,
    CONSTRAINT [PK_tbl_TaiKhoan] PRIMARY KEY CLUSTERED ([TaiKhoanID] ASC, [TenTaiKhoan] ASC)
);


GO
PRINT N'Creating [dbo].[tbl_ThuViec]...';


GO
CREATE TABLE [dbo].[tbl_ThuViec] (
    [ThuViecID]          INT  IDENTITY (1, 1) NOT NULL,
    [NhanVienID]         INT  NULL,
    [NgayThuViec]        DATE NULL,
    [NgayKetThucThuViec] DATE NULL,
    PRIMARY KEY CLUSTERED ([ThuViecID] ASC)
);


GO
PRINT N'Creating [dbo].[tbl_TinhHinhThuViec]...';


GO
CREATE TABLE [dbo].[tbl_TinhHinhThuViec] (
    [TinhHinhThuViecID] INT        IDENTITY (1, 1) NOT NULL,
    [KhaNangLamViec]    NCHAR (10) NULL,
    [ThaiDoLamViec]     NCHAR (10) NULL,
    [KinhNghiemLamViec] NCHAR (10) NULL,
    [HieuQuaLamViec]    NCHAR (10) NULL,
    [NgayChapNhan]      NCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([TinhHinhThuViecID] ASC)
);


GO
PRINT N'Creating [dbo].[tbl_TrinhDoHocVan]...';


GO
CREATE TABLE [dbo].[tbl_TrinhDoHocVan] (
    [TrinhDoHocVanID]  INT            IDENTITY (1, 1) NOT NULL,
    [TenTrinhDoHocVan] NVARCHAR (250) NULL,
    [ChuyenNganh]      NVARCHAR (250) NULL,
    PRIMARY KEY CLUSTERED ([TrinhDoHocVanID] ASC)
);


GO
-- Refactoring step to update target server with deployed transaction logs

IF OBJECT_ID(N'dbo.__RefactorLog') IS NULL
BEGIN
    CREATE TABLE [dbo].[__RefactorLog] (OperationKey UNIQUEIDENTIFIER NOT NULL PRIMARY KEY)
    EXEC sp_addextendedproperty N'microsoft_database_tools_support', N'refactoring log', N'schema', N'dbo', N'table', N'__RefactorLog'
END
GO
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '8bb944e1-444f-4644-95d1-de207547cd37')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('8bb944e1-444f-4644-95d1-de207547cd37')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '4b064b4b-0e35-4b36-a9ef-a05a50e23ae2')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('4b064b4b-0e35-4b36-a9ef-a05a50e23ae2')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'abf7435c-edf4-4f26-8e98-596dad139a97')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('abf7435c-edf4-4f26-8e98-596dad139a97')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'f3f503ff-8b04-42c9-9dfe-dcc87f66ba21')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('f3f503ff-8b04-42c9-9dfe-dcc87f66ba21')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '2db30e6c-bcb0-4987-ab2f-2911f2f87c17')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('2db30e6c-bcb0-4987-ab2f-2911f2f87c17')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'eebd6e39-7b2a-45ba-a577-26830f959bc9')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('eebd6e39-7b2a-45ba-a577-26830f959bc9')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'df319782-597b-4e15-aae7-d65ec75976ba')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('df319782-597b-4e15-aae7-d65ec75976ba')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '86384719-5eae-47bd-8448-ef88e3f2a3b7')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('86384719-5eae-47bd-8448-ef88e3f2a3b7')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '0cf14ba0-73fa-4a0a-8bf5-7d5470b56760')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('0cf14ba0-73fa-4a0a-8bf5-7d5470b56760')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '2ff0b345-1be9-49bd-9cb0-6aeab7464e2f')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('2ff0b345-1be9-49bd-9cb0-6aeab7464e2f')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'f3932627-d3a7-4069-a0cf-47255cfb5406')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('f3932627-d3a7-4069-a0cf-47255cfb5406')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '7d9744bf-32b9-4434-ab91-b389381f54d7')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('7d9744bf-32b9-4434-ab91-b389381f54d7')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '8fa378a9-448d-4676-98cd-ac614b62a8c9')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('8fa378a9-448d-4676-98cd-ac614b62a8c9')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '99e8e8dc-aeb3-4f47-86ab-674546965de3')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('99e8e8dc-aeb3-4f47-86ab-674546965de3')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '8d29efcf-30a1-4bec-8217-584af83789d0')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('8d29efcf-30a1-4bec-8217-584af83789d0')

GO

GO
/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
USE QLTuyenDungDB
GO
/*    Tai Khoan     */
TRUNCATE TABLE tbl_TaiKhoan
GO

INSERT INTO tbl_TaiKhoan values('ad', 'ad')
GO

SELECT * FROM tbl_TaiKhoan
GO

/*    Phòng ban     */
TRUNCATE TABLE tbl_PhongBan
GO

INSERT INTO tbl_PhongBan values(N'Kế toán', 'A1', '0123456789')
INSERT INTO tbl_PhongBan values(N'Marketing', 'A2', '0123456789')
INSERT INTO tbl_PhongBan values(N'Nhân sự', 'A3', '0123456789')
INSERT INTO tbl_PhongBan values(N'Kế hoạch', 'B1', '0123456789')
INSERT INTO tbl_PhongBan values(N'Quản lý', 'B2', '0123456789')
INSERT INTO tbl_PhongBan values(N'Đối ngoại', 'B3', '0123456789')
GO

SELECT * FROM tbl_PhongBan
GO

/*    Trình độ học vấn     */
TRUNCATE TABLE tbl_TrinhDoHocVan
GO

INSERT INTO tbl_TrinhDoHocVan values(N'Cao đẳng', '1')
INSERT INTO tbl_TrinhDoHocVan values(N'Đại học', '1')
INSERT INTO tbl_TrinhDoHocVan values(N'Thạc sĩ', '1')
INSERT INTO tbl_TrinhDoHocVan values(N'Tiến sĩ', '1')
INSERT INTO tbl_TrinhDoHocVan values(N'Cao đẳng', '2')
INSERT INTO tbl_TrinhDoHocVan values(N'Đại học', '2')
INSERT INTO tbl_TrinhDoHocVan values(N'Thạc sĩ', '2')
INSERT INTO tbl_TrinhDoHocVan values(N'Tiến sĩ', '2')
INSERT INTO tbl_TrinhDoHocVan values(N'Cao đẳng', '3')
INSERT INTO tbl_TrinhDoHocVan values(N'Đại học', '3')
INSERT INTO tbl_TrinhDoHocVan values(N'Thạc sĩ', '3')
INSERT INTO tbl_TrinhDoHocVan values(N'Tiến sĩ', '3')
GO

SELECT * FROM tbl_TrinhDoHocVan
GO

/*    Chức vụ     */
TRUNCATE TABLE tbl_ChucVu
GO

INSERT INTO tbl_ChucVu values(N'Nhân viên bộ phận phát triển kinh doanh', N'Bộ phận phát triển kinh doanh là bộ phận có nhiệm vụ làm cầu nối giữa khách hàng với sản phẩm, dịch vụ của doanh nghiệp. Nhân sự của bộ phận này cần phải thuyết phục, đàm phán với khách hàng, đối tác để họ trở thành người sử dụng sản phẩm, dịch vụ của doanh nghiệp mình.', N'Đối với một doanh nghiệp, bộ phận phát triển kinh doanh được coi là nòng cốt của công ty. Đây là bộ phân có khả năng đem về những khoản lợi nhuận để duy trì, nuôi dưỡng hệ thống doanh nghiệp. Bởi vậy, bộ phận này luôn giành được nhiều ưu ái nhất nhưng đòi hỏi nhân sự cũng phải là những người có thực tài nhất.')
INSERT INTO tbl_ChucVu values(N'Nhân viên bộ phận kỹ thuật sản xuất', N'Bộ phận kỹ thuật sản xuất là nơi xuất xưởng, cung cấp các sản phẩm vật chất hay dịch vụ mô hình cho bộ phận phát triển kinh doanh. Nếu không có bộ phận này, bộ phận phát triển kinh doanh cũng coi như không có vì sẽ không có sản phẩm để bán cho khách hàng. Một doanh nghiệp nếu sở hữu một đội ngũ kỹ thuật chuyên nghiệp, giàu kinh nghiệm và nhạy bén với thị trường thì coi như đã nắm chìa khóa thành công trong tay.', N'- Tổ chức thiết kế, triển khai sản xuất sản phẩm, kiểm định, kiểm soát chất lượng sản phẩm, tiến hành nghiệm thu sản phẩm.')
INSERT INTO tbl_ChucVu values(N'Nhân viên kế toán - kiểm toán', N'Kế toán là bộ phận có nhiệm vụ xác định, ghi chép, thu thập và tổng hợp các thông tin kinh tế, tạo báo cáo tài chính để trình lên ban lãnh đạo hoặc những người có thẩm quyền để đưa ra các quyết định về kinh tế - xã hội trong doanh nghiệp và đánh giá hiệu quả kinh doanh.', N'Tùy từng loại hình của công ty mà có những vị trí kế toán và kiểm toán nhất định. Chẳng hạn như những công ty chuyên làm bên lĩnh vực sản xuất thì những vị trí như kế toán kho, ')
INSERT INTO tbl_ChucVu values(N'Nhân viên hành chính văn phòng', N'Hành chính văn phòng hay còn gọi là bộ phận quản trị nhân sự. Quản trị nhân sự là bộ phận phụ trách công tác quản lý người lao động trong doanh nghiệp, đảm nhận việc tuyển dụng, đào tạo, đánh giá, khen thưởng người lao động. Ngoài ra, bộ phận hành chính văn phòng còn cần phải giám sát, theo dõi lãnh đạo và văn hóa doanh nghiệp đảm bảo phù hợp với quy định pháp luật về lao động và việc làm.', N'Quản trị nhân sự giúp cho doanh nghiệp tìm kiếm, phát triển và duy trì lực lượng lao động, đảm bảo chất lượng người lao động. Đây là vị trí rất quan trọng của doanh nghiệp vì nhân sự ở đây phụ trách về con người – yếu tố cốt lõi để doanh nghiệp có thể vận hành và hoạt động hiệu quả. Do đó nếu bạn đang có nhu cầu ')
INSERT INTO tbl_ChucVu values(N'Nhân viên kiểm soát chất lượng, an toàn, quản lý môi trường', N'Kiểm soát chất lượng, an toàn, quản lý môi trường là bộ phận có nhiệm vụ đảm bảo các sản phẩm doanh nghiệp làm ra không mắc lỗi, đảm bảo một môi trường làm việc an toàn, lành mạnh, trong sạch.', N'Đối với các doanh nghiệp sản xuất thực phẩm thì bộ phận này đặc biệt quan trọng. Họ sẽ là những người chịu trách nhiệm về việc tuân thủ các quy tắc của OSHA (Occupational Safety and Health Administration - Cơ quan quản lý an toàn và sức khỏe nghề nghiệp), tuân thủ các tiêu chuẩn, quy chuẩn, giám sát chất lượng không khí và lượng nước, chất lượng sản phẩm, đào tạo nhân viên trong từng lĩnh vực và thống kê báo cáo hàng tháng, hàng quý, hàng năm cho Nhà nước.')
INSERT INTO tbl_ChucVu values(N'Nhân viên Logistics', N'Logistic là lĩnh vực ra đời cùng xu hướng toàn cầu hóa và nhu cầu vận chuyển, lưu thông hàng hóa trên toàn thế giới ngày một gia tăng. Logistic là bộ phận chịu trách nhiệm về chuỗi cung ứng hàng hóa bao gồm các hoạt động lưu trữ, vận chuyển và các hoạt động liên quan.', N'Đối với các doanh nghiệp hoạt động trong lĩnh vực kho vận thì đây là bộ phận cơ bản, chịu trách nhiệm đóng gói, xử lý quy trình vận chuyển giao hàng, tiếp nhận vật liệu nhập và lưu kho thành phẩm, thống kê hàng tồn. Một số bộ phận khác cũng có thể kiêm nhiệm luôn chức vụ của một nhân viên logistics như nhân viên hành chính, nhân viên kế toán – kiểm toán tuy nhiên xét về mức độ chuyên nghiệp thì vẫn cần đến một nhân viên logistics cộm cán. Đó sẽ là người tính toán quy trình sắp xếp hàng hóa xuất, nhập sao cho nhanh chóng, thuận tiện nhất nhưng vẫn đảm bảo chất lượng sản phẩm.')
GO

SELECT * FROM tbl_ChucVu
GO

/*    Chuyên môn     */
TRUNCATE TABLE tbl_ChuyenMon
GO

INSERT INTO tbl_ChuyenMon values(N'Công nghệ thông tin')
INSERT INTO tbl_ChuyenMon values(N'Hệ thống thông tin')
INSERT INTO tbl_ChuyenMon values(N'Kỹ thuật công nghệ')
GO

SELECT * FROM tbl_ChuyenMon
GO

GO
DECLARE @VarDecimalSupported AS BIT;

SELECT @VarDecimalSupported = 0;

IF ((ServerProperty(N'EngineEdition') = 3)
    AND (((@@microsoftversion / power(2, 24) = 9)
          AND (@@microsoftversion & 0xffff >= 3024))
         OR ((@@microsoftversion / power(2, 24) = 10)
             AND (@@microsoftversion & 0xffff >= 1600))))
    SELECT @VarDecimalSupported = 1;

IF (@VarDecimalSupported > 0)
    BEGIN
        EXECUTE sp_db_vardecimal_storage_format N'$(DatabaseName)', 'ON';
    END


GO
PRINT N'Update complete.';


GO