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
using WPFStudy.ViewModel;

namespace WPFStudy
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        //MainViewModel mainViewModel = null;
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ___无名称__Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //MessageBox.Show();

        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButton get = sender as RadioButton;
            MessageBox.Show(get.Content.ToString());
        }
    }
}
