using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_TEST.Models
{
    public class Currency
    {
        public Currency(string title, decimal rate)
        {
            Title = title;
            Rate = rate;
        }
        public string Title { get; set; }
        public decimal Rate { get; set; }
    }
}
