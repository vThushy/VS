﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfMvvmTest
{
    public class RelayCommand : ICommand
    {
        readonly Action<object> _execute;
        readonly Func<object, bool> _canExecute;
        bool canExecuteCache;

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute, bool CanExecuteCache)
        {
            _execute = execute;
            _canExecute = canExecute;
            canExecuteCache = CanExecuteCache;
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
