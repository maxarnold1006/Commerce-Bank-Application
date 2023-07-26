using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A6_AB_LTA_OOP_Polymorphism
{
    public partial class TransactionsDetailsForm : Form
    {
        // Class-level variable to store customer ID
        string customerIDString;

        public TransactionsDetailsForm(string usernameString)
        {
            InitializeComponent();

            // If () statement block to set the customer ID appropriately
            if (usernameString == "admin")
            {
                customerIDString = "All";
                customer_IDTextBox.Text = customerIDString;
            }
            else if (usernameString == "roy1983")
            {
                customerIDString = "C036";
                customer_IDTextBox.Text = customerIDString;
            }
            else
            {
                customerIDString = "C045";
                customer_IDTextBox.Text = customerIDString;
            }
        }

        private void transactionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.transactionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.americanBankNewDataSet);

        }

        private void TransactionsDetailsForm_Load(object sender, EventArgs e)
        {
            if (customerIDString == "All")
            {
                customer_IDTextBox.Text = customerIDString;
                // This line of code loads data into the 'americanBankNewDataSet.Transactions' table.
                this.transactionsTableAdapter.Fill(this.americanBankNewDataSet.Transactions);
            }
            else
            {
                // This line of code loads data into the 'americanBankNewDataSet.Transactions' table.
                this.transactionsTableAdapter.FillByCustomerID(this.americanBankNewDataSet.Transactions, customerIDString);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
