using Barbershop.Classes;
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

namespace Barbershop.Pages
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        Frame frame;
        public Register(Frame frame)
        {
            InitializeComponent();
            this.frame = frame;
        }

        private void button2_Click(object sender, RoutedEventArgs e) {
            if (MainWindow.DB.users.SingleOrDefault(u => u.Nickname == textBox1.Text) == null) {
                if (textBox1.Text != "" && textBox2.Text != "") {
                    User U = new User(textBox1.Text, " ", " ", textBox2.Text, 0);
                    MainWindow.DB.users.Add(U);
                    MainWindow.DB.SaveChanges();
                    frame.Navigate(PageController.LoginPage);
                    return;
                }
                MessageBox.Show("Заповніть поля");
                return;
            }
            MessageBox.Show("Такий користувач вже існує");
        }
    }
}
