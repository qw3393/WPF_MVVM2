using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPFCommandsDemo.Models;

namespace WPFCommandsDemo.ViewModels
{
    public class MainViewModel
    {
        public ICommand MyCommand { get; set; }
        public MainViewModel()
        {
            MyCommand = new Command(ExecuteMethod, CanexecuteMethod);
        }

        private void ExecuteMethod(object obj)
        {
            MessageBox.Show("코드비하인드가 아닌 Command ExecuteMethod");
        }

        private bool CanexecuteMethod(object arg)
        {
            return true;
        }
    }
}
