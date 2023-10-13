using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    public delegate void WolfEventHandler(object sender, WolfEventArgs e);

    public class WolfEventPublisher
    {
        public event WolfEventHandler WolfTooYoungEvent;

        public void CheckWolfAge(Wolf wolf)
        {
            if (wolf.Age < 1)
            {
                OnWolfTooYoungEvent(new WolfEventArgs(wolf));
            }
        }

        protected virtual void OnWolfTooYoungEvent(WolfEventArgs e)
        {
            WolfTooYoungEvent?.Invoke(this, e);
        }
    }
}
