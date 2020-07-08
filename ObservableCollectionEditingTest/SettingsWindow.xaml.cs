using System.Collections.ObjectModel;
using System.Windows;

namespace ObservableCollectionEditingTest
{
    public partial class SettingsWindow : Window
    {
        private SettingsViewModel _model;
        public SettingsWindow(ObservableCollection<Person> people)
        {
            InitializeComponent();
            this.DataContext = _model = new SettingsViewModel(people);
        }

        private void btnAddPerson_Click(object sender, RoutedEventArgs e)
        {
            _model.AddPerson();
        }
    }
}
