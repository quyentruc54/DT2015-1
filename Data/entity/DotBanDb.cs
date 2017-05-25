using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.entity
{
   public  class DotBanDb:EntityDb
    {
       public int IdDotBan { get; set; }
       public string Ten { get; set; }
       public DateTime NgayThang { get; set; }
       public int SoLuong { get; set; }
        public DotBanDb(System.Data.DataRow row):base(row) { }
        public DotBanDb() { }

    }
}
