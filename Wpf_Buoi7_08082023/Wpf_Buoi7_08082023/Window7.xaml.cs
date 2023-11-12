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

namespace Wpf_Buoi7_08082023
{
    /// <summary>
    /// Interaction logic for Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        public Window7()
        {
            InitializeComponent();
        }

        private void txtEditor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            string str = txtEditor.Text;
            int row =
            txtEditor.GetLineIndexFromCharacterIndex(txtEditor.CaretIndex);
            int col = txtEditor.CaretIndex -
            txtEditor.GetCharacterIndexFromLineIndex(row);
            int sel = txtEditor.SelectionLength;
            int len = txtEditor.Text.Length; // includes CR LF
            int lines = txtEditor.LineCount;
            int chars = len - (2 * (lines - 1)); // remove CR LF
            lblCursorPosition.Text = "Chars " + chars + " , Len " + len + " , Lines " + lines + " , Line " + (row + 1) + ", Char " + (col + 1) + " , Sel " + sel;
        }
    }
}
