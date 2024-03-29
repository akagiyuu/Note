﻿using System;
using Microsoft.UI.Xaml;
using Note.Utilities;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Note
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : Application
    {
        private MainWindow _main;

        public string[] Arguments { get; set; }

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            // Force to use dark theme, replaced by user config later
            RequestedTheme = ApplicationTheme.Dark;
            InitializeComponent();
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            Arguments = Environment.GetCommandLineArgs();
            _main = new MainWindow();
            _main.Activate();
            MainWindow.Current = _main;
            Setting.LoadUserConfig();
        }
    }
}