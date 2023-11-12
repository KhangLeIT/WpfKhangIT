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
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
            List<User3> items = new List<User3>();
            items.Add(new User3() { Name1="name1", Age1= 121,Sex=SexType.Male });
            items.Add(new User3() { Name1 = "name2", Age1 = 111, Sex = SexType.Female });
            items.Add(new User3() { Name1 = "name3", Age1 = 131, Sex = SexType.Male });
            lvUsers.ItemsSource = items;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("Sex");
            view.GroupDescriptions.Add(groupDescription);
            
        }
    }
    public enum SexType { Male, Female};
    public class User3
    {
        public string Name1 { get; set; }
        public int Age1 { get; set; }
        public string Mail { get; set; }
        public SexType Sex { get; set; }

    }
}
