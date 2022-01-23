﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPFTestProject.View;

namespace WPFTestProject
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            if(new LoginView().ShowDialog() == true)
            {
                new MainView().ShowDialog();
            }
            if(new MainView().ShowDialog() == true)
            {
                new MusicView().ShowDialog();
            }
            Application.Current.Shutdown();
        }
    }
}