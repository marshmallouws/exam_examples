using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_WPF
{
    public class Binding
    {
        public string Text { get; set; }

        public void SetText(int count)
        {
            Text = $"You have clicked {count} times";
        }
        
        public Binding(int count)
        { 
            Text = $"You have clicked {count} times";
        }
    }
}
