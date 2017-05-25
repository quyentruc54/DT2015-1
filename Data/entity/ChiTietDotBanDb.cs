using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;
namespace Data.entity
{
   public class ChiTietDotBanDb:EntityDb
    {
       public int IdChiTietDotBan {
            get
            {
                return this.IdChiTietDotBan;
            }
            set
            {
                if (value.GetType().Name == "string")
                {
                    IdChiTietDotBan = Convert.ToInt16(value);
                }
            }
        }
       public int IdDotBan
        {
            get
            {
                return this.IdDotBan;
            }
            set
            {
                if (value.GetType().Name == "string")
                {
                    IdDotBan = Convert.ToInt16(value);
                }
            }
        }
       public int IdLoadBan
        {
            get
            {
                return this.IdLoadBan;
            }
            set
            {
                if (value.GetType().Name == "string")
                {
                    this.IdLoadBan = Convert.ToInt16(value);
                }
            }
        }
       public int IdBeBan
        {
            get
            {
                return this.IdBeBan;
            }
            set
            {
                if (value.GetType().Name == "string")
                {
                    this.IdBeBan = Convert.ToInt16(value);
                }
            }
        }
       public int IdXaThu
        {
            get
            {
                return this.IdXaThu;
            }
            set
            {
                if (value.GetType().Name == "string")
                {
                    this.IdXaThu = Convert.ToInt16(value);
                }
            }
        }
       public int Diem41 { get; set; }
       public int Diem42 { get; set; }
       public int Diem43 { get; set; }
       public int Diem71 { get; set; }
       public int Diem72 { get; set; }
       public int Diem73 { get; set; }
       public int Diem81 { get; set; }
       public int Diem82 { get; set; }
       public int Diem83 { get; set; }
       public int Diem4 { get; set; }
       public int Diem7 { get; set; }
       public int Diem8 { get; set; }
       public int Diem { get; set; }
       public string Anh41 { get; set; }
       public string Anh42 { get; set; }
       public string Anh43 { get; set; }
       public string Anh71 { get; set; }
       public string Anh72 { get; set; }
       public string Anh73 { get; set; }
       public string Anh81 { get; set; }
       public string Anh82 { get; set; }
       public string Anh83 { get; set; }
       public string GhiChu { get; set; }
        public ChiTietDotBanDb (DataRow row):base(row)
        {
        }
        public ChiTietDotBanDb() { }
    }
}
