using System;
using System.Collections.Generic;
using System.Text;

namespace FixMyShip.Entities
{
    public class Guest
    {
        public virtual int Guestid { get; set; }
        public virtual string GuestName { get; set; }
        public virtual string GuestEmail { get; set; }
    }
}
