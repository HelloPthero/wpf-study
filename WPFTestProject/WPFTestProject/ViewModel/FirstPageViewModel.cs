using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTestProject.Common;
using WPFTestProject.Model;

namespace WPFTestProject.ViewModel
{
    public class FirstPageViewModel : BaseNotify
    {
        //仪表盘的值
        private int _instrumentValue;

        public int InstrumentValue
        {
            get { return _instrumentValue; }
            set { _instrumentValue = value; this.DoNotify(); }
        }


        //列表的值

        public ObservableCollection<CourseSeriesModel> CourseSeriesList { get; set; } = new ObservableCollection<CourseSeriesModel>();

        public FirstPageViewModel()
        {
            this.RefreshInstrument();
            this.InitCourseSeries();
        }

        private void InitCourseSeries()
        {
            CourseSeriesList.Add(
                new CourseSeriesModel
                {
                    CourseName = "WPF太难了呀",
                    SeriesCollection=new LiveCharts.SeriesCollection 
                    { 
                        new PieSeries
                        {
                            Title="第1项",
                            Values=new ChartValues<ObservableValue>{new ObservableValue(123) },
                            DataLabels=false
                        },
                        new PieSeries
                        {
                            Title="第2项",
                            Values=new ChartValues<ObservableValue>{new ObservableValue(166) },
                            DataLabels=false
                        },
                        new PieSeries
                        {
                            Title="第3项",
                            Values=new ChartValues<ObservableValue>{new ObservableValue(216) },
                            DataLabels=false
                        }
                    },
                    SeriesList=new ObservableCollection<SeriesModel>
                    {
                        new SeriesModel{SeriesName="A名",CurrentValue=12,IsGrowing=true,ChangeRate=70},
                        new SeriesModel{SeriesName="B名",CurrentValue=21,IsGrowing=false,ChangeRate=-60},
                        new SeriesModel{SeriesName="C名",CurrentValue=65,IsGrowing=true,ChangeRate=80},
                        new SeriesModel{SeriesName="D名",CurrentValue=23,IsGrowing=false,ChangeRate=-20},
                        new SeriesModel{SeriesName="E名",CurrentValue=67,IsGrowing=true,ChangeRate=70},
                    }
                });
            CourseSeriesList.Add(
                new CourseSeriesModel
                {
                    CourseName = "WPF太难了呀",
                    SeriesCollection = new LiveCharts.SeriesCollection
                    {
                        new PieSeries
                        {
                            Title="第1项",
                            Values=new ChartValues<ObservableValue>{new ObservableValue(123) },
                            DataLabels=false
                        },
                        new PieSeries
                        {
                            Title="第2项",
                            Values=new ChartValues<ObservableValue>{new ObservableValue(166) },
                            DataLabels=false
                        },
                        new PieSeries
                        {
                            Title="第3项",
                            Values=new ChartValues<ObservableValue>{new ObservableValue(216) },
                            DataLabels=false
                        }
                    },
                    SeriesList = new ObservableCollection<SeriesModel>
                    {
                        new SeriesModel{SeriesName="A名",CurrentValue=12,IsGrowing=true,ChangeRate=70},
                        new SeriesModel{SeriesName="B名",CurrentValue=21,IsGrowing=false,ChangeRate=-60},
                        new SeriesModel{SeriesName="C名",CurrentValue=65,IsGrowing=true,ChangeRate=80},
                        new SeriesModel{SeriesName="D名",CurrentValue=23,IsGrowing=false,ChangeRate=-20},
                        new SeriesModel{SeriesName="E名",CurrentValue=67,IsGrowing=true,ChangeRate=70},
                    }
                });
        }

        Random random = new Random();
        bool refreshInstrumentTaskSwitch = true;
        //当前页面所有线程集合
        List<Task> taskList = new List<Task>();
        //刷新仪表盘的值
        private void RefreshInstrument()
        {
            //通过新的线程处理仪表盘数据刷新
            var task = Task.Factory.StartNew(new Action(async() =>
            {
                while (refreshInstrumentTaskSwitch)
                {
                    InstrumentValue = random.Next(Math.Max(this.InstrumentValue - 5,-12),Math.Min(this.InstrumentValue+5,60));
                    await Task.Delay(1000);
                }

            }));
            this.taskList.Add(task);
        }

        public void Dispose()
        {
            try
            {
                this.refreshInstrumentTaskSwitch = false;
                //等待当前页面的所有线程处理完毕 再往下执行
                Task.WaitAll(this.taskList.ToArray());
            }
            catch
            {

            }
        }
    }
}
