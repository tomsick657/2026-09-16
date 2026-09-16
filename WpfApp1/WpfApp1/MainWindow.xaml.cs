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

        // 乘法表按鈕事件
        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    sb.Append($"{j}x{i}={i * j,2}   ");
                }
                sb.AppendLine();
            }
            resultTextBox.Text = sb.ToString();
        }

        // 新增：蒐集使用者資訊按鈕事件
        private void infoButton_Click(object sender, RoutedEventArgs e)
        {
            string name = nameTexBox.Text.Trim();
            string phone = telTextBox.Text.Trim();

            // 組合顯示訊息
            string message = $"【使用者資訊】\n姓名：{name}\n電話：{phone}";

            // 彈出 MessageBox 顯示資訊
            MessageBox.Show(message, "使用者資訊確認", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
