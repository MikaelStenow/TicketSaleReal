using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSale
{
    public class TicketTransaction
    {
        public TicketType TicketType { get; set; }      
        public int NumberOfTickets { get; set; }
        public DateTime TransactionDate { get; set; }

        public bool TransactionType { get; set; }
        public override string ToString()
        {
            var price = TransactionType ? $"-{TicketType.Price}" : TicketType.Price;
            var numberOfTickets = TransactionType ? $"-{NumberOfTickets}" : NumberOfTickets.ToString();
            //Interpolation
            return $"{TransactionDate};{TicketType.Type};{price};{numberOfTickets}";
        }
    }
}
