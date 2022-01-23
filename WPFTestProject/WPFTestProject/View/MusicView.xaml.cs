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
using System.Windows.Shapes;
using WPFTestProject.ViewModel;

namespace WPFTestProject.View
{
    /// <summary>
    /// MusicView.xaml 的交互逻辑
    /// </summary>
    public partial class MusicView : Window
    {
        public MusicView()
        {
            InitializeComponent();

            this.DataContext = new MusicViewModel();
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
            if(this.WindowState==WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else
            this.WindowState = WindowState.Maximized;
        }

        private void winBtnClose(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
