using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfBuoi9_15082023
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
            MenuItem root = new MenuItem() { Title = "menu"};
            MenuItem childItem1 = new MenuItem() { Title = "Child Item #1" };
                     childItem1.Items.Add(new MenuItem() { Title="Child Item #1.1"});
                     childItem1.Items.Add(new MenuItem() { Title = "Child Item #1.2" });
            root.Items.Add(childItem1);
            root.Items.Add(new MenuItem() { Title="Child Item #2"});
            trvMenu.Items.Add(root); 

        }
    }

    public class MenuItem
    {
        public MenuItem()
        {
            this.Items = new ObservableCollection<MenuItem>();

        }
        public string Title { get; set; }
        public ObservableCollection<MenuItem> Items { get; set; }
    }
}
