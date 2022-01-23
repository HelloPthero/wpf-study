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
    /// BarView.xaml 的交互逻辑
    /// </summary>
    public partial class BarView : Window
    {
        public BarView()
        {
            InitializeComponent();
        }

        private void SetLabelColorByRadioButton(object sender,RoutedEventArgs e)
        {
            //通过引用资源触发方法时  sender 无法获取到当前对象  要通过e.Source
            RadioButton rb = e.Source as RadioButton;
            Rectangle rec = rb.Content as Rectangle;
            lbl.Background = rec.Fill;
        }


        //comboboxItem 需要通过隧道事件触发 PreviewMouseLeftButtonUp
        private void cbItem_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            lbl.Content = "修改后的文本";
        }
    }
}
