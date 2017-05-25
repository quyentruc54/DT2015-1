using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.model;
using BTBD.Common;
using System.Windows;
namespace Data.control
{
    public class ViewDonViControl
    {
        DatabaseModel _dbModel;

        public entity.DonViDb objSelect { get; set; }
        public entity.DonViDb objNew { get; set; }

        public ViewDonViControl()
        {
            _dbModel = new model.DatabaseModel("BDTD");
            _dbModel.select("DonViChiTietDb");
            Thembutton = new RelayCommand(p => them());
            Xoabutton = new RelayCommand(p => Xoa());
            Suabutton = new RelayCommand(p => sua());
        }
        private void them()
        {
            System.Windows.Forms.MessageBox.Show("add command");
        }
        private void sua()
        {
            System.Windows.Forms.MessageBox.Show("edit command");
        }
        private void Xoa()
        {
            System.Windows.Forms.MessageBox.Show("delete command");
        }
        public List<entity.DonViChiTietDb> DonVidbs
        {
            get
            {
                return _dbModel.DonViDbs;
            }
        }
        public void ThemRecord(int id, int parent, string name)
        {
            entity.DonViDb obj = new entity.DonViDb(id, parent, name);
            _dbModel.insert(obj);
        }
        public int IdDonViNew()
        {
          var a =  _dbModel.DonViDbs.Max(r => r.IdDonVi);
            return Convert.ToInt16(a);
        }

        public RelayCommand Thembutton { get; set; }
         public RelayCommand Suabutton { get; set; }
        public RelayCommand Xoabutton { get; set; }
    }
}
