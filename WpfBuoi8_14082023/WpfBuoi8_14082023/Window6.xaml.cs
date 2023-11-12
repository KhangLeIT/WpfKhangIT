using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
            List<User6> items = new List<User6>();
            items.Add(new User6() { Name="Khang", Age = 22});
            items.Add(new User6() { Name = "Jane", Age = 39 });
            items.Add(new User6() { Name = "Sammy", Age = 12 });
            items.Add(new User6() { Name = "Donna", Age = 12 });
            lbUser.ItemsSource = items;
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lbUser.ItemsSource);
            view.SortDescriptions.Add(new SortDescription("Age", ListSortDirection.Ascending));
            view.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));


        }
    }
    public class User6
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
