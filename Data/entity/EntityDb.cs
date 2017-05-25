using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;
namespace Data.entity
{
   public  class EntityDb
    {
        public List<string> Columns;
        public List<string> Values;

        public EntityDb() { }
        public EntityDb(DataRow row)
        {
            object obj = new object();
            this.Columns = new List<string>();
            this.Values = new List<string>();
            PropertyInfo[] props = this.GetType().GetProperties();
            foreach (PropertyInfo item in props)
            {
                //row.
                //if (item.Name )
                this.Columns.Add(item.Name);
                string s = row[item.Name].ToString();                
                Type p = item.PropertyType;
                if (s == "" || s == null)
                    s = "0";
                
                item.SetValue(this, Convert.ChangeType(s, p));
            }
        }
    }
}
