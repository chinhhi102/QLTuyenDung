﻿CREATE TABLE [dbo].[tbl_HoSoPV]
(
	[HoSoPVID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [NgayPV] DATE NULL, 
    [KetQuaPV] INT NULL DEFAULT 0, 
    [NhanVienID] INT NULL
)
