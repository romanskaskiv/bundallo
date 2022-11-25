using Barbershop.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Barbershop.Classes
{
    public class PageController
    {
        public static Login LoginPage { get; set; }
        public static Main MainPage { get; set; }
        public static OrderList OrderListPage { get; set; }
        public static Register RegisterPage { get; set; }
        public static void SetLoginPage(Frame frame) {
            LoginPage = new Login(frame);
        }
        public static void SetMainPage(Frame frame) {
            MainPage = new Main(frame);
        }
        public static void SetOrderListPage(Frame frame, List<OrderString> L) {
            OrderListPage = new OrderList(frame, L);
        }
        public static void SetRegisterPage(Frame frame) {
            RegisterPage = new Register(frame);
        }
    }
}
