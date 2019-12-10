using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace KTM_WebTM.THONGTIN
{
    public class tDatabaseInitializer : DropCreateDatabaseAlways<NDUNG>
    {
        protected override void Seed(NDUNG context)
        {
            GetTACGIAS().ForEach(c => context.TACGIAS.Add(c));
            GetTINTUCS().ForEach(p => context.TINTUCS.Add(p));
        }
        private static List<TACGIA> GetTACGIAS()
        {
            var tgias = new List<TACGIA> {
new TACGIA
{
TGIA_ID = 1,
TENTG = "Fiction",
EMAIL="ABC"
},
new TACGIA
{
TGIA_ID = 2,
TENTG = "Biographies and Memoirs",
EMAIL="ABC"
},
new TACGIA{
TGIA_ID = 3,
TENTG = "Biological Sciences",
EMAIL="ABC"
},
new TACGIA
{
TGIA_ID = 4,
TENTG = "Self-Help",
EMAIL="ABC"
}
};
            return tgias;
        }
        private static List<TINTUC> GetTINTUCS()
        {
            var tintucs = new List<TINTUC> {
    //TINTUC 1
    new TINTUC
{
TIN_ID = 1,
NOIDUNG = "300 Years Before A Game of Thrones (A Targaryen History)",
NGAYGUI ="2/2/2",
ANH="Pic1.png",
TGIA_ID = 1
},
//TINTUC 2
new TINTUC
{
TIN_ID = 2,
NOIDUNG = "300 Years Before A Game of Thrones (A Targaryen History)",
NGAYGUI ="2/2/2",
ANH="Pic1.png",
TGIA_ID = 2
},
//TINTUC 3
new TINTUC
{
TIN_ID = 3,
NOIDUNG = "300 Years Before A Game of Thrones (A Targaryen History)",
NGAYGUI ="2/2/2",
ANH="Pic1.png",
TGIA_ID = 3
},
//TINTUC 4
new TINTUC
{
TIN_ID = 4,
NOIDUNG = "300 Years Before A Game of Thrones (A Targaryen History)",
NGAYGUI ="2/2/2",
ANH="Pic1.png",
TGIA_ID = 4
},

};
            return tintucs;
        }
    }
}