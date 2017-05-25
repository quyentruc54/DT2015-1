using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Data.entity;
using Finisar.SQLite;
using System.Data;

using System.Reflection;
namespace Data.model
{
   public class DatabaseModel
    {
       private Boolean isconnected = false;
       private string _connectionstring;
       
        private SQLiteConnection _Sqlconnection;
        private List<CameraDb> _CameraDbs;
        private List<ChiTietDotBanDb> _ChiTietDotBanDbs;
        private List<DonViChiTietDb> _DonViDbs;
        private List<DotBanDb> _DotBanDbs;
        private List<ThamSoDb> _ThamSoDbs;
        private List<XaThuDb> _XaThuDbs;

        public List<CameraDb> CameraDbs { get {return _CameraDbs;} }
        public virtual List<ChiTietDotBanDb> ChiTietDotBanDbs { get { return _ChiTietDotBanDbs; } }
       public virtual List<DonViChiTietDb> DonViDbs { get { return _DonViDbs; } }
       public virtual List<DotBanDb> DotBanDbs { get { return _DotBanDbs; } }
       public virtual List<ThamSoDb> ThamsoDbs { get { return _ThamSoDbs; } }
       public virtual List<XaThuDb> XaThuDbs { get { return _XaThuDbs; } }
       public DatabaseModel (string dbname)
       {

           _connectionstring = "Data Source="+dbname +".db;Version=3;New=False;Compress=True;";
           ConnectionString = _connectionstring;
           _Sqlconnection = new SQLiteConnection(_connectionstring);
            _CameraDbs = new List<CameraDb>();
            _ChiTietDotBanDbs = new List<entity.ChiTietDotBanDb>();
            _DonViDbs = new List<entity.DonViChiTietDb>();
            _DotBanDbs = new List<entity.DotBanDb>();
            _ThamSoDbs = new List<entity.ThamSoDb>();
            _XaThuDbs = new List<XaThuDb>();

       }
       public string ConnectionString { get; set; }
       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
       public Boolean Connect ()
       {
           Boolean blreturn = false ;
           _Sqlconnection.Open();
           if (_Sqlconnection.State == System.Data.ConnectionState.Open)
               blreturn = true;
           return blreturn;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
       public Boolean DisConnect()
       {
           Boolean blReturn = false ;
           switch (_Sqlconnection.State )
           {
               case System.Data.ConnectionState.Closed:
                   {
                       blReturn = false;
                       break; 
                   }
               case System.Data.ConnectionState.Connecting:
                   {
                       blReturn = true;
                       break; 
                   }
               case System.Data.ConnectionState.Executing:
                   {
                       blReturn = true;
                       break; 
                   }
               case System.Data.ConnectionState.Fetching:
                   {
                       blReturn = true;
                       break; 
                   }
               case System.Data.ConnectionState.Open:
                   {
                       blReturn = true;
                       break; 
                   }
               case System.Data.ConnectionState.Broken :
                   {
                       blReturn = true;
                       break; 
                   }

           }
           return blReturn;
       }
        string getstringInsert(EntityDb o)
        {
            string s1 = "", s2 = "";
            foreach (string item in o.Columns)
            {
                if (s1 == "")
                {
                    s1 += item;

                }
                else
                {
                    s1 += "," + item;
                }
            }
            foreach (string item in o.Values)
            {
                if (s2 == "")
                { s2 += "'"+ item + "'"; }
                else
                { s2 += ",'" + item + "'"; }
            }

            return "insert into " + o.GetType().Name + "(" + s1+ ") values (" +s2 +")";
        }
        string getstringDelete(EntityDb o, string condition)
        {
            string strreturn = "";
            strreturn = "Delete from " + o.GetType().Name + " where " + condition ;
            return strreturn;
        }
        string getstringUpdate(EntityDb o, EntityDb s)
        {
            string re="update " + o.GetType().Name + " set " ;
            re +=  o.Columns[1] + "='" + s.Values[1] + "'";

            for (int i = 2; i < o.Columns.Count; i++)
            {
                re += " , "+  o.Columns[i] + "='" + s.Values[i] + "'";
            }

            re += "where " + o.Columns[0] + " == " + o.Values[0]; // mệnh đề where
            
            return re;
        }
        public Boolean insert(entity.EntityDb o )
        {
            Boolean bl = false;
             if (_Sqlconnection.State == System.Data.ConnectionState.Open )
            {
                SQLiteCommand sql_command = _Sqlconnection.CreateCommand();
                sql_command.CommandText = this.getstringInsert(o);
                sql_command.ExecuteNonQuery();
                _DonViDbs.Add((DonViChiTietDb)o);
                bl = true;
            }
            return bl;
        }

        public Boolean update (entity.EntityDb  o, entity.EntityDb  s)
        {
            Boolean bl = false;
            SQLiteCommand sql_command = _Sqlconnection.CreateCommand();
            sql_command.CommandText = this.getstringUpdate(o, s);
            sql_command.ExecuteNonQuery();
            bl = true;
            return bl;
        }
        public void  select  ( string tablename)
        {    
            SQLiteCommand sql_command = _Sqlconnection.CreateCommand();
            sql_command.CommandText = "select * from " + tablename;
            SQLiteDataAdapter db = new SQLiteDataAdapter(sql_command.CommandText, _Sqlconnection);
            System.Data.DataTable dt = new System.Data.DataTable();
            db.Fill(dt);
            switch (tablename )
                        {
                case nameof(CameraDb):
                    {
                        CameraDb cam = new entity.CameraDb();
                        FillCameraDb(dt, cam.GetType().GetProperties());
                        break;
                    }
                case nameof(ChiTietDotBanDb):
                    {
                        ChiTietDotBanDb cam = new entity.ChiTietDotBanDb();
                        FillChiTietDotBanDb(dt, cam.GetType().GetProperties());
                        break;
                    }
                case nameof(DonViChiTietDb):
                    {
                        DonViDb cam = new entity.DonViDb();
                        FillDonViDb(dt, cam.GetType().GetProperties());
                        break;
                    }
                case nameof(DotBanDb):
                    {
                        DotBanDb cam = new entity.DotBanDb();
                        FillDotBanDb(dt, cam.GetType().GetProperties());
                        break;
                    }
                case nameof(ThamSoDb):
                    {
                        ThamSoDb cam = new entity.ThamSoDb();
                        FillThamSoDb(dt, cam.GetType().GetProperties());
                        break;
                    }
                case nameof(XaThuDb):
                    {
                        XaThuDb cam = new entity.XaThuDb();
                        FillXaThuDb(dt, cam.GetType().GetProperties());
                        break;
                    }

            }


        }
        public void delete (EntityDb o, string condition)
        {
            if (_Sqlconnection.State == System.Data.ConnectionState.Open)
            {
                SQLiteCommand sql_command = _Sqlconnection.CreateCommand();
                sql_command.CommandText = this.getstringDelete(o, condition);
                sql_command.ExecuteNonQuery();              
            }

        }
        private void FillCameraDb(System.Data.DataTable table,  PropertyInfo[] props)
        {
            foreach (DataRow item in table.Rows)
            {
                CameraDb cam = new CameraDb(item);
                _CameraDbs.Add(cam);
            }
        }
        private void FillChiTietDotBanDb(DataTable table, PropertyInfo [] props)
        {
            foreach (DataRow item in table.Rows)
            {
                ChiTietDotBanDb cam = new ChiTietDotBanDb(item);
                _ChiTietDotBanDbs.Add(cam);
            }
        }
        /// <summary>
        /// đơn vị chi tiết
        /// </summary>
        /// <param name="table"></param>
        /// <param name="props"></param>
        private void FillDonViDb(DataTable table, PropertyInfo[] props)
        {
            foreach (DataRow item in table.Rows)
            {
                DonViChiTietDb cam = new DonViChiTietDb(item);
                _DonViDbs.Add(cam);
            }
        }
        private void FillDotBanDb(DataTable table, PropertyInfo[] props)
        {
            foreach (DataRow item in table.Rows)
            {
                DotBanDb cam = new DotBanDb(item);
                _DotBanDbs.Add(cam);
            }
        }
        private void FillThamSoDb(DataTable table, PropertyInfo[] props)
        {
            foreach (DataRow item in table.Rows)
            {
                ThamSoDb cam = new ThamSoDb(item);
                _ThamSoDbs.Add(cam);
            }
        }
        private void FillXaThuDb(DataTable table, PropertyInfo[] props)
        {
            foreach (DataRow item in table.Rows)
            {
                XaThuDb cam = new XaThuDb(item);
                _XaThuDbs.Add(cam);
            }
        }
    }
    
}
