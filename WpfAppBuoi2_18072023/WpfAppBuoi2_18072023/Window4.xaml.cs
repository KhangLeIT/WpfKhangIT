
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Shapes;
namespace WpfAppBuoi2_18072023
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void getLayoutSlot1(object sender, RoutedEventArgs e)
        {
            RectangleGeometry myRectangleGeometry = new RectangleGeometry();
            myRectangleGeometry.Rect = LayoutInformation.GetLayoutSlot(txt1);
            Path myPath = new Path();
            myPath.Data = myRectangleGeometry;
            myPath.Stroke = Brushes.LightGoldenrodYellow;
            myPath.StrokeThickness = 5;
            Grid.SetColumn(myPath, 0);
            Grid.SetRow(myPath, 0);
            myGrid.Children.Add(myPath);
            txt2.Text = "LayoutSlot is equal to " + LayoutInformation.GetLayoutSlot(txt1).ToString();

        }
    }
}
