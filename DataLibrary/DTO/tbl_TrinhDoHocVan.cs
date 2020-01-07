namespace DataLibrary.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_TrinhDoHocVan
    {
        public void copy(tbl_TrinhDoHocVan o)
        {
            TenTrinhDoHocVan = o.TenTrinhDoHocVan;
            ChuyenMonID = o.ChuyenMonID;
        }

        [Key]
        public int TrinhDoHocVanID { get; set; }

        [StringLength(250)]
        public string TenTrinhDoHocVan { get; set; }

        public int? ChuyenMonID { get; set; }
    }
}
