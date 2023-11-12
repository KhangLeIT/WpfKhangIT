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

namespace WpfBuoi8_14082023
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
           
            List<User1> users = new List<User1>();
            users.Add(new User1() { Name1 = "khang", Age1 = 22, Mail = "kkk@gmail.com" });
            users.Add(new User1() { Name1 = "Tan", Age1 = 22, Mail = "kkk@gmail.com" });
            users.Add(new User1() { Name1 = "Le", Age1 = 22, Mail = "kkk@gmail.com" });
            lvDataBinding.ItemsSource = users;
        }
    }

    public class User1 { 
        public string Name1 { get; set; }
        public int Age1 { get; set; }
        public string Mail { get; set; }
       
    }
}
