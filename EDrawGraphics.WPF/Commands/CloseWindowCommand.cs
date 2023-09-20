using System;
using System.Windows;
using System.Windows.Input;

namespace EDrawGraphics.WPF.Commands
{
    public class CloseWindowCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private readonly Window _window;

        public CloseWindowCommand(Window window)
        {
            _window = window;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _window.Close();
        }
    }
}