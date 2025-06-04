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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ToggleTextButton_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock.Text == "Welcome to WPF")
            {
                textBlock.Text = "Hello World";
            }
            else
            {
                textBlock.Text = "Welcome to WPF";
            }
        }
    }
}