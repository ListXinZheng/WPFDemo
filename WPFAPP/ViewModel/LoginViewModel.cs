using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFAPP.Common;

namespace WPFAPP.Model
{
    public class LoginViewModel:NotifyBase
    {
        public LoginViewModel()
        {
            this.CLoseLoginWindowCommand = new CommandBase();
            this.CLoseLoginWindowCommand.DoExcute = new Action<object>((o) => { (o as Window).Close(); });
            this.CLoseLoginWindowCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });
            LoginDataModel = new LoginModel ();
            LoginDataModel.UserName = "Administor";
            LoginDataModel.PassWord = "0000";
            LoginCommand = new CommandBase();
            LoginCommand.DoExcute = new Action<object>(Loginfun);
            LoginCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });
        }

        private void Loginfun(object obj)
        {
            if (string.IsNullOrEmpty(LoginDataModel.UserName))
            {
                ErrorMessage = "用户名不能为空";
                return;
            }
            if (string.IsNullOrEmpty(LoginDataModel.PassWord))
            {
                ErrorMessage = "密码不能为空";
                return;
            }
            if (string.IsNullOrEmpty(LoginDataModel.ValidationCode))
            {
                ErrorMessage = "验证码不能为空";
                return;
            }
            if (LoginDataModel.ValidationCode.ToLower() != "1314")
            {
                ErrorMessage = "验证码错误";
                return;
            }
            if (true)
            {
                //进行数据库访问和验证
            }
            GlobalValues.Userinfo.UserName = LoginDataModel.UserName;
            GlobalValues.Userinfo.userLevel = 0;
            GlobalValues.Userinfo.Password = LoginDataModel.PassWord;
            GlobalValues.Userinfo.RealName = "lihang";
            GlobalValues.Userinfo.Gender = 0;
            GlobalValues.Userinfo.Avatar = "../Assets/Imag/Ultra.png";
            Application.Current.Dispatcher.Invoke(() => { (obj as Window).DialogResult = true; });
        }
        private string _errmesg;

        public string ErrorMessage
        {
            get { return _errmesg; }
            set
            {
                _errmesg = value;
                this.RaisePropertyChanged("ErrorMessage");
            }
        }

        public CommandBase CLoseLoginWindowCommand { get; set; }
        public LoginModel LoginDataModel  { get; set; }
        public CommandBase LoginCommand { get; set; }
    }
}
