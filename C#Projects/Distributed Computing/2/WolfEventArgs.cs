using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    public class WolfEventArgs : EventArgs
    {
        public Wolf Wolf { get; set; }

        public WolfEventArgs(Wolf wolf)
        {
            Wolf = wolf;
        }
    }
}
