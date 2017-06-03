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

namespace YUI.Test
{
    public class DataGridTest
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }

    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<DataGridTest> Data { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Data = new List<DataGridTest>();

            Data.Add(new DataGridTest {ID = "1", Name = "Smith", Phone = "1234125412", Address = "asdgbhiuas"});
            Data.Add(new DataGridTest {ID = "2", Name = "Jion", Phone = "1234125412", Address = "asdgbhiuas"});
            Data.Add(new DataGridTest {ID = "3", Name = "asdf", Phone = "1234125412", Address = "asdgbhiuas"});
            Data.Add(new DataGridTest {ID = "4", Name = "asdgas", Phone = "1234125412", Address = "asdgbhiuas"});
            Data.Add(new DataGridTest {ID = "5", Name = "dsg", Phone = "1234125412", Address = "asdgbhiuas"});
            Data.Add(new DataGridTest {ID = "6", Name = "asdg", Phone = "1234125412", Address = "asdgbhiuas"});
        }
    }
}
