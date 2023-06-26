using LiveCharts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAPP.Model
{
    public class ProductInfoModel
    {
        public string ProductName { get; set; }
        public SeriesCollection Seriescollect { get; set; }
        public ObservableCollection<SeriesModel> SeriesList { get; set; }
    }
}
