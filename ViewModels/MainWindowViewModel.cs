using Prism.Commands;
using Prism.Mvvm;
using System;

namespace ParceDataWpf.ViewModels
{
    /// <summary>
    /// Entery point to programm.
    /// </summary>
    public class MainWindowViewModel : BindableBase
    {
        private string tittle = "Data Parser";
        /// <summary>
        /// Title for Main window.
        /// </summary>
        public string Title
        {
            get { return tittle; }
            set { SetProperty(ref tittle, value); }
        }
        /// <summary>
        /// Command for close programm.
        /// </summary>
        public DelegateCommand CloseAppCommand { get; private set; }
        /// <summary>
        /// Method for main class.
        /// </summary>
        public MainWindowViewModel()
        {
            CloseAppCommand = new DelegateCommand(CloseApp);
        }

        private void CloseApp()
        {
            Environment.Exit(0);
        }
    }
}
