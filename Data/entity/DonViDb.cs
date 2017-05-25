﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.entity
{
 public   class DonViDb:EntityDb
    {
     public int IdDonVi { get; set; }
     public int IdDonViCha { get; set; }
     public string Ten { get; set; }
      //  public string TenDonViTrucThuoc { get; private set; }
        public DonViDb (System.Data.DataRow row):base(row)
        {
        }
        public DonViDb()
        {
        }
        public DonViDb (int id, int parent, string name  )
        {
            IdDonVi = id;
            IdDonViCha = parent;
            Ten = name;
        }
    }
}
