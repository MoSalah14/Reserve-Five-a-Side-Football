using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserve__a_Five_a_Side_Football.Player
{
    public class ConfirmReservationEventargs:EventArgs
    {
        public int ID { get; set; }
        public ConfirmReservationEventargs() 
        {
            
        }
        public ConfirmReservationEventargs(int _id) : base()
        {
            ID = _id;
        }

    }
}
