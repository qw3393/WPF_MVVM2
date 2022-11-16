using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WPFCommandsDemo3.Models;
using System.Windows;

namespace WPFCommandsDemo3.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<string> MyMessages { get; private set; }
        public DelegateCommand MessageBoxCommand { get; private set; }
        public DelegateCommand ConsoleCommand { get; private set; }

        public MainViewModel()
        {
            MyMessages = new ObservableCollection<string>()
            {
                "안녕하세요!",
                "제 이름은 Goldrush 입니다.",
                "메세지 박스",
                "콘솔"
            };

            MessageBoxCommand =
                new DelegateCommand(DisplayInMessageBox, MessageBoxCanUse);
            ConsoleCommand =
                new DelegateCommand(DisplayInConsole, ConsoleBoxCanUse);
        }

        public void DisplayInMessageBox(object message)
        {
            MessageBox.Show((string)message);
        }
        public void DisplayInConsole(object message)
        {
            Console.WriteLine((string)message);
        }
        public bool MessageBoxCanUse(object message)
        {
            if ((string)message == "콘솔")
                return false;

            return true;
        }
        public bool ConsoleBoxCanUse(object message)
        {
            if ((string)message == "메세지 박스")
                return false;

            return true;
        }

    }
}
