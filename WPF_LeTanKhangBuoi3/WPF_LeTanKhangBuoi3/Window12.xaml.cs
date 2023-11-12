using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Interaction logic for Window12.xaml
    /// </summary>
    public partial class Window12 : Window
    {
        public Window12()
        {
            InitializeComponent();
            List<DataPoint> test = new List<DataPoint>();
            test.Add(new DataPoint("Black", 1, 50));
            test.Add(new DataPoint("Red", 2, 40));
            test.Add(new DataPoint("Blue", 3, 20));
            test.Add(new DataPoint("Green", 4, 125));
            test.Add(new DataPoint("Yellow", 5, 65));
            test.Add(new DataPoint("Violet", 6, 15));
            test.Add(new DataPoint("Wheat", 7, 90));
            test.Add(new DataPoint("Indigo", 8, 45));
            test.Add(new DataPoint("Cyan", 9, 130));
            test.Add(new DataPoint("Navy", 10, 75));
            list.ItemsSource = test;

        }
    }
    public class CounterConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double counter = (double)value;
            return counter *20;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class DataPoint
    {
        public DataPoint(String name, Double counter, Double value)
        {
            Name = name;
            Counter = counter; Value = value;
        }
        public String Name { get; set; }
        public Double Counter { get; set; }
        public Double Value { get; set; }
    }

}
