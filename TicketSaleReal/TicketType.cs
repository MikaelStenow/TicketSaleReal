using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSale
{
    public class TicketType
    {
        public String Type { get; set; }
        public String Price { get; set; }
        public override string ToString()
        {
            return Type;
        }

    }
}
