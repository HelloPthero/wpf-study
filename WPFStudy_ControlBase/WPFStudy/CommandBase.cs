using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFStudy
{
    public class CommandBase : ICommand 
    {
        public event EventHandler CanExecuteChanged;

        //委托 用于存储要执行的方法
        public Action<object> DoAction{ get;set; }

        //委托 用于存储(判断方法是否可执行)的方法
        public Func<object,bool> DoCanExecute { get; set; }

        public bool CanExecute(object parameter)
        {
            return DoCanExecute?.Invoke(parameter) == true ;
        }

        public void Execute(object parameter)
        {
            DoAction?.Invoke(parameter);
        }


        //方法 用于在数据等的变化后重新判断方法是否可执行 会出发CanExecute()方法
        public void ReJudgeCanExecute()  
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        
        }

    }
}
