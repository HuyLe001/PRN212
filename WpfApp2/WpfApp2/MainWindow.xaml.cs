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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtTinh.Click += TxtTinh_Click;
        }


        private void TxtTinh_Click(object sender, RoutedEventArgs e)
        {
            double a, b;
            bool isAValid = double.TryParse(txta.Text, out a);
            bool isBValid = double.TryParse(txtb.Text, out b);

            if (!isAValid || !isBValid)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho A và B.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            double result = a + b;
            txtab.Text = result.ToString();
        }

        // Các sự kiện dư thừa nếu không sử dụng, bạn có thể để trống như sau:
        private void ___No_Name__TextChanged(object sender, TextChangedEventArgs e) { }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) { }
        private void txtab_TextChanged(object sender, TextChangedEventArgs e) { }
    }

}
