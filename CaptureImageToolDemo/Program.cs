﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CaptureImageToolDemo
{
    static class Program
    {//|5|1|a|s|p||x|
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormCSharpWinDemo());
        }
    }
}