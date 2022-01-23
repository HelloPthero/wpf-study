using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using WPFStudy.Model;

namespace WPFStudy.View
{
    /// <summary>
    /// ListView.xaml 的交互逻辑
    /// </summary>
    public partial class ListView : Window
    {
        public ListView()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<MoviesModel> list = GetTestList();
            listView.ItemsSource = list;


            ////DataGrid
            //dataGrid.ItemsSource = GetTestList();
            ////comboBox 取法
            ////1  x:Name
            ////countryComboBox.ItemsSource = GetComboBoxTestList();
            ////2
            //DataGridComboBoxColumn countryComboBox2 =   dataGrid.Columns[3] as DataGridComboBoxColumn;
            //countryComboBox2.ItemsSource = GetComboBoxTestList();


            //通过viewModel绑定 
            ViewModel vm = new ViewModel();
            vm.DataList = GetTestList();
            vm.ComboBoxList = GetComboBoxTestList();
            this.DataContext = vm;



        }

        public class ViewModel 
        { 
            public List<MoviesModel> DataList { get; set; }

            public List<ComboBoxModel> ComboBoxList { get; set; } 
        }



        #region  测试数据
        /// <summary>
        /// 测试的数据源
        /// </summary>
        /// <returns></returns>
        private List<MoviesModel> GetTestList() 
        {
            var list = new List<MoviesModel>();
            var item1 = new MoviesModel
            {
                Name = "搏击俱乐部",
                Id = 1,
                PublishTime = Convert.ToDateTime("2021-01-01"),
                IsWatched = true,
                CountryId = 2
            };
            var item2 = new MoviesModel
            {
                Name = "教父",
                Id = 2,
                PublishTime = Convert.ToDateTime("1997-01-01"),
                IsWatched = true,
                CountryId = 2
            };
            var item3 = new MoviesModel
            {
                Name = "死亡诗社",
                Id = 3,
                PublishTime = Convert.ToDateTime("2018-02-01"),
                IsWatched = true,
                CountryId = 2
            };
            var item4 = new MoviesModel
            {
                Name = "星际穿越",
                Id = 4,
                PublishTime = Convert.ToDateTime("2018-02-01"),
                IsWatched = false,
                CountryId = 2
            };

            list.Add(item1);
            list.Add(item2);
            list.Add(item3);
            list.Add(item4);
            return list;
        }


        public List<ComboBoxModel> GetComboBoxTestList()
        {
            var result = new List<ComboBoxModel>();
            var item1 = new ComboBoxModel
            {
                Id = 1,
                Country = "美国"
            };
            var item2 = new ComboBoxModel
            { 
                Id = 2,
                Country = "法国"
            };
            var item3 = new ComboBoxModel
            {
                Id = 3,
                Country = "中国"
            };
            result.Add(item1);
            result.Add(item2);
            result.Add(item3);

            return result;

        }


        //private List<MoviesModel> GetListBySql()
        //{
        //    List<MoviesModel> list = new List<MoviesModel>();
        //    string sql = "select * from t_movies";
        //    SqlDataReader dr = SqlHelper.ExecuteReader(sql, 1);
        //    while (dr.Read())
        //    {
        //        MoviesModel item = new MoviesModel();
        //        item.Id = (int)dr["Id"];
        //        item.Name = dr["Name"].ToString();
        //        item.Director = dr["Director"].ToString();
        //        item.PublishTime = Convert.ToDateTime(dr["PublichTime"].ToString());
        //        list.Add(item);
        //    }
        //    dr.Close();
        //    return list;
        //}

        #endregion
    }
}
