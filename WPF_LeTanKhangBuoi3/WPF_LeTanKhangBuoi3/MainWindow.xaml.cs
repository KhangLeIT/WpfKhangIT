using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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

namespace WPF_LeTanKhangBuoi3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

        public MainWindow()
        {
            InitializeComponent();
         
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            String strMessage, strHoTen, strTitle, strNgoaiNgu = "", strQueQuan = "" ;
            strHoTen = textBox1.Text + " " + textBox2.Text +"  \n ";
            if (radioButton1.IsChecked == true)
                strTitle = "Mr.";
            else
                strTitle = "Miss/Mrs.";

            strTitle = "Xin chào: " + strTitle + " " + strHoTen;
            
            if (checkBox1.IsChecked == true)
            {
                strNgoaiNgu = "Tiếng Anh  ";
            }
            if (checkBox2.IsChecked == true)
            {
                strNgoaiNgu = (strNgoaiNgu.Length == 0) ? "Tiếng Trung" : (strNgoaiNgu + " và Tiếng Trung");
            }
            
            if(checkBox1.IsChecked == true || checkBox2.IsChecked == true)
            {
                strNgoaiNgu = "Ngoại ngữ: " + strNgoaiNgu + "  \n ";
            }

            
            if (comboBox1.SelectedIndex >= 0)//Nếu đã có một mục trong danh sách được chọn
            {
                strQueQuan = "Quê Quán: " + comboBox1.Text;
            }
            strMessage = strTitle + strNgoaiNgu + strQueQuan;
            MessageBox.Show(strMessage);
            
           
        }
    }
}
