﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnExit(ExitEventArgs e)
        {
            var t = new Dropbox.Api.DropboxAppClient("fsdfsd", "fsdf");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            base.OnExit(e);
        }
    }
}
