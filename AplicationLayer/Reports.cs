using Businesslayer;
using System;
using OfficeOpenXml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel Files|*.xlsx;*.xls";
            saveDialog.Title = "Save an Excel File";
            saveDialog.ShowDialog();

            if (saveDialog.FileName != "")
            {
                ExportToExcel(advancedDataGridView, saveDialog.FileName);
                MessageBox.Show("Export Successful!");
            }
        }

        private void ExportToExcel(DataGridView dgv, string filePath)
        {
            using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");
                int totalCols = dgv.Columns.Count;
                int totalRows = dgv.Rows.Count;

                // Add the headers
                for (int i = 1; i <= totalCols; i++)
                {
                    worksheet.Cells[1, i].Value = dgv.Columns[i - 1].HeaderText;
                }

                // Add the cell values
                for (int i = 0; i < totalRows; i++)
                {
                    for (int j = 0; j < totalCols; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dgv.Rows[i].Cells[j].Value;
                    }
                }

                package.Save();
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            ////view table to display the record in to the table design.
            datagrideviewsbll bll = new datagrideviewsbll();
            DataTable tableData = bll.GetTableDataForAdvancedGridView();
            Console.WriteLine("data table" + tableData);
            // Bind the DataTable to your advanced data grid view
            advancedDataGridView.DataSource = tableData;
            MessageBox.Show("Data refresh Successful!");
        }
    }
}
