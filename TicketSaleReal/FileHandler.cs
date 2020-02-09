using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TicketSale
{
    public class FileHandler
    {
        public static string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        public static IList<TicketType> ReadTicketTypes()
        {
            try
            {
                string path = Path.Combine(assemblyPath, @"TicketTypes.txt");
                string[] ticketTypeArray = File.ReadAllLines(path, System.Text.Encoding.GetEncoding(1252));

                var ticketTypeList = new List<TicketType>();

                foreach (string type in ticketTypeArray)
                {
                    var ticketType = AddToTicketType(type);

                    ticketTypeList.Add(ticketType);
                }

                return ticketTypeList;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static TicketType AddToTicketType(string type)
        {
            var ticketTypes = new TicketType();

            var t = type.Split(';');
            ticketTypes.Type = t[0];
            ticketTypes.Price = t[1];
            return ticketTypes;
        }


        public static void SaveTransaction(TicketTransaction ticketTransaction)
        {
            string path = Path.Combine(assemblyPath, @"Transactions.csv"); 
            //Create colum header first time
            if (File.Exists(path)==false)
            {
                File.AppendAllText(path, @"Datum;Biljett typ; Pris; Antal" + Environment.NewLine,
                    System.Text.Encoding.GetEncoding(1252));
            }
            File.AppendAllText(path, ticketTransaction + Environment.NewLine, System.Text.Encoding.GetEncoding(1252));
        }

        public static int NumberOfTicketsSold()
        {
            try
            {
                int ticketsSold = 0;
                string path = Path.Combine(assemblyPath, @"Transactions.csv");

                var ticketTransactionList = new List<TicketTransaction>();

                if (File.Exists(path) == true)
                {
                    string[] ticketTransactionArray = File.ReadAllLines(path, System.Text.Encoding.GetEncoding(1252));
                    foreach (string transaction in ticketTransactionArray)
                    {
                        var t = transaction.Split(';');
                        if (Int32.TryParse(t[3], out int numberOfTickets))
                        {
                            ticketsSold += numberOfTickets;
                        }
                    }
                }
                return ticketsSold;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

    }
}
