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
    /// Interaction logic for Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        private GridViewColumnHeader listViewSortCol = null;
        private SortAdorner listViewSortAdorner = null;
        public Window7()
        {
            InitializeComponent();
            List<User7> items = new List<User7>();
            items.Add(new User7() { Name = "name1", Age = 121, Sex = SexType.Male });
            items.Add(new User7() { Name = "name2", Age = 111, Sex = SexType.Female });
            items.Add(new User7() { Name= "name3", Age = 131, Sex = SexType.Male });
            lbUser.ItemsSource = items;



        }

        private void lvUserCollunmHearder_Click(object sender, RoutedEventArgs e)
        {
           GridViewColumnHeader column = (sender as GridViewColumnHeader);
            string sortBy = column.Tag.ToString();
            if( listViewSortCol != null )
            {
                AdornerLayer.GetAdornerLayer(listViewSortCol).Remove(listViewSortAdorner);
                lbUser.Items.SortDescriptions.Clear();

            }
            ListSortDirection newDir  = ListSortDirection.Ascending;
            if(listViewSortCol == column && listViewSortAdorner.Direction == newDir)
            {
                newDir = ListSortDirection.Descending;
                listViewSortCol = column;
                listViewSortAdorner = new SortAdorner(listViewSortCol, newDir);
                AdornerLayer.GetAdornerLayer(listViewSortCol).Add(listViewSortAdorner);
                lbUser.Items.SortDescriptions.Add(new SortDescription(sortBy, newDir));

            }

        }

    }
    public enum SexType1 { Male, Female };
    public class User7
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }
        public SexType Sex { get; set; }
    }
    public class SortAdorner : Adorner
    {
        private static Geometry ascGeometry = Geometry.Parse("M 0 4 L 3.5 0 L 7 4 Z");
        private static Geometry descGeometry= Geometry.Parse("M 0 0 L 3.5 4 L 7 0 Z");
        public ListSortDirection Direction { get; private set; }
        public SortAdorner(UIElement element, ListSortDirection dir) : base(element)
        {
            this.Direction = dir;
        }
        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            if (AdornedElement.RenderSize.Width < 20)
                return;
            TranslateTransform transform = new TranslateTransform(AdornedElement.RenderSize.Width - 15, (AdornedElement.RenderSize.Height - 5) / 2);
            drawingContext.PushTransform(transform);
            Geometry geometry = ascGeometry;
            if (this.Direction == ListSortDirection.Descending) geometry = descGeometry;
            drawingContext.DrawGeometry(Brushes.Black, null, geometry);
            drawingContext.Pop();

        }
    }
}
