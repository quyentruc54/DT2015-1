using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.entity
{
  public   class ThamSoDb:EntityDb
    {
      public string TenThamSo { get; set; }
      public string GiaTriThamSo { get; set; }
        public ThamSoDb(System.Data.DataRow row):base(row) { }
        public ThamSoDb() { }
    }
}
