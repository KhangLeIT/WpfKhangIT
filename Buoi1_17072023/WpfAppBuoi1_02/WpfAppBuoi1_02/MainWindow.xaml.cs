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

namespace WpfAppBuoi1_02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button btn1;
        Window2 fr;
        public MainWindow()
        {
            InitializeComponent();
            btn1 = new Button();
            btn1.Content = "Click Vào đê";
            btn1.LayoutTransform = new ScaleTransform(3, 3);
            btn1.Margin = new System.Windows.Thickness(10);
            btn1.Click += new RoutedEventHandler(btn1_Click);
            this.Content = btn1;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            btn1.Content = "You was clicked";
            fr = new Window2();
            fr.Show();
        }
    }
}
