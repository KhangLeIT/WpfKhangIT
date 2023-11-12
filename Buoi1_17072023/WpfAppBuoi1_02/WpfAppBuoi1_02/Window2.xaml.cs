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

namespace WpfAppBuoi1_02
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        Label lb;
        Button btnE;
        public Window2()
        {
            InitializeComponent();

            lb = new Label();
            lb.Content = "THIS IS ANOTHER WINDOW";
            // btnE = new Button();
            // btnE.Content = "Click me";
            lb.LayoutTransform = new ScaleTransform(3, 3);
            lb.Margin = new System.Windows.Thickness(10);
        }
    }
}
