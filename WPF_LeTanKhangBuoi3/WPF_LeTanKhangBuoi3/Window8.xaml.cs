using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
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
    /// Interaction logic for Window8.xaml
    /// </summary>
    public partial class Window8 : Window
    {
        public Window8()
        {
            InitializeComponent();
            ObservableCollection<string> colors = new ObservableCollection<string>();

            String[] allColors = Enum.GetNames(typeof(KnownColor));

            foreach (String color in allColors)
            {
                colors.Add(color);
            }

            ObservableCollection<States> states = new ObservableCollection<States>();

            states.Add(new States("California", colors));
            states.Add(new States("Maryland", colors));
            states.Add(new States("Washington", colors));
            states.Add(new States("New York", colors));
            states.Add(new States("Taxes", colors));

            list.ItemsSource = states;
        }
        public class States
        {
            public States()
            {
            }

            public States(String name, ObservableCollection<string> colors)
            {
                Name = name;
                Colors = colors;
            }

            public String Name
            { get; set; }

            public ObservableCollection<String> Colors
            { get; set; }
        }
    }
}
