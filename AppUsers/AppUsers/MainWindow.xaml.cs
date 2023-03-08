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

namespace AppUsers
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = TextBoxLogin.Text.Trim();
            string pass_1 = passbox_1.Password.Trim();
            string pass_2 = passbox_2.Password.Trim();
            string email = TextBoxEmail.Text.Trim().ToLower();

            TextBoxLogin.Background = Brushes.Transparent;
            passbox_1.Background = Brushes.Transparent;
            passbox_2.Background = Brushes.Transparent;
            TextBoxEmail.Background = Brushes.Transparent;

            if (login.Length < 5)
            {
                TextBoxLogin.ToolTip = "Неправильный логин!";
                TextBoxLogin.Background = Brushes.DarkRed;
            }
            if (pass_1.Length <5)
            {
                passbox_1.ToolTip = "Неправильный пароль!";
                passbox_1.Background = Brushes.DarkRed;
            }
            if (pass_2.Length < 5)
            {
                passbox_2.ToolTip = "Неправильный пароль!";
                passbox_2.Background = Brushes.DarkRed;
            }
            if (pass_1 != pass_2)
            {
                passbox_2.ToolTip = "Пароли не совпадают!";
                passbox_2.Background = Brushes.DarkRed;
            }
            if (email.Length <5 || !email.Contains("@") || !email.Contains("."))
            {
                TextBoxEmail.ToolTip = "Неправильный email!";
                TextBoxEmail.Background = Brushes.DarkRed;
            }
            else
            {
                MessageBox.Show("Ошибок нет");
                TextBoxLogin.Text = "";
                passbox_1.Password = "";
                passbox_2.Password = "";
                TextBoxEmail.Text = "";
            }
        }

        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            TextBoxLogin.Text = "";
            TextBoxLogin.Background = Brushes.Transparent;

            passbox_1.Password = "";
            passbox_1.Background = Brushes.Transparent;

            passbox_2.Password = "";
            passbox_2.Background = Brushes.Transparent;

            TextBoxEmail.Text = "";
            TextBoxEmail.Background = Brushes.Transparent;
        }
    }
}
