using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFStudy.Model;

namespace WPFStudy.View
{
    /// <summary>
    /// contralIntra.xaml 的交互逻辑
    /// </summary>
    public partial class contralIntra : Window
    {
        public contralIntra()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //dpDatePicker.Text = dpDatePicker..ToString("yyyy-MM-dd");

            //后台加载Frame中的Page
            //1、
            //frame.Source = new Uri("TestPage.xaml", UriKind.Relative);
            //2、
            TestPage page = new TestPage();
            frame.Navigate(page);

            //Navigate传值
            //string info = "";
            //frame.Navigate(page, info);
           
        }

        #region   控件

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButton get = sender as RadioButton;
            MessageBox.Show(get.Content.ToString());
        }

        private void checkbox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void GetAllCheckBox(object sender, RoutedEventArgs e)
        {
            string checkedName = "";
            foreach( UIElement ch in grid.Children)
            {
                if(ch is CheckBox) 
                {
                    CheckBox cb = ch as CheckBox;
                    if (cb.IsChecked == true)
                    {
                        checkedName += cb.Content.ToString()+"/";
                    }
                }
            }

            MessageBox.Show(checkedName);
        }

        private void AddCheckBox(object sender, RoutedEventArgs e)
        {
            CheckBox newbox = new CheckBox
            {
                Content = "搞钱",
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(120, 170, 0, 0)
            };
            grid.Children.Add(newbox);
            var l = buttonGetCheckedBox.Margin.Left;
            var t= buttonGetCheckedBox.Margin.Top;
            buttonGetCheckedBox.Margin = new Thickness(l, t + 30, 0, 0);

            buttonAddCheckBox.Margin = new Thickness(l, t + 60, 0, 0);
            
        }

        /// <summary>
        /// 改变图像资源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeImage(object sender, RoutedEventArgs e)
        {
            //ImageSource Source
            //ImageSource BitmapSource BitmapImage
            //UriKind.Relative  路径类型 相对路径
            //img.Source = new BitmapImage(new Uri("/asset/images/feng.jpg", UriKind.Relative));

            //绝对路径
            //application/siteoforigin授权
            //siteoforigin授权 需要把资源文件 属性中的[生成操作]改为[内容]
            img.Source = new BitmapImage(new Uri("pack://application:,,,/asset/images/feng.jpg", UriKind.Absolute));

            //始终复制到输出目录  生成操作 内容  使资源生成到bin/debug目录下 才可用
            //img.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory+"/asset/images/feng.jpg", UriKind.Absolute));

        }


        /// <summary>
        /// Combobox增加下拉框子项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddComboboxItem(object sender,RoutedEventArgs e)
        {
            List<MoviesModel> list = getTestList();
            combobox.SelectedValuePath = "Id";
            combobox.DisplayMemberPath = "Name";
            combobox.Items.Clear();


            //指定数据源
            combobox.ItemsSource = list;

            //foreach逐个添加
            //foreach (MoviesModel item in list)
            //    combobox.Items.Add(item);

            //通过双向绑定
            //combobox.DataContext = list;
            //前端  ItemsSource="{Binding}"


            //注意  在使用ItemsSource时  后续不可通过Items.Add()动态添加单个Item  也不可通过Items.RemoveAt()移除

        }


        /// <summary>
        /// ListBox 增加Item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddListBoxItem(object sender, RoutedEventArgs e)
        {
            List<MoviesModel> list = getTestList();
            listBox.DisplayMemberPath = "Name";
            listBox.SelectedValuePath = "Id";
            listBox.Items.Clear();
            listBox.ItemsSource = list;

            //操作同ComboBox

        }


        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        /// <summary>
        /// 日历 获取选中的date集合
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void obCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            //获取选中的多个date
            SelectedDatesCollection dates = obCalendar.SelectedDates;
            DateTime s = dates.First();
            DateTime ed = dates.Last();

            if (Mouse.Captured is CalendarItem)
            {
                //鼠标捕捉事件  
            }
        }

        //加载进度条
        private void loadProgress_Click(object sender, RoutedEventArgs e)
        {
            //常规方法无法加载进度条
            //progressBar.Value = 0;
            //for(int i = 0; i < progressBar.Maximum; i++)
            //{
            //    progressBar.Value = i;
            //    Thread.Sleep(1000);
            //}


            //Dispatcher  线程任务
            //线程任务投放
            progressBar.Value = 0;
            var max = progressBar.Maximum;
            Task.Run(() =>
            {
                for (int i = 0; i < max; i++)
                {
                    progressBar.Dispatcher.Invoke(() => {
                        progressBar.Value = i;
                    });
                    Thread.Sleep(1000);
                }

            });

        }

        //进度条值改变事件
        private void progressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }


        #endregion


        #region  测试数据
        /// <summary>
        /// 测试的数据源
        /// </summary>
        /// <returns></returns>
        private List<MoviesModel> getTestList()
        {
            var list = new List<MoviesModel>();
            var item1 = new MoviesModel
            {
                Name = "搏击俱乐部",
                Id = 1,
            };
            var item2 = new MoviesModel
            {
                Name = "教父",
                Id = 2,
            };
            var item3 = new MoviesModel
            {
                Name = "死亡诗社",
                Id = 3,
            };

            list.Add(item1);
            list.Add(item2);
            list.Add(item3);
            return list;
        }

        #endregion

       
    }
}
