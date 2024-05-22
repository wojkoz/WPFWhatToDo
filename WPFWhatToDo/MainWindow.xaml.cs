using System.Windows;

namespace WPFWhatToDo
{
    public partial class MainWindow : Window
    {
        private readonly MainPageViewModel viewModel;

        public MainWindow(MainPageViewModel viewModel)
        {
            InitializeComponent();
            this.viewModel = viewModel;
            DataContext = viewModel;
        }
    }
}