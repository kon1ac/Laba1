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
using Practa1.Laba1DataSetTableAdapters;

namespace Practa1
{
    public partial class MainWindow : Window
    {
        CustomersTableAdapter customer = new CustomersTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            CustomersDataGrid.ItemsSource = customer.GetData();
        }
    }
}