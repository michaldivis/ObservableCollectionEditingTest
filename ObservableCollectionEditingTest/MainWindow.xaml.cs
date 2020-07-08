using System.Windows;

namespace ObservableCollectionEditingTest
{
    public partial class MainWindow : Window
    {
        private MainViewModel _model;
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = _model = new MainViewModel();
        }

        private void btnOpenSettings_Click(object sender, RoutedEventArgs e)
        {
            new SettingsWindow(_model.People).ShowDialog();
        }
    }
}
