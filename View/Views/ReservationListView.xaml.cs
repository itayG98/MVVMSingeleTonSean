﻿using MVVM.Model;
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

namespace MVVM.Views
{
    /// <summary>
    /// Interaction logic for UserControl2.xaml
    /// </summary>
    public partial class ReservationListView : UserControl
    {
        public List<Reservation> resrv;

        public List<Reservation> Reservations { get { return resrv; } set { resrv = value; } }
        public ReservationListView()
        {
            InitializeComponent();
        }
    }
}
