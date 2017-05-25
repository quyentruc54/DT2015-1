using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.entity
{
    public class  XaThuDb:EntityDb
    {
        public int IdXaThu { get; set; }
        public string HoTen { get; set; }
        public string CapBac { get; set; }
        public string ChucVu { get; set; }
        public string IdDonVi { get; set; }
        public XaThuDb(System.Data.DataRow row):base(row) { }
        public XaThuDb() { }
    }
}
