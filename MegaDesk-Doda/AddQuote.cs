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
    public partial class AddQuote : Form
    {

        private Form _mainMenu;
        public AddQuote(Form mainMenu)
        {
            InitializeComponent();

            // assign private variables 
            _mainMenu = mainMenu;
        }

        private void btnCancelClick(object sender, EventArgs e)
        {
            Close();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }
    }
}
