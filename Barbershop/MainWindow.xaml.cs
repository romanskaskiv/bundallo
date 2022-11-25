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

namespace Barbershop {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public static User U { get; set; }
        public static Database DB { get; set; }
        public MainWindow() {
            InitializeComponent();
            DB = new Database();
            PageController.SetLoginPage(frame);
            frame.Navigate(PageController.LoginPage);
        }
    }
}
