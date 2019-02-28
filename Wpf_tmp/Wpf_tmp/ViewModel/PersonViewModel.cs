using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf_tmp.Model;

namespace Wpf_tmp.ViewModel
{
    public class PersonViewModel : ObservableObject
    {
        private Person _person;
        public Person PPerson
        {
            get
            {
                return _person;
            }
            set
            {
                _person = value;
                //OnPropertyChanged("Person"); 
            }
        }

        private ObservableCollection<Person> _persons;
        public ObservableCollection<Person> Persons
        {
            get
            {
                return _persons;
            }
            set
            {
                _persons = value;
                //OnPropertyChanged("Persons");
            }
        }

        private ICommand _submitCommand;
        public ICommand SubmitCommand
        {
            get
            {
                if (_submitCommand == null)
                {
                    _submitCommand = new RelayCommand(SubmitExecute, CanSubmitExecute, false);
                }
                return _submitCommand;
            }
        }

        public PersonViewModel()
        {
            PPerson = new Person();
            Persons = new ObservableCollection<Person>(){
                new Person { Fname = "joe", LName = "smith"}
                };
            Person p = new Person { Fname = "steve", LName = "banks" };
            Persons.Add(p);
        }

        public void SubmitExecute(object parameter)
        {
            Persons.Add(PPerson);
            //Person p = new Person();
            //p.Fname = PPerson.Fname;  //--these values all update the entire ListView
            //p.LName = PPerson.LName;  //--except for the original to PPersons
            //Persons.Add(p);
        }

        private bool CanSubmitExecute(object parameter)
        {
            if (string.IsNullOrEmpty(PPerson.Fname) || string.IsNullOrEmpty(PPerson.LName))
            {
                return true;  //--this is another problem -- so I just set to true for now -- should be false
            }
            else
            {
                return true;
            }
        }
    }
}