using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;
namespace Data.entity
{
   public class CameraDb:EntityDb
    {
       public Int16 IdCamera
        {
            get; set;
        }
       public int IdBeBan { get; set; }
       public int IdBia { get; set; }
       public string IP { get; set; }
       public string Port { get; set; }
       public string User { get; set; }
       public string Pass { get; set; }
        public CameraDb (Int16 idcam, int idbe, int idbia, string ip, string port, string user, string pass)
        {

            this.IdCamera = idcam;
            this.IdBeBan = idbe;
            this.IdBia = idbia;
            this.IP = ip;
            this.Port = port;
            this.User = user;
            this.Pass = pass;

            this.Columns = new List<string>();
            this.Columns.Add(nameof(this.IdCamera));
            this.Columns.Add(nameof(this.IdBeBan));
            this.Columns.Add(nameof(this.IdBia));
            this.Columns.Add(nameof(this.IP));
            this.Columns.Add(nameof(this.Port));
            this.Columns.Add(nameof(this.User));
            this.Columns.Add(nameof(this.Pass));

            this.Values = new List<string>();
            this.Values.Add((this.IdCamera.ToString ()));
            this.Values.Add((this.IdBeBan.ToString ()));
            this.Values.Add((this.IdBia.ToString ()));
            this.Values.Add((this.IP));
            this.Values.Add((this.Port));
            this.Values.Add((this.User));
            this.Values.Add((this.Pass));
        }
        public CameraDb() { }
        public CameraDb (DataRow row ):base     (row)
        {
        }
    }
}
