using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFTestProject.Controls
{
    /// <summary>
    /// Instrument.xaml 的交互逻辑
    /// </summary>
    public partial class Instrument : UserControl
    {
        //依赖属性   在依赖对象中使用
        public double Value
        {
            get { return (double)this.GetValue(ValueProperty); }
            set { this.SetValue(ValueProperty, value); }
        }

        public static readonly DependencyProperty ValueProperty =
                DependencyProperty.Register("Value", typeof(double), typeof(Instrument),
                    new PropertyMetadata(double.NaN, new PropertyChangedCallback(OnPropertyChanged)));



        public int MinNum
        {
            get { return (int)GetValue(MinNumProperty); }
            set { SetValue(MinNumProperty, value); }
        }

        public static readonly DependencyProperty MinNumProperty =
            DependencyProperty.Register("MinNum", typeof(int), typeof(Instrument),
                new PropertyMetadata(default(int), new PropertyChangedCallback(OnPropertyChanged)));



        public int MaxNum
        {
            get { return (int)GetValue(MaxNumProperty); }
            set { SetValue(MaxNumProperty, value); }
        }

        public static readonly DependencyProperty MaxNumProperty =
            DependencyProperty.Register("MaxNum", typeof(int), typeof(Instrument),
                new PropertyMetadata(default(int), new PropertyChangedCallback(OnPropertyChanged)));



        //间隔
        public int Interval
        {
            get { return (int)GetValue(IntervalProperty); }
            set { SetValue(IntervalProperty, value); }
        }

        public static readonly DependencyProperty IntervalProperty =
            DependencyProperty.Register("Interval", typeof(int), typeof(Instrument),
                new PropertyMetadata(default(int), new PropertyChangedCallback(OnPropertyChanged)));



        public static void OnPropertyChanged(DependencyObject d,DependencyPropertyChangedEventArgs s)
        {
            (d as Instrument).Refresh();
        }

        public Instrument()
        {
            
             
            InitializeComponent();
            this.SizeChanged += Instrument_SizeChanged;
        }

        private void Instrument_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var minSize = Math.Min(this.RenderSize.Width, this.RenderSize.Height);
            this.chart.Height = minSize;
            this.chart.Width = minSize;
        }

        //重绘
        private void Refresh()
        {
            if (double.IsNaN(this.chart.Width))
            {
                return;
            }
            //画刻度
            double radius = this.chart.Width / 2;
            this.mainCanvas.Children.Clear();
            //double min = 0, max = 100;
            //double scaleAreaCount = 10;
            double step = 270.0 / (this.MaxNum - this.MinNum);
            for(var i = 0; i <= this.MaxNum - this.MinNum; i++)
            {
                //弧度计算 
                Line lineScale = new Line();
                double stpoint = radius - 13;
                if (i % this.Interval == 0)
                    stpoint = radius - 22;
                lineScale.X1 = radius - stpoint * Math.Cos((i*step-45)*Math.PI/180);
                lineScale.Y1 = radius - stpoint * Math.Sin((i * step - 45) * Math.PI / 180);
                lineScale.X2 = radius - (radius-8)*Math.Cos((i * step - 45) * Math.PI/180);
                lineScale.Y2 = radius - (radius-8) * Math.Sin((i * step - 45) * Math.PI / 180);
                lineScale.Stroke = Brushes.White;
                lineScale.StrokeThickness = 1;


                this.mainCanvas.Children.Add(lineScale);

                if(i%this.Interval == 0)
                {
                    stpoint = radius - 36;
                    TextBlock textScale = new TextBlock();
                    textScale.Text = (this.MinNum+i).ToString();
                    textScale.Foreground = Brushes.White;
                    Canvas.SetLeft(textScale, radius - stpoint * Math.Cos((i * step - 45) * Math.PI / 180)-8.0);
                    Canvas.SetTop(textScale, radius - stpoint * Math.Sin((i * step - 45) * Math.PI / 180) - 10.0);
                    this.mainCanvas.Children.Add(textScale);
                }
                
            }

            //画内部圆弧
            string sData = "M{0} {1} A{0} {0} 0 1 1 {2} {3}";
            sData = string.Format(sData, radius / 2, radius, radius, radius * 1.5);
            var canverter = TypeDescriptor.GetConverter(typeof(Geometry));
            this.circle.Data = (Geometry)canverter.ConvertFrom(sData);


            //画指针
            sData = "M{0} {1},{1} {2},{1} {3}";
            sData = string.Format(sData, radius * 0.3, radius, radius-5, radius+5);
           
            this.point.Data = (Geometry)canverter.ConvertFrom(sData);

             //this.rtPoint.Angle =  this.Value * step - 45;
            //指针缓慢移动的动画
            DoubleAnimation da = new DoubleAnimation((this.Value-this.MinNum) * step - 45, new Duration(TimeSpan.FromMilliseconds(800)));
            this.rtPoint.BeginAnimation(RotateTransform.AngleProperty, da);
        }
    }
}
