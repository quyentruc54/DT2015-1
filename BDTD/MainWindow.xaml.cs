﻿using System;
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
using Data;
using Data.entity;
using Data.model;
using System.Data.Entity;
namespace BDTD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {            
            InitializeComponent();
            //CameraDb c = new CameraDb(1,1,1,"8.8.8.8","8080","Quyen", "KKKK");
            //DatabaseModel db = new DatabaseModel("BDTD");
            //db.Connect();
            //db.select( "CameraDb");
        }


    }
}
