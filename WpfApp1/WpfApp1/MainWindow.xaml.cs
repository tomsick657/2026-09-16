using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            // 生成九九乘法表
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    sb.Append($"{j}x{i}={i * j,2}   ");
                }
                sb.AppendLine();
            }

            // 將結果寫入 XAML 的 resultTextBox 文字方塊中
            resultTextBox.Text = sb.ToString();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
