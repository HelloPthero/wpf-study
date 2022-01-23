using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPFTestProject.Common
{
    //密码附加的依赖属性
    public class PasswordHelper
    {
        /*
         * 设定了两个依赖属性 PasswordProperty   AttachProperty
         * 
         * AttachProperty 绑定的是View密码框中的值（不准确）  主要是为了密码框的PasswordChanged事件
         *  View中密码框内容发生变化时 触发 Password_PasswordChanged 将值付给PasswordProperty 间接赋给了ViewModel中的Password
         * 
         * * PasswordProperty 绑定的是ViewModel中的值 
         *  ViewModel中的Password值变化时 触发OnPropertyChanged 直接将获取到的值赋给密码框
         *  同时,在从后台给前台赋值的时候,关闭前台值变化的触发条件,防止前台又去改变后台
         *  
         *  
         *  上面的是我第一次学依赖附加属性的时候瞎jb写的  完全不对
         *  
         *  PasswordProperty绑定密码框的Password 通过Bingding
         *  helper中的password改变时，触发事件，获取passwordbox 给box.password赋值
         *  并且添加box.password的change事件
         *  box.password的值改变时，触发change事件，change事件再去改变helper.password
         *  实现了helper.password和box.password的绑定
         *  但是 刚开始如果不在view中对box.password进行赋值，是进不到helper.password的事件的 就不能给box加change事件了
         *  box.password已经用来binding了，所以上面没法做
         *  通过AttachProperty依赖附加属性,view中写一个固定值，直接给box增加change事件
         *  这样就能在刚开始box.password也能传到help.password了
         *
         */



        #region 定义密码的依赖属性
        //定义一个依赖属性 这个是和v
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.RegisterAttached("Password", typeof(string), typeof(PasswordHelper),
                new FrameworkPropertyMetadata("", new PropertyChangedCallback(OnPropertyChanged)));

        public static string GetPassword(DependencyObject d)
        {
            return d.GetValue(PasswordProperty).ToString();
        }

        public static void SetPassword(DependencyObject d,string value)
        {
            d.SetValue(PasswordProperty, value);
        }



        private static void OnPropertyChanged(DependencyObject d,DependencyPropertyChangedEventArgs e)
        {
            //ViewModel中密码值变化时通知页面密码框

            PasswordBox password = d as PasswordBox;
            //在这个地方完成了model到view的传值 
            //但view到model无法绑定
            password.PasswordChanged -= Password_PasswordChanged;
            if (!isUpdating)
                password.Password = e.NewValue?.ToString();
            //目前获得了password控件  给控件增加监听事件  view改变时触发
            password.PasswordChanged += Password_PasswordChanged;
        }

        #endregion


        #region 定义通用的依赖属性 Attach与Password绑定

        static bool isUpdating = false;

        public static readonly DependencyProperty AttachProperty = 
            DependencyProperty.RegisterAttached("Attach", typeof(bool), typeof(PasswordHelper),
                new FrameworkPropertyMetadata(default(bool), new PropertyChangedCallback(OnAttached)));

        public static bool GetAttach(DependencyObject d)
        {
            return (bool)d.GetValue(AttachProperty); 
        }

        public static void SetAttach(DependencyObject d, bool value)
        {
            d.SetValue(AttachProperty, value);
        }

        private static void OnAttached(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            
            PasswordBox password = d as PasswordBox;
            password.PasswordChanged += Password_PasswordChanged;
        }

        private static void Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordBox password = sender as PasswordBox;
            isUpdating = true;
            SetPassword(password, password.Password);
            isUpdating = false; 
        }
        #endregion
    }
}
