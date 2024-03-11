using Businesslayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zuby.ADGV;

namespace AplicationLayer
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            this.Resize += advancedDataGridView1_Resize;

            // Optional: Call the event handler once to initially set the DataGridView properties
            advancedDataGridView1_Resize(null, null);
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            ////view table to display the record in to the table design.
            datagrideviewsbll bll = new datagrideviewsbll();
            DataTable tableData = bll.GetTableDataForAdvancedGridView();
            Console.WriteLine("data table" + tableData);
            // Bind the DataTable to your advanced data grid view
            advancedDataGridView.DataSource = tableData;




        }


        private void advancedDataGridView1_Resize(object sender, EventArgs e)
        {
            try
            {
                // Calculate the available width for DataGridView
                int availableWidth = this.ClientSize.Width - SystemInformation.VerticalScrollBarWidth;

                // Set DataGridView width and height
                advancedDataGridView.Width = availableWidth;
                advancedDataGridView.Height = this.ClientSize.Height- SystemInformation.HorizontalScrollBarHeight;

                // Calculate the width of each column (for example, distribute equally)
                int columnCount = advancedDataGridView.Columns.Count;
                int columnWidth = availableWidth / columnCount;

                // Set the width for each column
                foreach (DataGridViewColumn column in advancedDataGridView.Columns)
                {
                    column.Width = columnWidth;
                }
            }
            catch (DivideByZeroException)
            {

              
            }
          
        }

            private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
