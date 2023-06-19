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
using WPFAPP.Common;
using WPFAPP.ViewModel;

namespace WPFAPP.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            this.MaxHeight = SystemParameters.PrimaryScreenHeight;
            MainViewModel model =   new MainViewModel();
            this.DataContext = model;
            model.UserInfo.Level = GlobalValues.Userinfo.userLevel;
            model.UserInfo.UserName = GlobalValues.Userinfo.UserName;
            model.UserInfo.Gender = GlobalValues.Userinfo.Gender;
            model.UserInfo.Avatar = GlobalValues.Userinfo.Avatar;
            model.UserInfo.RealName = GlobalValues.Userinfo.RealName;
        }

        private void LoginLeftBtnMouse(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_minisize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Btn_MaxNormal(object sender, RoutedEventArgs e)
        {
            this.WindowState = this.WindowState== WindowState.Normal ? WindowState.Maximized : WindowState.Normal;
        }
    }
}
