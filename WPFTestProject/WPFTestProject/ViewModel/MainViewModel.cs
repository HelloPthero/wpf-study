using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFTestProject.Common;
using WPFTestProject.Model;

namespace WPFTestProject.ViewModel
{
    public class MainViewModel:BaseNotify
    {
        public UserModel UserInfo { get; set; }

        private string _searchText;

        public string SearchText
        {
            get { return _searchText; }
            set { _searchText = value; this.DoNotify(); }
        }

        private FrameworkElement _mainContent;

        public FrameworkElement MainContent 
        {
            get { return _mainContent; }
            set { _mainContent = value; this.DoNotify(); }
        }

        public BaseCommand NavChangeCommand { get; set; }

        public MainViewModel()
        {
            this.NavChangeCommand = new BaseCommand();
            this.NavChangeCommand.DoExecute = new Action<object>(DoNavChanged);
            this.NavChangeCommand.DoCanExecute = new Func<object, bool>(o=>true);

            this.UserInfo = new UserModel(GlobalValues.Userinfo);

            //MainContent初始化为首页
            DoNavChanged("FirstPageView");

        }

        private void DoNavChanged(object obj)
        {
            //通过反射的方式 
            //
            Type type = Type.GetType("WPFTestProject.View."+obj.ToString());

            ConstructorInfo cti = type.GetConstructor(System.Type.EmptyTypes);
            this.MainContent = (FrameworkElement)cti.Invoke(null);
        }

    }
}
