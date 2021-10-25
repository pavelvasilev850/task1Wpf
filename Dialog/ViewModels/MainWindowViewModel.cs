using Prism.Mvvm;

namespace Dialog.ViewModels
{
    /// <summary>
    /// Entery point for support programm.
    /// </summary>
    public class MainWindowViewModel : BindableBase
    {

        private string _title = "Dialog";
        /// <summary>
        /// Title for Main window.
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        /// <summary>
        /// Constractor for main class.
        /// </summary>
        public MainWindowViewModel()
        {

        }
    }
}
