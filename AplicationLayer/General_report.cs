using Businesslayer;
using System.Data;
using System.Windows.Forms;
using System;
using ClosedXML.Excel;

namespace AplicationLayer
{
    public partial class General_report : Form
    {
        private DataTable tableData; // Declare DataTable as a field

        public General_report()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void General_report_Load(object sender, EventArgs e)
        {

            // Fetch data and assign it to the DataTable field
            datagrideviewsbll bll = new datagrideviewsbll();
           
            tableData = bll.GetTableDataForAdvancedGridView();
            Console.WriteLine("data table" + tableData);

            // Bind the DataTable to your advanced data grid view
            dataGridView1.DataSource = tableData;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Width = 100; // Or set a width suitable for your data
            }
        }

        private void searchsapcode_TextChanged(object sender, EventArgs e)
        {
            // Check if tableData has been initialized
            if (tableData != null)
            {
                string searchText = searchsapcode.Text.Trim();

                // Apply the filter to the DataTable's DefaultView
                DataView dv = tableData.DefaultView;
                dv.RowFilter = $"Sapcode LIKE '%{searchText}%'";
            }
        }

        private void txtbatchno_TextChanged(object sender, EventArgs e)
        {
            // Check if tableData has been initialized
            if (tableData != null)
            {
                string searchText = txtbatchno.Text.Trim();

                // Apply the filter to the DataTable's DefaultView
                DataView dv = tableData.DefaultView;
                dv.RowFilter = $"Batch_No LIKE '%{searchText}%'";
            }
        }

        private void txtrheo_TextChanged(object sender, EventArgs e)
        {
            // Check if tableData has been initialized
            if (tableData != null)
            {
                string searchText = txtrheo.Text.Trim();

                // Apply the filter to the DataTable's DefaultView
                DataView dv = tableData.DefaultView;
                dv.RowFilter = $"Reho_Date_Time LIKE'%{searchText}%'";
            }
        }

        private void txtmooney_TextChanged(object sender, EventArgs e)
        {
            if (tableData != null)
            {
                string searchText = txtmooney.Text.Trim();

                // Apply the filter to the DataTable's DefaultView
                DataView dv = tableData.DefaultView;
                dv.RowFilter = $"Mooney_Date_Time LIKE'%{searchText}%'";
            }
        }

        private void txtstatus_TextChanged(object sender, EventArgs e)
        {
            if (tableData != null)
            {
                string searchText = txtstatus.Text.Trim();

                // Apply the filter to the DataTable's DefaultView
                DataView dv = tableData.DefaultView;
                dv.RowFilter = $"status LIKE'%{searchText}%'";
            }
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a DataTable to store the selected rows
                DataTable selectedData = new DataTable();

                // Add columns to the DataTable
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    // Handle cases where the ValueType is null
                    var valueType = column.ValueType ?? typeof(string);
                    selectedData.Columns.Add(column.HeaderText, valueType);
                }

                // Add selected rows to the DataTable
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    DataRow dataRow = selectedData.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        // Handle null cell values to avoid errors
                        dataRow[cell.ColumnIndex] = cell.Value ?? DBNull.Value;
                    }
                    selectedData.Rows.Add(dataRow);
                }

                // Export the DataTable to an Excel file
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(selectedData, "SelectedData");

                    // Save the Excel file to the specified location
                    using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Workbook|*.xlsx" })
                    {
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            wb.SaveAs(sfd.FileName);
                            MessageBox.Show("Excel file saved successfully.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions and show a message to the user
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnrefesh_Click(object sender, EventArgs e)
        {
            try
            {
                // Re-fetch the data from the data source
                datagrideviewsbll bll = new datagrideviewsbll();
                DataTable tableData = bll.GetTableDataForAdvancedGridView();

                // Rebind the data to the DataGridView
                dataGridView1.DataSource = tableData;

                // Optionally, you can adjust the column widths again if needed
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.Width = 100; // Or set a width suitable for your data
                }

                // Optionally, show a message indicating the refresh was successful
                MessageBox.Show("Data refreshed successfully.", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the refresh
                MessageBox.Show("An error occurred while refreshing the data grid: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
