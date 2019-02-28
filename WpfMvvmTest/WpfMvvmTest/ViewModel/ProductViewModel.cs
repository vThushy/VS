using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfMvvmTest.Model;


namespace WpfMvvmTest.ViewModel
{
    class ProductViewModel
    {
        public IList<Product> m_Products;
        public ProductViewModel()
        {
            m_Products = new List<Product>
            {
                new Product {ID=1, Name ="Pro1", Price=10},
                new Product{ID=2, Name="BAse2", Price=12}
            };
        }

        public IList<Product> Products
        {
            get
            {
                return m_Products;
            }
            set
            {
                m_Products = value;
            }
        }

        public void SubmitExecute(object parameter)
        {
       //    Products.Add(product);
            //Person p = new Person();
            //p.Fname = PPerson.Fname;  //--these values all update the entire ListView
            //p.LName = PPerson.LName;  //--except for the original to PPersons
            //Persons.Add(p);
        }

        private bool CanSubmitExecute(object parameter)
        {
            //if (string.IsNullOrEmpty(Product.pro))
            //{
            //    return true;  //--this is another problem -- so I just set to true for now -- should be false
            //}
            //else
            //{
                return true;
            //}
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

        private ICommand mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater(UpdateDatabase);
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }

        private void UpdateDatabase(object parameter)
        {
            //here you can access this.Products, update the database or do whatever you want...
        }

        private class Updater : ICommand
        {
            private readonly Action<object> _execute;
            public Updater(Action<object> execute)
            {
                _execute = execute;
            }

            #region ICommand Members

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {
                _execute(parameter);
            }

            #endregion
        }
    }
}