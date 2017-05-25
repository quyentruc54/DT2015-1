using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Data.control;
using Data.entity;
namespace BDTD.View
{
    /// <summary>
    /// Interaction logic for ViewDonVi.xaml
    /// </summary>
    public partial class ViewDonVi : UserControl
    {
        ViewDonViControl _control = new ViewDonViControl();
        public ViewDonVi()
        {
            InitializeComponent();
            this.DataContext = _control;
            btnThem.Click += them;
        }
        void them(object sender, EventArgs e)
        {
            MessageBox.Show("1");
            DonViDb obj = new DonViDb(_control.IdDonViNew(), (int)cbbIdDonVi.SelectedValue, txtTenDonVi.Text);
            _control.objNew = obj;
        }

        private void grid_SelectionChanged(object sender, DevExpress.Xpf.Grid.GridSelectionChangedEventArgs e)
        {
            _control.objSelect = (DonViDb)grid.SelectedItem;
        }
    }
}
