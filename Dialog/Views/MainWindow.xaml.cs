using System.Windows;
using System.Windows.Input;

namespace Dialog.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Mathod to call support programm.
        /// </summary>
        /// <param name="message">Message for output.</param>
        public MainWindow(string message)
        {
            InitializeComponent();
            Message.Text = message;
        }

        private void Move(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
