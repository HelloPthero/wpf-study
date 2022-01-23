using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace WPFStudy.ViewModel
{
    public class MainViewModel:INotifyPropertyChanged
    {
        //发布的委托
        public event PropertyChangedEventHandler PropertyChanged;
        //MainWindow _mainWindow;
        //public MainViewModel(MainWindow window)
        //{
        //    this._mainWindow = window;
        //}

        //右侧list
        private List<string> _itemList; 

        public List<string> ItemList
        {
            get 
            { 
                _itemList = new List<string> { "123", "234", "345", "456" };
                return _itemList; 
            }
            set { _itemList = value; }
        }



        //用户名
        private string _name;

        public string Name 
        {
            get { return _name; }
            set { 
                _name = value;
                
            }
        }
        //密码
        private string _password; 

        public string Password
        {
            get { return _password; }
            set 
            { 
                _password = value;
                
            }
        }



        //按钮绑定
        private ICommand _buttonCommad;

        public ICommand ButtonCommand 
        {
            get {
                if (_buttonCommad == null)
                {
                    _buttonCommad = new CommandBase() {
                        DoAction = new Action<object>(doSomeThing),
                        DoCanExecute = new Func<object, bool>(canDoSomeThing)
                    };            
                }
                return _buttonCommad;
            }
            set { _buttonCommad = value; }
        }
        private void doSomeThing(object obj)
        {

            
            //如果事件做完需要重新判断方法是否可执行 
            //需要执行BaseCommand 中的CanExecuteChanged  其包装在ReJudge方法中
            (this.ButtonCommand as CommandBase).ReJudgeCanExecute(); 
        }

        private bool canDoSomeThing(object obj)
        {
            return true;
        }

    }
}
