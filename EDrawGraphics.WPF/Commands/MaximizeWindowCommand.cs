using System;
using System.Windows;
using System.Windows.Input;

namespace EDrawGraphics.WPF.Commands
{
    public class MaximizeWindowCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private readonly Window _window;

        public MaximizeWindowCommand(Window window)
        {
            _window = window;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (_window.WindowState == WindowState.Maximized)
            {
                _window.WindowState = WindowState.Normal;
            }
            else
            {
                _window.WindowState = WindowState.Maximized;
            }
        }
    }
}