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
    /// Interaction logic for Window11.xaml
    /// </summary>
    public partial class Window11 : Window
    {
        public ObservableCollection<Tuple<string, int, string>> Currencies =
            new ObservableCollection<Tuple<string, int, string>>();
        public Window11()
        {
            InitializeComponent();
            Currencies.Add(new Tuple<string, int, string>("AED", 784, "United Arab Emirates"));
            Currencies.Add(new Tuple<string, int, string>("AUD", 036, "Australian Dollar"));
            Currencies.Add(new Tuple<string, int, string>("CAD", 124, "Canadian Dollar"));
            Currencies.Add(new Tuple<string, int, string>("EUR", 978, "Euro"));
            Currencies.Add(new Tuple<string, int, string>("GBP", 826, "Pound Sterling"));
            Currencies.Add(new Tuple<string, int, string>("JPY", 392, "Japanese Yen"));
            Currencies.Add(new Tuple<string, int, string>("MXN", 484, "Mexican Peso"));
            Currencies.Add(new Tuple<string, int, string>("NZD", 554, "New Zeland Dollar"));
            Currencies.Add(new Tuple<string, int, string>("QAR", 634, "Qatar Riyal"));
            Currencies.Add(new Tuple<string, int, string>("SAR", 682, "Saudi Riyal"));
            Currencies.Add(new Tuple<string, int, string>("USD", 840, "US Dollar"));
            DataContext = Currencies;

        }
    }
}
