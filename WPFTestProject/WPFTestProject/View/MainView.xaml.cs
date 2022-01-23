using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFTestProject.Common;
using WPFTestProject.ViewModel;

namespace WPFTestProject
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainView : Window
    {
        public MainView() 
        {
            InitializeComponent();
            //防止窗口最大化时挡住任务栏
            this.MaxHeight = SystemParameters.PrimaryScreenHeight;

            MainViewModel model = new MainViewModel();
            this.DataContext = model;
            

        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //窗口拖动
            if (e.LeftButton == MouseButtonState.Pressed) this.DragMove();
        }

        private void winBtnMin(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void winBtnMax(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
        }

        private void winBtnClose(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void winBtnMusic(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
