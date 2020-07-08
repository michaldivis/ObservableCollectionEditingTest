using System.Collections.ObjectModel;

namespace ObservableCollectionEditingTest
{
    public class SettingsViewModel
    {
        public ObservableCollection<Person> People { get; set; }

        public SettingsViewModel(ObservableCollection<Person> people)
        {
            People = people;
        }

        public void AddPerson()
        {
            People.Add(new Person());
        }
    }
}
