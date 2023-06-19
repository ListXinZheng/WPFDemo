using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFAPP.Common;
using WPFAPP.Model;

namespace WPFAPP.ViewModel
{
    public class MainViewModel : NotifyBase
    {
        public MainViewModel()
        {
			NavButtonChangeCommand = new CommandBase();
			UserInfo = new UserModel();

            NavButtonChangeCommand.DoExcute += new Action<object>(NavButtonChanged);
			NavButtonChangeCommand.DoCanExecute += new Func<object, bool>((o) => { return true;});
			NavButtonChanged("HomePage");

        }

        private void NavButtonChanged(object obj)
        {
			Type type = Type.GetType("WPFAPP.View." + obj.ToString());
			ConstructorInfo cti = type.GetConstructor(Type.EmptyTypes);
			this.MainContent = (FrameworkElement)cti.Invoke(null);
		}

        public UserModel UserInfo { get; set; }
		private string _searchtext;

		public string SearchText
		{
			get { return _searchtext; }
			set
			{
				_searchtext = value;
				this.RaisePropertyChanged("SearchText");
			}
		}
		private FrameworkElement  _showmainwindow;

		public FrameworkElement MainContent
		{
			get { return _showmainwindow; }
			set
			{
                _showmainwindow = value;
				this.RaisePropertyChanged("MainContent");
			}
		}
		public CommandBase NavButtonChangeCommand { get; set; }
	}
}
