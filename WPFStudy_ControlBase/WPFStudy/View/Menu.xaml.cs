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
    /// Menu.xaml 的交互逻辑
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void linkContralIntraView_Click(object sender, RoutedEventArgs e)
        {
            contralIntra win = new contralIntra();
            win.Show();
        }

        private void linkPanelView_Click(object sender, RoutedEventArgs e)
        {
            Panel win = new Panel();
            win.Show();
        }

        private void linkListView_Click(object sender, RoutedEventArgs e)
        {
            ListView win = new ListView();
            win.Show();
        }


        //左键打开contextmenu
        private void lbl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lblMenu.PlacementTarget = lbl;
            lblMenu.IsOpen = true;
        }

        /// <summary>
        /// TreeView  点击节点的显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeViewItem val = e.NewValue as TreeViewItem;
            MessageBox.Show(val.Header.ToString());
        }
    }
}
