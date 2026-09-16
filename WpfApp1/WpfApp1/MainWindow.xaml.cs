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
            string xInput = xTextBox.Text.Trim();

            // 防呆判斷：確認 x 是否為大於 0 的正整數
            if (int.TryParse(xInput, out int x) && x > 0)
            {

                // 外層迴圈代表 1 到 x
                for (int i = 1; i <= x; i++)
                {
                    // 內層迴圈固定乘以 1 到 9
                    for (int j = 1; j <= 9; j++)
                    {
                        sb.Append($"{i}x{j}={i * j,2} ");
                    }
                    sb.AppendLine(); // 每一個數字算完 1~9 後換行
                }
            }
            else
            {
                MessageBox.Show("請輸入大於 0 的正整數 x！", "錯誤提示", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // 顯示結果於文字框
            resultTextBox.Text = sb.ToString();
        }

        private void infoButton_Click(object sender, RoutedEventArgs e)
        {
            string name = nameTexBox.Text.Trim();
            string phone = telTextBox.Text.Trim();

            string message = $"【使用者資訊】\n姓名：{name}\n電話：{phone}";
            MessageBox.Show(message, "使用者資訊確認", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
        }
    }
}
