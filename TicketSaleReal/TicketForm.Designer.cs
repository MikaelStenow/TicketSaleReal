namespace TicketSale
{
    partial class TicketForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TicketType = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.TotalAmountLabel = new System.Windows.Forms.Label();
            this.TicketsListView = new System.Windows.Forms.ListView();
            this.RefundTicketButton = new System.Windows.Forms.Button();
            this.ClearTicketsButton = new System.Windows.Forms.Button();
            this.BuyButton = new System.Windows.Forms.Button();
            this.ComboBoxTicketTypes = new System.Windows.Forms.ComboBox();
            this.NumericUpDownTicketSales = new System.Windows.Forms.NumericUpDown();
            this.SelectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTicketSales)).BeginInit();
            this.SuspendLayout();
            // 
            // TicketType
            // 
            this.TicketType.AutoSize = true;
            this.TicketType.Location = new System.Drawing.Point(47, 71);
            this.TicketType.Name = "TicketType";
            this.TicketType.Size = new System.Drawing.Size(49, 13);
            this.TicketType.TabIndex = 0;
            this.TicketType.Text = "Biljett typ";
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(303, 72);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(31, 13);
            this.Amount.TabIndex = 1;
            this.Amount.Text = "Antal";
            // 
            // TotalAmountLabel
            // 
            this.TotalAmountLabel.AutoSize = true;
            this.TotalAmountLabel.Location = new System.Drawing.Point(671, 71);
            this.TotalAmountLabel.Name = "TotalAmountLabel";
            this.TotalAmountLabel.Size = new System.Drawing.Size(59, 13);
            this.TotalAmountLabel.TabIndex = 2;
            this.TotalAmountLabel.Text = "Totalt pris: ";
            this.TotalAmountLabel.Click += new System.EventHandler(this.TotalAmountLabel_Click);
            // 
            // TicketsListView
            // 
            this.TicketsListView.HideSelection = false;
            this.TicketsListView.Location = new System.Drawing.Point(50, 128);
            this.TicketsListView.Name = "TicketsListView";
            this.TicketsListView.Size = new System.Drawing.Size(699, 247);
            this.TicketsListView.TabIndex = 3;
            this.TicketsListView.UseCompatibleStateImageBehavior = false;
            // 
            // RefundTicketButton
            // 
            this.RefundTicketButton.Location = new System.Drawing.Point(452, 405);
            this.RefundTicketButton.Name = "RefundTicketButton";
            this.RefundTicketButton.Size = new System.Drawing.Size(74, 24);
            this.RefundTicketButton.TabIndex = 4;
            this.RefundTicketButton.Text = "Återköp";
            this.RefundTicketButton.UseVisualStyleBackColor = true;
            this.RefundTicketButton.Click += new System.EventHandler(this.RefundTicketButton_Click);
            // 
            // ClearTicketsButton
            // 
            this.ClearTicketsButton.Location = new System.Drawing.Point(564, 406);
            this.ClearTicketsButton.Name = "ClearTicketsButton";
            this.ClearTicketsButton.Size = new System.Drawing.Size(75, 23);
            this.ClearTicketsButton.TabIndex = 5;
            this.ClearTicketsButton.Text = "Rensa";
            this.ClearTicketsButton.UseVisualStyleBackColor = true;
            this.ClearTicketsButton.Click += new System.EventHandler(this.ClearTicketsButton_Click);
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(674, 406);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(75, 23);
            this.BuyButton.TabIndex = 6;
            this.BuyButton.Text = "Köp";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // ComboBoxTicketTypes
            // 
            this.ComboBoxTicketTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTicketTypes.FormattingEnabled = true;
            this.ComboBoxTicketTypes.Location = new System.Drawing.Point(112, 68);
            this.ComboBoxTicketTypes.Name = "ComboBoxTicketTypes";
            this.ComboBoxTicketTypes.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxTicketTypes.TabIndex = 7;
            this.ComboBoxTicketTypes.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTicketTypes_SelectedIndexChanged);
            // 
            // NumericUpDownTicketSales
            // 
            this.NumericUpDownTicketSales.Location = new System.Drawing.Point(357, 69);
            this.NumericUpDownTicketSales.Name = "NumericUpDownTicketSales";
            this.NumericUpDownTicketSales.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDownTicketSales.TabIndex = 8;
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(576, 66);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SelectButton.Size = new System.Drawing.Size(75, 23);
            this.SelectButton.TabIndex = 9;
            this.SelectButton.Text = "Välj";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.NumericUpDownTicketSales);
            this.Controls.Add(this.ComboBoxTicketTypes);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.ClearTicketsButton);
            this.Controls.Add(this.RefundTicketButton);
            this.Controls.Add(this.TicketsListView);
            this.Controls.Add(this.TotalAmountLabel);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.TicketType);
            this.Name = "TicketForm";
            this.Text = "Billjetförsäljning";
            this.Load += new System.EventHandler(this.TicketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTicketSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TicketType;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label TotalAmountLabel;
        private System.Windows.Forms.ListView TicketsListView;
        private System.Windows.Forms.Button RefundTicketButton;
        private System.Windows.Forms.Button ClearTicketsButton;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.ComboBox ComboBoxTicketTypes;
        private System.Windows.Forms.NumericUpDown NumericUpDownTicketSales;
        private System.Windows.Forms.Button SelectButton;
    }
}

