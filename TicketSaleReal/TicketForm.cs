using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSale
{
    public partial class TicketForm : Form
    {
        TicketType selectedTicketTypes;
        int numberOfTicketsSold = 0;
        int numberOfTicketsSelected = 0;

        public TicketForm()
        {
            InitializeComponent();
        }
        private void TicketForm_Load(object sender, EventArgs e)
        {
            TicketsListView.Clear();

            TicketsListView.Columns.Add("Biljett Typ", 200);
            TicketsListView.Columns.Add("Pris", 200);
            TicketsListView.Columns.Add("Antal biljetter", 100);

            numberOfTicketsSold = FileHandler.NumberOfTicketsSold();

            var types = FileHandler.ReadTicketTypes();
            foreach (var type in types)
            {
                ComboBoxTicketTypes.Items.Add(type);

                ListViewItem lvi = new ListViewItem(type.Type);
                lvi.Name = type.Type;
                lvi.SubItems.Add(type.Price);
                lvi.SubItems.Add("0");
                lvi.Tag = type;
                TicketsListView.Items.Add(lvi);
                TicketsListView.View = View.Details;
            }

            ComboBoxTicketTypes.SelectedIndex = 0;
        }

        //Buttons
        private void ClearTicketsButton_Click(object sender, EventArgs e)
        {
            ClearListView();
        }

        private void RefundTicketButton_Click(object sender, EventArgs e)
        {
            if (numberOfTicketsSold < numberOfTicketsSelected)
            {
               MessageBox.Show($"Du har försökt återköpa mer biljetter än det finns! Det har sålts {numberOfTicketsSold} st biljetter, men du har valt {numberOfTicketsSelected}.", "Återköp", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var result = MessageBox.Show("Är du säker på att du vill genomföra detta återköp?", "Återköp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    SaveTransaction(true);
            }
        }
        private void BuyButton_Click(object sender, EventArgs e)
        {
            SaveTransaction(false);
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (TicketsListView.Items.ContainsKey(selectedTicketTypes.Type))
            {
                TicketsListView.Items[selectedTicketTypes.Type].SubItems[2].Text = NumericUpDownTicketSales.Text;
            }
            numberOfTicketsSelected += Decimal.ToInt32(NumericUpDownTicketSales.Value);
            UpdateTotalAmount();
        }
        //Button end

        private void ComboBoxTicketTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTicketTypes = ComboBoxTicketTypes.SelectedItem as TicketType;
            NumericUpDownTicketSales.Value = 1;
        }

        private void SaveTransaction(bool refund)
        {
            var items = TicketsListView.Items;

            foreach (ListViewItem item in items)
            {
                //Don't save zero tickets for a tickettype
                if (item.SubItems[2].Text != "0")
                {
                    var ticketTransaction = new TicketTransaction();

                    ticketTransaction.TicketType = item.Tag as TicketType;

                    ticketTransaction.TransactionType = refund;
           
                    if (Int32.TryParse(item.SubItems[2].Text, out int numberOfTickets))
                    {
                        ticketTransaction.NumberOfTickets = numberOfTickets;
                    }

                    ticketTransaction.TransactionDate = DateTime.Now.Date;

                    FileHandler.SaveTransaction(ticketTransaction);
                }
            }

            ClearListView();
        }

        private void ClearListView()
        {
            var items = TicketsListView.Items;

            foreach (ListViewItem item in items)
            {
                item.SubItems[2].Text = "0";
            }

            UpdateTotalAmount();
        }
        private void UpdateTotalAmount()
        {
            int tot = 0;
            var items = TicketsListView.Items;

            foreach (ListViewItem item in items)
            {
                if (item.SubItems[2].Text != "0")
                {
                    if (Int32.TryParse(item.SubItems[1].Text, out int price) &&
                        Int32.TryParse(item.SubItems[2].Text, out int numberOfTickets))
                    {
                        tot += numberOfTickets * price;
                    }
                }
            }

            //Interpolation
            TotalAmountLabel.Text = $"Totalt pris: {tot.ToString()}";
        }
    }
}
