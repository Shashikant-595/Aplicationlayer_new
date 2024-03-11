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
    public partial class Batchquality_master : Form
    {
        public Batchquality_master()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void rheoMooneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rheo_Mooney childForm = new Rheo_Mooney();

            // Set the parent form for the child form
            childForm.MdiParent = this; // This makes it a child form

            // Show the child form
            childForm.Show();
        }

        private void rheoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Rheo childForm = new Rheo();

            // Set the parent form for the child form
            childForm.MdiParent = this; // This makes it a child form

            // Show the child form
            childForm.Show();
        }

        private void mooneyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Mooney childForm = new Mooney();

            // Set the parent form for the child form
            childForm.MdiParent = this; // This makes it a child form

            // Show the child form
            childForm.Show();
        }

        private void Batchquality_master_Load(object sender, EventArgs e)
        {

        }
    }
}
