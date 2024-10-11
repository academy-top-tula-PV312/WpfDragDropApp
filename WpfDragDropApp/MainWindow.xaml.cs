using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDragDropApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool ctrlDown;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtBoxTitle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragDrop.DoDragDrop(txtBoxTitle, txtBoxTitle.Text, DragDropEffects.Move);
        }

        private void btnTitle_Drop(object sender, DragEventArgs e)
        {
            btnTitle.Content = e.Data.GetData(DataFormats.Text);
        }

        private void txtEditor_KeyDown(object sender, KeyEventArgs e)
        {
            txtBlockKeys.Text += e.Key.ToString() + " ";
        }

        private void txtEditor_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtEditor_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (Keyboard.Modifiers == ModifierKeys.Control)
            {
                if (e.Delta > 0)
                    txtEditor.FontSize += 2;
                else
                    txtEditor.FontSize -= 2;
            }
        }
    }
}