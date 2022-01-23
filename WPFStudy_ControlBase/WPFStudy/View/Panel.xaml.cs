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
    /// Panel.xaml 的交互逻辑
    /// </summary>
    public partial class Panel : Window
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //在流面板中增加item
            //for(var i = 4; i <= 50; i++)
            //{
            //    Button btn = new Button();
            //    btn.Content = "按钮" + i;
            //    btn.Background = new SolidColorBrush(Colors.AliceBlue);
            //    btn.Margin = new Thickness(5, 5, 0, 0);

            //    warpPanel.Children.Add(btn);
            //}
        }
    }
}
