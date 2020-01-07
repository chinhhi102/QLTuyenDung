namespace DataLibrary.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_ChucVu
    {
        public void copy(tbl_ChucVu o)
        {
            TenChucVu = o.TenChucVu;
            NoiDungCV = o.NoiDungCV;
            QuyenLoiCV = o.QuyenLoiCV;
        }

        [Key]
        public int ChucVuID { get; set; }

        public string TenChucVu { get; set; }

        public string NoiDungCV { get; set; }

        public string QuyenLoiCV { get; set; }
    }
}
