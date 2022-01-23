using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WPFTestProject.Common;
using WPFTestProject.DataAccess;
using WPFTestProject.Model;

namespace WPFTestProject.ViewModel
{
    public class LoginViewModel:BaseNotify
    {
        //关闭窗口控制
        public BaseCommand CloseWindowCommand { get; set; }

        //登录控制
        public BaseCommand LoginCommand { get; set; }

        //进度条

        private Visibility _showProgress;

        public Visibility ShowProgress 
        {
            get { return _showProgress; }
            set { _showProgress = value; this.DoNotify(); }
        }


        public LoginModel LoginModel { get; set; }

        private String _errorMessage;

        public String ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; this.DoNotify(); }
        }


        public LoginViewModel()
        {
            this.ShowProgress = Visibility.Hidden;

            this.CloseWindowCommand = new BaseCommand();
            this.CloseWindowCommand.DoExecute = new Action<object>((o)=> {
                //执行关闭
                (o as Window).Close();
            
            });
            this.CloseWindowCommand.DoCanExecute = new Func<object, bool>((o) =>
            {
                //判断关闭按钮是否可以使用
                return true;
            });


            this.LoginModel = new LoginModel();
            //this.LoginModel.Password;

            this.LoginCommand = new BaseCommand();
            this.LoginCommand.DoExecute = new Action<object>(DoLogin);
            this.LoginCommand.DoCanExecute = new Func<object, bool>(DoCanLogin);
        }
        

        public void DoLogin(object obj)
        {
            this.ShowProgress = Visibility.Visible;
            if (string.IsNullOrEmpty(LoginModel.UserName))
            {
                this.ErrorMessage = "请输入用户名";
                this.ShowProgress = Visibility.Hidden;
                return;
            }
            if (string.IsNullOrEmpty(LoginModel.Password))
            {
                this.ErrorMessage = "请输入密码";
                this.ShowProgress = Visibility.Hidden;
                return;
            }
            if (string.IsNullOrEmpty(LoginModel.ValidationCode))
            {
                this.ErrorMessage = "请输入验证码";
                this.ShowProgress = Visibility.Hidden;
                return;
            }
            if (LoginModel.ValidationCode.ToLower() != "yzm")
            {
                this.ErrorMessage = "验证码错误";
                this.ShowProgress = Visibility.Hidden;
                return;
            }


            //如果非本地数据库 获取数据会慢 所以要用个线程

            Task.Run(new Action(async() =>
            {
                await Task.Delay(2000);
                try
                {
                    var user = LocalDataAccess.GetInstance().CheckUserInfo(LoginModel.UserName, LoginModel.Password);

                    if (user == null)
                    {
                        throw new Exception("登录失败,用户名或密码错误");
                    }

                    //存入到全局变量中
                    GlobalValues.Userinfo = user;

                    Application.Current.Dispatcher.Invoke(new Action(() =>
                    {
                        (obj as Window).DialogResult = true;

                    }));

                    
                }
                catch (Exception ex)
                {
                    this.ErrorMessage = ex.Message;
                    this.ShowProgress = Visibility.Hidden;
                }



            }));

            
            
            
        }
        public bool DoCanLogin(object obj)
        {
            return true;
        }


        

    }
}
