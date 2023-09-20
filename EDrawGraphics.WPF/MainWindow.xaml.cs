using EDrawGraphics.WPF.ViewModels;
using System;
using System.Windows;
using System.Windows.Threading;

namespace EDrawGraphics.WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(this);
        }

        private void mainWindow_Activated(object sender, EventArgs e)
        {
            Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, new Action(() => WindowStyle = WindowStyle.None));
        }
    }
}
