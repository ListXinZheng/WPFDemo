using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFAPP.Common;

namespace WPFAPP.Model
{
    public class LoginModel:NotifyBase
    {
        public LoginModel()
        {
                
        }
		private string username;

		public string UserName
		{
			get { return username; }
			set
			{
				username = value;
				this.RaisePropertyChanged("UserName");
			}
		}
		private string password;

		public string PassWord
		{
			get { return password; }
			set
			{
				password = value;
				this.RaisePropertyChanged("PassWord");
			}
		}
		private string validationcode;

		public string ValidationCode
		{
			get { return validationcode; }
			set
			{
				validationcode = value;
				this.RaisePropertyChanged("ValidationCode");
			}
		}

	}
}
