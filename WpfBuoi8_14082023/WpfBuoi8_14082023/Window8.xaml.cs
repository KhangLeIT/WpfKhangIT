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
    /// Interaction logic for Window8.xaml
    /// </summary>
    public partial class Window8 : Window
    {
        public Window8()
        {
            InitializeComponent();
            List<User8> items = new List<User8>();
            items.Add(new User8() { Name = "John Doe", Age = 42 });
            items.Add(new User8() { Name = "John Doe", Age = 39 });
            items.Add(new User8() { Name = "Sammy Doe", Age = 13 });
            items.Add(new User8() { Name = "Donna Doe", Age = 13 });
            lvUsers.ItemsSource = items;
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
            view.Filter = UserFilter;
        }

        private bool UserFilter(Object item)
        {
            if (String.IsNullOrEmpty(txtFilter.Text))
            {
                return true;
            }
            else return ((item as User8).Name.IndexOf(txtFilter.Text, StringComparison.OrdinalIgnoreCase) >=0);
        }
        private void txtFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(lvUsers.ItemsSource).Refresh();
        }
    }

   public enum SexType7 {Male, Female };

    public class User8
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }
        public SexType7 Sex { get; set; }
    }
}
