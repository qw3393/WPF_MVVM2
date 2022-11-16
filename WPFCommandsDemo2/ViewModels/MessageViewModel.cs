using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFCommandsDemo2.Models;

namespace WPFCommandsDemo2.ViewModels
{
    public class MessageViewModel
    {
        //public string MessageText { get; set; }
        public MessageCommand DisplayMessageCommand { get; private set; }
        public MessageViewModel()
        {
            DisplayMessageCommand = new MessageCommand(DisplayMessage);
        }
        public void DisplayMessage(string message)
        {
            //MessageBox.Show(MessageText);
            MessageBox.Show(message);
        }
    }
}
