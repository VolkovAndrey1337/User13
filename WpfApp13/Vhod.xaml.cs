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

namespace WpfApp13
{
    /// <summary>
    /// Логика взаимодействия для Vhod.xaml
    /// </summary>
    public partial class Vhod : Window
    {
        public Vhod()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            {
                string login = Name.Text;
                string password = Password.Password;

                for (int i = login.Length; i < 100; i++)
                {
                    login += " ";
                }
                for (int i = password.Length; i < 15; i++)
                {
                    password += " ";
                }

                PolzovateliEntities DB = new PolzovateliEntities();
                try
                {
                    Polzovateli user = DB.Polzovateli.Where((u) => u.Name == login && u.Password == password).Single();
                    MainWindow main = new MainWindow();
                    main.Show();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Проверьте правильность логина или пароля!");
                }
            }
        }

        
    }
}
