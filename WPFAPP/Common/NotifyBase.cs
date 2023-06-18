using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPFAPP.Common
{
    public class NotifyBase : INotifyPropertyChanged
    {
        public NotifyBase()
        {
                
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        /// <summary>
        /// 通知变化
        /// </summary>
        /// <param name="propertyname"></param>
        public void RaisePropertyChanged([CallerMemberName]string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
