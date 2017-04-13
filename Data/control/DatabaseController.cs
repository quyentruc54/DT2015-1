using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Data.entity;
namespace Data.control
{
   public class DatabaseController
    {
       private Boolean isconnected = false;
       public virtual DbSet<CameraDb> CameraDbs { get; set; }
       public virtual DbSet<ChiTietDotBanDb> ChiTietDotBanDbs { get; set; }
       public virtual DbSet<DonViDb> DonViDbs { get; set; }
       public virtual DbSet<DotBanDb> DotBanDbs { get; set; }
       public virtual DbSet<ThamSoDb> ThamsoDbs { get; set; }
       public virtual DbSet<XaThuDb> XaThuDbs { get; set; }
       public string ConnectionString { get; set; }
       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
       public Boolean Connect ()
       {
           Boolean blreturn = false ;

           return blreturn;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
       public Boolean DisConnect()
       {
           Boolean blReturn = false ;

           return blReturn;
       }

       public void Insert (object obj)
       {
           if (isconnected )
           {

           }
       }
    }
}
