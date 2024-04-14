using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDLC_Train
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dW_Istanbul_MallDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.dW_Istanbul_MallDataSet.Customer);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportReportToPDF(reportViewer1.LocalReport, "MyReportFileName");
        }

        private void ExportReportToPDF(LocalReport report, string fileName)
        {
            try
            {
                Warning[] warnings;
                string[] streamIds;
                string mimeType = string.Empty;
                string encoding = string.Empty;
                string extension = string.Empty;

                // Set the device info parameter to specify the file name
                string deviceInfo =
                    $"<DeviceInfo>" +
                    $"<OutputFormat>PDF</OutputFormat>" +
                    $"<PageWidth>8.5in</PageWidth>" +
                    $"<PageHeight>11in</PageHeight>" +
                    $"<MarginTop>0.5in</MarginTop>" +
                    $"<MarginLeft>0.5in</MarginLeft>" +
                    $"<MarginRight>0.5in</MarginRight>" +
                    $"<MarginBottom>0.5in</MarginBottom>" +
                    $"</DeviceInfo>";

                byte[] bytes = report.Render("PDF", deviceInfo, out mimeType, out encoding, out extension, out streamIds, out warnings);

                // Choose a location to save the PDF file
                string path = Path.Combine(@"C:\Users\muhsin Ch\OneDrive\Bureau", fileName + ".pdf");

                // Write the bytes to a file
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    fs.Write(bytes, 0, bytes.Length);
                }

                MessageBox.Show("Report exported to PDF successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting report to PDF: {ex.Message}");
            }
        }

    }
}
