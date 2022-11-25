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
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public Frame frame;
        public Main(Frame frame)
        {
            InitializeComponent();
            this.frame = frame;
            for(int i = 0; i < MainWindow.DB.users.ToList().Count; i++) {
                if (MainWindow.DB.users.ToList()[i].IsBarber == 1) {
                    comboBox1.Items.Add(MainWindow.DB.users.ToList()[i].FirstName + " " + MainWindow.DB.users.ToList()[i].SecondName);
                }
            }
            for (int i = 0; i < MainWindow.DB.haircuts.ToList().Count; i++) {
                comboBox2.Items.Add(MainWindow.DB.haircuts.ToList()[i].Name + " " + MainWindow.DB.haircuts.ToList()[i].Price);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e) {
            if(comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1) {
                DateTime dt = (DateTime)tpicker.SelectedTime;
                TimeOnly t = new TimeOnly(dt.Hour, dt.Minute, dt.Second);
                Order O = new Order(0, MainWindow.U.Nickname, MainWindow.DB.users.ToList()[comboBox1.SelectedIndex].Nickname, t, comboBox2.SelectedIndex);
                MainWindow.DB.orders.Add(O);
                MainWindow.DB.SaveChanges();
                MessageBox.Show("Записано");
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e) {
            List<OrderString> L = new List<OrderString>();
            foreach(Order O in MainWindow.DB.orders.ToList()) {
                if(O.NicknameUser == MainWindow.U.Nickname) {
                    OrderString OS = new OrderString(O.NicknameBarber, O.Time, MainWindow.DB.haircuts.ToList()[O.IdHaircut].Name, MainWindow.DB.haircuts.ToList()[O.IdHaircut].Price);
                    L.Add(OS);
                }
            }
            PageController.SetOrderListPage(frame, L);
            frame.Navigate(PageController.OrderListPage);
        }

        private void button3_Click(object sender, RoutedEventArgs e) {
            frame.Navigate(PageController.LoginPage);
        }
    }
}
