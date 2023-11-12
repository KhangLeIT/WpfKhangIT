using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace WPF_LeTanKhangBuoi3
{
    /// <summary>
    /// Interaction logic for Window9.xaml
    /// </summary>
    public partial class Window9 : Window
    {
        private ObservableCollection<City> cty = new ObservableCollection<City>();

        public Window9()
        {
            InitializeComponent();
            cty.Add(new City() { Name = "Hello", State="MA", Pop = 123});
            DataContext = cty;
        }
        class City
        {
            public String State
            { get; set; }
            public String Name
            { get; set; }
            public int Pop
            { get; set; }

            
        }
    }
}
