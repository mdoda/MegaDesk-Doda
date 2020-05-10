using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Doda
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAddNewQuote_Click(object sender, EventArgs e)
        {
            var quoteForm = new AddQuote(this);

            quoteForm.Show();

            Hide();
        }

        private void btnViewQuotes_Click(object sender, EventArgs e)
        {
            var formViewAllQuotes = new ViewAllQuotes(this);

            formViewAllQuotes.Show();

            Hide();
        }

        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            var formSearchQuotes = new SearchQuotes(this);

            formSearchQuotes.Show();

            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
