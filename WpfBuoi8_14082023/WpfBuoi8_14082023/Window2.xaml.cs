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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            List<User> users = new List<User>();
            users.Add(new User() { Name= "khang", Age = 22});
            users.Add(new User() { Name = "Tan", Age = 22 });
            users.Add(new User() { Name = "Le", Age = 22 });
            lvDataBinding.ItemsSource = users;

        }
    }

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return this.Name + "," + this.Age + "Years Old";
        }
    }
}
