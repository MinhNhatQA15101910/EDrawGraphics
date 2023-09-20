using EDrawGraphics.WPF.Commands;
using EDrawGraphics.WPF.Models;
using System.Windows;
using System.Windows.Input;

namespace EDrawGraphics.WPF.ViewModels
{
    public class WindowButtonsViewModel : ObservableObject
    {
        private readonly Window _window;

        public WindowButtonsViewModel(Window window)
        {
            _window = window;
        }

        public ICommand MinimizeWindowCommand => new MinimizeWindowCommand(_window);
        public ICommand MaximizeWindowCommand => new MaximizeWindowCommand(_window);
        public ICommand CloseWindowCommand => new CloseWindowCommand(_window);

    }
}
