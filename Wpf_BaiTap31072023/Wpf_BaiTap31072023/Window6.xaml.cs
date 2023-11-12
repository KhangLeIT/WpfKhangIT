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

namespace Wpf_BaiTap31072023
{
    /// <summary>
    /// Interaction logic for Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        bool selectedCoffe;
        bool selectedKiwi;
        bool selectedTaTua;
        

        public Window6()
        {
            InitializeComponent();
            selectedCoffe = false;
            selectedKiwi = false;
            selectedTaTua = false;
            
        }

        private void HandleChecked(object sender, RoutedEventArgs e)
        {

            if (sender.Equals(chkCoffee)) selectedCoffe = true;

            if (sender.Equals(chkKiwiJuice)) selectedKiwi = true;

            if (sender.Equals(chkTaTua)) selectedTaTua = true;
        }

        private void HandleUnchecked(object sender, RoutedEventArgs e)
        {

            if (sender.Equals(chkCoffee)) selectedCoffe = false;

            if (sender.Equals(chkKiwiJuice)) selectedKiwi = false;

            if (sender.Equals(chkTaTua)) selectedTaTua = false;
        }

        private void DislayCustomerChoices(object sender, RoutedEventArgs e)
        {
            String choices = "Ban da chon ";
            bool selected = false;
            //
            if (selectedCoffe)
            {
                choices += "Coffee ing; ";
                selected = true;
            }
            //
            if (selectedKiwi)
            {
                choices += "Nước Kiwi Ko đường; ";
                selected = true;
            }
            //
            if (selectedTaTua)
            {
                choices += "Nuoc Tà Tưa; ";
                selected = true;
            }
            //
            
            if (!selected) choices = "Ban chua chon do uong nao";
            //
            MessageBox.Show(choices);
        }
    }
}
