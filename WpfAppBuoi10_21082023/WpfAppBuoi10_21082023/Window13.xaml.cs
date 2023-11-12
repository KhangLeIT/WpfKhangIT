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
using System.Windows.Shapes;

namespace WpfAppBuoi10_21082023
{
    /// <summary>
    /// Interaction logic for Window13.xaml
    /// </summary>
    public partial class Window13 : Window
    {
        public Window13()
        {
            InitializeComponent();
            cldSample.SelectedDate = DateTime.Now.AddDays(1);
        }
    }
}
