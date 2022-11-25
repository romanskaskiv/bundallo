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

namespace Barbershop.Pages {
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page {
        public Frame frame;
        public Login(Frame frame) {
            InitializeComponent();
            this.frame = frame;
        }

        private void button1_Click(object sender, RoutedEventArgs e) {
            User U = MainWindow.DB.users.SingleOrDefault(u => u.Nickname == textBox1.Text && u.Password == textBox2.Text && u.IsBarber == 0);
            if (U != null) {
                MainWindow.U = U;
                PageController.SetMainPage(frame);
                frame.Navigate(PageController.MainPage);
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e) {
            PageController.SetRegisterPage(frame);
            frame.Navigate(PageController.RegisterPage);
        }
    }
}
