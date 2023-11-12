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

namespace WPF_LeTanKhangBuoi3
{
    /// <summary>
    /// Interaction logic for Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        public Window7()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            ComboBox1.Items.Add(TextBox1.Text);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            ComboBox1.Items.RemoveAt(ComboBox1.Items.IndexOf(ComboBox1.SelectedItem));
        }
    }
}
