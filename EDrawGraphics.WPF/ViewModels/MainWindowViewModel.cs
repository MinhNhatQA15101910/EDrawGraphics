using EDrawGraphics.WPF.Commands;
using EDrawGraphics.WPF.Models;
using System.Windows;
using System.Windows.Input;

namespace EDrawGraphics.WPF.ViewModels
{
    public class MainWindowViewModel : ObservableObject
    {
        private readonly MainWindow _window;

        public MainWindowViewModel(MainWindow window)
        {
            _window = window;

            _window.border.DataContext = new WindowButtonsViewModel(_window);
        }

        public ICommand MoveWindowCommand => new MoveWindowCommand(_window);

    }
}
