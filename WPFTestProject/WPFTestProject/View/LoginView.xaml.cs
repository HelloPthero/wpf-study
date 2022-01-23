using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFTestProject.ViewModel;

namespace WPFTestProject.View
{
    /// <summary>
    /// LoginView.xaml 的交互逻辑
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
            this.DataContext = new LoginViewModel();
        }

        private void WinMove_LeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //窗口拖动
            if (e.LeftButton == MouseButtonState.Pressed) this.DragMove();
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

        private void txtUserName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
