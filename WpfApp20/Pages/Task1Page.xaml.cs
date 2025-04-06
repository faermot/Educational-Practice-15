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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp20.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task1Page.xaml
    /// </summary>
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }


        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string input = ArrayBoxOne.Text;
                string[] parts = input.Split(',');

                char[] chars = new char[parts.Length];

                for (int i = 0; i < parts.Length; i++)
                {
                    string part = parts[i].Trim();

                    if (part.Length != 1)
                    {
                        MessageBox.Show("Каждый элемент должен быть одним символом.");
                        return;
                    }

                    char ch = part[0];

                    if (ch >= '0' && ch <= '9')
                    {
                        chars[i] = '*';
                    }
                    else
                    {
                        chars[i] = ch;
                    }
                }

                ResultTextBlock.Text = "Результат: " + string.Join(", ", chars);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
