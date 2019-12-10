using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KTM_WebTM.THONGTIN
{
    public class NDUNG : DbContext
    {

        public NDUNG() : base("THONGTIN")
        { }
        public DbSet<TACGIA> TACGIAS { get; set; }
        public DbSet<TINTUC> TINTUCS { get; set; }

    }
}