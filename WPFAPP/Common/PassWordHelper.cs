using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon.Primitives;

namespace WPFAPP.Common
{
    public class PassWordHelper
    {
        public static readonly DependencyProperty PassWordProperty = DependencyProperty.RegisterAttached("PassWord",typeof(string),typeof(PassWordHelper),
            new FrameworkPropertyMetadata("",new PropertyChangedCallback(PropertyChanged)));
        private static void PropertyChanged(DependencyObject d,DependencyPropertyChangedEventArgs e)
        {
            PasswordBox password = d as PasswordBox;
            password.PasswordChanged -= Password_PasswordChanged;
            if (!_IsUpdating)
            {
                password.Password = e.NewValue?.ToString();
            }
            password.PasswordChanged += Password_PasswordChanged;
        }
        public static string GetPassWord(DependencyObject obj) 
        {
            return obj.GetValue(PassWordProperty).ToString();
        }
        public static void SetPassWord(DependencyObject obj, string val)
        {
            obj.SetValue(PassWordProperty, val);
        }

        public static readonly DependencyProperty PassWordAttach = DependencyProperty.RegisterAttached("Attach", typeof(bool), typeof(PassWordHelper),
           new FrameworkPropertyMetadata(default(bool), new PropertyChangedCallback(Attached)));
        public static bool GetAttach(DependencyObject obj)
        {
            return (bool)obj.GetValue(PassWordAttach);
        }
        public static void SetAttach(DependencyObject obj, string val)
        {
            obj.SetValue(PassWordAttach, val);
        }
        private static void Attached(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PasswordBox password = d as PasswordBox;
            password.PasswordChanged += Password_PasswordChanged;
        }

        private static void Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = sender as PasswordBox;
            _IsUpdating = true;
            SetPassWord(passwordBox, passwordBox.Password);
            _IsUpdating = false;
        }
        static bool _IsUpdating = false;
    }
}
