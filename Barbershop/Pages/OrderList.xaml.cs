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
    /// Interaction logic for OrderList.xaml
    /// </summary>
    public partial class OrderList : Page
    {
        Frame frame;
        public OrderList(Frame frame, List<OrderString> L)
        {
            InitializeComponent();
            dataGrid.ItemsSource = L;
            this.frame = frame;
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }

        private void button_Click(object sender, RoutedEventArgs e) {
            frame.Navigate(PageController.MainPage);
        }
    }
}
