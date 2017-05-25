using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.entity
{
public    class DonViChiTietDb:entity.EntityDb
    {
        public int IdDonVi { get; set; }
        public int IdDonViCha { get; set; }
        public string Ten { get; set; }
          public string TenDonViCha { get; private set; }
        public DonViChiTietDb(System.Data.DataRow row):base(row)
        {
        }
        public DonViChiTietDb()
        {
        }
        public DonViChiTietDb(int id, int parent, string name, string nameparent)
        {
            IdDonVi = id;
            IdDonViCha = parent;
            Ten = name;
            TenDonViCha = nameparent;
        }

    }
}
