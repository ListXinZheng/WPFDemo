using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WPFAPP.Common;

namespace WPFAPP.ViewModel
{
    public class FirstPageViewModel:NotifyBase
    {
		private int _instrumentvalue;

		public int InstrumentValue
		{
			get { return _instrumentvalue; }
			set
			{
				_instrumentvalue = value;
				this.RaisePropertyChanged("InstrumentValue");
			}
		}
		private int _maxhigh;

		public int MaxHigh
		{
			get { return _maxhigh; }
			set
			{
				_maxhigh = value;
				this.RaisePropertyChanged("MaxHigh");
			}
		}

		public FirstPageViewModel()
        {
            this.Refreshinstucmentvalue();
        }
		private Random random = new Random();
        private void Refreshinstucmentvalue()
		{
			Task.Factory.StartNew(() =>
			{
				while (true)
				{
					InstrumentValue = random.Next(10, 40);
					if (MaxHigh< InstrumentValue)
					{
                        MaxHigh = InstrumentValue;

                    }
					Thread.Sleep(1500);
				}
			});
		}
	}
}
