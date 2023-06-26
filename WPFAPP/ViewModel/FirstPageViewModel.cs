using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WPFAPP.Common;
using WPFAPP.DataAcess;
using WPFAPP.Model;

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
        public ObservableCollection<ProductInfoModel> SeriesInfoList { get; set; } = new ObservableCollection<ProductInfoModel>();
        public FirstPageViewModel()
        {
            this.Refreshinstucmentvalue();
			InitProductInfoData();
        }
		private void InitProductInfoData()
		{
			SeriesInfoList.Add(
				new ProductInfoModel
				{
					ProductName = "运动控制卡-16轴",
					Seriescollect = new LiveCharts.SeriesCollection() 
					{ 
						new PieSeries()
						{
						Title="朝阳光",
						Values = new ChartValues<ObservableValue>() { new ObservableValue(25)} ,
						DataLabels = false
						}
						 ,
						new PieSeries()
						{
						Title = "欣旺达",
						Values = new ChartValues<ObservableValue>() { new ObservableValue(9) },
						DataLabels = false
						}
						,
                        new PieSeries()
                        {
                        Title = "瑞领",
                        Values = new ChartValues<ObservableValue>() { new ObservableValue(13) },
                        DataLabels = false
                        }
                    },
					SeriesList= new ObservableCollection<SeriesModel>()
					{
						new SeriesModel()
						{
							SeriesName = "朝阳光",
							CurrentValue = 25,
							IsGrowing= false,
							ChangeRate=60,	
						}
						,
                        new SeriesModel()
                        {
                            SeriesName = "瑞领",
                            CurrentValue = 13,
                            IsGrowing= false,
                            ChangeRate=40,
                        }
						,
                        new SeriesModel()
                        {
                            SeriesName = "海胜",
                            CurrentValue = 16,
                            IsGrowing= true,
                            ChangeRate=50,
                        }
						,
                        new SeriesModel()
                        {
                            SeriesName = "欣旺达",
                            CurrentValue = 26,
                            IsGrowing= false,
                            ChangeRate=40,
                        }
						,
                        new SeriesModel()
                        {
                            SeriesName = "卓迈",
                            CurrentValue = 86,
                            IsGrowing= true,
                            ChangeRate=80,
                        }
                    }	

				}
			);
            SeriesInfoList.Add(
                new ProductInfoModel
                {
                    ProductName = "运动控制卡-8轴",
                    Seriescollect = new LiveCharts.SeriesCollection()
                    {
                        new PieSeries()
                        {
                        Title="安德瑞",
                        Values = new ChartValues<ObservableValue>() { new ObservableValue(30)} ,
                        DataLabels = false
                        }
                         ,
                        new PieSeries()
                        {
                        Title = "同硕鑫",
                        Values = new ChartValues<ObservableValue>() { new ObservableValue(5) },
                        DataLabels = false
                        }
                        ,
                        new PieSeries()
                        {
                        Title = "日研",
                        Values = new ChartValues<ObservableValue>() { new ObservableValue(18) },
                        DataLabels = false
                        }
                    },
                    SeriesList = new ObservableCollection<SeriesModel>()
                    {
                        new SeriesModel()
                        {
                            SeriesName = "朝阳光",
                            CurrentValue = 25,
                            IsGrowing= false,
                            ChangeRate=60,
                        }
                        ,
                        new SeriesModel()
                        {
                            SeriesName = "瑞领",
                            CurrentValue = 13,
                            IsGrowing= false,
                            ChangeRate=40,
                        }
                        ,
                        new SeriesModel()
                        {
                            SeriesName = "海胜",
                            CurrentValue = 16,
                            IsGrowing= true,
                            ChangeRate=50,
                        }
                        ,
                        new SeriesModel()
                        {
                            SeriesName = "欣旺达",
                            CurrentValue = 26,
                            IsGrowing= false,
                            ChangeRate=40,
                        }
                        ,
                        new SeriesModel()
                        {
                            SeriesName = "卓迈",
                            CurrentValue = 86,
                            IsGrowing= true,
                            ChangeRate=80,
                        }
                    }

                }
            );
            SeriesInfoList.Add(
                new ProductInfoModel
                {
                    ProductName = "运动控制卡-5轴",
                    Seriescollect = new LiveCharts.SeriesCollection()
                    {
                        new PieSeries()
                        {
                        Title="正浩",
                        Values = new ChartValues<ObservableValue>() { new ObservableValue(9)} ,
                        DataLabels = false
                        }
                         ,
                        new PieSeries()
                        {
                        Title = "海名声",
                        Values = new ChartValues<ObservableValue>() { new ObservableValue(25) },
                        DataLabels = false
                        }
                        ,
                        new PieSeries()
                        {
                        Title = "鑫伦",
                        Values = new ChartValues<ObservableValue>() { new ObservableValue(6) },
                        DataLabels = false
                        }
                    },
                    SeriesList = new ObservableCollection<SeriesModel>()
                    {
                        new SeriesModel()
                        {
                            SeriesName = "朝阳光",
                            CurrentValue = 25,
                            IsGrowing= false,
                            ChangeRate=60,
                        }
                        ,
                        new SeriesModel()
                        {
                            SeriesName = "瑞领",
                            CurrentValue = 13,
                            IsGrowing= false,
                            ChangeRate=40,
                        }
                        ,
                        new SeriesModel()
                        {
                            SeriesName = "海胜",
                            CurrentValue = 16,
                            IsGrowing= true,
                            ChangeRate=50,
                        }
                        ,
                        new SeriesModel()
                        {
                            SeriesName = "欣旺达",
                            CurrentValue = 26,
                            IsGrowing= false,
                            ChangeRate=40,
                        }
                        ,
                        new SeriesModel()
                        {
                            SeriesName = "卓迈",
                            CurrentValue = 86,
                            IsGrowing= true,
                            ChangeRate=80,
                        }
                    }

                }
            );

           
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
