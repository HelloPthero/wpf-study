using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFTestProject.Common
{
    public class BaseCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        //委托 用于执行事件
        public Action<object> DoExecute { get; set; }
        
        public Func<object,bool> DoCanExecute { get; set; } 

        public bool CanExecute(object parameter)
        {
            return DoCanExecute?.Invoke(parameter)==true;
        }

        public void Execute(object parameter)
        {
            DoExecute?.Invoke(parameter);
        }
    }
}
