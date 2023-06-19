using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFAPP.Common;

namespace WPFAPP.Model
{
    public class UserModel:NotifyBase
    {
		private string _username;

		public string UserName
		{
			get { return _username; }
			set
			{
				_username = value;
				this.RaisePropertyChanged("UserName");
			}
		}
		private int _gender;

		public int Gender
		{
			get { return _gender; }
			set
			{
				_gender = value;
				this.RaisePropertyChanged("Gender");
			}
		}
		private int _userLevel;

		public int Level
		{
			get { return _userLevel; }
			set
			{
                _userLevel = value;
				this.RaisePropertyChanged("Level");
			}
		}
		private string _avatar;

		public string Avatar
		{
			get { return _avatar; }
			set
			{
				_avatar = value;
				this.RaisePropertyChanged("Avatar");
			}
		}
		private string _readname;

		public string RealName
		{
			get { return _readname; }
			set
			{
				_readname = value;
				this.RaisePropertyChanged("RealName");
			}
		}

	}
}
