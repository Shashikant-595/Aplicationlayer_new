using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicationLayer
{
    public partial class Entryscreen : Form
    {
        public Entryscreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void h1(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            string text = txth1.Text;

            if (!char.IsDigit(c) && c != '.' || text.Length > 4)
            {
                e.Handled = true;

            }
            
        }
    }
}
