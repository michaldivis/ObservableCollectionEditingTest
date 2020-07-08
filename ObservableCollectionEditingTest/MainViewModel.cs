using System;
using System.Collections.ObjectModel;

namespace ObservableCollectionEditingTest
{
    public class MainViewModel
    {
        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();

        public MainViewModel()
        {
            People.Add(new Person
            {
                FirstName = "Gerald",
                LastName = "Fergusson",
                DateOfBirth = new DateTime(1984, 12, 6)
            });

            People.Add(new Person
            {
                FirstName = "Jessica",
                LastName = "Wraith",
                DateOfBirth = new DateTime(1991, 11, 4)
            });
        }
    }
}
