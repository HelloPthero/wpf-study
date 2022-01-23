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

namespace WPFStudy.View
{
    /// <summary>
    /// HeaderContentControl.xaml 的交互逻辑
    /// </summary>
    public partial class HeaderContentControl : Window
    {
        public HeaderContentControl()
        {
            InitializeComponent();
        }

        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {

        }

        private void Expander_Collapsed(object sender, RoutedEventArgs e)
        {

        }

        private void tabButton_Click(object sender, RoutedEventArgs e)
        {
            TabItem tabItem = tab.SelectedItem as TabItem;   //获取tabItem
            //object tabitem = tab.SelectedContent;    //获取tabItem中的内容
            tabItem.Header = "变变变";

            //切换页签的两种方式
            tab.SelectedItem = tab.Items[1];
            tab.SelectedIndex = 1;
        }
    }
}
