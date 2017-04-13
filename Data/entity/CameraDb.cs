using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.entity
{
   public class CameraDb
    {
       public int IdCamera { get; set; }
       public int IdBeBan { get; set; }
       public int IdBia { get; set; }
       public String IP { get; set; }
       public string Port { get; set; }
       public string User { get; set; }
       public string Pass { get; set; }
    }
}
