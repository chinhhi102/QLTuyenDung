namespace DataLibrary.DTO
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TuyenDungModels : DbContext
    {
        public TuyenDungModels()
            : base("name=QLTuyenDung")
        {
        }

        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<tbl_ChucVu> tbl_ChucVu { get; set; }
        public virtual DbSet<tbl_ChuyenMon> tbl_ChuyenMon { get; set; }
        public virtual DbSet<tbl_HoSoPV> tbl_HoSoPV { get; set; }
        public virtual DbSet<tbl_MauThongBao> tbl_MauThongBao { get; set; }
        public virtual DbSet<tbl_NhanVien> tbl_NhanVien { get; set; }
        public virtual DbSet<tbl_PhongBan> tbl_PhongBan { get; set; }
        public virtual DbSet<tbl_TaiKhoan> tbl_TaiKhoan { get; set; }
        public virtual DbSet<tbl_ThuViec> tbl_ThuViec { get; set; }
        public virtual DbSet<tbl_TinhHinhThuViec> tbl_TinhHinhThuViec { get; set; }
        public virtual DbSet<tbl_TrinhDoHocVan> tbl_TrinhDoHocVan { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
